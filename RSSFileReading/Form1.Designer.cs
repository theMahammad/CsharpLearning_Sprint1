namespace RSSFileReading
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_getDataInUrl = new System.Windows.Forms.Button();
            this.txt_RSSUrl = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_headings = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wb_showingContent = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_getDataInUrl);
            this.groupBox1.Controls.Add(this.txt_RSSUrl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1295, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSS URL";
            // 
            // btn_getDataInUrl
            // 
            this.btn_getDataInUrl.Location = new System.Drawing.Point(1137, 20);
            this.btn_getDataInUrl.Name = "btn_getDataInUrl";
            this.btn_getDataInUrl.Size = new System.Drawing.Size(75, 42);
            this.btn_getDataInUrl.TabIndex = 1;
            this.btn_getDataInUrl.Text = "Get";
            this.btn_getDataInUrl.UseVisualStyleBackColor = true;
            this.btn_getDataInUrl.Click += new System.EventHandler(this.btn_getDataInUrl_Click);
            // 
            // txt_RSSUrl
            // 
            this.txt_RSSUrl.Location = new System.Drawing.Point(6, 21);
            this.txt_RSSUrl.Name = "txt_RSSUrl";
            this.txt_RSSUrl.Size = new System.Drawing.Size(1107, 22);
            this.txt_RSSUrl.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_headings);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 553);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Headlines";
            // 
            // lst_headings
            // 
            this.lst_headings.FormattingEnabled = true;
            this.lst_headings.ItemHeight = 16;
            this.lst_headings.Location = new System.Drawing.Point(6, 21);
            this.lst_headings.Name = "lst_headings";
            this.lst_headings.Size = new System.Drawing.Size(223, 532);
            this.lst_headings.TabIndex = 1;
            this.lst_headings.SelectedIndexChanged += new System.EventHandler(this.lst_headings_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wb_showingContent);
            this.groupBox3.Location = new System.Drawing.Point(291, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(955, 543);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // wb_showingContent
            // 
            this.wb_showingContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_showingContent.Location = new System.Drawing.Point(3, 18);
            this.wb_showingContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_showingContent.Name = "wb_showingContent";
            this.wb_showingContent.Size = new System.Drawing.Size(949, 522);
            this.wb_showingContent.TabIndex = 3;
            this.wb_showingContent.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 668);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser wb_showingContent;
        private System.Windows.Forms.ListBox lst_headings;
        private System.Windows.Forms.TextBox txt_RSSUrl;
        private System.Windows.Forms.Button btn_getDataInUrl;
    }
}

