namespace GameBank
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.zemin1 = new System.Windows.Forms.PictureBox();
            this.zemin2 = new System.Windows.Forms.PictureBox();
            this.zemin3 = new System.Windows.Forms.PictureBox();
            this.yakısıklıflappy = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zemin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakısıklıflappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            this.SuspendLayout();
            // 
            // zemin1
            // 
            this.zemin1.BackColor = System.Drawing.Color.Transparent;
            this.zemin1.Image = ((System.Drawing.Image)(resources.GetObject("zemin1.Image")));
            this.zemin1.Location = new System.Drawing.Point(-1, 476);
            this.zemin1.Name = "zemin1";
            this.zemin1.Size = new System.Drawing.Size(339, 51);
            this.zemin1.TabIndex = 0;
            this.zemin1.TabStop = false;
            // 
            // zemin2
            // 
            this.zemin2.BackColor = System.Drawing.Color.Transparent;
            this.zemin2.Image = ((System.Drawing.Image)(resources.GetObject("zemin2.Image")));
            this.zemin2.Location = new System.Drawing.Point(329, 476);
            this.zemin2.Name = "zemin2";
            this.zemin2.Size = new System.Drawing.Size(336, 50);
            this.zemin2.TabIndex = 2;
            this.zemin2.TabStop = false;
            // 
            // zemin3
            // 
            this.zemin3.BackColor = System.Drawing.Color.Transparent;
            this.zemin3.Image = ((System.Drawing.Image)(resources.GetObject("zemin3.Image")));
            this.zemin3.Location = new System.Drawing.Point(661, 477);
            this.zemin3.Name = "zemin3";
            this.zemin3.Size = new System.Drawing.Size(336, 50);
            this.zemin3.TabIndex = 3;
            this.zemin3.TabStop = false;
            // 
            // yakısıklıflappy
            // 
            this.yakısıklıflappy.BackColor = System.Drawing.Color.Transparent;
            this.yakısıklıflappy.Image = ((System.Drawing.Image)(resources.GetObject("yakısıklıflappy.Image")));
            this.yakısıklıflappy.Location = new System.Drawing.Point(120, 121);
            this.yakısıklıflappy.Name = "yakısıklıflappy";
            this.yakısıklıflappy.Size = new System.Drawing.Size(50, 57);
            this.yakısıklıflappy.TabIndex = 6;
            this.yakısıklıflappy.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.BackColor = System.Drawing.Color.Lime;
            this.scoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoretext.ForeColor = System.Drawing.Color.Transparent;
            this.scoretext.Location = new System.Drawing.Point(3, 496);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(131, 29);
            this.scoretext.TabIndex = 7;
            this.scoretext.Text = "SCORE: 0";
            // 
            // BoruAlt
            // 
            this.BoruAlt.BackColor = System.Drawing.Color.Transparent;
            this.BoruAlt.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt.Image")));
            this.BoruAlt.Location = new System.Drawing.Point(720, 281);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(100, 202);
            this.BoruAlt.TabIndex = 8;
            this.BoruAlt.TabStop = false;
            // 
            // BoruUst
            // 
            this.BoruUst.BackColor = System.Drawing.Color.Transparent;
            this.BoruUst.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst.Image")));
            this.BoruUst.Location = new System.Drawing.Point(720, -150);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(100, 298);
            this.BoruUst.TabIndex = 9;
            this.BoruUst.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(949, 527);
            this.Controls.Add(this.yakısıklıflappy);
            this.Controls.Add(this.BoruUst);
            this.Controls.Add(this.BoruAlt);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.zemin3);
            this.Controls.Add(this.zemin2);
            this.Controls.Add(this.zemin1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.zemin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakısıklıflappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox zemin1;
        private System.Windows.Forms.PictureBox zemin2;
        private System.Windows.Forms.PictureBox zemin3;
        private System.Windows.Forms.PictureBox yakısıklıflappy;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.PictureBox BoruAlt;
        private System.Windows.Forms.PictureBox BoruUst;
        private System.Windows.Forms.Timer gametimer;
    }
}