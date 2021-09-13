namespace WinShut
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hrBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.secBox = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.actionBox = new System.Windows.Forms.ComboBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.ScheduleTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelCount = new System.Windows.Forms.Label();
            this.label_link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hour :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(99, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(170, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sec :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hrBox
            // 
            this.hrBox.Location = new System.Drawing.Point(24, 39);
            this.hrBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hrBox.Name = "hrBox";
            this.hrBox.Size = new System.Drawing.Size(48, 23);
            this.hrBox.TabIndex = 3;
            this.hrBox.Text = "0";
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(99, 39);
            this.minBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(48, 23);
            this.minBox.TabIndex = 4;
            this.minBox.Text = "0";
            // 
            // secBox
            // 
            this.secBox.Location = new System.Drawing.Point(170, 39);
            this.secBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secBox.Name = "secBox";
            this.secBox.Size = new System.Drawing.Size(48, 23);
            this.secBox.TabIndex = 5;
            this.secBox.Text = "0";
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAction.Location = new System.Drawing.Point(24, 75);
            this.btnAction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(173, 31);
            this.btnAction.TabIndex = 6;
            this.btnAction.Text = "Execute";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // actionBox
            // 
            this.actionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionBox.FormattingEnabled = true;
            this.actionBox.Items.AddRange(new object[] {
            "Shutdown",
            "Reboot",
            "Log Off",
            "Hibernate",
            "Force Shutdown"});
            this.actionBox.Location = new System.Drawing.Point(239, 39);
            this.actionBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(156, 23);
            this.actionBox.TabIndex = 8;
            this.actionBox.SelectedIndexChanged += new System.EventHandler(this.actionBox_SelectedIndexChanged);
            // 
            // btnAbort
            // 
            this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbort.Location = new System.Drawing.Point(223, 75);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(173, 31);
            this.btnAbort.TabIndex = 9;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // ScheduleTimer
            // 
            this.ScheduleTimer.Interval = 1000;
            this.ScheduleTimer.Tick += new System.EventHandler(this.ScheduleTimer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(239, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Choose Action";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTag.Location = new System.Drawing.Point(24, 120);
            this.labelTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(91, 16);
            this.labelTag.TabIndex = 11;
            this.labelTag.Text = "Seconds Left :";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(132, 120);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(71, 16);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "Time to go";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(253, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Processes :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelCount.Location = new System.Drawing.Point(346, 120);
            this.LabelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(41, 16);
            this.LabelCount.TabIndex = 16;
            this.LabelCount.Text = "Count";
            this.LabelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_link
            // 
            this.label_link.AutoSize = true;
            this.label_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_link.LinkColor = System.Drawing.Color.Indigo;
            this.label_link.Location = new System.Drawing.Point(279, 147);
            this.label_link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(85, 13);
            this.label_link.TabIndex = 17;
            this.label_link.TabStop = true;
            this.label_link.Text = "Made by Nahian";
            this.label_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_link_LinkClicked);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 174);
            this.Controls.Add(this.label_link);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.actionBox);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.secBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.hrBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "AppForm";
            this.Text = "winshut";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hrBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox secBox;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox actionBox;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Timer ScheduleTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.LinkLabel label_link;
    }
}

