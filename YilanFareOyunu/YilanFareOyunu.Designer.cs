namespace YilanFareOyunu
{
    partial class YilanFareOyunu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YilanFareOyunu));
            this.tmrhareket = new System.Windows.Forms.Timer(this.components);
            this.lblbaslik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsure = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblhak = new System.Windows.Forms.Label();
            this.lbllevel = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timersure = new System.Windows.Forms.Timer(this.components);
            this.timerpuan = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbaslat = new System.Windows.Forms.Button();
            this.btnbitir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyunKullanimiHakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelistiricihakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yilan3 = new System.Windows.Forms.PictureBox();
            this.yilan2 = new System.Windows.Forms.PictureBox();
            this.yilan1 = new System.Windows.Forms.PictureBox();
            this.fare = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yilan3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fare)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrhareket
            // 
            this.tmrhareket.Tick += new System.EventHandler(this.tmrhareket_Tick);
            // 
            // lblbaslik
            // 
            this.lblbaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblbaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbaslik.ForeColor = System.Drawing.Color.Black;
            this.lblbaslik.Location = new System.Drawing.Point(0, 350);
            this.lblbaslik.Name = "lblbaslik";
            this.lblbaslik.Size = new System.Drawing.Size(880, 24);
            this.lblbaslik.TabIndex = 5;
            this.lblbaslik.Text = "Durum";
            this.lblbaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsure);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblhak);
            this.groupBox1.Controls.Add(this.lbllevel);
            this.groupBox1.Controls.Add(this.lblpuan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(376, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblsure
            // 
            this.lblsure.BackColor = System.Drawing.Color.Transparent;
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblsure.Location = new System.Drawing.Point(335, 45);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(100, 20);
            this.lblsure.TabIndex = 7;
            this.lblsure.Text = "00:00:00";
            this.lblsure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.label7.Location = new System.Drawing.Point(335, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Süre";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblhak
            // 
            this.lblhak.BackColor = System.Drawing.Color.Transparent;
            this.lblhak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblhak.Location = new System.Drawing.Point(225, 45);
            this.lblhak.Name = "lblhak";
            this.lblhak.Size = new System.Drawing.Size(100, 20);
            this.lblhak.TabIndex = 5;
            this.lblhak.Text = "5";
            this.lblhak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbllevel
            // 
            this.lbllevel.BackColor = System.Drawing.Color.Transparent;
            this.lbllevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbllevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lbllevel.Location = new System.Drawing.Point(115, 45);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(100, 20);
            this.lbllevel.TabIndex = 4;
            this.lbllevel.Text = "0";
            this.lbllevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpuan
            // 
            this.lblpuan.BackColor = System.Drawing.Color.Transparent;
            this.lblpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblpuan.Location = new System.Drawing.Point(5, 45);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(100, 20);
            this.lblpuan.TabIndex = 3;
            this.lblpuan.Text = "0";
            this.lblpuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.label4.Location = new System.Drawing.Point(225, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hak";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.label3.Location = new System.Drawing.Point(115, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Level";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Puan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timersure
            // 
            this.timersure.Interval = 1000;
            this.timersure.Tick += new System.EventHandler(this.timersure_Tick);
            // 
            // timerpuan
            // 
            this.timerpuan.Interval = 200;
            this.timerpuan.Tick += new System.EventHandler(this.timerpuan_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbaslat);
            this.groupBox2.Controls.Add(this.btnbitir);
            this.groupBox2.Location = new System.Drawing.Point(45, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 72);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnbaslat
            // 
            this.btnbaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.btnbaslat.BackgroundImage = global::YilanFareOyunu.Properties.Resources.baslat;
            this.btnbaslat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnbaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbaslat.Location = new System.Drawing.Point(26, 14);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(100, 50);
            this.btnbaslat.TabIndex = 7;
            this.btnbaslat.UseVisualStyleBackColor = false;
            this.btnbaslat.Click += new System.EventHandler(this.btnbaslat_Click);
            // 
            // btnbitir
            // 
            this.btnbitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.btnbitir.BackgroundImage = global::YilanFareOyunu.Properties.Resources.durdur2;
            this.btnbitir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnbitir.Enabled = false;
            this.btnbitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbitir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnbitir.Location = new System.Drawing.Point(132, 14);
            this.btnbitir.Name = "btnbitir";
            this.btnbitir.Size = new System.Drawing.Size(100, 50);
            this.btnbitir.TabIndex = 9;
            this.btnbitir.UseVisualStyleBackColor = false;
            this.btnbitir.Click += new System.EventHandler(this.btnbitir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Green;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyunToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(880, 26);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oyunToolStripMenuItem
            // 
            this.oyunToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.oyunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyunKullanimiHakkindaToolStripMenuItem,
            this.gelistiricihakkindaToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.oyunToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.oyunToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.oyunToolStripMenuItem.Image = global::YilanFareOyunu.Properties.Resources.question_mark;
            this.oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            this.oyunToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.oyunToolStripMenuItem.Text = "Yardım Menüsü";
            this.oyunToolStripMenuItem.Click += new System.EventHandler(this.oyunToolStripMenuItem_Click);
            // 
            // oyunKullanimiHakkindaToolStripMenuItem
            // 
            this.oyunKullanimiHakkindaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.oyunKullanimiHakkindaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.oyunKullanimiHakkindaToolStripMenuItem.Image = global::YilanFareOyunu.Properties.Resources.information;
            this.oyunKullanimiHakkindaToolStripMenuItem.Name = "oyunKullanimiHakkindaToolStripMenuItem";
            this.oyunKullanimiHakkindaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.oyunKullanimiHakkindaToolStripMenuItem.Text = "Oyun Hakkında";
            this.oyunKullanimiHakkindaToolStripMenuItem.Click += new System.EventHandler(this.oyunKullanimiHakkindaToolStripMenuItem_Click);
            // 
            // gelistiricihakkindaToolStripMenuItem
            // 
            this.gelistiricihakkindaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.gelistiricihakkindaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gelistiricihakkindaToolStripMenuItem.Image = global::YilanFareOyunu.Properties.Resources.developer;
            this.gelistiricihakkindaToolStripMenuItem.Name = "gelistiricihakkindaToolStripMenuItem";
            this.gelistiricihakkindaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.gelistiricihakkindaToolStripMenuItem.Text = "Geliştirici Hakkında";
            this.gelistiricihakkindaToolStripMenuItem.Click += new System.EventHandler(this.gelistiricihakkindaToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cikisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cikisToolStripMenuItem.Image = global::YilanFareOyunu.Properties.Resources.logout;
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // yilan3
            // 
            this.yilan3.BackColor = System.Drawing.Color.Transparent;
            this.yilan3.Enabled = false;
            this.yilan3.Image = ((System.Drawing.Image)(resources.GetObject("yilan3.Image")));
            this.yilan3.Location = new System.Drawing.Point(5, 254);
            this.yilan3.Name = "yilan3";
            this.yilan3.Size = new System.Drawing.Size(150, 40);
            this.yilan3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yilan3.TabIndex = 14;
            this.yilan3.TabStop = false;
            // 
            // yilan2
            // 
            this.yilan2.BackColor = System.Drawing.Color.Transparent;
            this.yilan2.Enabled = false;
            this.yilan2.Image = ((System.Drawing.Image)(resources.GetObject("yilan2.Image")));
            this.yilan2.Location = new System.Drawing.Point(584, 165);
            this.yilan2.Name = "yilan2";
            this.yilan2.Size = new System.Drawing.Size(150, 40);
            this.yilan2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yilan2.TabIndex = 13;
            this.yilan2.TabStop = false;
            // 
            // yilan1
            // 
            this.yilan1.BackColor = System.Drawing.Color.Transparent;
            this.yilan1.Enabled = false;
            this.yilan1.Image = ((System.Drawing.Image)(resources.GetObject("yilan1.Image")));
            this.yilan1.Location = new System.Drawing.Point(21, 79);
            this.yilan1.Name = "yilan1";
            this.yilan1.Size = new System.Drawing.Size(150, 40);
            this.yilan1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yilan1.TabIndex = 4;
            this.yilan1.TabStop = false;
            this.yilan1.Tag = "";
            // 
            // fare
            // 
            this.fare.BackColor = System.Drawing.Color.Green;
            this.fare.Image = global::YilanFareOyunu.Properties.Resources.mouse;
            this.fare.Location = new System.Drawing.Point(408, 154);
            this.fare.Name = "fare";
            this.fare.Size = new System.Drawing.Size(32, 32);
            this.fare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fare.TabIndex = 10;
            this.fare.TabStop = false;
            // 
            // YilanFareOyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(880, 462);
            this.Controls.Add(this.yilan3);
            this.Controls.Add(this.yilan2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.fare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblbaslik);
            this.Controls.Add(this.yilan1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(900, 505);
            this.MinimumSize = new System.Drawing.Size(900, 505);
            this.Name = "YilanFareOyunu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yılan - Fare Oyunu";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yilan3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        public System.Windows.Forms.Timer tmrhareket;
        public System.Windows.Forms.Label lblbaslik;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblhak;
        public System.Windows.Forms.Label lbllevel;
        public System.Windows.Forms.Label lblpuan;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnbaslat;
        public System.Windows.Forms.Button btnbitir;
        public System.Windows.Forms.PictureBox yilan1;
        public System.Windows.Forms.Timer timersure;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblsure;
        public System.Windows.Forms.Timer timerpuan;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.PictureBox yilan2;
        public System.Windows.Forms.PictureBox yilan3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyunKullanimiHakkindaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelistiricihakkindaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        public System.Windows.Forms.PictureBox fare;
    }
}

