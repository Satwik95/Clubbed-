namespace Clubbed_
{
    partial class EditStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStaff));
            this.sid = new System.Windows.Forms.TextBox();
            this.nam = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sid
            // 
            this.sid.Location = new System.Drawing.Point(224, 75);
            this.sid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(267, 33);
            this.sid.TabIndex = 0;
            this.sid.TextChanged += new System.EventHandler(this.sid_TextChanged);
            // 
            // nam
            // 
            this.nam.Location = new System.Drawing.Point(224, 145);
            this.nam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(267, 33);
            this.nam.TabIndex = 1;
            this.nam.TextChanged += new System.EventHandler(this.nam_TextChanged);
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(224, 302);
            this.salary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(267, 33);
            this.salary.TabIndex = 2;
            this.salary.TextChanged += new System.EventHandler(this.salary_TextChanged);
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(224, 216);
            this.department.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(267, 33);
            this.department.TabIndex = 6;
            this.department.TextChanged += new System.EventHandler(this.department_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "S_ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name:";
            // 
            // button1
            // 
            this.button1.Image = global::Clubbed_.Properties.Resources.back_icon;
            this.button1.Location = new System.Drawing.Point(400, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 87);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Clubbed_.Properties.Resources.add_icon__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(224, 365);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 87);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.sid);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.salary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.department);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(106, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(607, 540);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clubbed_.Properties.Resources.wavy_pattern_abstract_hd_wallpaper_2560x1600_44431;
            this.ClientSize = new System.Drawing.Size(822, 710);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditStaff";
            this.Text = "EditStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditStaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox sid;
        private System.Windows.Forms.TextBox nam;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}