namespace eliotPong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.animeTimer = new System.Windows.Forms.Timer(this.components);
            this.AITimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scoreP1 = new System.Windows.Forms.Label();
            this.scoreP2 = new System.Windows.Forms.Label();
            this.winBox = new System.Windows.Forms.PictureBox();
            this.lossBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lossBox)).BeginInit();
            this.SuspendLayout();
            // 
            // animeTimer
            // 
            this.animeTimer.Enabled = true;
            this.animeTimer.Interval = 2;
            this.animeTimer.Tick += new System.EventHandler(this.animeTimer_Tick);
            // 
            // AITimer
            // 
            this.AITimer.Enabled = true;
            this.AITimer.Interval = 750;
            this.AITimer.Tick += new System.EventHandler(this.AITimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 1161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // scoreP1
            // 
            this.scoreP1.AutoSize = true;
            this.scoreP1.BackColor = System.Drawing.Color.Lime;
            this.scoreP1.Font = new System.Drawing.Font("Quartz MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreP1.Location = new System.Drawing.Point(572, 52);
            this.scoreP1.Name = "scoreP1";
            this.scoreP1.Size = new System.Drawing.Size(137, 38);
            this.scoreP1.TabIndex = 1;
            this.scoreP1.Text = "~~~~~~";
            // 
            // scoreP2
            // 
            this.scoreP2.AutoSize = true;
            this.scoreP2.BackColor = System.Drawing.Color.Lime;
            this.scoreP2.Font = new System.Drawing.Font("Quartz MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreP2.Location = new System.Drawing.Point(1066, 52);
            this.scoreP2.Name = "scoreP2";
            this.scoreP2.Size = new System.Drawing.Size(117, 38);
            this.scoreP2.TabIndex = 2;
            this.scoreP2.Text = "~~~~~";
            // 
            // winBox
            // 
            this.winBox.BackgroundImage = global::eliotPong.Properties.Resources.pong_win;
            this.winBox.Location = new System.Drawing.Point(-16, -39);
            this.winBox.Name = "winBox";
            this.winBox.Size = new System.Drawing.Size(1940, 1200);
            this.winBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.winBox.TabIndex = 3;
            this.winBox.TabStop = false;
            this.winBox.Visible = false;
            // 
            // lossBox
            // 
            this.lossBox.BackgroundImage = global::eliotPong.Properties.Resources.pong_lose;
            this.lossBox.Location = new System.Drawing.Point(0, 0);
            this.lossBox.Name = "lossBox";
            this.lossBox.Size = new System.Drawing.Size(1940, 1200);
            this.lossBox.TabIndex = 4;
            this.lossBox.TabStop = false;
            this.lossBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1161);
            this.Controls.Add(this.lossBox);
            this.Controls.Add(this.winBox);
            this.Controls.Add(this.scoreP2);
            this.Controls.Add(this.scoreP1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lossBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer AITimer;
        public System.Windows.Forms.Timer animeTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label scoreP1;
        private System.Windows.Forms.Label scoreP2;
        private System.Windows.Forms.PictureBox winBox;
        private System.Windows.Forms.PictureBox lossBox;
    }
}

