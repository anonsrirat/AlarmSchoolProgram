using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class FormHome : Form
    {
        private float originalFontSizeLabelShowtime;
        private float originalFontSizeTitle;
        private Size originalFormSize;
        private Rectangle originalLabelShowtimeRect;
        private Rectangle originalTitleRect;
        private Rectangle originalPictureBoxRect;

        public FormHome()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // อัปเดตเวลาทุกๆ ครั้งที่ Timer ติ๊ก
            UpdateTime();
        }

        private void UpdateTime()
        {
            LabelShowtime.Text = "ขณะนี้เวลา :" + DateTime.Now.ToString("HH:mm:ss");
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // เก็บค่าขนาดเริ่มต้นของฟอร์มและคอนโทรล
            originalFormSize = this.ClientSize;

            originalFontSizeLabelShowtime = LabelShowtime.Font.Size;
            originalLabelShowtimeRect = new Rectangle(LabelShowtime.Location, LabelShowtime.Size);

            originalFontSizeTitle = labelTitle.Font.Size;
            originalTitleRect = new Rectangle(labelTitle.Location, labelTitle.Size);

            originalPictureBoxRect = new Rectangle(LogoImage.Location, LogoImage.Size);

            // เริ่มต้นการแสดงเวลาปัจจุบัน
            UpdateTime();
            timer1.Start();
        }

        private void FormHome_Resize(object sender, EventArgs e)
        {

            // คำนวณสัดส่วนการเปลี่ยนแปลงของขนาดฟอร์ม
            float scaleX = (float)this.ClientSize.Width / originalFormSize.Width;
            float scaleY = (float)this.ClientSize.Height / originalFormSize.Height;

            if (float.IsNaN(originalFontSizeLabelShowtime * scaleY) || float.IsInfinity(originalFontSizeLabelShowtime * scaleY))
            {
                return;
            }

            // ปรับขนาดฟอนต์ตามสัดส่วนการเปลี่ยนแปลง
            LabelShowtime.Font = new Font(LabelShowtime.Font.FontFamily, originalFontSizeLabelShowtime * scaleY);
            labelTitle.Font = new Font(labelTitle.Font.FontFamily, originalFontSizeTitle * scaleY);

            // ปรับขนาดและตำแหน่งของ Label1 ตามสัดส่วนการเปลี่ยนแปลง
            LabelShowtime.Location = new Point((int)(originalLabelShowtimeRect.X * scaleX), (int)(originalLabelShowtimeRect.Y * scaleY));
            LabelShowtime.Size = new Size((int)(originalLabelShowtimeRect.Width * scaleX), (int)(originalLabelShowtimeRect.Height * scaleY));

            // ปรับขนาดและตำแหน่งของ Label2 ตามสัดส่วนการเปลี่ยนแปลง
            labelTitle.Location = new Point((int)(originalTitleRect.X * scaleX), (int)(originalTitleRect.Y * scaleY));
            labelTitle.Size = new Size((int)(originalTitleRect.Width * scaleX), (int)(originalTitleRect.Height * scaleY));

            // ปรับขนาดและตำแหน่งของ PictureBox ตามสัดส่วนการเปลี่ยนแปลง
            LogoImage.Location = new Point((int)(originalPictureBoxRect.X * scaleX), (int)(originalPictureBoxRect.Y * scaleY));
            LogoImage.Size = new Size((int)(originalPictureBoxRect.Width * scaleX), (int)(originalPictureBoxRect.Height * scaleY));
        }
    }
}
