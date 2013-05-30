namespace ClassAlerter
{
    partial class TimePlan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstLevel = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lstDetail = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblTime = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTimeFrom = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.txtTimeTo = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panMain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtTimeUsed = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).BeginInit();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLevel
            // 
            this.lstLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLevel.DropDownWidth = 51;
            this.lstLevel.FormattingEnabled = false;
            this.lstLevel.Items.AddRange(new object[] {
            "高效",
            "中等",
            "低效",
            "离开"});
            this.lstLevel.Location = new System.Drawing.Point(0, 1);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.Size = new System.Drawing.Size(51, 23);
            this.lstLevel.TabIndex = 7;
            this.lstLevel.SelectedIndexChanged += new System.EventHandler(this.lstLevel_SelectedIndexChanged);
            // 
            // lstDetail
            // 
            this.lstDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDetail.DropDownWidth = 51;
            this.lstDetail.FormattingEnabled = false;
            this.lstDetail.Items.AddRange(new object[] {
            "数学",
            "专业",
            "政治",
            "英语",
            "自由"});
            this.lstDetail.Location = new System.Drawing.Point(144, 1);
            this.lstDetail.Name = "lstDetail";
            this.lstDetail.Size = new System.Drawing.Size(51, 23);
            this.lstDetail.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(221, 1);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(6, 2);
            this.lblTime.TabIndex = 9;
            this.lblTime.Values.ExtraText = "";
            this.lblTime.Values.Image = null;
            this.lblTime.Values.Text = "";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(85, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(24, 20);
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Text = "到";
            this.kryptonLabel2.Values.ExtraText = "";
            this.kryptonLabel2.Values.Image = null;
            this.kryptonLabel2.Values.Text = "到";
            // 
            // txtTimeFrom
            // 
            this.txtTimeFrom.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.txtTimeFrom.Location = new System.Drawing.Point(52, 1);
            this.txtTimeFrom.Mask = "90:00";
            this.txtTimeFrom.Name = "txtTimeFrom";
            this.txtTimeFrom.PromptChar = '_';
            this.txtTimeFrom.Size = new System.Drawing.Size(34, 23);
            this.txtTimeFrom.TabIndex = 11;
            this.txtTimeFrom.Text = "  :";
            this.txtTimeFrom.TextChanged += new System.EventHandler(this.txtTimeTo_TextChanged);
            // 
            // txtTimeTo
            // 
            this.txtTimeTo.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.txtTimeTo.Location = new System.Drawing.Point(107, 1);
            this.txtTimeTo.Mask = "90:00";
            this.txtTimeTo.Name = "txtTimeTo";
            this.txtTimeTo.PromptChar = '_';
            this.txtTimeTo.Size = new System.Drawing.Size(34, 23);
            this.txtTimeTo.TabIndex = 12;
            this.txtTimeTo.Text = "  :";
            this.txtTimeTo.TextChanged += new System.EventHandler(this.txtTimeTo_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, -1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(16, 25);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "X";
            this.btnDelete.Values.ExtraText = "";
            this.btnDelete.Values.Image = null;
            this.btnDelete.Values.ImageStates.ImageCheckedNormal = null;
            this.btnDelete.Values.ImageStates.ImageCheckedPressed = null;
            this.btnDelete.Values.ImageStates.ImageCheckedTracking = null;
            this.btnDelete.Values.Text = "X";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.txtTimeUsed);
            this.panMain.Controls.Add(this.lstDetail);
            this.panMain.Controls.Add(this.btnDelete);
            this.panMain.Controls.Add(this.lblTime);
            this.panMain.Controls.Add(this.txtTimeTo);
            this.panMain.Controls.Add(this.lstLevel);
            this.panMain.Controls.Add(this.txtTimeFrom);
            this.panMain.Controls.Add(this.kryptonLabel2);
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(316, 26);
            this.panMain.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassCenter;
            this.panMain.TabIndex = 14;
            // 
            // txtTimeUsed
            // 
            this.txtTimeUsed.AlwaysActive = false;
            this.txtTimeUsed.Location = new System.Drawing.Point(197, 1);
            this.txtTimeUsed.MaxLength = 2;
            this.txtTimeUsed.Name = "txtTimeUsed";
            this.txtTimeUsed.Size = new System.Drawing.Size(24, 23);
            this.txtTimeUsed.TabIndex = 14;
            this.txtTimeUsed.Text = "0";
            this.txtTimeUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeUsed.TextChanged += new System.EventHandler(this.txtTimeUsed_TextChanged);
            // 
            // TimePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panMain);
            this.Name = "TimePlan";
            this.Size = new System.Drawing.Size(317, 27);
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).EndInit();
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox lstLevel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox lstDetail;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTime;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtTimeFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtTimeTo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panMain;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimeUsed;
    }
}
