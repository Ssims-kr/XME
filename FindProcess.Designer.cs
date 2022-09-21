namespace XME
{
    partial class FindProcess
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
            this.lBox_ProcessList = new System.Windows.Forms.ListBox();
            this.toggle_Filter = new MetroFramework.Controls.MetroToggle();
            this.btn_Select = new MetroFramework.Controls.MetroButton();
            this.lbl_Filter = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lBox_ProcessList
            // 
            this.lBox_ProcessList.FormattingEnabled = true;
            this.lBox_ProcessList.ItemHeight = 12;
            this.lBox_ProcessList.Location = new System.Drawing.Point(23, 63);
            this.lBox_ProcessList.Name = "lBox_ProcessList";
            this.lBox_ProcessList.Size = new System.Drawing.Size(274, 88);
            this.lBox_ProcessList.TabIndex = 0;
            // 
            // toggle_Filter
            // 
            this.toggle_Filter.Location = new System.Drawing.Point(116, 157);
            this.toggle_Filter.Name = "toggle_Filter";
            this.toggle_Filter.Size = new System.Drawing.Size(100, 29);
            this.toggle_Filter.TabIndex = 1;
            this.toggle_Filter.Text = "Off";
            this.toggle_Filter.UseSelectable = true;
            this.toggle_Filter.CheckedChanged += new System.EventHandler(this.toggle_Filter_CheckedChanged);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(222, 157);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 29);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "선택";
            this.btn_Select.UseSelectable = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.Location = new System.Drawing.Point(23, 157);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(87, 29);
            this.lbl_Filter.TabIndex = 3;
            this.lbl_Filter.Text = "필터";
            this.lbl_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FindProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.lbl_Filter);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.toggle_Filter);
            this.Controls.Add(this.lBox_ProcessList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindProcess";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "프로세스 선택";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FindProcess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBox_ProcessList;
        private MetroFramework.Controls.MetroToggle toggle_Filter;
        private MetroFramework.Controls.MetroButton btn_Select;
        private MetroFramework.Controls.MetroLabel lbl_Filter;
    }
}
