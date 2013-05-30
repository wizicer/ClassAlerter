using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ClassAlerter
{
    public partial class TimePlan : UserControl
    {
        public delegate void DeleteDelegate(object sender);
        public event DeleteDelegate OnDeleting;
        public delegate void EfficiencyDelegate(object sender);
        public event EfficiencyDelegate OnEfficiencyChanged;

        private DateTime _timeClassStart;
        private bool isClassStart = false;

        private int _timeLast;
        private int _timeUsed = 0;

        public int TimeUsed
        {
            get { return _timeUsed; }
            set
            {
                _timeUsed = value;
                txtTimeUsed.Text = value.ToString();
            }
        }

        public int TimeLast
        {
            get { return _timeLast; }
            set { _timeLast = value; }
        }

        public TimePlan()
        {
            InitializeComponent();
        }

        public TimePlan(string tf, string tt, string dt, string ll,int tu)
        {
            InitializeComponent();
            txtTimeFrom.Text = tf;
            txtTimeTo.Text = tt;
            lstDetail.SelectedIndex = lstDetail.Items.IndexOf(dt);
            lstLevel.SelectedIndex = lstLevel.Items.IndexOf(ll);
            TimeUsed = tu;
        }

        public string TimeFrom
        {
            get
            {
                return txtTimeFrom.Text;
            }
            set
            {
                txtTimeFrom.Text = value;
            }
        }

        public string TimeTo
        {
            get
            {
                return txtTimeTo.Text;
            }
            set
            {
                txtTimeTo.Text = value;
            }
        }

        public string Detail
        {
            get
            {
                return lstDetail.Text;
            }
            set
            {
                lstDetail.SelectedIndex = lstDetail.Items.IndexOf(value);
            }
        }

        public string Level
        {
            get
            {
                return lstLevel.Text;
            }
            set
            {
                lstLevel.SelectedIndex = lstLevel.Items.IndexOf(value);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.OnDeleting(this);
        }

        private void txtTimeTo_TextChanged(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void ShowTime()
        {
            try
            {
                DateTime dtto = DateTime.Parse(txtTimeTo.Text);
                DateTime dtfrom = DateTime.Parse(txtTimeFrom.Text);
                if (dtto.Hour < 4) dtto = dtto.AddDays(1);
                if (dtfrom.Hour < 4) dtfrom = dtfrom.AddDays(1);
                _timeLast = Convert.ToInt32((dtto - dtfrom).TotalMinutes);

                //if (_timeUsed > 0)
                //{
                //    lblTime.Text = string.Format("{1}/{0}分", _timeLast, _timeUsed);
                //}
                //else
                //{
                //    lblTime.Text = string.Format("时长：{0}分", _timeLast);
                //}
                lblTime.Text = string.Format("时长：{0}分", _timeLast);
            }
            catch
            {
                lblTime.Text = "非法时间";
            }
        }

        private void lstLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnEfficiencyChanged != null)
            {
                this.OnEfficiencyChanged(this);
            }
        }

        public void RefreshPlan()
        {
            try
            {
                DateTime dtto = DateTime.Parse(TimeTo);
                DateTime dtfrom = DateTime.Parse(TimeFrom).AddMinutes(-2);
                DateTime dtnow = DateTime.Parse(DateTime.Now.ToString("HH:mm"));
                if (dtto.Hour < 4) dtto = dtto.AddDays(1);
                if (dtfrom.Hour < 4) dtfrom = dtfrom.AddDays(1);
                if (dtnow.Hour < 4) dtnow = dtnow.AddDays(1);
                if ((dtnow - dtfrom).TotalMilliseconds >= 0 && (dtnow - dtto).TotalMilliseconds < 0)
                {
                    panMain.StateCommon.Color2 = Color.DodgerBlue;
                    isClassStart = true;
                }
                else
                {
                    panMain.StateCommon.Color2 = Color.Empty;
                    if (isClassStart)
                    {
                        isClassStart = false;
                        TimeUsed = Convert.ToInt32((DateTime.Now - _timeClassStart).TotalMinutes);
                        TimeUsed = TimeUsed > 600 ? 0 : TimeUsed;
                        _timeClassStart = DateTime.Now.AddYears(100);
                    }
                }
                ShowTime();
            }
            catch
            {
            }
        }

        public void AcceptClassStart()
        {
            if (isClassStart)
            {
                _timeClassStart = DateTime.Now;
            }
        }

        private void txtTimeUsed_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(txtTimeUsed.Text);
            }
            catch
            {
            }
            _timeUsed = i;
        }
    }
}
