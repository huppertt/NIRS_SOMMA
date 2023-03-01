using System;
using System.Text;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    protected void DataDraw(object sender, EventArgs e)
    {
        if (nirsData[0].Count < 2)
        {
            return;
        }

        Gdk.Drawable da = drawingarea1.GdkWindow;

        double tMin = 0;
        if (checkbutton_showtimeWin.Active)
        {
            tMin = time[time.Count - 1] - Convert.ToDouble(entry_timeWin.Text);
        }


        bool[] chflags = new bool[5];
        for (int i = 0; i < 5; i++)
        {
            chflags[i] = false;
        }

        string selected = combobox_whichData.ActiveText;
        if (selected.Contains("all"))
        {
            chflags[0] = true;
            chflags[1] = true;
            chflags[2] = true;
            chflags[3] = true;
            chflags[4] = true;
        }
        if (selected.Contains("HbO"))
        {
            chflags[0] = true;
        }
        if (selected.Contains("HbR"))
        {
            chflags[1] = true;
        }
        if (selected.Contains("HbT"))
        {
            chflags[2] = true;
        }
        if (selected.Contains("SO2"))
        {
            chflags[3] = true;
        }
        if (selected.Contains("EMG"))
        {
            chflags[4] = true;
        }


        Gdk.Color[] LineColors = new Gdk.Color[5];
        LineColors[0] = new Gdk.Color(255, 0, 0); //HbO2
        LineColors[1] = new Gdk.Color(0, 0, 255); //HbR
        LineColors[2] = new Gdk.Color(0, 255, 0); //HbT
        LineColors[3] = new Gdk.Color(255, 29, 206); //SO2
        LineColors[4] = new Gdk.Color(0, 0, 0); // EMG


        if (!recordEMG)
        {
            chflags[4] = false;
        }



        int width, height;
        da.GetSize(out width, out height);

        int StartIdx = 0;


        for (int sIdx = 0; sIdx < time.Count; sIdx++)
        {
            if (time[sIdx] <= tMin)
            {
                StartIdx = sIdx;
            }
        }

        double maxY, minY;
        minY = 99999; maxY = -99999;

        for (int datasel = 0; datasel < 5; datasel++) {
            if (chflags[datasel])
            {
                for (int tIdx = StartIdx; tIdx < nirsData[datasel].Count; tIdx++)
                {
                    double d = nirsData[datasel][tIdx];
                    if (d != -999)
                    {
                        if (maxY < d)
                        {
                            maxY = d;
                        }
                        if (minY > d)
                        {
                            minY = d;
                        }
                    }
                }
            }
        }


        double rangeY = maxY - minY;
        double rangeX = time[(int)time.Count - 1] - time[StartIdx];
        int xoffset = 50;
        int yoffset = 1;
        height = height - 31;
        width = width - 51;

        Gdk.GC gc = new Gdk.GC(da);
        gc.RgbBgColor = new Gdk.Color(0, 0, 0);
        gc.RgbFgColor = new Gdk.Color(0, 0, 0);
        Gdk.Rectangle rarea = new Gdk.Rectangle();
        rarea.X = xoffset - 1;
        rarea.Y = yoffset - 1;
        rarea.Height = height + 2;
        rarea.Width = width + 2;
        da.DrawRectangle(gc, true, rarea);

        gc.RgbBgColor = new Gdk.Color(0, 0, 0);
        gc.RgbFgColor = new Gdk.Color(255, 255, 255);
        rarea.X = xoffset;
        rarea.Y = yoffset;
        rarea.Height = height;
        rarea.Width = width;
        da.DrawRectangle(gc, true, rarea);


        for (int datasel = 0; datasel < 5; datasel++)
        {
            if (chflags[datasel])
            {
                gc.RgbFgColor = LineColors[datasel];
                gc.SetLineAttributes(1, Gdk.LineStyle.Solid, Gdk.CapStyle.Projecting, Gdk.JoinStyle.Round);
                for (int tIdx = StartIdx + 1; tIdx < nirsData[datasel].Count; tIdx++)
                {
                    if (nirsData[datasel][tIdx] != -999 & nirsData[datasel][tIdx - 1] != -999)
                    {
                        double y2 = (nirsData[datasel][tIdx] - minY) / rangeY * height;
                        double y1 = (nirsData[datasel][tIdx - 1] - minY) / rangeY * height;

                        double x2 = (time[tIdx] - time[StartIdx]) / rangeX * width;
                        double x1 = (time[tIdx - 1] - time[StartIdx]) / rangeX * width;

                        da.DrawLine(gc, (int)x1 + xoffset, (int)(height - y1 + yoffset), (int)x2 + xoffset, (int)(height - y2 + yoffset));
                    }

                }
            }
        }


        gc.RgbFgColor = new Gdk.Color(169,169,169);
        for (int i = 0; i < events.Count; i++)
        {
            if (events[i] > time[StartIdx])
            {
                double y2 = -1;
                double y1 = height + 1;

                double x2 = (events[i] - time[StartIdx]) / rangeX * width;
                double x1 = (events[i] - time[StartIdx]) / rangeX * width;

                da.DrawLine(gc, (int)x1 + xoffset, (int)(height - y1 + yoffset), (int)x2 + xoffset, (int)(height - y2 + yoffset));
            }
        }


        gc.RgbFgColor = new Gdk.Color(0, 0, 0);
        int numxlabels = 10;
        int numylabels = 5;
        double tstart, tend, dt;
        tstart = time[StartIdx];
        tend = time[time.Count - 1];
        dt = Math.Round((tend - tstart) / (1 + numxlabels));
        if (dt < 1)
        {
            dt = 1;
        }
        for (double i = 0; i < rangeX; i += dt)
        {
            double x = i / rangeX * width;
            Gtk.Label lab = new Label();
            lab.Text = String.Format("{0}", Math.Round((i + tstart) * 10) / 10);
            da.DrawLayout(gc, (int)x + xoffset, (int)height + 2, lab.Layout);
        }

        double dy;
        dy = rangeY / (1 + numylabels);
        if (dy == 0.0)
        {
            dy = 1;
        }
        for (double i = 0; i < rangeY; i += dy)
        {
            double y = height - i / rangeY * height;
            Gtk.Label lab = new Label();
            lab.Text = String.Format("{0}", Math.Round((i + minY) * 10) / 10);
            da.DrawLayout(gc, 10, (int)y + yoffset, lab.Layout);
        }

    }


    protected void updateData()
    {
        System.Net.IPEndPoint iPEndPoint = new System.Net.IPEndPoint(System.Net.IPAddress.Any, 0);
        // "10.0.0.1", 2390

        int cnt = 0;
        while (mainthread.IsAlive)
        {

            byte[] msg = udpClient.Receive(ref iPEndPoint);
            string msgs = Encoding.ASCII.GetString(msg);
            string[] msgss = msgs.Split(new char[] { ' ' });

            time.Add(Convert.ToDouble(msgss[0]) / 1000);
            nirsData[0].Add(Convert.ToDouble(msgss[1]));
            nirsData[1].Add(Convert.ToDouble(msgss[2]));
            nirsData[2].Add(Convert.ToDouble(msgss[3]));
            nirsData[3].Add(Convert.ToDouble(msgss[4]));

            if (recordEMG)
            {
                nirsData[4].Add(Convert.ToDouble(msgss[5]));
            }


            cnt++;

            if (cnt > 100)
            {
                time_elapsed_label.Text = String.Format("Time Elapsed: {0}", time[time.Count - 1]);

                drawingarea1.QueueDraw();
                progressbar1.Pulse();
                cnt = 0;
            }

        }
    }
}