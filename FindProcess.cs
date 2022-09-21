using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XME
{
    public partial class FindProcess : MetroFramework.Forms.MetroForm
    {
        #region 프로퍼티
        public int ProcessId { get; set; }
        #endregion

        #region 생성자
        public FindProcess()
        {
            InitializeComponent();

            ProcessId = -1;
        }
        #endregion

        private void FindProcess_Load(object sender, EventArgs e)
        {
            // 프로세스 취득
            Process[] p = Process.GetProcesses();

            // 추가
            foreach (var item in p)
            {
                string f = string.Format("{0} | {1}", item.ProcessName, item.Id);
                lBox_ProcessList.Items.Add(f);
            }
        }

        private void toggle_Filter_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_Filter.Checked)
            {
                lBox_ProcessList.Items.Clear();

                // 프로세스 취득
                Process[] p = Process.GetProcesses();

                // 추가
                foreach (var item in p)
                {
                    if (item.ProcessName.ToLower().Contains("xops") || item.ProcessName.ToLower().Contains("xoperations"))
                    {
                        string f = string.Format("{0} | {1}", item.ProcessName, item.Id);
                        lBox_ProcessList.Items.Add(f);
                    }
                }
            }
            else
            {
                lBox_ProcessList.Items.Clear();

                // 프로세스 취득
                Process[] p = Process.GetProcesses();

                // 추가
                foreach (var item in p)
                {
                    string f = string.Format("{0} | {1}", item.ProcessName, item.Id);
                    lBox_ProcessList.Items.Add(f);
                }
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            string[] ss = lBox_ProcessList.GetItemText(lBox_ProcessList.SelectedItem).Split('|');

            ProcessId = int.Parse(ss.Last());

            this.Close();
        }
    }
}
