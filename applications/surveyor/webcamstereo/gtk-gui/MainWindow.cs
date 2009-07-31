// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.UIManager UIManager;
    
    private Gtk.Action FileAction;
    
    private Gtk.Action ExitAction;
    
    private Gtk.Action ToolsAction;
    
    private Gtk.ToggleAction RecordImagesAction;
    
    private Gtk.Action CalibrateAlignmentAction;
    
    private Gtk.Action ManualTweaksAction;
    
    private Gtk.Action SaveAsAnimatedGifAction;
    
    private Gtk.VBox vbox1;
    
    private Gtk.MenuBar menubar1;
    
    private Gtk.HBox hbox1;
    
    private Gtk.Image leftimage;
    
    private Gtk.Image rightimage;
    
    private Gtk.HBox hbox2;
    
    private Gtk.CheckButton chkRecord;
    
    private Gtk.CheckButton chkCalibrateLeft;
    
    private Gtk.CheckButton chkCalibrateRight;
    
    private Gtk.CheckButton chkFlipRight;
    
    private Gtk.CheckButton chkFlipLeft;
    
    private Gtk.CheckButton chkRadialCorrection;
    
    private Gtk.CheckButton chkRectification;
    
    private Gtk.Button cmdTweaks;
    
    private Gtk.Button cmdCalibrateAlignment;
    
    private Gtk.HBox hbox3;
    
    private Gtk.Label lblBaseline;
    
    private Gtk.Entry txtBaseline;
    
    private Gtk.HBox hbox4;
    
    private Gtk.Button cmdSimpleStereo;
    
    private Gtk.Button cmdDenseStereo;
    
    private Gtk.Button cmdSaveCalibration;
    
    private Gtk.Button cmdSaveCalibrationImage;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.UIManager = new Gtk.UIManager();
        Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
        this.FileAction = new Gtk.Action("FileAction", Mono.Unix.Catalog.GetString("File"), null, null);
        this.FileAction.ShortLabel = Mono.Unix.Catalog.GetString("File");
        w1.Add(this.FileAction, null);
        this.ExitAction = new Gtk.Action("ExitAction", Mono.Unix.Catalog.GetString("Exit"), null, "gtk-stop");
        this.ExitAction.ShortLabel = Mono.Unix.Catalog.GetString("Exit");
        w1.Add(this.ExitAction, null);
        this.ToolsAction = new Gtk.Action("ToolsAction", Mono.Unix.Catalog.GetString("Tools"), null, null);
        this.ToolsAction.ShortLabel = Mono.Unix.Catalog.GetString("Tools");
        w1.Add(this.ToolsAction, null);
        this.RecordImagesAction = new Gtk.ToggleAction("RecordImagesAction", Mono.Unix.Catalog.GetString("Record images"), null, null);
        this.RecordImagesAction.Active = true;
        this.RecordImagesAction.ShortLabel = Mono.Unix.Catalog.GetString("Record images");
        w1.Add(this.RecordImagesAction, null);
        this.CalibrateAlignmentAction = new Gtk.Action("CalibrateAlignmentAction", Mono.Unix.Catalog.GetString("Calibrate Alignment"), null, null);
        this.CalibrateAlignmentAction.ShortLabel = Mono.Unix.Catalog.GetString("Calibrate Alignment");
        w1.Add(this.CalibrateAlignmentAction, null);
        this.ManualTweaksAction = new Gtk.Action("ManualTweaksAction", Mono.Unix.Catalog.GetString("Manual Tweaks"), null, null);
        this.ManualTweaksAction.ShortLabel = Mono.Unix.Catalog.GetString("Manual Tweaks");
        w1.Add(this.ManualTweaksAction, null);
        this.UIManager.InsertActionGroup(w1, 0);
        Gtk.ActionGroup w2 = new Gtk.ActionGroup("New Action Group");
        this.SaveAsAnimatedGifAction = new Gtk.Action("SaveAsAnimatedGifAction", Mono.Unix.Catalog.GetString("Save as animated gif"), null, null);
        this.SaveAsAnimatedGifAction.ShortLabel = Mono.Unix.Catalog.GetString("Save as animated gif");
        w2.Add(this.SaveAsAnimatedGifAction, null);
        this.UIManager.InsertActionGroup(w2, 1);
        this.AddAccelGroup(this.UIManager.AccelGroup);
        this.CanFocus = true;
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("Webcam SVS");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.vbox1 = new Gtk.VBox();
        this.vbox1.Name = "vbox1";
        this.vbox1.Spacing = 6;
        // Container child vbox1.Gtk.Box+BoxChild
        this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='SaveAsAnimatedGifAction' action='SaveAsAnimatedGifAction'/><menuitem name='ExitAction' action='ExitAction'/></menu><menu name='ToolsAction' action='ToolsAction'><menuitem name='RecordImagesAction' action='RecordImagesAction'/><menuitem name='CalibrateAlignmentAction' action='CalibrateAlignmentAction'/><menuitem name='ManualTweaksAction' action='ManualTweaksAction'/></menu></menubar></ui>");
        this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
        this.menubar1.Name = "menubar1";
        this.vbox1.Add(this.menubar1);
        Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
        w3.Position = 0;
        w3.Expand = false;
        w3.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox1 = new Gtk.HBox();
        this.hbox1.Name = "hbox1";
        this.hbox1.Spacing = 6;
        // Container child hbox1.Gtk.Box+BoxChild
        this.leftimage = new Gtk.Image();
        this.leftimage.Name = "leftimage";
        this.hbox1.Add(this.leftimage);
        Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox1[this.leftimage]));
        w4.Position = 0;
        // Container child hbox1.Gtk.Box+BoxChild
        this.rightimage = new Gtk.Image();
        this.rightimage.Name = "rightimage";
        this.hbox1.Add(this.rightimage);
        Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox1[this.rightimage]));
        w5.Position = 1;
        this.vbox1.Add(this.hbox1);
        Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
        w6.Position = 1;
        w6.Expand = false;
        w6.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox2 = new Gtk.HBox();
        this.hbox2.Name = "hbox2";
        this.hbox2.Spacing = 6;
        // Container child hbox2.Gtk.Box+BoxChild
        this.chkRecord = new Gtk.CheckButton();
        this.chkRecord.CanFocus = true;
        this.chkRecord.Name = "chkRecord";
        this.chkRecord.Label = Mono.Unix.Catalog.GetString("Record");
        this.chkRecord.DrawIndicator = true;
        this.chkRecord.UseUnderline = true;
        this.hbox2.Add(this.chkRecord);
        Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox2[this.chkRecord]));
        w7.Position = 0;
        // Container child hbox2.Gtk.Box+BoxChild
        this.chkCalibrateLeft = new Gtk.CheckButton();
        this.chkCalibrateLeft.CanFocus = true;
        this.chkCalibrateLeft.Name = "chkCalibrateLeft";
        this.chkCalibrateLeft.Label = Mono.Unix.Catalog.GetString("Calibrate left camera");
        this.chkCalibrateLeft.DrawIndicator = true;
        this.chkCalibrateLeft.UseUnderline = true;
        this.hbox2.Add(this.chkCalibrateLeft);
        Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox2[this.chkCalibrateLeft]));
        w8.Position = 1;
        // Container child hbox2.Gtk.Box+BoxChild
        this.chkCalibrateRight = new Gtk.CheckButton();
        this.chkCalibrateRight.CanFocus = true;
        this.chkCalibrateRight.Name = "chkCalibrateRight";
        this.chkCalibrateRight.Label = Mono.Unix.Catalog.GetString("Calibrate right camera");
        this.chkCalibrateRight.DrawIndicator = true;
        this.chkCalibrateRight.UseUnderline = true;
        this.hbox2.Add(this.chkCalibrateRight);
        Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox2[this.chkCalibrateRight]));
        w9.Position = 2;
        // Container child hbox2.Gtk.Box+BoxChild
        this.chkFlipRight = new Gtk.CheckButton();
        this.chkFlipRight.CanFocus = true;
        this.chkFlipRight.Name = "chkFlipRight";
        this.chkFlipRight.Label = Mono.Unix.Catalog.GetString("Flip right");
        this.chkFlipRight.DrawIndicator = true;
        this.chkFlipRight.UseUnderline = true;
        this.hbox2.Add(this.chkFlipRight);
        Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.hbox2[this.chkFlipRight]));
        w10.PackType = ((Gtk.PackType)(1));
        w10.Position = 3;
        // Container child hbox2.Gtk.Box+BoxChild
        this.chkFlipLeft = new Gtk.CheckButton();
        this.chkFlipLeft.CanFocus = true;
        this.chkFlipLeft.Name = "chkFlipLeft";
        this.chkFlipLeft.Label = Mono.Unix.Catalog.GetString("Flip left");
        this.chkFlipLeft.DrawIndicator = true;
        this.chkFlipLeft.UseUnderline = true;
        this.hbox2.Add(this.chkFlipLeft);
        Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox2[this.chkFlipLeft]));
        w11.PackType = ((Gtk.PackType)(1));
        w11.Position = 4;
        // Container child hbox2.Gtk.Box+BoxChild
        this.chkRadialCorrection = new Gtk.CheckButton();
        this.chkRadialCorrection.CanFocus = true;
        this.chkRadialCorrection.Name = "chkRadialCorrection";
        this.chkRadialCorrection.Label = Mono.Unix.Catalog.GetString("Radial Correction");
        this.chkRadialCorrection.DrawIndicator = true;
        this.chkRadialCorrection.UseUnderline = true;
        this.hbox2.Add(this.chkRadialCorrection);
        Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.hbox2[this.chkRadialCorrection]));
        w12.PackType = ((Gtk.PackType)(1));
        w12.Position = 5;
        // Container child hbox2.Gtk.Box+BoxChild
        this.chkRectification = new Gtk.CheckButton();
        this.chkRectification.CanFocus = true;
        this.chkRectification.Name = "chkRectification";
        this.chkRectification.Label = Mono.Unix.Catalog.GetString("Rectification");
        this.chkRectification.DrawIndicator = true;
        this.chkRectification.UseUnderline = true;
        this.hbox2.Add(this.chkRectification);
        Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox2[this.chkRectification]));
        w13.PackType = ((Gtk.PackType)(1));
        w13.Position = 6;
        // Container child hbox2.Gtk.Box+BoxChild
        this.cmdTweaks = new Gtk.Button();
        this.cmdTweaks.CanFocus = true;
        this.cmdTweaks.Name = "cmdTweaks";
        this.cmdTweaks.UseUnderline = true;
        this.cmdTweaks.Label = Mono.Unix.Catalog.GetString("Tweaks");
        this.hbox2.Add(this.cmdTweaks);
        Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox2[this.cmdTweaks]));
        w14.PackType = ((Gtk.PackType)(1));
        w14.Position = 7;
        w14.Expand = false;
        w14.Fill = false;
        // Container child hbox2.Gtk.Box+BoxChild
        this.cmdCalibrateAlignment = new Gtk.Button();
        this.cmdCalibrateAlignment.CanFocus = true;
        this.cmdCalibrateAlignment.Name = "cmdCalibrateAlignment";
        this.cmdCalibrateAlignment.UseUnderline = true;
        this.cmdCalibrateAlignment.Label = Mono.Unix.Catalog.GetString("Calibrate Alignment");
        this.hbox2.Add(this.cmdCalibrateAlignment);
        Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.hbox2[this.cmdCalibrateAlignment]));
        w15.PackType = ((Gtk.PackType)(1));
        w15.Position = 8;
        w15.Expand = false;
        w15.Fill = false;
        this.vbox1.Add(this.hbox2);
        Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
        w16.Position = 2;
        w16.Expand = false;
        w16.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox3 = new Gtk.HBox();
        this.hbox3.Name = "hbox3";
        this.hbox3.Spacing = 6;
        // Container child hbox3.Gtk.Box+BoxChild
        this.lblBaseline = new Gtk.Label();
        this.lblBaseline.Name = "lblBaseline";
        this.lblBaseline.LabelProp = Mono.Unix.Catalog.GetString("Baseline (mm)");
        this.hbox3.Add(this.lblBaseline);
        Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.hbox3[this.lblBaseline]));
        w17.Position = 0;
        w17.Expand = false;
        w17.Fill = false;
        // Container child hbox3.Gtk.Box+BoxChild
        this.txtBaseline = new Gtk.Entry();
        this.txtBaseline.CanFocus = true;
        this.txtBaseline.Name = "txtBaseline";
        this.txtBaseline.IsEditable = true;
        this.txtBaseline.InvisibleChar = '●';
        this.hbox3.Add(this.txtBaseline);
        Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.hbox3[this.txtBaseline]));
        w18.Position = 1;
        this.vbox1.Add(this.hbox3);
        Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
        w19.Position = 3;
        w19.Expand = false;
        w19.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox4 = new Gtk.HBox();
        this.hbox4.Name = "hbox4";
        this.hbox4.Spacing = 6;
        // Container child hbox4.Gtk.Box+BoxChild
        this.cmdSimpleStereo = new Gtk.Button();
        this.cmdSimpleStereo.CanFocus = true;
        this.cmdSimpleStereo.Name = "cmdSimpleStereo";
        this.cmdSimpleStereo.UseUnderline = true;
        this.cmdSimpleStereo.Label = Mono.Unix.Catalog.GetString("Simple Stereo");
        this.hbox4.Add(this.cmdSimpleStereo);
        Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox4[this.cmdSimpleStereo]));
        w20.Position = 0;
        w20.Expand = false;
        w20.Fill = false;
        // Container child hbox4.Gtk.Box+BoxChild
        this.cmdDenseStereo = new Gtk.Button();
        this.cmdDenseStereo.CanFocus = true;
        this.cmdDenseStereo.Name = "cmdDenseStereo";
        this.cmdDenseStereo.UseUnderline = true;
        this.cmdDenseStereo.Label = Mono.Unix.Catalog.GetString("Dense Stereo");
        this.hbox4.Add(this.cmdDenseStereo);
        Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.hbox4[this.cmdDenseStereo]));
        w21.Position = 1;
        w21.Expand = false;
        w21.Fill = false;
        // Container child hbox4.Gtk.Box+BoxChild
        this.cmdSaveCalibration = new Gtk.Button();
        this.cmdSaveCalibration.CanFocus = true;
        this.cmdSaveCalibration.Name = "cmdSaveCalibration";
        this.cmdSaveCalibration.UseUnderline = true;
        this.cmdSaveCalibration.Label = Mono.Unix.Catalog.GetString("Save calibration file");
        this.hbox4.Add(this.cmdSaveCalibration);
        Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.hbox4[this.cmdSaveCalibration]));
        w22.Position = 3;
        w22.Expand = false;
        w22.Fill = false;
        // Container child hbox4.Gtk.Box+BoxChild
        this.cmdSaveCalibrationImage = new Gtk.Button();
        this.cmdSaveCalibrationImage.CanFocus = true;
        this.cmdSaveCalibrationImage.Name = "cmdSaveCalibrationImage";
        this.cmdSaveCalibrationImage.UseUnderline = true;
        this.cmdSaveCalibrationImage.Label = Mono.Unix.Catalog.GetString("Save calibration image");
        this.hbox4.Add(this.cmdSaveCalibrationImage);
        Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.hbox4[this.cmdSaveCalibrationImage]));
        w23.Position = 4;
        w23.Expand = false;
        w23.Fill = false;
        this.vbox1.Add(this.hbox4);
        Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
        w24.PackType = ((Gtk.PackType)(1));
        w24.Position = 4;
        w24.Expand = false;
        w24.Fill = false;
        this.Add(this.vbox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 1076;
        this.DefaultHeight = 300;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.ExitAction.Activated += new System.EventHandler(this.OnExitActionActivated);
        this.RecordImagesAction.Activated += new System.EventHandler(this.OnRecordImagesActionActivated);
        this.CalibrateAlignmentAction.Activated += new System.EventHandler(this.OnCalibrateAlignmentActionActivated);
        this.ManualTweaksAction.Activated += new System.EventHandler(this.OnManualTweaksActionActivated);
        this.SaveAsAnimatedGifAction.Activated += new System.EventHandler(this.OnSaveAsAnimatedGifActionActivated);
        this.chkRecord.Clicked += new System.EventHandler(this.OnChkRecordClicked);
        this.chkCalibrateLeft.Clicked += new System.EventHandler(this.OnChkCalibrateLeftClicked);
        this.chkCalibrateRight.Clicked += new System.EventHandler(this.OnChkCalibrateRightClicked);
        this.cmdCalibrateAlignment.Clicked += new System.EventHandler(this.OnCmdCalibrateAlignmentClicked);
        this.cmdTweaks.Clicked += new System.EventHandler(this.OnCmdTweaksClicked);
        this.chkRectification.Clicked += new System.EventHandler(this.OnChkDisableRectificationClicked);
        this.chkRadialCorrection.Clicked += new System.EventHandler(this.OnChkRadialCorrectionClicked);
        this.chkFlipLeft.Clicked += new System.EventHandler(this.OnChkFlipLeftClicked);
        this.chkFlipRight.Clicked += new System.EventHandler(this.OnChkFlipRightClicked);
        this.cmdSimpleStereo.Clicked += new System.EventHandler(this.OnCmdSimpleStereoClicked);
        this.cmdDenseStereo.Clicked += new System.EventHandler(this.OnCmdDenseStereoClicked);
        this.cmdSaveCalibration.Clicked += new System.EventHandler(this.OnCmdSaveCalibrationClicked);
        this.cmdSaveCalibrationImage.Clicked += new System.EventHandler(this.OnCmdSaveCalibrationImageClicked);
    }
}