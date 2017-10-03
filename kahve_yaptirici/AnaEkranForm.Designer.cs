namespace kahve_yaptirici
{
    partial class AnaEkranForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkranForm));
            this.KapatButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tarihSaatLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TemizleButton = new System.Windows.Forms.Button();
            this.elineSaglikLbl = new System.Windows.Forms.Label();
            this.SilBtn = new System.Windows.Forms.Button();
            this.secBtn = new System.Windows.Forms.Button();
            this.secilenKisiLb = new System.Windows.Forms.Label();
            this.kisilerLb = new System.Windows.Forms.ListBox();
            this.kisiEkleBtn = new System.Windows.Forms.Button();
            this.kisiAdiTb = new System.Windows.Forms.TextBox();
            this.talihliLb = new System.Windows.Forms.Label();
            this.sayiLbl = new System.Windows.Forms.Label();
            this.leaderboardLb = new System.Windows.Forms.ListBox();
            this.top5Lbl = new System.Windows.Forms.Label();
            this.TickerTimer = new System.Windows.Forms.Timer(this.components);
            this.GecenAyKraliLbl = new System.Windows.Forms.Label();
            this.GecenAyKraliAdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KapatButton)).BeginInit();
            this.SuspendLayout();
            // 
            // KapatButton
            // 
            this.KapatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KapatButton.Image = ((System.Drawing.Image)(resources.GetObject("KapatButton.Image")));
            this.KapatButton.Location = new System.Drawing.Point(500, 3);
            this.KapatButton.Name = "KapatButton";
            this.KapatButton.Size = new System.Drawing.Size(16, 16);
            this.KapatButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.KapatButton.TabIndex = 1;
            this.KapatButton.TabStop = false;
            this.KapatButton.Click += new System.EventHandler(this.KapatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "KAHVE YAPTIRICI";
            // 
            // tarihSaatLbl
            // 
            this.tarihSaatLbl.AutoSize = true;
            this.tarihSaatLbl.Location = new System.Drawing.Point(131, 7);
            this.tarihSaatLbl.Name = "tarihSaatLbl";
            this.tarihSaatLbl.Size = new System.Drawing.Size(42, 14);
            this.tarihSaatLbl.TabIndex = 3;
            this.tarihSaatLbl.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TemizleButton
            // 
            this.TemizleButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.TemizleButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.TemizleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TemizleButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TemizleButton.Location = new System.Drawing.Point(239, 81);
            this.TemizleButton.Name = "TemizleButton";
            this.TemizleButton.Size = new System.Drawing.Size(63, 22);
            this.TemizleButton.TabIndex = 17;
            this.TemizleButton.Text = "Temizle";
            this.TemizleButton.UseVisualStyleBackColor = true;
            this.TemizleButton.Click += new System.EventHandler(this.TemizleButton_Click);
            // 
            // elineSaglikLbl
            // 
            this.elineSaglikLbl.AutoSize = true;
            this.elineSaglikLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elineSaglikLbl.Location = new System.Drawing.Point(15, 243);
            this.elineSaglikLbl.Name = "elineSaglikLbl";
            this.elineSaglikLbl.Size = new System.Drawing.Size(181, 17);
            this.elineSaglikLbl.TabIndex = 16;
            this.elineSaglikLbl.Text = "ŞİMDİDEN ELLERİNE SAĞLIK!!";
            // 
            // SilBtn
            // 
            this.SilBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.SilBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.SilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SilBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilBtn.Location = new System.Drawing.Point(239, 53);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(63, 22);
            this.SilBtn.TabIndex = 15;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = true;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // secBtn
            // 
            this.secBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.secBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.secBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secBtn.Location = new System.Drawing.Point(16, 162);
            this.secBtn.Name = "secBtn";
            this.secBtn.Size = new System.Drawing.Size(286, 23);
            this.secBtn.TabIndex = 14;
            this.secBtn.Text = "KAHVE YAPTIR!";
            this.secBtn.UseVisualStyleBackColor = true;
            this.secBtn.Click += new System.EventHandler(this.secBtn_Click);
            // 
            // secilenKisiLb
            // 
            this.secilenKisiLb.AutoSize = true;
            this.secilenKisiLb.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secilenKisiLb.Location = new System.Drawing.Point(15, 199);
            this.secilenKisiLb.Name = "secilenKisiLb";
            this.secilenKisiLb.Size = new System.Drawing.Size(90, 18);
            this.secilenKisiLb.TabIndex = 13;
            this.secilenKisiLb.Text = "SEÇİLEN KİŞİ :";
            // 
            // kisilerLb
            // 
            this.kisilerLb.BackColor = System.Drawing.SystemColors.Control;
            this.kisilerLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kisilerLb.FormattingEnabled = true;
            this.kisilerLb.ItemHeight = 14;
            this.kisilerLb.Location = new System.Drawing.Point(16, 53);
            this.kisilerLb.Name = "kisilerLb";
            this.kisilerLb.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.kisilerLb.Size = new System.Drawing.Size(217, 100);
            this.kisilerLb.TabIndex = 12;
            // 
            // kisiEkleBtn
            // 
            this.kisiEkleBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.kisiEkleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.kisiEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kisiEkleBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisiEkleBtn.Location = new System.Drawing.Point(239, 24);
            this.kisiEkleBtn.Name = "kisiEkleBtn";
            this.kisiEkleBtn.Size = new System.Drawing.Size(63, 22);
            this.kisiEkleBtn.TabIndex = 11;
            this.kisiEkleBtn.Text = "Ekle";
            this.kisiEkleBtn.UseVisualStyleBackColor = true;
            this.kisiEkleBtn.Click += new System.EventHandler(this.kisiEkleBtn_Click);
            // 
            // kisiAdiTb
            // 
            this.kisiAdiTb.BackColor = System.Drawing.SystemColors.Control;
            this.kisiAdiTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kisiAdiTb.Location = new System.Drawing.Point(16, 24);
            this.kisiAdiTb.Name = "kisiAdiTb";
            this.kisiAdiTb.Size = new System.Drawing.Size(217, 22);
            this.kisiAdiTb.TabIndex = 10;
            this.kisiAdiTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kisiAdiTb_KeyPress);
            // 
            // talihliLb
            // 
            this.talihliLb.AutoSize = true;
            this.talihliLb.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talihliLb.Location = new System.Drawing.Point(15, 223);
            this.talihliLb.Name = "talihliLb";
            this.talihliLb.Size = new System.Drawing.Size(0, 18);
            this.talihliLb.TabIndex = 18;
            // 
            // sayiLbl
            // 
            this.sayiLbl.AutoSize = true;
            this.sayiLbl.Location = new System.Drawing.Point(15, 266);
            this.sayiLbl.Name = "sayiLbl";
            this.sayiLbl.Size = new System.Drawing.Size(0, 14);
            this.sayiLbl.TabIndex = 19;
            // 
            // leaderboardLb
            // 
            this.leaderboardLb.BackColor = System.Drawing.SystemColors.Control;
            this.leaderboardLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leaderboardLb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.leaderboardLb.FormattingEnabled = true;
            this.leaderboardLb.ItemHeight = 14;
            this.leaderboardLb.Location = new System.Drawing.Point(313, 53);
            this.leaderboardLb.Name = "leaderboardLb";
            this.leaderboardLb.Size = new System.Drawing.Size(203, 128);
            this.leaderboardLb.TabIndex = 20;
            this.leaderboardLb.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.leaderboardLb_DrawItem);
            // 
            // top5Lbl
            // 
            this.top5Lbl.AutoSize = true;
            this.top5Lbl.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.top5Lbl.Location = new System.Drawing.Point(310, 24);
            this.top5Lbl.Name = "top5Lbl";
            this.top5Lbl.Size = new System.Drawing.Size(0, 17);
            this.top5Lbl.TabIndex = 21;
            // 
            // TickerTimer
            // 
            this.TickerTimer.Enabled = true;
            this.TickerTimer.Interval = 500;
            this.TickerTimer.Tick += new System.EventHandler(this.TickerTimer_Tick);
            // 
            // GecenAyKraliLbl
            // 
            this.GecenAyKraliLbl.AutoSize = true;
            this.GecenAyKraliLbl.Location = new System.Drawing.Point(310, 184);
            this.GecenAyKraliLbl.Name = "GecenAyKraliLbl";
            this.GecenAyKraliLbl.Size = new System.Drawing.Size(102, 14);
            this.GecenAyKraliLbl.TabIndex = 22;
            this.GecenAyKraliLbl.Text = "Geçen Ayın Kralı : ";
            // 
            // GecenAyKraliAdLbl
            // 
            this.GecenAyKraliAdLbl.AutoSize = true;
            this.GecenAyKraliAdLbl.Location = new System.Drawing.Point(310, 198);
            this.GecenAyKraliAdLbl.Name = "GecenAyKraliAdLbl";
            this.GecenAyKraliAdLbl.Size = new System.Drawing.Size(0, 14);
            this.GecenAyKraliAdLbl.TabIndex = 23;
            // 
            // AnaEkranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(528, 289);
            this.Controls.Add(this.GecenAyKraliAdLbl);
            this.Controls.Add(this.GecenAyKraliLbl);
            this.Controls.Add(this.top5Lbl);
            this.Controls.Add(this.leaderboardLb);
            this.Controls.Add(this.sayiLbl);
            this.Controls.Add(this.talihliLb);
            this.Controls.Add(this.TemizleButton);
            this.Controls.Add(this.elineSaglikLbl);
            this.Controls.Add(this.tarihSaatLbl);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secBtn);
            this.Controls.Add(this.KapatButton);
            this.Controls.Add(this.secilenKisiLb);
            this.Controls.Add(this.kisiAdiTb);
            this.Controls.Add(this.kisilerLb);
            this.Controls.Add(this.kisiEkleBtn);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaEkranForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.KapatButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox KapatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tarihSaatLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button TemizleButton;
        private System.Windows.Forms.Label elineSaglikLbl;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button secBtn;
        private System.Windows.Forms.Label secilenKisiLb;
        private System.Windows.Forms.ListBox kisilerLb;
        private System.Windows.Forms.Button kisiEkleBtn;
        private System.Windows.Forms.TextBox kisiAdiTb;
        private System.Windows.Forms.Label talihliLb;
        private System.Windows.Forms.Label sayiLbl;
        private System.Windows.Forms.ListBox leaderboardLb;
        private System.Windows.Forms.Label top5Lbl;
        private System.Windows.Forms.Timer TickerTimer;
        private System.Windows.Forms.Label GecenAyKraliLbl;
        private System.Windows.Forms.Label GecenAyKraliAdLbl;
    }
}

