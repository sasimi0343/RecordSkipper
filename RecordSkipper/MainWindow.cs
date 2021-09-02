using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace RecordSkipper
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ScreenPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.ResetTransform();
            if (Screen.PrimaryScreen.Bounds.Width > 0 && Screen.PrimaryScreen.Bounds.Height > 0)
            {
                e.Graphics.ScaleTransform((float)ScreenPanel.Width / Screen.PrimaryScreen.Bounds.Width, (float)ScreenPanel.Height / Screen.PrimaryScreen.Bounds.Height);
            }
            e.Graphics.CopyFromScreen(new Point(), new Point(), new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
        }

        public void ScreenShot()
        {
            Bitmap bit = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graph = Graphics.FromImage(bit);
            graph.CopyFromScreen(new Point(), new Point(), new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
            if (!Directory.Exists(this.FolderBox.Text))
            {

            }
            else
            {
                bit.Save(this.FolderBox.Text + "\\" + this.currentTick + ".png", ImageFormat.Png);
            }

            currentTick++;
            
            graph.Dispose();
            bit.Dispose();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            this.ScreenPanel.Refresh();
            if (shotting)
            {
                this.ScreenShot();
            }
        }

        private void ScreenPanel_Resize(object sender, EventArgs e)
        {
            this.ScreenPanel.Refresh();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar1.Value = (int)Math.Round((decimal)this.trackBar1.Value);
            this.TickText.Text = "Tick - " + this.trackBar1.Value;
            this.tick.Interval = this.trackBar1.Value * 1000;
        }

        private int currentTick = 0;
        public bool shotting = false;

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (shotting)
            {
                this.shotting = false;
                this.StartButton.Text = "Record";
                this.StartButton.BackColor = Color.Blue;
            }
            else
            {
                if (!Directory.Exists(this.FolderBox.Text))
                {
                    MessageBox.Show("指定されたフォルダが無効です。");
                }
                else
                {
                    this.shotting = true;
                    this.currentTick = 1;
                    this.StartButton.Text = "Recording...";
                    this.StartButton.BackColor = Color.Red;
                }
            }
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            this.OutputDialog.ShowDialog();
            this.FolderBox.Text = this.OutputDialog.SelectedPath;
        }
    }
}
