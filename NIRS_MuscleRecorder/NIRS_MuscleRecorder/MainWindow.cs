using System;
using Gtk;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using System.Text;

public partial class MainWindow : Gtk.Window
{

    public int udpport;
    public string udpaddress;
    public string DataFolder;
    public List<double>[] nirsData;
    public List<double> events;
    public List<double> time;

    public static Thread mainthread;
    UdpClient udpClient;
    bool isrunning;

    int nchannels;

    bool recordEMG;
    bool StreamSD;
    bool StreamUDP;
    bool StreamSerial;
    int LED780;
    int LED850;


    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        // read the config file

        XmlDocument doc = new XmlDocument();
        XmlDocument doc2 = new XmlDocument();
        doc.Load(@"Config.xml");
        XmlNodeList elemList;

        elemList = doc.GetElementsByTagName("datadir");
        DataFolder = elemList[0].InnerXml;
        DataFolder = DataFolder.Trim();

        elemList = doc.GetElementsByTagName("udpaddress");
        udpaddress = elemList[0].InnerXml;
        udpaddress = udpaddress.Trim();

        elemList = doc.GetElementsByTagName("udpport");
        udpport = Convert.ToInt32(elemList[0].InnerXml);

        elemList = doc.GetElementsByTagName("allowEMG");
        if (elemList[0].InnerXml.Trim() == "false")
        {
            checkbutton_EMG.Active = false;
            checkbutton_EMG.Sensitive = false;
            recordEMG = false;
        }
        else
        {
            checkbutton_EMG.Active = true;
            checkbutton_EMG.Sensitive = true;
            recordEMG = true;
        }


        //Set the default adv-options
        StreamSD = true;
        checkbutton_SD.Active = true;
        StreamUDP = true;
        checkbutton_UDP.Active = true;


        LED780 = 255;
        LED850 = 255;
        entry_780Power.Text = String.Format("{0}", LED780);
        entry_850Power.Text = String.Format("{0}", LED850);


        drawingarea1.ExposeEvent += DataDraw;

        // Connect to the device
        udpClient = new UdpClient(udpport);
        udpClient.Connect(udpaddress, udpport);
        isrunning = false;
        mainthread = new Thread(updateData);

        Byte[] sendBytes = Encoding.ASCII.GetBytes("IDN?");
        udpClient.Send(sendBytes, sendBytes.Length);

        System.Net.IPEndPoint iPEndPoint = new System.Net.IPEndPoint(System.Net.IPAddress.Any, 0);
        byte[] msg = udpClient.Receive(ref iPEndPoint);
        string msgs = Encoding.ASCII.GetString(msg);

        textview_DeviceInfo.Buffer.Text = msgs;

        nchannels = 5;

        nirsData = new List<double>[nchannels];
        for (int i = 0; i < nchannels; i++)
        {
            nirsData[i] = new List<double>();
        }
        events = new List<double>();
        time = new List<double>();

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

  
}
