namespace Clubbed_
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Load = new System.Windows.Forms.Button();
            this.goingback = new System.Windows.Forms.Button();
            this.addstaff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 235);
            this.dataGridView1.TabIndex = 1;
            // 
            // Load
            // 
            this.Load.Image = global::Clubbed_.Properties.Resources.load2_download_icon;
            this.Load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Load.Location = new System.Drawing.Point(86, 377);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(99, 57);
            this.Load.TabIndex = 2;
            this.Load.Text = "Load";
            this.Load.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // goingback
            // 
            this.goingback.Image = global::Clubbed_.Properties.Resources.back_icon;
            this.goingback.Location = new System.Drawing.Point(427, 377);
            this.goingback.Name = "goingback";
            this.goingback.Size = new System.Drawing.Size(80, 57);
            this.goingback.TabIndex = 3;
            this.goingback.UseVisualStyleBackColor = true;
            this.goingback.Click += new System.EventHandler(this.goingback_Click);
            // 
            // addstaff
            // 
            this.addstaff.Image = global::Clubbed_.Properties.Resources.add_icon__1_;
            this.addstaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addstaff.Location = new System.Drawing.Point(191, 377);
            this.addstaff.Name = "addstaff";
            this.addstaff.Size = new System.Drawing.Size(98, 57);
            this.addstaff.TabIndex = 4;
            this.addstaff.Text = "Add";
            this.addstaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addstaff.UseVisualStyleBackColor = true;
            this.addstaff.Click += new System.EventHandler(this.addstaff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Category:";
            // 
            // button1
            // 
            this.button1.Image = global::Clubbed_.Properties.Resources.blue_cross_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(295, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.addstaff);
            this.groupBox1.Controls.Add(this.Load);
            this.groupBox1.Controls.Add(this.goingback);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 534);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Overview";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clubbed_.Properties.Resources.wavy_pattern_abstract_hd_wallpaper_2560x1600_44431;
            this.ClientSize = new System.Drawing.Size(762, 670);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Staff";
            this.Text = "Staff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button goingback;
        private System.Windows.Forms.Button addstaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}