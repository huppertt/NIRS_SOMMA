using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.IO;
using csmatio.io;
using csmatio.types;

public partial class MainWindow : Gtk.Window
{

    protected void MarkStimulus(object sender, EventArgs e)
    {
        if (isrunning)
        {
            events.Add(time[time.Count - 1]);

            num_events_label.Text = String.Format("# events {0}", events.Count);
        }
    }

    protected void ClickedStart(object sender, EventArgs e)
    {
        if (!isrunning)
        {

            StreamSD = checkbutton_SD.Active;
            StreamUDP = checkbutton_UDP.Active;
            StreamSerial = checkbutton1.Active;
            recordEMG = checkbutton_EMG.Active;

            buttonMarkEvent.Sensitive = true;
            nirsData = new List<double>[nchannels];
            for (int i = 0; i < nchannels; i++)
            {
                nirsData[i] = new List<double>();
            }           
            events = new List<double>();
            time = new List<double>();

            num_events_label.Text = String.Format("# events {0}", events.Count);

            // Send the updated info to the device
            Byte[] sendBytes = Encoding.ASCII.GetBytes(String.Format("LED1gain {0}",LED780));
            udpClient.Send(sendBytes, sendBytes.Length);
            sendBytes = Encoding.ASCII.GetBytes(String.Format("LED2gain {0}", LED850));
            udpClient.Send(sendBytes, sendBytes.Length);

            if (recordEMG)
            {
                sendBytes = Encoding.ASCII.GetBytes("EMG On");
            }
            else
            {
                sendBytes = Encoding.ASCII.GetBytes("EMG Off");
            }
            udpClient.Send(sendBytes, sendBytes.Length);

            if (StreamSD)
            {
                sendBytes = Encoding.ASCII.GetBytes("SaveFile On");
                udpClient.Send(sendBytes, sendBytes.Length);
                string filename = entry_fileName.Text;
                sendBytes = Encoding.ASCII.GetBytes(String.Format("SetFileName {0}", filename));
            }
            else
            {
                sendBytes = Encoding.ASCII.GetBytes("SaveFile Off");
            }
            udpClient.Send(sendBytes, sendBytes.Length);

            if (StreamUDP)
            {
                sendBytes = Encoding.ASCII.GetBytes("SendUDP On");
            }
            else
            {
                sendBytes = Encoding.ASCII.GetBytes("SendUDP Off");
            }
            udpClient.Send(sendBytes, sendBytes.Length);

            if (StreamSerial)
            {
                sendBytes = Encoding.ASCII.GetBytes("SendSerial On");
            }
            else
            {
                sendBytes = Encoding.ASCII.GetBytes("SendSerial Off");
            }
            udpClient.Send(sendBytes, sendBytes.Length);


            sendBytes = Encoding.ASCII.GetBytes("Start");
            udpClient.Send(sendBytes, sendBytes.Length);
            mainthread = new Thread(updateData);

            mainthread.Start();
            isrunning = true;
            
            buttonStart.Label = "Stop";
        }
        else
        {
            Byte[] sendBytes = Encoding.ASCII.GetBytes("Stop");
            udpClient.Send(sendBytes, sendBytes.Length);
            mainthread.Abort();
            isrunning = false;
            buttonStart.Label = "Start";
            buttonMarkEvent.Sensitive = false;
            //save the data
            string[] paths = new string[] {DataFolder,
                String.Format("{0}",entry_subjID.Text) };
            string pathname = System.IO.Path.Combine(paths);

            if (!Directory.Exists(pathname))
            {
                Directory.CreateDirectory(pathname);
            }

            string filename = String.Format("{0}_{1}_{2}.mat", entry_subjID.Text, comboboxentry_ScanName.ActiveText, DateTime.Now.ToString("MMMMddyyyy_HHmm"));
            filename = System.IO.Path.Combine(pathname, filename);
            SaveData(filename);

        }
    }

    protected void EditSubjID(object sender, EventArgs e)
    {


        buttonStart.Sensitive = true;
    }


    public void SaveData(string filename)
    {
        // Store the data into the *.mat matlab format

        MLStructure mlhdr = new MLStructure("hdr", new int[] { 1, 1 });

        mlhdr["Date"] = new MLChar("", DateTime.Now.ToString("MMMMddyyyy_HHmm"));
        mlhdr["SubjID"] = new MLChar("", entry_subjID.Text);
        mlhdr["Scan"] = new MLChar("", comboboxentry_ScanName.ActiveText);
        mlhdr["Comments"] = new MLChar("", textview_Comments.Buffer.Text);



        // save the raw data info


        MLStructure mldata = new MLStructure("Data", new int[] { 1, 1 });

        double[] _time = new double[time.Count];
        double[] _HbO = new double[nirsData[0].Count];
        double[] _HbR = new double[nirsData[1].Count];
        double[] _HbT = new double[nirsData[2].Count];
        double[] _SO2 = new double[nirsData[3].Count];
        double[] _EMG = new double[nirsData[4].Count];


        for (int i = 0; i < nirsData[0].Count; i++)
        {
            _time[i] = time[i];
            _HbO[i] = nirsData[0][i];
            _HbR[i] = nirsData[1][i];
            _HbT[i] = nirsData[2][i];
            _SO2[i] = nirsData[3][i];
            if (recordEMG)
            {
                _EMG[i] = nirsData[4][i];
            }
        }


        List<MLArray> mlList = new List<MLArray>();

        mlList.Add(mlhdr);
        mlList.Add(new MLDouble("time", _time, 1));
        mlList.Add(new MLDouble("HbO", _HbO, 1));
        mlList.Add(new MLDouble("HbR", _HbR, 1));
        mlList.Add(new MLDouble("HbT", _HbT, 1));
        mlList.Add(new MLDouble("SO2", _SO2, 1));
        if (recordEMG)
        {
            mlList.Add(new MLDouble("EMG", _EMG, 1));
        }


        new MatFileWriter(filename, mlList, false);

        return;
    }





}