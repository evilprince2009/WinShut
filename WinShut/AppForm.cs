using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WinShut
{
    public partial class AppForm : Form
    {
        private string _actionParameter;
        private const string ActionTerm = "shutdown";
        private readonly int _initialValue = 0;

        public AppForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LabelCount.Text = Process_Count();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(hrBox.Text) || String.IsNullOrWhiteSpace(minBox.Text) ||
                    String.IsNullOrWhiteSpace(secBox.Text))
                {
                    InputStatus("invalid input", Color.Red);
                }
                else
                {
                    int hour = Convert.ToInt32(hrBox.Text);
                    int minutes = Convert.ToInt32(minBox.Text);
                    int seconds = Convert.ToInt32(secBox.Text);
                    double totalTime = (hour * 3600) + (minutes * 60) + seconds;
                    if (_actionParameter != null)
                    {
                        Process.Start(ActionTerm,
                            _actionParameter + " -t " + totalTime);
                        ScheduleTimer.Start();
                        labelTime.Text = totalTime.ToString();
                    }
                    else
                    {
                        InputStatus("choose action", Color.Red);
                    }
                }
            }
            catch (Exception)
            {

                InputStatus("invalid input", Color.Red);
            }
        }
        private void btnAbort_Click(object sender, EventArgs e)
        {
            Process.Start(ActionTerm, " -a ");
            MasterReset();
        }

        private void actionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (actionBox.SelectedIndex)
            {
                case 0:
                    _actionParameter = "-s";
                    break;
                case 1:
                    _actionParameter = "-r";
                    break;
                case 2:
                    _actionParameter = "-l";
                    break;
                case 3:
                    _actionParameter = "-h";
                    break;
                case 4:
                    _actionParameter = "-s -f";
                    break;
                default:
                    _actionParameter = null;
                    break;
            }
        }
        private void ScheduleTimer_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelTime.Text) > 0)
            {
                labelTime.Text = (Convert.ToInt32(labelTime.Text) - 1).ToString();
            }
        }

        private void MasterReset()
        {
            ScheduleTimer.Stop();
            labelTime.Text = "Time to go";
            labelTag.Text = "Seconds left :";
            hrBox.Text = _initialValue.ToString();
            minBox.Text = _initialValue.ToString();
            secBox.Text = _initialValue.ToString();
            labelTime.ForeColor = Color.Black;
        }

        private static string Process_Count()
        {
            Process[] processCollection = Process.GetProcesses();
            return processCollection.Length.ToString();
        }

        private void InputStatus(string message, Color color)
        {
            labelTag.Text = "Message :";
            labelTime.Text = message;
            labelTime.ForeColor = color;
        }

        private void label_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link_url = "https://www.linkedin.com/in/evilprince2009";
            Process.Start(link_url);
        }
    }
}