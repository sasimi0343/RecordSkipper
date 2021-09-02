

namespace RecordSkipper
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.TickText = new System.Windows.Forms.Label();
            this.ScreenPanel = new System.Windows.Forms.Panel();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.OutputDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderBox = new System.Windows.Forms.TextBox();
            this.FolderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // TickText
            // 
            resources.ApplyResources(this.TickText, "TickText");
            this.TickText.Name = "TickText";
            // 
            // ScreenPanel
            // 
            resources.ApplyResources(this.ScreenPanel, "ScreenPanel");
            this.ScreenPanel.Name = "ScreenPanel";
            this.ScreenPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ScreenPanel_Paint);
            this.ScreenPanel.Resize += new System.EventHandler(this.ScreenPanel_Resize);
            // 
            // tick
            // 
            this.tick.Enabled = true;
            this.tick.Interval = 10000;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // StartButton
            // 
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.BackColor = System.Drawing.Color.Blue;
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Name = "StartButton";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // OutputDialog
            // 
            resources.ApplyResources(this.OutputDialog, "OutputDialog");
            // 
            // FolderBox
            // 
            resources.ApplyResources(this.FolderBox, "FolderBox");
            this.FolderBox.Name = "FolderBox";
            // 
            // FolderButton
            // 
            resources.ApplyResources(this.FolderButton, "FolderButton");
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.FolderBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ScreenPanel);
            this.Controls.Add(this.TickText);
            this.Controls.Add(this.trackBar1);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label TickText;
        private System.Windows.Forms.Panel ScreenPanel;
        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.FolderBrowserDialog OutputDialog;
        private System.Windows.Forms.TextBox FolderBox;
        private System.Windows.Forms.Button FolderButton;
    }
}

