namespace ClassAlerter
{
    partial class frmAlerter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlerter));
            this.lstTimeLast = new System.Windows.Forms.ListBox();
            this.timAlerter = new System.Windows.Forms.Timer(this.components);
            this.ntfTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowCurrentState = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrepBell = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStopScreenSaverWhenStudy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStopScreenSaver = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisitFreeKaoyan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.panTimeTable = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnColorPicker = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.picLineEight = new System.Windows.Forms.PictureBox();
            this.picLineStudy = new System.Windows.Forms.PictureBox();
            this.picLineWaste = new System.Windows.Forms.PictureBox();
            this.picLineBack = new System.Windows.Forms.PictureBox();
            this.panFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCountDown = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnStatToday = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClearLevel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.hdgForm = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btnMinimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btnDesigner = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panTimeTable)).BeginInit();
            this.panTimeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLineEight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineStudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineWaste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdgForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdgForm.Panel)).BeginInit();
            this.hdgForm.Panel.SuspendLayout();
            this.hdgForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTimeLast
            // 
            this.lstTimeLast.BackColor = System.Drawing.Color.LightBlue;
            this.lstTimeLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstTimeLast.FormattingEnabled = true;
            this.lstTimeLast.ItemHeight = 12;
            this.lstTimeLast.Location = new System.Drawing.Point(474, 207);
            this.lstTimeLast.Name = "lstTimeLast";
            this.lstTimeLast.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstTimeLast.Size = new System.Drawing.Size(89, 60);
            this.lstTimeLast.TabIndex = 5;
            this.lstTimeLast.Visible = false;
            // 
            // timAlerter
            // 
            this.timAlerter.Enabled = true;
            this.timAlerter.Interval = 1000;
            this.timAlerter.Tick += new System.EventHandler(this.timAlerter_Tick);
            // 
            // ntfTray
            // 
            this.ntfTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfTray.ContextMenuStrip = this.mnuTray;
            this.ntfTray.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfTray.Icon")));
            this.ntfTray.Text = "Alerter";
            this.ntfTray.Visible = true;
            this.ntfTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ntfTray_MouseClick);
            this.ntfTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfTray_MouseDoubleClick);
            // 
            // mnuTray
            // 
            this.mnuTray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShow,
            this.mnuShowCurrentState,
            this.mnuPrepBell,
            this.mnuStopScreenSaverWhenStudy,
            this.mnuStopScreenSaver,
            this.mnuVisitFreeKaoyan,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuTray.Name = "mnuTray";
            this.mnuTray.Size = new System.Drawing.Size(243, 164);
            // 
            // mnuShow
            // 
            this.mnuShow.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mnuShow.Name = "mnuShow";
            this.mnuShow.Size = new System.Drawing.Size(242, 22);
            this.mnuShow.Text = "显示主窗体";
            this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
            // 
            // mnuShowCurrentState
            // 
            this.mnuShowCurrentState.Checked = true;
            this.mnuShowCurrentState.CheckOnClick = true;
            this.mnuShowCurrentState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuShowCurrentState.Name = "mnuShowCurrentState";
            this.mnuShowCurrentState.Size = new System.Drawing.Size(242, 22);
            this.mnuShowCurrentState.Text = "屏幕上显示当前课程";
            this.mnuShowCurrentState.Click += new System.EventHandler(this.mnuShowCurrentState_Click);
            // 
            // mnuPrepBell
            // 
            this.mnuPrepBell.Checked = true;
            this.mnuPrepBell.CheckOnClick = true;
            this.mnuPrepBell.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuPrepBell.Name = "mnuPrepBell";
            this.mnuPrepBell.Size = new System.Drawing.Size(242, 22);
            this.mnuPrepBell.Text = "课前两分钟打预备铃";
            // 
            // mnuStopScreenSaverWhenStudy
            // 
            this.mnuStopScreenSaverWhenStudy.Checked = true;
            this.mnuStopScreenSaverWhenStudy.CheckOnClick = true;
            this.mnuStopScreenSaverWhenStudy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuStopScreenSaverWhenStudy.Name = "mnuStopScreenSaverWhenStudy";
            this.mnuStopScreenSaverWhenStudy.Size = new System.Drawing.Size(242, 22);
            this.mnuStopScreenSaverWhenStudy.Text = "学习时间禁止屏幕保护";
            // 
            // mnuStopScreenSaver
            // 
            this.mnuStopScreenSaver.CheckOnClick = true;
            this.mnuStopScreenSaver.Name = "mnuStopScreenSaver";
            this.mnuStopScreenSaver.Size = new System.Drawing.Size(242, 22);
            this.mnuStopScreenSaver.Text = "禁止屏幕保护";
            this.mnuStopScreenSaver.Click += new System.EventHandler(this.mnuStopScreenSaver_Click);
            // 
            // mnuVisitFreeKaoyan
            // 
            this.mnuVisitFreeKaoyan.Name = "mnuVisitFreeKaoyan";
            this.mnuVisitFreeKaoyan.Size = new System.Drawing.Size(242, 22);
            this.mnuVisitFreeKaoyan.Text = "欢迎访问免费考研论坛身心健康";
            this.mnuVisitFreeKaoyan.Click += new System.EventHandler(this.mnuVisitFreeKaoyan_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(242, 22);
            this.mnuExit.Text = "退出";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // panTimeTable
            // 
            this.panTimeTable.Controls.Add(this.label1);
            this.panTimeTable.Controls.Add(this.pictureBox1);
            this.panTimeTable.Controls.Add(this.btnColorPicker);
            this.panTimeTable.Controls.Add(this.picLineEight);
            this.panTimeTable.Controls.Add(this.picLineStudy);
            this.panTimeTable.Controls.Add(this.picLineWaste);
            this.panTimeTable.Controls.Add(this.picLineBack);
            this.panTimeTable.Controls.Add(this.panFlow);
            this.panTimeTable.Controls.Add(this.lstTimeLast);
            this.panTimeTable.Controls.Add(this.lblCountDown);
            this.panTimeTable.Controls.Add(this.kryptonButton3);
            this.panTimeTable.Controls.Add(this.kryptonButton2);
            this.panTimeTable.Controls.Add(this.kryptonButton1);
            this.panTimeTable.Controls.Add(this.btnExit);
            this.panTimeTable.Controls.Add(this.btnStatToday);
            this.panTimeTable.Controls.Add(this.btnClearLevel);
            this.panTimeTable.Controls.Add(this.btnSave);
            this.panTimeTable.Controls.Add(this.btnAdd);
            this.panTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTimeTable.Location = new System.Drawing.Point(0, 0);
            this.panTimeTable.Name = "panTimeTable";
            this.panTimeTable.Size = new System.Drawing.Size(479, 343);
            this.panTimeTable.TabIndex = 1;
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.Location = new System.Drawing.Point(474, 158);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(90, 25);
            this.btnColorPicker.Splitter = false;
            this.btnColorPicker.TabIndex = 13;
            this.btnColorPicker.Text = "颜色";
            this.btnColorPicker.Values.ExtraText = "";
            this.btnColorPicker.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnColorPicker.Values.Image")));
            this.btnColorPicker.Values.ImageStates.ImageCheckedNormal = null;
            this.btnColorPicker.Values.ImageStates.ImageCheckedPressed = null;
            this.btnColorPicker.Values.ImageStates.ImageCheckedTracking = null;
            this.btnColorPicker.Values.Text = "颜色";
            this.btnColorPicker.Visible = false;
            this.btnColorPicker.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.btnColorPicker_SelectedColorChanged);
            // 
            // picLineEight
            // 
            this.picLineEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.picLineEight.Location = new System.Drawing.Point(387, 334);
            this.picLineEight.Name = "picLineEight";
            this.picLineEight.Size = new System.Drawing.Size(2, 6);
            this.picLineEight.TabIndex = 12;
            this.picLineEight.TabStop = false;
            // 
            // picLineStudy
            // 
            this.picLineStudy.BackColor = System.Drawing.Color.Blue;
            this.picLineStudy.Location = new System.Drawing.Point(4, 337);
            this.picLineStudy.Name = "picLineStudy";
            this.picLineStudy.Size = new System.Drawing.Size(1, 3);
            this.picLineStudy.TabIndex = 11;
            this.picLineStudy.TabStop = false;
            // 
            // picLineWaste
            // 
            this.picLineWaste.BackColor = System.Drawing.Color.Red;
            this.picLineWaste.Location = new System.Drawing.Point(474, 337);
            this.picLineWaste.Name = "picLineWaste";
            this.picLineWaste.Size = new System.Drawing.Size(1, 3);
            this.picLineWaste.TabIndex = 10;
            this.picLineWaste.TabStop = false;
            // 
            // picLineBack
            // 
            this.picLineBack.BackColor = System.Drawing.Color.Black;
            this.picLineBack.Location = new System.Drawing.Point(4, 337);
            this.picLineBack.Name = "picLineBack";
            this.picLineBack.Size = new System.Drawing.Size(471, 3);
            this.picLineBack.TabIndex = 9;
            this.picLineBack.TabStop = false;
            // 
            // panFlow
            // 
            this.panFlow.AutoScroll = true;
            this.panFlow.BackColor = System.Drawing.Color.Transparent;
            this.panFlow.Location = new System.Drawing.Point(4, 3);
            this.panFlow.Name = "panFlow";
            this.panFlow.Size = new System.Drawing.Size(375, 330);
            this.panFlow.TabIndex = 8;
            // 
            // lblCountDown
            // 
            this.lblCountDown.Location = new System.Drawing.Point(466, 273);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(106, 20);
            this.lblCountDown.TabIndex = 6;
            this.lblCountDown.Text = "离考试还有{0}天";
            this.lblCountDown.Values.ExtraText = "";
            this.lblCountDown.Values.Image = null;
            this.lblCountDown.Values.Text = "离考试还有{0}天";
            this.lblCountDown.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(384, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 25);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.Values.ExtraText = "";
            this.btnExit.Values.Image = null;
            this.btnExit.Values.ImageStates.ImageCheckedNormal = null;
            this.btnExit.Values.ImageStates.ImageCheckedPressed = null;
            this.btnExit.Values.ImageStates.ImageCheckedTracking = null;
            this.btnExit.Values.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStatToday
            // 
            this.btnStatToday.Location = new System.Drawing.Point(473, 75);
            this.btnStatToday.Name = "btnStatToday";
            this.btnStatToday.Size = new System.Drawing.Size(90, 25);
            this.btnStatToday.TabIndex = 3;
            this.btnStatToday.Text = "统计效率";
            this.btnStatToday.Values.ExtraText = "";
            this.btnStatToday.Values.Image = null;
            this.btnStatToday.Values.ImageStates.ImageCheckedNormal = null;
            this.btnStatToday.Values.ImageStates.ImageCheckedPressed = null;
            this.btnStatToday.Values.ImageStates.ImageCheckedTracking = null;
            this.btnStatToday.Values.Text = "统计效率";
            this.btnStatToday.Visible = false;
            this.btnStatToday.Click += new System.EventHandler(this.btnStatToday_Click);
            // 
            // btnClearLevel
            // 
            this.btnClearLevel.Location = new System.Drawing.Point(473, 106);
            this.btnClearLevel.Name = "btnClearLevel";
            this.btnClearLevel.Size = new System.Drawing.Size(90, 25);
            this.btnClearLevel.TabIndex = 2;
            this.btnClearLevel.Text = "清除效率";
            this.btnClearLevel.Values.ExtraText = "";
            this.btnClearLevel.Values.Image = null;
            this.btnClearLevel.Values.ImageStates.ImageCheckedNormal = null;
            this.btnClearLevel.Values.ImageStates.ImageCheckedPressed = null;
            this.btnClearLevel.Values.ImageStates.ImageCheckedTracking = null;
            this.btnClearLevel.Values.Text = "清除效率";
            this.btnClearLevel.Visible = false;
            this.btnClearLevel.Click += new System.EventHandler(this.btnClearLevel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(384, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存计划";
            this.btnSave.Values.ExtraText = "";
            this.btnSave.Values.Image = null;
            this.btnSave.Values.ImageStates.ImageCheckedNormal = null;
            this.btnSave.Values.ImageStates.ImageCheckedPressed = null;
            this.btnSave.Values.ImageStates.ImageCheckedTracking = null;
            this.btnSave.Values.Text = "保存计划";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(384, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加计划";
            this.btnAdd.Values.ExtraText = "";
            this.btnAdd.Values.Image = null;
            this.btnAdd.Values.ImageStates.ImageCheckedNormal = null;
            this.btnAdd.Values.ImageStates.ImageCheckedPressed = null;
            this.btnAdd.Values.ImageStates.ImageCheckedTracking = null;
            this.btnAdd.Values.Text = "添加计划";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // hdgForm
            // 
            this.hdgForm.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btnMinimize,
            this.btnDesigner});
            this.hdgForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hdgForm.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.hdgForm.Location = new System.Drawing.Point(0, 0);
            this.hdgForm.Name = "hdgForm";
            // 
            // hdgForm.Panel
            // 
            this.hdgForm.Panel.Controls.Add(this.panTimeTable);
            this.hdgForm.Size = new System.Drawing.Size(481, 393);
            this.hdgForm.TabIndex = 7;
            this.hdgForm.Text = "工作计划安排器";
            this.hdgForm.ValuesPrimary.Description = "";
            this.hdgForm.ValuesPrimary.Heading = "工作计划安排器";
            this.hdgForm.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("hdgForm.ValuesPrimary.Image")));
            this.hdgForm.ValuesSecondary.Description = "";
            this.hdgForm.ValuesSecondary.Heading = "保持效率，勇往直前";
            this.hdgForm.ValuesSecondary.Image = null;
            this.hdgForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hdgForm_MouseMove);
            this.hdgForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hdgForm_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.ExtraText = "";
            this.btnMinimize.Image = null;
            this.btnMinimize.Text = "";
            this.btnMinimize.ToolTipBody = "最小化到任务栏";
            this.btnMinimize.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.btnMinimize.UniqueName = "38CDEDED95734FC338CDEDED95734FC3";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnDesigner
            // 
            this.btnDesigner.ExtraText = "梁爽";
            this.btnDesigner.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader;
            this.btnDesigner.Image = null;
            this.btnDesigner.Text = "设计：";
            this.btnDesigner.ToolTipBody = "打开冰河魔法师的页面";
            this.btnDesigner.UniqueName = "BF82DAC180A04B86BF82DAC180A04B86";
            this.btnDesigner.Click += new System.EventHandler(this.btnDesigner_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(385, 75);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 4;
            this.kryptonButton1.Text = "同步计划";
            this.kryptonButton1.Values.ExtraText = "";
            this.kryptonButton1.Values.Image = null;
            this.kryptonButton1.Values.ImageStates.ImageCheckedNormal = null;
            this.kryptonButton1.Values.ImageStates.ImageCheckedPressed = null;
            this.kryptonButton1.Values.ImageStates.ImageCheckedTracking = null;
            this.kryptonButton1.Values.Text = "同步计划";
            this.kryptonButton1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(386, 106);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton2.TabIndex = 4;
            this.kryptonButton2.Text = "同步时间";
            this.kryptonButton2.Values.ExtraText = "";
            this.kryptonButton2.Values.Image = null;
            this.kryptonButton2.Values.ImageStates.ImageCheckedNormal = null;
            this.kryptonButton2.Values.ImageStates.ImageCheckedPressed = null;
            this.kryptonButton2.Values.ImageStates.ImageCheckedTracking = null;
            this.kryptonButton2.Values.Text = "同步时间";
            this.kryptonButton2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(386, 158);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton3.TabIndex = 4;
            this.kryptonButton3.Text = "同步所有";
            this.kryptonButton3.Values.ExtraText = "";
            this.kryptonButton3.Values.Image = null;
            this.kryptonButton3.Values.ImageStates.ImageCheckedNormal = null;
            this.kryptonButton3.Values.ImageStates.ImageCheckedPressed = null;
            this.kryptonButton3.Values.ImageStates.ImageCheckedTracking = null;
            this.kryptonButton3.Values.Text = "同步所有";
            this.kryptonButton3.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(397, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(398, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "设备已连接";
            // 
            // frmAlerter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 393);
            this.Controls.Add(this.hdgForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmAlerter";
            this.Text = "冰河魔法师的考研专用工具";
            this.Load += new System.EventHandler(this.frmAlerter_Load);
            this.Shown += new System.EventHandler(this.frmAlerter_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlerter_FormClosing);
            this.mnuTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panTimeTable)).EndInit();
            this.panTimeTable.ResumeLayout(false);
            this.panTimeTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLineEight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineStudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineWaste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdgForm.Panel)).EndInit();
            this.hdgForm.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hdgForm)).EndInit();
            this.hdgForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timAlerter;
        private System.Windows.Forms.NotifyIcon ntfTray;
        private System.Windows.Forms.ListBox lstTimeLast;
        private System.Windows.Forms.ContextMenuStrip mnuTray;
        private System.Windows.Forms.ToolStripMenuItem mnuPrepBell;
        private System.Windows.Forms.ToolStripMenuItem mnuStopScreenSaverWhenStudy;
        private System.Windows.Forms.ToolStripMenuItem mnuStopScreenSaver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuShow;
        private System.Windows.Forms.ToolStripMenuItem mnuShowCurrentState;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panTimeTable;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCountDown;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStatToday;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClearLevel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private System.Windows.Forms.FlowLayoutPanel panFlow;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdgForm;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnMinimize;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnDesigner;
        private System.Windows.Forms.PictureBox picLineBack;
        private System.Windows.Forms.PictureBox picLineStudy;
        private System.Windows.Forms.PictureBox picLineWaste;
        private System.Windows.Forms.PictureBox picLineEight;
        private System.Windows.Forms.ToolStripMenuItem mnuVisitFreeKaoyan;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton btnColorPicker;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

