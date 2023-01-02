namespace ReflectionProject
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
            this.txt_className = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GetClass = new System.Windows.Forms.Button();
            this.lb_classes = new System.Windows.Forms.ListBox();
            this.gb_classes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_methods = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_properties = new System.Windows.Forms.ListBox();
            this.pnl_classDetails = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_constructors = new System.Windows.Forms.ListBox();
            this.gb_classes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnl_classDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_className
            // 
            this.txt_className.Location = new System.Drawing.Point(155, 18);
            this.txt_className.Name = "txt_className";
            this.txt_className.Size = new System.Drawing.Size(510, 22);
            this.txt_className.TabIndex = 1;
            this.txt_className.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Call class by name";
            // 
            // btn_GetClass
            // 
            this.btn_GetClass.Location = new System.Drawing.Point(671, 18);
            this.btn_GetClass.Name = "btn_GetClass";
            this.btn_GetClass.Size = new System.Drawing.Size(75, 23);
            this.btn_GetClass.TabIndex = 5;
            this.btn_GetClass.Text = "Get";
            this.btn_GetClass.UseVisualStyleBackColor = true;
            this.btn_GetClass.Click += new System.EventHandler(this.btn_GetClass_Click);
            // 
            // lb_classes
            // 
            this.lb_classes.FormattingEnabled = true;
            this.lb_classes.ItemHeight = 16;
            this.lb_classes.Location = new System.Drawing.Point(19, 17);
            this.lb_classes.Name = "lb_classes";
            this.lb_classes.Size = new System.Drawing.Size(239, 356);
            this.lb_classes.TabIndex = 6;
            this.lb_classes.SelectedIndexChanged += new System.EventHandler(this.lb_classes_SelectedIndexChanged);
            // 
            // gb_classes
            // 
            this.gb_classes.Controls.Add(this.lb_classes);
            this.gb_classes.Location = new System.Drawing.Point(12, 65);
            this.gb_classes.Name = "gb_classes";
            this.gb_classes.Size = new System.Drawing.Size(276, 381);
            this.gb_classes.TabIndex = 7;
            this.gb_classes.TabStop = false;
            this.gb_classes.Text = "Classes of Current Project";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_methods);
            this.groupBox1.Location = new System.Drawing.Point(19, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(991, 138);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Methods";
            // 
            // lb_methods
            // 
            this.lb_methods.FormattingEnabled = true;
            this.lb_methods.ItemHeight = 16;
            this.lb_methods.Location = new System.Drawing.Point(6, 21);
            this.lb_methods.Name = "lb_methods";
            this.lb_methods.Size = new System.Drawing.Size(831, 100);
            this.lb_methods.TabIndex = 6;
            this.lb_methods.SelectedIndexChanged += new System.EventHandler(this.lb_methods_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_properties);
            this.groupBox2.Location = new System.Drawing.Point(19, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(991, 138);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // lb_properties
            // 
            this.lb_properties.FormattingEnabled = true;
            this.lb_properties.ItemHeight = 16;
            this.lb_properties.Location = new System.Drawing.Point(19, 17);
            this.lb_properties.Name = "lb_properties";
            this.lb_properties.Size = new System.Drawing.Size(818, 100);
            this.lb_properties.TabIndex = 6;
            this.lb_properties.SelectedIndexChanged += new System.EventHandler(this.lb_properties_SelectedIndexChanged);
            // 
            // pnl_classDetails
            // 
            this.pnl_classDetails.Controls.Add(this.groupBox3);
            this.pnl_classDetails.Controls.Add(this.groupBox2);
            this.pnl_classDetails.Controls.Add(this.groupBox1);
            this.pnl_classDetails.Location = new System.Drawing.Point(294, 65);
            this.pnl_classDetails.Name = "pnl_classDetails";
            this.pnl_classDetails.Size = new System.Drawing.Size(1028, 498);
            this.pnl_classDetails.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_constructors);
            this.groupBox3.Location = new System.Drawing.Point(19, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(991, 123);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Constructors";
            // 
            // lb_constructors
            // 
            this.lb_constructors.FormattingEnabled = true;
            this.lb_constructors.ItemHeight = 16;
            this.lb_constructors.Location = new System.Drawing.Point(19, 17);
            this.lb_constructors.Name = "lb_constructors";
            this.lb_constructors.Size = new System.Drawing.Size(818, 100);
            this.lb_constructors.TabIndex = 6;
            this.lb_constructors.SelectedIndexChanged += new System.EventHandler(this.lb_constructors_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 720);
            this.Controls.Add(this.pnl_classDetails);
            this.Controls.Add(this.gb_classes);
            this.Controls.Add(this.btn_GetClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_className);
            this.Name = "Form1";
            this.Text = "ReflectionApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_classes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnl_classDetails.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_className;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GetClass;
        private System.Windows.Forms.ListBox lb_classes;
        private System.Windows.Forms.GroupBox gb_classes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_methods;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lb_properties;
        private System.Windows.Forms.Panel pnl_classDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lb_constructors;
    }
}

