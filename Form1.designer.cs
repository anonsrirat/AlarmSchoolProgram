namespace PlayerUI
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettingsProgram = new System.Windows.Forms.Button();
            this.panelPlaylistSubMenu = new System.Windows.Forms.Panel();
            this.btnAddsound = new System.Windows.Forms.Button();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnSettingsTime = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelPlaylistSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnSettingsProgram);
            this.panelSideMenu.Controls.Add(this.panelPlaylistSubMenu);
            this.panelSideMenu.Controls.Add(this.btnSettingsTime);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = global::PlayerUI.Properties.Resources.icons8_exit_36;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(250, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettingsProgram
            // 
            this.btnSettingsProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettingsProgram.FlatAppearance.BorderSize = 0;
            this.btnSettingsProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSettingsProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnSettingsProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsProgram.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsProgram.ForeColor = System.Drawing.Color.Silver;
            this.btnSettingsProgram.Image = global::PlayerUI.Properties.Resources.icons8_settings_36;
            this.btnSettingsProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsProgram.Location = new System.Drawing.Point(0, 287);
            this.btnSettingsProgram.Name = "btnSettingsProgram";
            this.btnSettingsProgram.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSettingsProgram.Size = new System.Drawing.Size(250, 55);
            this.btnSettingsProgram.TabIndex = 5;
            this.btnSettingsProgram.Text = "ตั่งค่าส่วนต่างๆโปรแกรม";
            this.btnSettingsProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettingsProgram.UseVisualStyleBackColor = true;
            this.btnSettingsProgram.Click += new System.EventHandler(this.btnEqualizer_Click);
            // 
            // panelPlaylistSubMenu
            // 
            this.panelPlaylistSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPlaylistSubMenu.Controls.Add(this.btnAddsound);
            this.panelPlaylistSubMenu.Controls.Add(this.btnAddTime);
            this.panelPlaylistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistSubMenu.Location = new System.Drawing.Point(0, 202);
            this.panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            this.panelPlaylistSubMenu.Size = new System.Drawing.Size(250, 85);
            this.panelPlaylistSubMenu.TabIndex = 4;
            // 
            // btnAddsound
            // 
            this.btnAddsound.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddsound.FlatAppearance.BorderSize = 0;
            this.btnAddsound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAddsound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAddsound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddsound.Font = new System.Drawing.Font("Itim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddsound.ForeColor = System.Drawing.Color.Silver;
            this.btnAddsound.Location = new System.Drawing.Point(0, 40);
            this.btnAddsound.Name = "btnAddsound";
            this.btnAddsound.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddsound.Size = new System.Drawing.Size(250, 40);
            this.btnAddsound.TabIndex = 1;
            this.btnAddsound.Text = "ตั่งค่าเสียงบอกเวลา";
            this.btnAddsound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddsound.UseVisualStyleBackColor = true;
            this.btnAddsound.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAddTime
            // 
            this.btnAddTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTime.FlatAppearance.BorderSize = 0;
            this.btnAddTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAddTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTime.Font = new System.Drawing.Font("Itim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTime.ForeColor = System.Drawing.Color.Silver;
            this.btnAddTime.Location = new System.Drawing.Point(0, 0);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddTime.Size = new System.Drawing.Size(250, 40);
            this.btnAddTime.TabIndex = 0;
            this.btnAddTime.Text = "เพิ่ม/ลบ ช่วงเวลา";
            this.btnAddTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnSettingsTime
            // 
            this.btnSettingsTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettingsTime.FlatAppearance.BorderSize = 0;
            this.btnSettingsTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSettingsTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnSettingsTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsTime.Font = new System.Drawing.Font("Sarabun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSettingsTime.ForeColor = System.Drawing.Color.Silver;
            this.btnSettingsTime.Image = global::PlayerUI.Properties.Resources.icons8_clock_36;
            this.btnSettingsTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsTime.Location = new System.Drawing.Point(0, 147);
            this.btnSettingsTime.Name = "btnSettingsTime";
            this.btnSettingsTime.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSettingsTime.Size = new System.Drawing.Size(250, 55);
            this.btnSettingsTime.TabIndex = 3;
            this.btnSettingsTime.Text = "ตั้งค่าช่วงเวลา";
            this.btnSettingsTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettingsTime.UseVisualStyleBackColor = true;
            this.btnSettingsTime.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnHome.ForeColor = System.Drawing.Color.Silver;
            this.btnHome.Image = global::PlayerUI.Properties.Resources.icons8_home_36__3_;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 92);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 55);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "หน้าหลัก";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlayerUI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(36, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelPlayer.Controls.Add(this.label1);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(250, 516);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(684, 45);
            this.panelPlayer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Sarabun SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create By Arnon Srirat (ANS)                                              𝓥𝑇𝓚 " +
    "𝓢𝑇𝓤𝓓𝓘𝓞                                          Copyright © 2024";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 516);
            this.panelChildForm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelPlaylistSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPlayer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettingsProgram;
        private System.Windows.Forms.Panel panelPlaylistSubMenu;
        private System.Windows.Forms.Button btnAddsound;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnSettingsTime;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
    }
}

