namespace YilanFareOyunu
{
    partial class OyunGelistiricisiHakkinda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunGelistiricisiHakkinda));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.github = new System.Windows.Forms.LinkLabel();
            this.linkedin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(40, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mustafa Dalğa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Software Developer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // github
            // 
            this.github.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.github.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.github.Location = new System.Drawing.Point(41, 88);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(500, 18);
            this.github.TabIndex = 12;
            this.github.TabStop = true;
            this.github.Text = "https://github.com/mustafadalga";
            this.github.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.github_LinkClicked);
            // 
            // linkedin
            // 
            this.linkedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkedin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkedin.Location = new System.Drawing.Point(41, 117);
            this.linkedin.Name = "linkedin";
            this.linkedin.Size = new System.Drawing.Size(500, 18);
            this.linkedin.TabIndex = 13;
            this.linkedin.TabStop = true;
            this.linkedin.Text = "https://www.linkedin.com/in/mustafadalga";
            this.linkedin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkedin_LinkClicked);
            // 
            // OyunGelistiricisiHakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.linkedin);
            this.Controls.Add(this.github);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OyunGelistiricisiHakkinda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun Geliştiricisi Hakkında";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel github;
        private System.Windows.Forms.LinkLabel linkedin;
    }
}