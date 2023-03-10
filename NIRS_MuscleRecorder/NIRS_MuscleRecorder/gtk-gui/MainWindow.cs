
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.VBox vbox10;

	private global::Gtk.MenuBar menubar1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Frame frame11;

	private global::Gtk.Alignment GtkAlignment5;

	private global::Gtk.DrawingArea drawingarea1;

	private global::Gtk.Label GtkLabel14;

	private global::Gtk.VSeparator vseparator1;

	private global::Gtk.VBox vbox1;

	private global::Gtk.Frame frame2;

	private global::Gtk.Alignment GtkAlignment6;

	private global::Gtk.VBox vbox2;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Label label1;

	private global::Gtk.Entry entry_subjID;

	private global::Gtk.HBox hbox4;

	private global::Gtk.Label label3;

	private global::Gtk.ComboBoxEntry comboboxentry_ScanName;

	private global::Gtk.Frame frame4;

	private global::Gtk.Alignment GtkAlignment7;

	private global::Gtk.TextView textview_DeviceInfo;

	private global::Gtk.Label GtkLabel16;

	private global::Gtk.Label GtkLabel15;

	private global::Gtk.Fixed fixed5;

	private global::Gtk.Frame frame1;

	private global::Gtk.Alignment GtkAlignment;

	private global::Gtk.VBox vbox3;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Button buttonStart;

	private global::Gtk.ProgressBar progressbar1;

	private global::Gtk.Label time_elapsed_label;

	private global::Gtk.HSeparator hseparator1;

	private global::Gtk.HBox hbox7;

	private global::Gtk.Button buttonMarkEvent;

	private global::Gtk.Label num_events_label;

	private global::Gtk.Fixed fixed1;

	private global::Gtk.Label GtkLabel3;

	private global::Gtk.Frame frame3;

	private global::Gtk.Alignment GtkAlignment1;

	private global::Gtk.VBox vbox6;

	private global::Gtk.ComboBox combobox_whichData;

	private global::Gtk.HBox hbox9;

	private global::Gtk.Entry entry_timeWin;

	private global::Gtk.CheckButton checkbutton_showtimeWin;

	private global::Gtk.Label GtkLabel5;

	private global::Gtk.Expander expander1;

	private global::Gtk.VBox vbox7;

	private global::Gtk.Frame frame5;

	private global::Gtk.Alignment GtkAlignment2;

	private global::Gtk.VBox vbox8;

	private global::Gtk.HBox hbox13;

	private global::Gtk.Entry entry_780Power;

	private global::Gtk.Label label5;

	private global::Gtk.HBox hbox15;

	private global::Gtk.Entry entry_850Power;

	private global::Gtk.Label label7;

	private global::Gtk.Label GtkLabel6;

	private global::Gtk.Frame frame7;

	private global::Gtk.Alignment GtkAlignment3;

	private global::Gtk.VBox vbox9;

	private global::Gtk.CheckButton checkbutton_SD;

	private global::Gtk.HBox hbox17;

	private global::Gtk.Entry entry_fileName;

	private global::Gtk.Label label9;

	private global::Gtk.HSeparator hseparator3;

	private global::Gtk.CheckButton checkbutton_EMG;

	private global::Gtk.CheckButton checkbutton_UDP;

	private global::Gtk.CheckButton checkbutton1;

	private global::Gtk.Label GtkLabel10;

	private global::Gtk.Label GtkLabel11;

	private global::Gtk.Frame frame9;

	private global::Gtk.Alignment GtkAlignment4;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview_Comments;

	private global::Gtk.Label GtkLabel13;

	private global::Gtk.Statusbar statusbar1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox10 = new global::Gtk.VBox();
		this.vbox10.Name = "vbox10";
		this.vbox10.Spacing = 6;
		// Container child vbox10.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar1\'/></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox10.Add(this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.frame11 = new global::Gtk.Frame();
		this.frame11.WidthRequest = 1202;
		this.frame11.Name = "frame11";
		this.frame11.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame11.Gtk.Container+ContainerChild
		this.GtkAlignment5 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment5.WidthRequest = 1075;
		this.GtkAlignment5.Name = "GtkAlignment5";
		this.GtkAlignment5.LeftPadding = ((uint)(12));
		// Container child GtkAlignment5.Gtk.Container+ContainerChild
		this.drawingarea1 = new global::Gtk.DrawingArea();
		this.drawingarea1.Name = "drawingarea1";
		this.GtkAlignment5.Add(this.drawingarea1);
		this.frame11.Add(this.GtkAlignment5);
		this.GtkLabel14 = new global::Gtk.Label();
		this.GtkLabel14.Name = "GtkLabel14";
		this.GtkLabel14.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Data</b>");
		this.GtkLabel14.UseMarkup = true;
		this.frame11.LabelWidget = this.GtkLabel14;
		this.hbox1.Add(this.frame11);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.frame11]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vseparator1 = new global::Gtk.VSeparator();
		this.vseparator1.Name = "vseparator1";
		this.hbox1.Add(this.vseparator1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator1]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment6 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment6.Name = "GtkAlignment6";
		this.GtkAlignment6.LeftPadding = ((uint)(12));
		// Container child GtkAlignment6.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Subject ID");
		this.hbox3.Add(this.label1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label1]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entry_subjID = new global::Gtk.Entry();
		this.entry_subjID.CanFocus = true;
		this.entry_subjID.Name = "entry_subjID";
		this.entry_subjID.IsEditable = true;
		this.entry_subjID.InvisibleChar = '???';
		this.hbox3.Add(this.entry_subjID);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entry_subjID]));
		w8.Position = 1;
		this.vbox2.Add(this.hbox3);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("    Scan ID");
		this.hbox4.Add(this.label3);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label3]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.comboboxentry_ScanName = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentry_ScanName.AppendText(global::Mono.Unix.Catalog.GetString("6Min Walk"));
		this.comboboxentry_ScanName.AppendText(global::Mono.Unix.Catalog.GetString("CPET"));
		this.comboboxentry_ScanName.AppendText(global::Mono.Unix.Catalog.GetString("Practice (not saved)"));
		this.comboboxentry_ScanName.Name = "comboboxentry_ScanName";
		this.comboboxentry_ScanName.Active = 1;
		this.hbox4.Add(this.comboboxentry_ScanName);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.comboboxentry_ScanName]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		this.vbox2.Add(this.hbox4);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.frame4 = new global::Gtk.Frame();
		this.frame4.Name = "frame4";
		this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame4.Gtk.Container+ContainerChild
		this.GtkAlignment7 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment7.Name = "GtkAlignment7";
		this.GtkAlignment7.LeftPadding = ((uint)(12));
		// Container child GtkAlignment7.Gtk.Container+ContainerChild
		this.textview_DeviceInfo = new global::Gtk.TextView();
		this.textview_DeviceInfo.CanFocus = true;
		this.textview_DeviceInfo.Name = "textview_DeviceInfo";
		this.GtkAlignment7.Add(this.textview_DeviceInfo);
		this.frame4.Add(this.GtkAlignment7);
		this.GtkLabel16 = new global::Gtk.Label();
		this.GtkLabel16.Name = "GtkLabel16";
		this.GtkLabel16.LabelProp = global::Mono.Unix.Catalog.GetString("Device Info");
		this.GtkLabel16.UseMarkup = true;
		this.frame4.LabelWidget = this.GtkLabel16;
		this.vbox2.Add(this.frame4);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.frame4]));
		w15.Position = 2;
		this.GtkAlignment6.Add(this.vbox2);
		this.frame2.Add(this.GtkAlignment6);
		this.GtkLabel15 = new global::Gtk.Label();
		this.GtkLabel15.Name = "GtkLabel15";
		this.GtkLabel15.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Subject Info</b>");
		this.GtkLabel15.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel15;
		this.vbox1.Add(this.frame2);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame2]));
		w18.Position = 0;
		// Container child vbox1.Gtk.Box+BoxChild
		this.fixed5 = new global::Gtk.Fixed();
		this.fixed5.HeightRequest = 250;
		this.fixed5.Name = "fixed5";
		this.fixed5.HasWindow = false;
		this.vbox1.Add(this.fixed5);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.fixed5]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.buttonStart = new global::Gtk.Button();
		this.buttonStart.Sensitive = false;
		this.buttonStart.CanFocus = true;
		this.buttonStart.Name = "buttonStart";
		this.buttonStart.UseUnderline = true;
		this.buttonStart.Label = global::Mono.Unix.Catalog.GetString("START");
		this.hbox2.Add(this.buttonStart);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonStart]));
		w20.Position = 0;
		w20.Expand = false;
		w20.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.progressbar1 = new global::Gtk.ProgressBar();
		this.progressbar1.Name = "progressbar1";
		this.hbox2.Add(this.progressbar1);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.progressbar1]));
		w21.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.time_elapsed_label = new global::Gtk.Label();
		this.time_elapsed_label.Name = "time_elapsed_label";
		this.time_elapsed_label.LabelProp = global::Mono.Unix.Catalog.GetString("Time Elapsed: ");
		this.hbox2.Add(this.time_elapsed_label);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.time_elapsed_label]));
		w22.Position = 2;
		w22.Expand = false;
		w22.Fill = false;
		this.vbox3.Add(this.hbox2);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox2]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator();
		this.hseparator1.Name = "hseparator1";
		this.vbox3.Add(this.hseparator1);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hseparator1]));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.buttonMarkEvent = new global::Gtk.Button();
		this.buttonMarkEvent.Sensitive = false;
		this.buttonMarkEvent.CanFocus = true;
		this.buttonMarkEvent.Name = "buttonMarkEvent";
		this.buttonMarkEvent.UseUnderline = true;
		this.buttonMarkEvent.Label = global::Mono.Unix.Catalog.GetString("MARK EVENT");
		this.hbox7.Add(this.buttonMarkEvent);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonMarkEvent]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.num_events_label = new global::Gtk.Label();
		this.num_events_label.Name = "num_events_label";
		this.num_events_label.LabelProp = global::Mono.Unix.Catalog.GetString("Number Events: 0");
		this.hbox7.Add(this.num_events_label);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.num_events_label]));
		w26.Position = 1;
		w26.Expand = false;
		w26.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		this.hbox7.Add(this.fixed1);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.fixed1]));
		w27.Position = 2;
		this.vbox3.Add(this.hbox7);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox7]));
		w28.Position = 2;
		w28.Expand = false;
		w28.Fill = false;
		this.GtkAlignment.Add(this.vbox3);
		this.frame1.Add(this.GtkAlignment);
		this.GtkLabel3 = new global::Gtk.Label();
		this.GtkLabel3.Name = "GtkLabel3";
		this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Data Collection</b>");
		this.GtkLabel3.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel3;
		this.vbox1.Add(this.frame1);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame1]));
		w31.Position = 2;
		w31.Expand = false;
		w31.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame3 = new global::Gtk.Frame();
		this.frame3.Name = "frame3";
		this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame3.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.vbox6 = new global::Gtk.VBox();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.combobox_whichData = global::Gtk.ComboBox.NewText();
		this.combobox_whichData.AppendText(global::Mono.Unix.Catalog.GetString("All Signals"));
		this.combobox_whichData.AppendText(global::Mono.Unix.Catalog.GetString("HbO only"));
		this.combobox_whichData.AppendText(global::Mono.Unix.Catalog.GetString("HbR only"));
		this.combobox_whichData.AppendText(global::Mono.Unix.Catalog.GetString("HbTotal only"));
		this.combobox_whichData.AppendText(global::Mono.Unix.Catalog.GetString("HbO2 + HbR"));
		this.combobox_whichData.AppendText(global::Mono.Unix.Catalog.GetString("HbO2 + HbR + HbTotal"));
		this.combobox_whichData.AppendText(global::Mono.Unix.Catalog.GetString("SO2 only"));
		this.combobox_whichData.AppendText(global::Mono.Unix.Catalog.GetString("SO2 + HbTotal"));
		this.combobox_whichData.AppendText(global::Mono.Unix.Catalog.GetString("SO2 + HbO2 + HbR + HbTotal"));
		this.combobox_whichData.AppendText(global::Mono.Unix.Catalog.GetString("EMG only"));
		this.combobox_whichData.Name = "combobox_whichData";
		this.combobox_whichData.Active = 1;
		this.vbox6.Add(this.combobox_whichData);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.combobox_whichData]));
		w32.Position = 0;
		w32.Expand = false;
		w32.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.entry_timeWin = new global::Gtk.Entry();
		this.entry_timeWin.CanFocus = true;
		this.entry_timeWin.Name = "entry_timeWin";
		this.entry_timeWin.Text = global::Mono.Unix.Catalog.GetString("30");
		this.entry_timeWin.IsEditable = true;
		this.entry_timeWin.InvisibleChar = '???';
		this.hbox9.Add(this.entry_timeWin);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.entry_timeWin]));
		w33.Position = 0;
		// Container child hbox9.Gtk.Box+BoxChild
		this.checkbutton_showtimeWin = new global::Gtk.CheckButton();
		this.checkbutton_showtimeWin.CanFocus = true;
		this.checkbutton_showtimeWin.Name = "checkbutton_showtimeWin";
		this.checkbutton_showtimeWin.Label = global::Mono.Unix.Catalog.GetString("Show Time Window");
		this.checkbutton_showtimeWin.DrawIndicator = true;
		this.checkbutton_showtimeWin.UseUnderline = true;
		this.hbox9.Add(this.checkbutton_showtimeWin);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.checkbutton_showtimeWin]));
		w34.Position = 1;
		this.vbox6.Add(this.hbox9);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox9]));
		w35.Position = 1;
		w35.Expand = false;
		w35.Fill = false;
		this.GtkAlignment1.Add(this.vbox6);
		this.frame3.Add(this.GtkAlignment1);
		this.GtkLabel5 = new global::Gtk.Label();
		this.GtkLabel5.Name = "GtkLabel5";
		this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Visualization</b>");
		this.GtkLabel5.UseMarkup = true;
		this.frame3.LabelWidget = this.GtkLabel5;
		this.vbox1.Add(this.frame3);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame3]));
		w38.Position = 3;
		w38.Expand = false;
		w38.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.expander1 = new global::Gtk.Expander(null);
		this.expander1.CanFocus = true;
		this.expander1.Name = "expander1";
		this.expander1.Expanded = true;
		// Container child expander1.Gtk.Container+ContainerChild
		this.vbox7 = new global::Gtk.VBox();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.frame5 = new global::Gtk.Frame();
		this.frame5.Name = "frame5";
		this.frame5.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame5.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		// Container child GtkAlignment2.Gtk.Container+ContainerChild
		this.vbox8 = new global::Gtk.VBox();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.hbox13 = new global::Gtk.HBox();
		this.hbox13.Name = "hbox13";
		this.hbox13.Spacing = 6;
		// Container child hbox13.Gtk.Box+BoxChild
		this.entry_780Power = new global::Gtk.Entry();
		this.entry_780Power.CanFocus = true;
		this.entry_780Power.Name = "entry_780Power";
		this.entry_780Power.Text = global::Mono.Unix.Catalog.GetString("255");
		this.entry_780Power.IsEditable = true;
		this.entry_780Power.InvisibleChar = '???';
		this.hbox13.Add(this.entry_780Power);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.entry_780Power]));
		w39.Position = 0;
		// Container child hbox13.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("780nm");
		this.hbox13.Add(this.label5);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.label5]));
		w40.Position = 1;
		w40.Expand = false;
		w40.Fill = false;
		this.vbox8.Add(this.hbox13);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox13]));
		w41.Position = 0;
		w41.Expand = false;
		w41.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.hbox15 = new global::Gtk.HBox();
		this.hbox15.Name = "hbox15";
		this.hbox15.Spacing = 6;
		// Container child hbox15.Gtk.Box+BoxChild
		this.entry_850Power = new global::Gtk.Entry();
		this.entry_850Power.CanFocus = true;
		this.entry_850Power.Name = "entry_850Power";
		this.entry_850Power.Text = global::Mono.Unix.Catalog.GetString("255");
		this.entry_850Power.IsEditable = true;
		this.entry_850Power.InvisibleChar = '???';
		this.hbox15.Add(this.entry_850Power);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.entry_850Power]));
		w42.Position = 0;
		// Container child hbox15.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("855nm");
		this.hbox15.Add(this.label7);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.label7]));
		w43.Position = 1;
		w43.Expand = false;
		w43.Fill = false;
		this.vbox8.Add(this.hbox15);
		global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox15]));
		w44.Position = 1;
		w44.Expand = false;
		w44.Fill = false;
		this.GtkAlignment2.Add(this.vbox8);
		this.frame5.Add(this.GtkAlignment2);
		this.GtkLabel6 = new global::Gtk.Label();
		this.GtkLabel6.Name = "GtkLabel6";
		this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString("Source Power ");
		this.GtkLabel6.UseMarkup = true;
		this.frame5.LabelWidget = this.GtkLabel6;
		this.vbox7.Add(this.frame5);
		global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.frame5]));
		w47.Position = 0;
		w47.Expand = false;
		w47.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.frame7 = new global::Gtk.Frame();
		this.frame7.Name = "frame7";
		this.frame7.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame7.Gtk.Container+ContainerChild
		this.GtkAlignment3 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment3.Name = "GtkAlignment3";
		this.GtkAlignment3.LeftPadding = ((uint)(12));
		// Container child GtkAlignment3.Gtk.Container+ContainerChild
		this.vbox9 = new global::Gtk.VBox();
		this.vbox9.Name = "vbox9";
		this.vbox9.Spacing = 6;
		// Container child vbox9.Gtk.Box+BoxChild
		this.checkbutton_SD = new global::Gtk.CheckButton();
		this.checkbutton_SD.CanFocus = true;
		this.checkbutton_SD.Name = "checkbutton_SD";
		this.checkbutton_SD.Label = global::Mono.Unix.Catalog.GetString("Save To SD Card");
		this.checkbutton_SD.Active = true;
		this.checkbutton_SD.DrawIndicator = true;
		this.checkbutton_SD.UseUnderline = true;
		this.vbox9.Add(this.checkbutton_SD);
		global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.checkbutton_SD]));
		w48.Position = 0;
		w48.Expand = false;
		w48.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.hbox17 = new global::Gtk.HBox();
		this.hbox17.Name = "hbox17";
		this.hbox17.Spacing = 6;
		// Container child hbox17.Gtk.Box+BoxChild
		this.entry_fileName = new global::Gtk.Entry();
		this.entry_fileName.CanFocus = true;
		this.entry_fileName.Name = "entry_fileName";
		this.entry_fileName.Text = global::Mono.Unix.Catalog.GetString("<SubjID>_Scan#");
		this.entry_fileName.IsEditable = true;
		this.entry_fileName.InvisibleChar = '???';
		this.hbox17.Add(this.entry_fileName);
		global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.entry_fileName]));
		w49.Position = 0;
		// Container child hbox17.Gtk.Box+BoxChild
		this.label9 = new global::Gtk.Label();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("File Name");
		this.hbox17.Add(this.label9);
		global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.label9]));
		w50.Position = 1;
		w50.Expand = false;
		w50.Fill = false;
		this.vbox9.Add(this.hbox17);
		global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox17]));
		w51.Position = 1;
		w51.Expand = false;
		w51.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.hseparator3 = new global::Gtk.HSeparator();
		this.hseparator3.Name = "hseparator3";
		this.vbox9.Add(this.hseparator3);
		global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hseparator3]));
		w52.Position = 2;
		w52.Expand = false;
		w52.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.checkbutton_EMG = new global::Gtk.CheckButton();
		this.checkbutton_EMG.CanFocus = true;
		this.checkbutton_EMG.Name = "checkbutton_EMG";
		this.checkbutton_EMG.Label = global::Mono.Unix.Catalog.GetString("Record EMG");
		this.checkbutton_EMG.DrawIndicator = true;
		this.checkbutton_EMG.UseUnderline = true;
		this.vbox9.Add(this.checkbutton_EMG);
		global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.checkbutton_EMG]));
		w53.Position = 3;
		w53.Expand = false;
		w53.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.checkbutton_UDP = new global::Gtk.CheckButton();
		this.checkbutton_UDP.CanFocus = true;
		this.checkbutton_UDP.Name = "checkbutton_UDP";
		this.checkbutton_UDP.Label = global::Mono.Unix.Catalog.GetString("Send WIFI");
		this.checkbutton_UDP.Active = true;
		this.checkbutton_UDP.DrawIndicator = true;
		this.checkbutton_UDP.UseUnderline = true;
		this.vbox9.Add(this.checkbutton_UDP);
		global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.checkbutton_UDP]));
		w54.Position = 4;
		w54.Expand = false;
		w54.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.checkbutton1 = new global::Gtk.CheckButton();
		this.checkbutton1.CanFocus = true;
		this.checkbutton1.Name = "checkbutton1";
		this.checkbutton1.Label = global::Mono.Unix.Catalog.GetString("Send Serial-USB");
		this.checkbutton1.DrawIndicator = true;
		this.checkbutton1.UseUnderline = true;
		this.vbox9.Add(this.checkbutton1);
		global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.checkbutton1]));
		w55.Position = 5;
		w55.Expand = false;
		w55.Fill = false;
		this.GtkAlignment3.Add(this.vbox9);
		this.frame7.Add(this.GtkAlignment3);
		this.GtkLabel10 = new global::Gtk.Label();
		this.GtkLabel10.Name = "GtkLabel10";
		this.GtkLabel10.LabelProp = global::Mono.Unix.Catalog.GetString("Data Streaming");
		this.GtkLabel10.UseMarkup = true;
		this.frame7.LabelWidget = this.GtkLabel10;
		this.vbox7.Add(this.frame7);
		global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.frame7]));
		w58.Position = 1;
		w58.Expand = false;
		w58.Fill = false;
		this.expander1.Add(this.vbox7);
		this.GtkLabel11 = new global::Gtk.Label();
		this.GtkLabel11.Name = "GtkLabel11";
		this.GtkLabel11.LabelProp = global::Mono.Unix.Catalog.GetString("Advanced Options");
		this.GtkLabel11.UseUnderline = true;
		this.expander1.LabelWidget = this.GtkLabel11;
		this.vbox1.Add(this.expander1);
		global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.expander1]));
		w60.Position = 4;
		w60.Expand = false;
		w60.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame9 = new global::Gtk.Frame();
		this.frame9.Name = "frame9";
		this.frame9.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame9.Gtk.Container+ContainerChild
		this.GtkAlignment4 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment4.Name = "GtkAlignment4";
		this.GtkAlignment4.LeftPadding = ((uint)(12));
		// Container child GtkAlignment4.Gtk.Container+ContainerChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview_Comments = new global::Gtk.TextView();
		this.textview_Comments.CanFocus = true;
		this.textview_Comments.Name = "textview_Comments";
		this.GtkScrolledWindow.Add(this.textview_Comments);
		this.GtkAlignment4.Add(this.GtkScrolledWindow);
		this.frame9.Add(this.GtkAlignment4);
		this.GtkLabel13 = new global::Gtk.Label();
		this.GtkLabel13.Name = "GtkLabel13";
		this.GtkLabel13.LabelProp = global::Mono.Unix.Catalog.GetString("Comments");
		this.GtkLabel13.UseMarkup = true;
		this.frame9.LabelWidget = this.GtkLabel13;
		this.vbox1.Add(this.frame9);
		global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame9]));
		w64.Position = 5;
		this.hbox1.Add(this.vbox1);
		global::Gtk.Box.BoxChild w65 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
		w65.Position = 2;
		w65.Expand = false;
		w65.Fill = false;
		this.vbox10.Add(this.hbox1);
		global::Gtk.Box.BoxChild w66 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.hbox1]));
		w66.Position = 1;
		// Container child vbox10.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox10.Add(this.statusbar1);
		global::Gtk.Box.BoxChild w67 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.statusbar1]));
		w67.Position = 2;
		w67.Expand = false;
		w67.Fill = false;
		this.Add(this.vbox10);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1590;
		this.DefaultHeight = 1043;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.entry_subjID.Changed += new global::System.EventHandler(this.EditSubjID);
		this.buttonStart.Clicked += new global::System.EventHandler(this.ClickedStart);
		this.buttonMarkEvent.Clicked += new global::System.EventHandler(this.MarkStimulus);
	}
}
