namespace demoapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainMenu1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeAviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputChannelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externalTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolbarPlayButton = new System.Windows.Forms.ToolStripButton();
            this.ToolBarStopButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBarSnapButton = new System.Windows.Forms.ToolStripButton();
            this.ToolBarAVIButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBarDeviceButton = new System.Windows.Forms.ToolStripButton();
            this.ToolBarPropertiesButton = new System.Windows.Forms.ToolStripButton();
            this.ToolBarInputChannel = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.icImagingControl1 = new TIS.Imaging.ICImagingControl();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToolBarTriggerButton = new System.Windows.Forms.ToolStripButton();
            this.MainMenu1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icImagingControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.previewToolStripMenuItem,
            this.deviceSettingsToolStripMenuItem});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(881, 26);
            this.MainMenu1.TabIndex = 0;
            this.MainMenu1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.writeAviToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // writeAviToolStripMenuItem
            // 
            this.writeAviToolStripMenuItem.Name = "writeAviToolStripMenuItem";
            this.writeAviToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.writeAviToolStripMenuItem.Text = "Write Avi...";
            this.writeAviToolStripMenuItem.Click += new System.EventHandler(this.writeAviToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.previewToolStripMenuItem.Text = "Preview";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // deviceSettingsToolStripMenuItem
            // 
            this.deviceSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.inputChannelsToolStripMenuItem,
            this.externalTriggerToolStripMenuItem,
            this.speedToolStripMenuItem});
            this.deviceSettingsToolStripMenuItem.Name = "deviceSettingsToolStripMenuItem";
            this.deviceSettingsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.deviceSettingsToolStripMenuItem.Text = "Device Settings";
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deviceToolStripMenuItem.Text = "Device...";
            this.deviceToolStripMenuItem.Click += new System.EventHandler(this.deviceToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.imageToolStripMenuItem.Text = "Image...";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // inputChannelsToolStripMenuItem
            // 
            this.inputChannelsToolStripMenuItem.Name = "inputChannelsToolStripMenuItem";
            this.inputChannelsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.inputChannelsToolStripMenuItem.Text = "Input Channels";
            // 
            // externalTriggerToolStripMenuItem
            // 
            this.externalTriggerToolStripMenuItem.Name = "externalTriggerToolStripMenuItem";
            this.externalTriggerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.externalTriggerToolStripMenuItem.Text = "External Trigger";
            this.externalTriggerToolStripMenuItem.Click += new System.EventHandler(this.externalTriggerToolStripMenuItem_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.speedToolStripMenuItem.Text = "Speed";
            this.speedToolStripMenuItem.Click += new System.EventHandler(this.speedToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolbarPlayButton,
            this.ToolBarStopButton,
            this.toolStripSeparator2,
            this.ToolBarSnapButton,
            this.ToolBarAVIButton,
            this.toolStripSeparator3,
            this.ToolBarDeviceButton,
            this.ToolBarPropertiesButton,
            this.ToolBarInputChannel,
            this.toolStripSeparator4,
            this.ToolBarTriggerButton,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripTextBox2,
            this.toolStripButton5,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(881, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // ToolbarPlayButton
            // 
            this.ToolbarPlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolbarPlayButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolbarPlayButton.Image")));
            this.ToolbarPlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolbarPlayButton.Name = "ToolbarPlayButton";
            this.ToolbarPlayButton.Size = new System.Drawing.Size(23, 23);
            this.ToolbarPlayButton.Text = "Start the live video.";
            // 
            // ToolBarStopButton
            // 
            this.ToolBarStopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarStopButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarStopButton.Image")));
            this.ToolBarStopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarStopButton.Name = "ToolBarStopButton";
            this.ToolBarStopButton.Size = new System.Drawing.Size(23, 23);
            this.ToolBarStopButton.Text = "Stop the live video.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // ToolBarSnapButton
            // 
            this.ToolBarSnapButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarSnapButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarSnapButton.Image")));
            this.ToolBarSnapButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarSnapButton.Name = "ToolBarSnapButton";
            this.ToolBarSnapButton.Size = new System.Drawing.Size(23, 23);
            this.ToolBarSnapButton.Text = "Snap an image and save it to disk.";
            // 
            // ToolBarAVIButton
            // 
            this.ToolBarAVIButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarAVIButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarAVIButton.Image")));
            this.ToolBarAVIButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarAVIButton.Name = "ToolBarAVIButton";
            this.ToolBarAVIButton.Size = new System.Drawing.Size(23, 23);
            this.ToolBarAVIButton.Text = "Open the AVI Capture dialog";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // ToolBarDeviceButton
            // 
            this.ToolBarDeviceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarDeviceButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarDeviceButton.Image")));
            this.ToolBarDeviceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarDeviceButton.Name = "ToolBarDeviceButton";
            this.ToolBarDeviceButton.Size = new System.Drawing.Size(23, 23);
            this.ToolBarDeviceButton.Text = "Select a video capture device, video format and frame rate.";
            // 
            // ToolBarPropertiesButton
            // 
            this.ToolBarPropertiesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarPropertiesButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarPropertiesButton.Image")));
            this.ToolBarPropertiesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarPropertiesButton.Name = "ToolBarPropertiesButton";
            this.ToolBarPropertiesButton.Size = new System.Drawing.Size(23, 23);
            this.ToolBarPropertiesButton.Text = "Show camera and video properties dialog.";
            // 
            // ToolBarInputChannel
            // 
            this.ToolBarInputChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarInputChannel.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarInputChannel.Image")));
            this.ToolBarInputChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarInputChannel.Name = "ToolBarInputChannel";
            this.ToolBarInputChannel.Size = new System.Drawing.Size(29, 23);
            this.ToolBarInputChannel.Text = "Select an input channel.";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 26);
            this.toolStripTextBox1.ToolTipText = "âÊëúéBâeä‘äuÇì¸óÕ\r\n";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton1.Text = "âÊëúéBâeä‘äuämíË";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 26);
            this.toolStripTextBox2.ToolTipText = "éBâeâÊëúñáêîÇì¸óÕ\r\n";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(60, 23);
            this.toolStripButton5.Text = "éBâeñáêî";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 23);
            this.toolStripButton3.Text = "éBâeäJén";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 23);
            this.toolStripButton2.Text = "å¥ì_ïúãA";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 23);
            this.toolStripButton4.Text = "å¥ì_ê›íË";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 23);
            this.toolStripLabel1.Text = "ägëÂó¶";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%",
            "200%",
            "300%",
            "400%",
            "500%",
            "600%",
            "700%",
            "800%",
            "900%",
            "1000%"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 26);
            this.toolStripComboBox1.Tag = "";
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // icImagingControl1
            // 
            this.icImagingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.icImagingControl1.BackColor = System.Drawing.Color.White;
            this.icImagingControl1.DeviceListChangedExecutionMode = TIS.Imaging.EventExecutionMode.Invoke;
            this.icImagingControl1.DeviceLostExecutionMode = TIS.Imaging.EventExecutionMode.AsyncInvoke;
            this.icImagingControl1.ImageAvailableExecutionMode = TIS.Imaging.EventExecutionMode.MultiThreaded;
            this.icImagingControl1.LiveDisplayPosition = new System.Drawing.Point(0, 0);
            this.icImagingControl1.Location = new System.Drawing.Point(126, 85);
            this.icImagingControl1.Name = "icImagingControl1";
            this.icImagingControl1.Size = new System.Drawing.Size(755, 456);
            this.icImagingControl1.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 52);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(881, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(229, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(29, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "+";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(264, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(29, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "-";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Frame Filter Modules";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(0, 241);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 88);
            this.listBox2.TabIndex = 8;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Frame Filters";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 154);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dialog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // ToolBarTriggerButton
            // 
            this.ToolBarTriggerButton.CheckOnClick = true;
            this.ToolBarTriggerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarTriggerButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarTriggerButton.Image")));
            this.ToolBarTriggerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarTriggerButton.Name = "ToolBarTriggerButton";
            this.ToolBarTriggerButton.Size = new System.Drawing.Size(23, 23);
            this.ToolBarTriggerButton.Text = "Enable or disable the external trigger.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.icImagingControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu1;
            this.Name = "Form1";
            this.Text = "Demo Application C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icImagingControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private TIS.Imaging.ICImagingControl icImagingControl1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeAviToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputChannelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem externalTriggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ToolbarPlayButton;
        private System.Windows.Forms.ToolStripButton ToolBarStopButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ToolBarSnapButton;
        private System.Windows.Forms.ToolStripButton ToolBarAVIButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ToolBarDeviceButton;
        private System.Windows.Forms.ToolStripButton ToolBarPropertiesButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton ToolBarInputChannel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton ToolBarTriggerButton;
    }
}

