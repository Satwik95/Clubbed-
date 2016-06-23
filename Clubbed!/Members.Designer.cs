namespace Clubbed_
{
    partial class Members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.s_type = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Go_back = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(561, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // s_type
            // 
            this.s_type.AutoSize = true;
            this.s_type.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_type.Location = new System.Drawing.Point(110, 86);
            this.s_type.Name = "s_type";
            this.s_type.Size = new System.Drawing.Size(113, 25);
            this.s_type.TabIndex = 1;
            this.s_type.Text = "Select Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Image = global::Clubbed_.Properties.Resources.blue_cross_icon;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(178, 497);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(131, 81);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Image = global::Clubbed_.Properties.Resources.add_icon__1_;
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.Location = new System.Drawing.Point(330, 497);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(102, 81);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Add";
            this.Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Go_back
            // 
            this.Go_back.Image = global::Clubbed_.Properties.Resources.back_icon;
            this.Go_back.Location = new System.Drawing.Point(605, 497);
            this.Go_back.Name = "Go_back";
            this.Go_back.Size = new System.Drawing.Size(103, 81);
            this.Go_back.TabIndex = 4;
            this.Go_back.UseVisualStyleBackColor = true;
            this.Go_back.Click += new System.EventHandler(this.Go_back_Click);
            // 
            // Load
            // 
            this.Load.Image = global::Clubbed_.Properties.Resources.load2_download_icon;
            this.Load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Load.Location = new System.Drawing.Point(56, 497);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(106, 81);
            this.Load.TabIndex = 3;
            this.Load.Text = "Load";
            this.Load.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.s_type);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Edit);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Go_back);
            this.groupBox1.Controls.Add(this.Load);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 633);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Members Overveiw";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 81);
            this.button1.TabIndex = 7;
            this.button1.Text = "View Member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clubbed_.Properties.Resources.wavy_pattern_abstract_hd_wallpaper_2560x1600_44431;
            this.ClientSize = new System.Drawing.Size(876, 710);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Members";
            this.Text = "Members";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label s_type;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Go_back;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}