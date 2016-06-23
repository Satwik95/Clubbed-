using System.Windows.Forms;

namespace Clubbed_
{
    partial class Class
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        int screenWidth;
        int screenHeight;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            this.class_t = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.go_back = new System.Windows.Forms.Button();
            this.Loadclass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // class_t
            // 
            this.class_t.FormattingEnabled = true;
            this.class_t.Location = new System.Drawing.Point(302, 98);
            this.class_t.Name = "class_t";
            this.class_t.Size = new System.Drawing.Size(222, 33);
            this.class_t.TabIndex = 1;
            this.class_t.SelectedIndexChanged += new System.EventHandler(this.class_t_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 211);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Category:";
            // 
            // button1
            // 
            this.button1.Image = global::Clubbed_.Properties.Resources.add_icon__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(261, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 78);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // go_back
            // 
            this.go_back.Image = global::Clubbed_.Properties.Resources.back_icon;
            this.go_back.Location = new System.Drawing.Point(384, 394);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(104, 77);
            this.go_back.TabIndex = 4;
            this.go_back.UseVisualStyleBackColor = true;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            // 
            // Loadclass
            // 
            this.Loadclass.Image = global::Clubbed_.Properties.Resources.load2_download_icon;
            this.Loadclass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loadclass.Location = new System.Drawing.Point(136, 393);
            this.Loadclass.Name = "Loadclass";
            this.Loadclass.Size = new System.Drawing.Size(100, 78);
            this.Loadclass.TabIndex = 3;
            this.Loadclass.Text = "Load";
            this.Loadclass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Loadclass.UseVisualStyleBackColor = true;
            this.Loadclass.Click += new System.EventHandler(this.Loadclass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.class_t);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.go_back);
            this.groupBox1.Controls.Add(this.Loadclass);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(200, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 550);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Overveiw";
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clubbed_.Properties.Resources.wavy_pattern_abstract_hd_wallpaper_2560x1600_4443;
            this.ClientSize = new System.Drawing.Size(1013, 707);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Class";
            this.Text = "Class";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox class_t;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Loadclass;
        private System.Windows.Forms.Button go_back;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
    }
}