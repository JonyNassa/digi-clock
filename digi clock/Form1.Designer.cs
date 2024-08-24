namespace digi_clock
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
            this.daytime = new System.Windows.Forms.Label();
            this.week = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.secs = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // daytime
            // 
            this.daytime.AutoSize = true;
            this.daytime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.daytime.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daytime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.daytime.Location = new System.Drawing.Point(230, 112);
            this.daytime.Name = "daytime";
            this.daytime.Size = new System.Drawing.Size(231, 81);
            this.daytime.TabIndex = 0;
            this.daytime.Text = "22:22";
            this.daytime.Click += new System.EventHandler(this.daytime_Click);
            this.daytime.DoubleClick += new System.EventHandler(this.daytime_DoubleClick);
            // 
            // week
            // 
            this.week.AutoSize = true;
            this.week.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.week.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.week.Location = new System.Drawing.Point(453, 205);
            this.week.Name = "week";
            this.week.Size = new System.Drawing.Size(187, 38);
            this.week.TabIndex = 1;
            this.week.Text = "WEDNESDAY";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.date.Location = new System.Drawing.Point(104, 233);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(357, 60);
            this.date.TabIndex = 2;
            this.date.Text = "JULY 14 2024";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // secs
            // 
            this.secs.AutoSize = true;
            this.secs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secs.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.secs.Location = new System.Drawing.Point(407, 165);
            this.secs.Name = "secs";
            this.secs.Size = new System.Drawing.Size(44, 28);
            this.secs.TabIndex = 3;
            this.secs.Text = "22";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secs);
            this.Controls.Add(this.date);
            this.Controls.Add(this.week);
            this.Controls.Add(this.daytime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daytime;
        private System.Windows.Forms.Label week;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label secs;
        private System.Windows.Forms.Timer timer;
    }
}

