namespace SystemIO.Practice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstStaff = new System.Windows.Forms.ListBox();
            this.btnCallStaff = new System.Windows.Forms.Button();
            this.btnSaveStaff = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstStaff);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lstStaff
            // 
            this.lstStaff.FormattingEnabled = true;
            this.lstStaff.ItemHeight = 20;
            this.lstStaff.Location = new System.Drawing.Point(12, 12);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(298, 444);
            this.lstStaff.TabIndex = 2;
            this.lstStaff.SelectedIndexChanged += new System.EventHandler(this.lstStaff_SelectedIndexChanged);
            this.lstStaff.DoubleClick += new System.EventHandler(this.lstStaff_DoubleClick);
            // 
            // btnCallStaff
            // 
            this.btnCallStaff.Location = new System.Drawing.Point(383, 63);
            this.btnCallStaff.Name = "btnCallStaff";
            this.btnCallStaff.Size = new System.Drawing.Size(124, 57);
            this.btnCallStaff.TabIndex = 0;
            this.btnCallStaff.Text = "Call staff";
            this.btnCallStaff.UseVisualStyleBackColor = true;
            this.btnCallStaff.Click += new System.EventHandler(this.btnCallStaff_Click);
            // 
            // btnSaveStaff
            // 
            this.btnSaveStaff.Location = new System.Drawing.Point(383, 259);
            this.btnSaveStaff.Name = "btnSaveStaff";
            this.btnSaveStaff.Size = new System.Drawing.Size(124, 56);
            this.btnSaveStaff.TabIndex = 1;
            this.btnSaveStaff.Text = "Save staff";
            this.btnSaveStaff.UseVisualStyleBackColor = true;
            this.btnSaveStaff.Click += new System.EventHandler(this.btnSaveStaff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnCallStaff);
            this.Controls.Add(this.btnSaveStaff);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCallStaff;
        private Button btnSaveStaff;
        private ListBox lstStaff;
    }
}