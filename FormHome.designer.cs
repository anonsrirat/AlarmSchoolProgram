namespace PlayerUI
{
    partial class FormHome
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.LabelShowtime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LogoImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Itim", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(684, 431);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "โปรแกรมออดโรงเรียน";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelShowtime
            // 
            this.LabelShowtime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelShowtime.Font = new System.Drawing.Font("Itim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LabelShowtime.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelShowtime.Location = new System.Drawing.Point(0, 351);
            this.LabelShowtime.Name = "LabelShowtime";
            this.LabelShowtime.Size = new System.Drawing.Size(684, 80);
            this.LabelShowtime.TabIndex = 1;
            this.LabelShowtime.Text = "ขณะนี้เวลา";
            this.LabelShowtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogoImage
            // 
            this.LogoImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoImage.Image = global::PlayerUI.Properties.Resources.Logo;
            this.LogoImage.InitialImage = null;
            this.LogoImage.Location = new System.Drawing.Point(0, 0);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(684, 147);
            this.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoImage.TabIndex = 0;
            this.LogoImage.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.LabelShowtime);
            this.Controls.Add(this.LogoImage);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormHome";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.Resize += new System.EventHandler(this.FormHome_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label LabelShowtime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox LogoImage;
    }
}