namespace Clubbed_
{
    partial class EditMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMembers));
            this.M_ID = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.ph_no = new System.Windows.Forms.Label();
            this.mem_type = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.mid = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.expiry = new System.Windows.Forms.TextBox();
            this.mob = new System.Windows.Forms.TextBox();
            this.addr = new System.Windows.Forms.TextBox();
            this.memty = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // M_ID
            // 
            this.M_ID.AutoSize = true;
            this.M_ID.Location = new System.Drawing.Point(98, 85);
            this.M_ID.Name = "M_ID";
            this.M_ID.Size = new System.Drawing.Size(65, 27);
            this.M_ID.TabIndex = 0;
            this.M_ID.Text = "M_ID";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(98, 132);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(64, 27);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(98, 185);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(86, 27);
            this.ad.TabIndex = 2;
            this.ad.Text = "Address";
            // 
            // ph_no
            // 
            this.ph_no.AutoSize = true;
            this.ph_no.Location = new System.Drawing.Point(98, 240);
            this.ph_no.Name = "ph_no";
            this.ph_no.Size = new System.Drawing.Size(112, 27);
            this.ph_no.TabIndex = 3;
            this.ph_no.Text = "Mobile No.";
            // 
            // mem_type
            // 
            this.mem_type.AutoSize = true;
            this.mem_type.Location = new System.Drawing.Point(98, 289);
            this.mem_type.Name = "mem_type";
            this.mem_type.Size = new System.Drawing.Size(174, 27);
            this.mem_type.TabIndex = 4;
            this.mem_type.Text = "Membership Type";
            // 
            // exp
            // 
            this.exp.AutoSize = true;
            this.exp.Location = new System.Drawing.Point(98, 338);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(70, 27);
            this.exp.TabIndex = 5;
            this.exp.Text = "Expiry";
            // 
            // add
            // 
            this.add.Image = global::Clubbed_.Properties.Resources.add_icon__1_;
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(279, 368);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 71);
            this.add.TabIndex = 8;
            this.add.Text = "Add";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // menu
            // 
            this.menu.Image = global::Clubbed_.Properties.Resources.back_icon;
            this.menu.Location = new System.Drawing.Point(429, 368);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(103, 71);
            this.menu.TabIndex = 9;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // mid
            // 
            this.mid.Location = new System.Drawing.Point(279, 82);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(258, 33);
            this.mid.TabIndex = 10;
            this.mid.TextChanged += new System.EventHandler(this.mid_TextChanged);
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(279, 129);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(258, 33);
            this.n.TabIndex = 11;
            this.n.TextChanged += new System.EventHandler(this.n_TextChanged);
            // 
            // expiry
            // 
            this.expiry.Location = new System.Drawing.Point(279, 329);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(258, 33);
            this.expiry.TabIndex = 13;
            this.expiry.TextChanged += new System.EventHandler(this.expiry_TextChanged);
            // 
            // mob
            // 
            this.mob.Location = new System.Drawing.Point(279, 232);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(258, 33);
            this.mob.TabIndex = 14;
            this.mob.TextChanged += new System.EventHandler(this.mob_TextChanged);
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(279, 177);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(258, 33);
            this.addr.TabIndex = 15;
            this.addr.TextChanged += new System.EventHandler(this.addr_TextChanged);
            // 
            // memty
            // 
            this.memty.Location = new System.Drawing.Point(279, 283);
            this.memty.Name = "memty";
            this.memty.Size = new System.Drawing.Size(258, 33);
            this.memty.TabIndex = 16;
            this.memty.TextChanged += new System.EventHandler(this.memty_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.memty);
            this.groupBox1.Controls.Add(this.M_ID);
            this.groupBox1.Controls.Add(this.addr);
            this.groupBox1.Controls.Add(this.ad);
            this.groupBox1.Controls.Add(this.mob);
            this.groupBox1.Controls.Add(this.ph_no);
            this.groupBox1.Controls.Add(this.expiry);
            this.groupBox1.Controls.Add(this.mem_type);
            this.groupBox1.Controls.Add(this.n);
            this.groupBox1.Controls.Add(this.exp);
            this.groupBox1.Controls.Add(this.mid);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.menu);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(219, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 506);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // EditMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clubbed_.Properties.Resources.wavy_pattern_abstract_hd_wallpaper_2560x1600_44431;
            this.ClientSize = new System.Drawing.Size(1069, 694);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         
            this.Text = "EditMembers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label M_ID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label ph_no;
        private System.Windows.Forms.Label mem_type;
        private System.Windows.Forms.Label exp;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.TextBox mid;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox expiry;
        private System.Windows.Forms.TextBox mob;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.TextBox memty;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}