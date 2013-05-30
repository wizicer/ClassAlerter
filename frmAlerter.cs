using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Collections;
using System.Media;
using System.Drawing.Imaging;
using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;
using ClassAlerter.Properties;

namespace ClassAlerter
{
    public partial class frmAlerter : KryptonForm
    {
        #region 变量
        struct TimePlanItem
        {
            //int _timeUsed;

            //public int TimeUsed
            //{
            //    get { return _timeUsed; }
            //    set { _timeUsed = value; }
            //}

            string _timeFrom;

            public string TimeFrom
            {
                get { return _timeFrom; }
                set { _timeFrom = value; }
            }
            string _timeTo;

            public string TimeTo
            {
                get { return _timeTo; }
                set { _timeTo = value; }
            }
            string _detail;

            public string Detail
            {
                get { return _detail; }
                set { _detail = value; }
            }

            public TimePlanItem(string tf, string tt, string dt)
            {
                _timeFrom = tf;
                _timeTo = tt;
                _detail = dt;
            }
        }

        DateTime LastAlert;
        ArrayList TimePlanTable = new ArrayList();
        string SettingFileName = "Setting.xml";
        bool isExiting = false;
        Bitmap bmpProcessIcon = Resources.Process;
        int _lengthOfProcess = 8;
        //Bitmap bmpProcessIcon = new Bitmap("Process.ico");
        //Icon icoOriginProcessIcon = new Icon("Process.ico");

        Icon[] icoRestIcon = {Resources.Rest0,Resources.Rest1,Resources.Rest2,Resources.Rest3,
                                 Resources.Rest4,Resources.Rest5,Resources.Rest6,Resources.Rest7,
                                 Resources.Rest8,Resources.Rest9,Resources.Rest10};
        //Icon[] icoRestIcon = {new Icon("Rest0.ico"),new Icon("Rest1.ico"),new Icon("Rest2.ico"),new Icon("Rest3.ico"),
        //                         new Icon("Rest4.ico"),new Icon("Rest5.ico"),new Icon("Rest6.ico"),new Icon("Rest7.ico"),
        //                         new Icon("Rest8.ico"),new Icon("Rest9.ico"),new Icon("Rest10.ico")};
        int RestIconFrame = 0;

        Icon[] icoProcessIcon = new Icon[10];
        Icon icoProcessWait = Icon.FromHandle(Resources.ProcessWait.GetHicon());

        FloatingOSDWindow _osd = new FloatingOSDWindow();
        Point _mousePoint;

        Color _textColor = Color.Blue;

        //DateTime _timeClassStart;
        bool isClassStart = false;

        #endregion

        public frmAlerter()
        {
            InitializeComponent();
        }

        private void frmAlerter_Load(object sender, EventArgs e)
        {
            InitStateIcon();
            LoadPlan();
            SavePlan();
            LastAlert = DateTime.Now.AddSeconds(-60);
            lblCountDown.Text = string.Format("离考试还有{0}天", Convert.ToInt32((DateTime.Parse("2009-1-10") - DateTime.Now).TotalDays));
            DrawProgressLine();
            foreach (Control ctrl in panFlow.Controls)
            {
                if (Type.GetType(ctrl.ToString()) == typeof(TimePlan))
                {
                    ((TimePlan)ctrl).RefreshPlan();
                }
            }
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimePlan tp = new TimePlan("09:00", "09:00", "自由", "", 0);
            tp.OnDeleting += new TimePlan.DeleteDelegate(TimePlan_OnDeleting);
            tp.OnEfficiencyChanged += new TimePlan.EfficiencyDelegate(TimePlan_OnEfficiencyChanged);
            panFlow.Controls.Add(tp);
        }

        void TimePlan_OnDeleting(object sender)
        {
            panFlow.Controls.Remove((Control)sender);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePlan();
        }

        private void timAlerter_Tick(object sender, EventArgs e)
        {
            //bool p = false;
            for (int i = 0; i < TimePlanTable.Count; i++)
            {
                if ((DateTime.Now - LastAlert).TotalSeconds >= 60)
                {
                    if (mnuStopScreenSaverWhenStudy.Checked)
                    {
                        if (((TimePlanItem)TimePlanTable[i]).TimeFrom == DateTime.Now.ToString("HH:mm"))
                        {
                            ScreenSaver.SetScreenSaverActive(0);
                            mnuStopScreenSaver.Checked = true;
                        }
                        else if (((TimePlanItem)TimePlanTable[i]).TimeTo == DateTime.Now.ToString("HH:mm"))
                        {
                            ScreenSaver.SetScreenSaverActive(1);
                            mnuStopScreenSaver.Checked = false;
                        }
                    }
                }
                if (((TimePlanItem)TimePlanTable[i]).TimeFrom == DateTime.Now.ToString("HH:mm") ||
                   ((TimePlanItem)TimePlanTable[i]).TimeTo == DateTime.Now.ToString("HH:mm") ||
                   (mnuPrepBell.Checked && i < TimePlanTable.Count - 1 &&
                   ((TimePlanItem)TimePlanTable[i + 1]).TimeFrom == DateTime.Now.AddMinutes(2).ToString("HH:mm")))
                {
                    if (Alert())
                    {
                        lblCountDown.Text = string.Format("离考试还有{0}天", Convert.ToInt32((DateTime.Parse("2009-1-10") - DateTime.Now).TotalDays));

                        foreach (Control ctrl in panFlow.Controls)
                        {
                            if (Type.GetType(ctrl.ToString()) == typeof(TimePlan))
                            {
                                ((TimePlan)ctrl).RefreshPlan();
                            }
                        }
                        if ((!mnuPrepBell.Checked && ((TimePlanItem)TimePlanTable[i]).TimeFrom == DateTime.Now.ToString("HH:mm")) ||
                           (mnuPrepBell.Checked && i < TimePlanTable.Count - 1 &&
                           ((TimePlanItem)TimePlanTable[i + 1]).TimeFrom == DateTime.Now.AddMinutes(2).ToString("HH:mm")))
                        {
                            isClassStart = true;
                        }
                        else if (((TimePlanItem)TimePlanTable[i]).TimeTo == DateTime.Now.ToString("HH:mm"))
                        {
                            isClassStart = false;
                        }
                    }
                }
                DateTime dtto = DateTime.Parse(((TimePlanItem)TimePlanTable[i]).TimeTo);
                DateTime dtfrom = DateTime.Parse(((TimePlanItem)TimePlanTable[i]).TimeFrom);
                DateTime dtnow = DateTime.Parse(DateTime.Now.ToString("HH:mm"));
                DateTime dtnext = DateTime.Now;
                if (i < TimePlanTable.Count - 1) dtnext = DateTime.Parse(((TimePlanItem)TimePlanTable[i + 1]).TimeFrom);
                if (dtto.Hour < 4) dtto = dtto.AddDays(1);
                if (dtfrom.Hour < 4) dtfrom = dtfrom.AddDays(1);
                if (dtnow.Hour < 4) dtnow = dtnow.AddDays(1);
                if (dtnext.Hour < 4) dtnext = dtnext.AddDays(1);
                if ((dtnow - dtfrom).TotalMilliseconds >= 0 && (dtnow - dtto).TotalMilliseconds < 0)
                {
                    ntfTray.Icon = DrawState((dtnow - dtfrom).TotalMilliseconds, (dtto - dtfrom).TotalMilliseconds);
                    ntfTray.Text = string.Format("离[{1}]课下课还有{0}分钟！", (dtto - dtnow).TotalMinutes, ((TimePlanItem)TimePlanTable[i]).Detail);
                    if (mnuShowCurrentState.Checked)
                    {
                        _osd.Show(new Point(Screen.PrimaryScreen.Bounds.Width - 350, 30), 100,
                            _textColor, new Font("仿宋", 22f, FontStyle.Bold), 0, FloatingWindow.AnimateMode.ExpandCollapse, 0,
                            string.Format("{1}课  剩余{0}分钟！", (dtto - dtnow).TotalMinutes, ((TimePlanItem)TimePlanTable[i]).Detail));
                    }
                    break;
                }
                else if ((dtnow - dtto).TotalMilliseconds >= 0 && i < TimePlanTable.Count - 1 && (dtnext - dtnow).TotalMilliseconds > 0)
                {

                    ntfTray.Icon = icoRestIcon[RestIconFrame++ % 11];
                    ntfTray.Text = string.Format("休息时间，离上课还有{0}分钟！", (dtnext - dtnow).TotalMinutes);
                    if (mnuShowCurrentState.Checked)
                    {
                        if ((dtnext - dtnow).TotalMinutes <= 10)
                        {
                            _osd.Show(new Point(Screen.PrimaryScreen.Bounds.Width - 350, 30), 100,
                                _textColor, new Font("仿宋", 22f, FontStyle.Bold), 0, FloatingWindow.AnimateMode.ExpandCollapse, 0,
                                string.Format("离{1}课还有{0}分钟！", (dtnext - dtnow).TotalMinutes, ((TimePlanItem)TimePlanTable[i + 1]).Detail));
                        }
                        else
                        {
                            _osd.Hide();
                        }
                    }
                    break;
                }
                else if (i == TimePlanTable.Count - 1)
                {
                    ntfTray.Icon = icoRestIcon[RestIconFrame++ % 11];
                    if (dtnow.Hour < 4)
                    {
                        ntfTray.Text = "今日行程结束！";
                    }
                    else
                    {
                        ntfTray.Text = "今日行程即将开始！";
                    }
                    _osd.Hide();
                }
            }
            //if (!p)
            //{
            //        //ntfTray.Icon = DrawState((dtnow - dtfrom).TotalMilliseconds, (dtto - dtfrom).TotalMilliseconds);
            //}
        }

        private void ntfTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void frmAlerter_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!isExiting)
            //{
            //    this.Hide();
            //    e.Cancel = true;
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            isExiting = true;
            Application.Exit();
        }

        private void frmAlerter_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClearLevel_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panFlow.Controls)
            {
                if (Type.GetType(ctrl.ToString()) == typeof(TimePlan))
                {
                    ((TimePlan)ctrl).Level = "";
                    ((TimePlan)ctrl).TimeUsed = 0;
                }
            }

        }

        private void btnStatToday_Click(object sender, EventArgs e)
        {
            List<string> statname = new List<string>();
            statname.Add("高效");
            statname.Add("中等");
            statname.Add("低效");
            statname.Add("离开");
            statname.Add("");
            statname.Add("有效时间");
            statname.Add("浪费时间");
            string[] name = statname.ToArray();
            int[] stat = new int[statname.Count];
            string strout = "";
            string timeout = "";
            foreach (Control ctrl in panFlow.Controls)
            {
                if (Type.GetType(ctrl.ToString()) == typeof(TimePlan))
                {
                    stat[FindIndex(name, ((TimePlan)ctrl).Level)] += ((TimePlan)ctrl).TimeLast;
                    strout += ((TimePlan)ctrl).Level + "\t";
                    timeout += ((TimePlan)ctrl).TimeUsed.ToString() + "\t";
                    stat[5] += FindIndex(name, ((TimePlan)ctrl).Level) == 0 ? ((TimePlan)ctrl).TimeLast :
                        FindIndex(name, ((TimePlan)ctrl).Level) == 1 ? ((TimePlan)ctrl).TimeLast / 2 :
                        FindIndex(name, ((TimePlan)ctrl).Level) == 2 ? ((TimePlan)ctrl).TimeLast / 4 : 0;
                    stat[6] += FindIndex(name, ((TimePlan)ctrl).Level) == 3 ? ((TimePlan)ctrl).TimeLast :
                        FindIndex(name, ((TimePlan)ctrl).Level) == 2 ? ((TimePlan)ctrl).TimeLast * 3 / 4 :
                        FindIndex(name, ((TimePlan)ctrl).Level) == 1 ? ((TimePlan)ctrl).TimeLast / 2 : 0;
                }
            }
            string result = "";
            DrawProgressLine(stat[5], stat[6], stat[4]);

            for (int i = 0; i < name.Length; i++)
            {
                result += string.Format("{0}:\t{1}时{2}分\r\n", name[i] == "" ? "未定义" : name[i], Convert.ToInt32(stat[i] / 60), stat[i] % 60);
            }
            if (MessageBox.Show("情况如下：\r\n" + result + "\r\n是否要将信息放进剪贴板？", "情况统计", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Clipboard.SetText(result.Replace(":", ""));
                Clipboard.SetText(strout + "\r\n" + timeout);
            }
        }

        private void DrawProgressLine()
        {
            List<string> statname = new List<string>();
            statname.Add("高效");
            statname.Add("中等");
            statname.Add("低效");
            statname.Add("离开");
            statname.Add("");
            statname.Add("有效时间");
            statname.Add("浪费时间");
            string[] name = statname.ToArray();
            int[] stat = new int[statname.Count];
            foreach (Control ctrl in panFlow.Controls)
            {
                if (Type.GetType(ctrl.ToString()) == typeof(TimePlan))
                {
                    stat[FindIndex(name, ((TimePlan)ctrl).Level)] += ((TimePlan)ctrl).TimeLast;
                    stat[5] += FindIndex(name, ((TimePlan)ctrl).Level) == 0 ? ((TimePlan)ctrl).TimeLast :
                        FindIndex(name, ((TimePlan)ctrl).Level) == 1 ? ((TimePlan)ctrl).TimeLast / 2 :
                        FindIndex(name, ((TimePlan)ctrl).Level) == 2 ? ((TimePlan)ctrl).TimeLast / 4 : 0;
                    stat[6] += FindIndex(name, ((TimePlan)ctrl).Level) == 3 ? ((TimePlan)ctrl).TimeLast :
                        FindIndex(name, ((TimePlan)ctrl).Level) == 2 ? ((TimePlan)ctrl).TimeLast * 3 / 4 :
                        FindIndex(name, ((TimePlan)ctrl).Level) == 1 ? ((TimePlan)ctrl).TimeLast / 2 : 0;
                }
            }
            DrawProgressLine(stat[5], stat[6], stat[4]);
        }

        private void DrawProgressLine(int studyTime, int wasteTime, int unuseTime)
        {
            int tt = studyTime + wasteTime + unuseTime;
            picLineStudy.Width = studyTime * picLineBack.Width / tt;
            picLineWaste.Width = wasteTime * picLineBack.Width / tt;
            picLineWaste.Left = picLineBack.Left + picLineBack.Width - picLineWaste.Width;
            picLineEight.Left = 8 * 60 * picLineBack.Width / tt;
        }

        private void lnkDesigner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.wizicer.com");
        }

        private void mnuStopScreenSaver_Click(object sender, EventArgs e)
        {
            if (mnuStopScreenSaver.Checked)
            {
                ScreenSaver.SetScreenSaverActive(0);
            }
            else
            {
                ScreenSaver.SetScreenSaverActive(1);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }

        private void mnuShow_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void mnuShowCurrentState_Click(object sender, EventArgs e)
        {
            _osd.Hide();
        }

        #region 相关方法
        private Icon DrawState(double val, double max)
        {
            ////Bitmap bmp = new Bitmap(bmpProcessIcon);
            //Bitmap bmp = (Bitmap)bmpProcessIcon.Clone();
            //Graphics g = Graphics.FromImage(bmp);
            //int partnum = 10;
            //g.DrawLine(new Pen(new SolidBrush(Color.Purple)), 3, 7, 2 + Convert.ToInt32(val * 10 / max), 7);
            //g.DrawLine(new Pen(new SolidBrush(Color.Blue)), 3, 11, 2 + Convert.ToInt32((val % (max / partnum)) * 10 / (max / partnum)), 11);
            //g.Flush();
            //g.Dispose();
            //Icon tempico;
            //try
            //{
            //    tempico = Icon.FromHandle(bmp.GetHicon());
            //}
            //catch
            //{
            //    //bmpProcessIcon = new Bitmap("Process.ico");
            //    tempico = icoProcessIcon;
            //}
            //bmp.Dispose();
            //return tempico;
            if (isClassStart)
            {
                return icoProcessWait;
            }
            else
            {
                return icoProcessIcon[Convert.ToInt32(val * (_lengthOfProcess - 1) / max)];
            }
        }

        private void InitStateIcon()
        {
            for (int i = 0; i < _lengthOfProcess; ++i)
            {
                Bitmap bmp = new Bitmap(bmpProcessIcon);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawLine(new Pen(new SolidBrush(Color.White)), 4, 12, 4 + i, 12);
                g.Flush();
                g.Dispose();
                icoProcessIcon[i] = Icon.FromHandle(bmp.GetHicon());
            }
        }

        private void CalcStat()
        {
            //List<int> stat = new List<int>();
            List<string> statname = new List<string>();
            statname.Add("数学");
            statname.Add("专业");
            statname.Add("英语");
            statname.Add("政治");
            statname.Add("自由");
            string[] name = statname.ToArray();
            int[] stat = new int[statname.Count];
            foreach (Control ctrl in panFlow.Controls)
            {
                if (Type.GetType(ctrl.ToString()) == typeof(TimePlan))
                {
                    stat[FindIndex(name, ((TimePlan)ctrl).Detail)] += ((TimePlan)ctrl).TimeLast;
                }
            }
            lstTimeLast.Items.Clear();
            for (int i = 0; i < name.Length; i++)
            {
                lstTimeLast.Items.Add(string.Format("{0}:{1}时{2}分", name[i], Convert.ToInt32(stat[i] / 60), stat[i] % 60));
            }
        }

        private int FindIndex(string[] name, string p)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == p) return i;
            }
            return -1;
        }

        private bool Alert()
        {
            if ((DateTime.Now - LastAlert).TotalSeconds < 60) return false;
            SoundPlayer sp = new SoundPlayer("class.wav");
            sp.PlaySync();
            LastAlert = DateTime.Now;
            return true;
        }
        #endregion

        #region 读取存储计划表
        private void SavePlan()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement xe = xmlDoc.CreateElement("TimePlanTable");
            XmlElement xesub;
            XmlAttribute xa;
            TimePlanTable.Clear();
            foreach (Control ctrl in panFlow.Controls)
            {
                if (Type.GetType(ctrl.ToString()) == typeof(TimePlan))
                {
                    TimePlanTable.Add(new TimePlanItem(((TimePlan)ctrl).TimeFrom, ((TimePlan)ctrl).TimeTo, ((TimePlan)ctrl).Detail));
                    xesub = xmlDoc.CreateElement("TimePlan");
                    xesub.InnerText = ((TimePlan)ctrl).Detail;
                    xa = xmlDoc.CreateAttribute("TimeFrom");
                    xa.Value = ((TimePlan)ctrl).TimeFrom;
                    xesub.Attributes.Append(xa);
                    xa = xmlDoc.CreateAttribute("TimeTo");
                    xa.Value = ((TimePlan)ctrl).TimeTo;
                    xesub.Attributes.Append(xa);
                    xa = xmlDoc.CreateAttribute("Level");
                    xa.Value = ((TimePlan)ctrl).Level;
                    xesub.Attributes.Append(xa);
                    xa = xmlDoc.CreateAttribute("TimeUsed");
                    xa.Value = ((TimePlan)ctrl).TimeUsed.ToString();
                    xesub.Attributes.Append(xa);
                    xe.AppendChild(xesub);
                }
            }
            xmlDoc.AppendChild(xe);
            if (File.Exists(SettingFileName)) File.Delete(SettingFileName);
            xmlDoc.Save(SettingFileName);
            CalcStat();
        }

        private void LoadPlan()
        {
            if (!File.Exists(SettingFileName))
            {
                SavePlan();
            }
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(SettingFileName);
            XmlNode xn;
            xn = xmlDoc.SelectSingleNode("/TimePlanTable");
            foreach (XmlNode node in xn.ChildNodes)
            {
                int tu = 0;
                try
                {
                    tu = Convert.ToInt32(node.Attributes["TimeUsed"].Value);
                }
                catch
                {
                }
                TimePlan tp = new TimePlan(node.Attributes["TimeFrom"].Value, node.Attributes["TimeTo"].Value,
                    node.InnerText, node.Attributes["Level"].Value, tu);
                tp.OnDeleting += new TimePlan.DeleteDelegate(TimePlan_OnDeleting);
                tp.OnEfficiencyChanged += new TimePlan.EfficiencyDelegate(TimePlan_OnEfficiencyChanged);
                panFlow.Controls.Add(tp);
            }
        }
        #endregion

        private void hdgForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this._mousePoint.X = e.X;
                this._mousePoint.Y = e.Y;
            }
        }

        private void hdgForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Top = Control.MousePosition.Y - _mousePoint.Y;
                this.Left = Control.MousePosition.X - _mousePoint.X;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDesigner_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.wizicer.com");
        }

        void TimePlan_OnEfficiencyChanged(object sender)
        {
            DrawProgressLine();
        }

        private void mnuVisitFreeKaoyan_Click(object sender, EventArgs e)
        {
            Process.Start("http://bbs.freekaoyan.com/forum-336-1.html");
        }

        private void btnVisitFreeKaoyan_Click(object sender, EventArgs e)
        {
            Process.Start("http://bbs.freekaoyan.com/forum-336-1.html");
        }

        private void btnColorPicker_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            _textColor = btnColorPicker.SelectedColor;
            _osd.Show(_osd.Location, _osd.Alpha, _textColor, _osd.TextFont, 0, _osd.Mode, _osd.Time, _osd.Text);
        }

        private void ntfTray_MouseClick(object sender, MouseEventArgs e)
        {
            if (isClassStart)
            {
                isClassStart = false;
                foreach (Control ctrl in panFlow.Controls)
                {
                    if (Type.GetType(ctrl.ToString()) == typeof(TimePlan))
                    {
                        ((TimePlan)ctrl).AcceptClassStart();
                    }
                }
            }
        }

    }
}
