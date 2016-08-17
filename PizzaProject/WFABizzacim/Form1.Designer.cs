namespace WFABizzacim
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEbat = new System.Windows.Forms.ComboBox();
            this.lstPizza = new System.Windows.Forms.ListBox();
            this.rdinceKenar = new System.Windows.Forms.RadioButton();
            this.rdkalinKenar = new System.Windows.Forms.RadioButton();
            this.grpMazlemeler = new System.Windows.Forms.GroupBox();
            this.chcPeynir = new System.Windows.Forms.CheckBox();
            this.chcZeytin = new System.Windows.Forms.CheckBox();
            this.chctonBaligi = new System.Windows.Forms.CheckBox();
            this.chcAncuez = new System.Windows.Forms.CheckBox();
            this.chcMantar = new System.Windows.Forms.CheckBox();
            this.chcMisir = new System.Windows.Forms.CheckBox();
            this.chcSucuk = new System.Windows.Forms.CheckBox();
            this.chcSosis = new System.Windows.Forms.CheckBox();
            this.chcSalam = new System.Windows.Forms.CheckBox();
            this.chcdanaJambon = new System.Windows.Forms.CheckBox();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSiparisOnay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltoplamTutar = new System.Windows.Forms.Label();
            this.numerikAdet = new System.Windows.Forms.NumericUpDown();
            this.grpMazlemeler.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerikAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ebatlar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pizzalar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adet :";
            // 
            // cmbEbat
            // 
            this.cmbEbat.FormattingEnabled = true;
            this.cmbEbat.Location = new System.Drawing.Point(65, 89);
            this.cmbEbat.Name = "cmbEbat";
            this.cmbEbat.Size = new System.Drawing.Size(200, 21);
            this.cmbEbat.TabIndex = 1;
            // 
            // lstPizza
            // 
            this.lstPizza.FormattingEnabled = true;
            this.lstPizza.Location = new System.Drawing.Point(64, 128);
            this.lstPizza.Name = "lstPizza";
            this.lstPizza.Size = new System.Drawing.Size(201, 108);
            this.lstPizza.TabIndex = 2;
            // 
            // rdinceKenar
            // 
            this.rdinceKenar.AutoSize = true;
            this.rdinceKenar.Checked = true;
            this.rdinceKenar.Location = new System.Drawing.Point(65, 257);
            this.rdinceKenar.Name = "rdinceKenar";
            this.rdinceKenar.Size = new System.Drawing.Size(77, 17);
            this.rdinceKenar.TabIndex = 3;
            this.rdinceKenar.TabStop = true;
            this.rdinceKenar.Tag = "ince";
            this.rdinceKenar.Text = "İnce Kenar";
            this.rdinceKenar.UseVisualStyleBackColor = true;
            // 
            // rdkalinKenar
            // 
            this.rdkalinKenar.AutoSize = true;
            this.rdkalinKenar.Location = new System.Drawing.Point(157, 257);
            this.rdkalinKenar.Name = "rdkalinKenar";
            this.rdkalinKenar.Size = new System.Drawing.Size(79, 17);
            this.rdkalinKenar.TabIndex = 3;
            this.rdkalinKenar.TabStop = true;
            this.rdkalinKenar.Tag = "kalin";
            this.rdkalinKenar.Text = "Kalın Kenar";
            this.rdkalinKenar.UseVisualStyleBackColor = true;
            // 
            // grpMazlemeler
            // 
            this.grpMazlemeler.Controls.Add(this.chcPeynir);
            this.grpMazlemeler.Controls.Add(this.chcZeytin);
            this.grpMazlemeler.Controls.Add(this.chctonBaligi);
            this.grpMazlemeler.Controls.Add(this.chcAncuez);
            this.grpMazlemeler.Controls.Add(this.chcMantar);
            this.grpMazlemeler.Controls.Add(this.chcMisir);
            this.grpMazlemeler.Controls.Add(this.chcSucuk);
            this.grpMazlemeler.Controls.Add(this.chcSosis);
            this.grpMazlemeler.Controls.Add(this.chcSalam);
            this.grpMazlemeler.Controls.Add(this.chcdanaJambon);
            this.grpMazlemeler.Location = new System.Drawing.Point(65, 281);
            this.grpMazlemeler.Name = "grpMazlemeler";
            this.grpMazlemeler.Size = new System.Drawing.Size(200, 149);
            this.grpMazlemeler.TabIndex = 4;
            this.grpMazlemeler.TabStop = false;
            this.grpMazlemeler.Text = "Malzemeler";
            // 
            // chcPeynir
            // 
            this.chcPeynir.AutoSize = true;
            this.chcPeynir.Location = new System.Drawing.Point(98, 111);
            this.chcPeynir.Name = "chcPeynir";
            this.chcPeynir.Size = new System.Drawing.Size(55, 17);
            this.chcPeynir.TabIndex = 0;
            this.chcPeynir.Text = "Peynir";
            this.chcPeynir.UseVisualStyleBackColor = true;
            // 
            // chcZeytin
            // 
            this.chcZeytin.AutoSize = true;
            this.chcZeytin.Location = new System.Drawing.Point(6, 111);
            this.chcZeytin.Name = "chcZeytin";
            this.chcZeytin.Size = new System.Drawing.Size(55, 17);
            this.chcZeytin.TabIndex = 0;
            this.chcZeytin.Text = "Zeytin";
            this.chcZeytin.UseVisualStyleBackColor = true;
            // 
            // chctonBaligi
            // 
            this.chctonBaligi.AutoSize = true;
            this.chctonBaligi.Location = new System.Drawing.Point(97, 88);
            this.chctonBaligi.Name = "chctonBaligi";
            this.chctonBaligi.Size = new System.Drawing.Size(73, 17);
            this.chctonBaligi.TabIndex = 0;
            this.chctonBaligi.Text = "Ton Balığı";
            this.chctonBaligi.UseVisualStyleBackColor = true;
            // 
            // chcAncuez
            // 
            this.chcAncuez.AutoSize = true;
            this.chcAncuez.Location = new System.Drawing.Point(5, 88);
            this.chcAncuez.Name = "chcAncuez";
            this.chcAncuez.Size = new System.Drawing.Size(62, 17);
            this.chcAncuez.TabIndex = 0;
            this.chcAncuez.Text = "Ançuez";
            this.chcAncuez.UseVisualStyleBackColor = true;
            // 
            // chcMantar
            // 
            this.chcMantar.AutoSize = true;
            this.chcMantar.Location = new System.Drawing.Point(97, 65);
            this.chcMantar.Name = "chcMantar";
            this.chcMantar.Size = new System.Drawing.Size(59, 17);
            this.chcMantar.TabIndex = 0;
            this.chcMantar.Text = "Mantar";
            this.chcMantar.UseVisualStyleBackColor = true;
            // 
            // chcMisir
            // 
            this.chcMisir.AutoSize = true;
            this.chcMisir.Location = new System.Drawing.Point(5, 65);
            this.chcMisir.Name = "chcMisir";
            this.chcMisir.Size = new System.Drawing.Size(47, 17);
            this.chcMisir.TabIndex = 0;
            this.chcMisir.Text = "Mısır";
            this.chcMisir.UseVisualStyleBackColor = true;
            // 
            // chcSucuk
            // 
            this.chcSucuk.AutoSize = true;
            this.chcSucuk.Location = new System.Drawing.Point(97, 42);
            this.chcSucuk.Name = "chcSucuk";
            this.chcSucuk.Size = new System.Drawing.Size(57, 17);
            this.chcSucuk.TabIndex = 0;
            this.chcSucuk.Text = "Sucuk";
            this.chcSucuk.UseVisualStyleBackColor = true;
            // 
            // chcSosis
            // 
            this.chcSosis.AutoSize = true;
            this.chcSosis.Location = new System.Drawing.Point(5, 42);
            this.chcSosis.Name = "chcSosis";
            this.chcSosis.Size = new System.Drawing.Size(51, 17);
            this.chcSosis.TabIndex = 0;
            this.chcSosis.Text = "Sosis";
            this.chcSosis.UseVisualStyleBackColor = true;
            // 
            // chcSalam
            // 
            this.chcSalam.AutoSize = true;
            this.chcSalam.Location = new System.Drawing.Point(97, 19);
            this.chcSalam.Name = "chcSalam";
            this.chcSalam.Size = new System.Drawing.Size(55, 17);
            this.chcSalam.TabIndex = 0;
            this.chcSalam.Text = "Salam";
            this.chcSalam.UseVisualStyleBackColor = true;
            // 
            // chcdanaJambon
            // 
            this.chcdanaJambon.AutoSize = true;
            this.chcdanaJambon.Location = new System.Drawing.Point(5, 19);
            this.chcdanaJambon.Name = "chcdanaJambon";
            this.chcdanaJambon.Size = new System.Drawing.Size(92, 17);
            this.chcdanaJambon.TabIndex = 0;
            this.chcdanaJambon.Text = "Dana Jambon";
            this.chcdanaJambon.UseVisualStyleBackColor = true;
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(281, 89);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(282, 303);
            this.lstSiparisler.TabIndex = 2;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(124, 449);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(69, 23);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(251, 451);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(63, 20);
            this.txtTutar.TabIndex = 5;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(320, 449);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSepeteEkle.TabIndex = 6;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tutar";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(484, 814);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(63, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(553, 812);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSiparisOnay
            // 
            this.btnSiparisOnay.Location = new System.Drawing.Point(401, 449);
            this.btnSiparisOnay.Name = "btnSiparisOnay";
            this.btnSiparisOnay.Size = new System.Drawing.Size(90, 23);
            this.btnSiparisOnay.TabIndex = 6;
            this.btnSiparisOnay.Text = "Siparişi Onayla";
            this.btnSiparisOnay.UseVisualStyleBackColor = true;
            this.btnSiparisOnay.Click += new System.EventHandler(this.btnSiparisOnay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 70);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(244, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pizzacı Sipariş Ekranı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Toplam Tutar :";
            // 
            // lbltoplamTutar
            // 
            this.lbltoplamTutar.AutoSize = true;
            this.lbltoplamTutar.Location = new System.Drawing.Point(431, 417);
            this.lbltoplamTutar.Name = "lbltoplamTutar";
            this.lbltoplamTutar.Size = new System.Drawing.Size(0, 13);
            this.lbltoplamTutar.TabIndex = 0;
            // 
            // numerikAdet
            // 
            this.numerikAdet.Location = new System.Drawing.Point(64, 449);
            this.numerikAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numerikAdet.Name = "numerikAdet";
            this.numerikAdet.Size = new System.Drawing.Size(42, 20);
            this.numerikAdet.TabIndex = 8;
            this.numerikAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 486);
            this.Controls.Add(this.numerikAdet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnSiparisOnay);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.grpMazlemeler);
            this.Controls.Add(this.rdkalinKenar);
            this.Controls.Add(this.rdinceKenar);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.lstPizza);
            this.Controls.Add(this.cmbEbat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltoplamTutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizzacım v1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMazlemeler.ResumeLayout(false);
            this.grpMazlemeler.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerikAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEbat;
        private System.Windows.Forms.ListBox lstPizza;
        private System.Windows.Forms.RadioButton rdinceKenar;
        private System.Windows.Forms.RadioButton rdkalinKenar;
        private System.Windows.Forms.GroupBox grpMazlemeler;
        private System.Windows.Forms.CheckBox chcPeynir;
        private System.Windows.Forms.CheckBox chcZeytin;
        private System.Windows.Forms.CheckBox chctonBaligi;
        private System.Windows.Forms.CheckBox chcAncuez;
        private System.Windows.Forms.CheckBox chcMantar;
        private System.Windows.Forms.CheckBox chcMisir;
        private System.Windows.Forms.CheckBox chcSucuk;
        private System.Windows.Forms.CheckBox chcSosis;
        private System.Windows.Forms.CheckBox chcSalam;
        private System.Windows.Forms.CheckBox chcdanaJambon;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSiparisOnay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltoplamTutar;
        private System.Windows.Forms.NumericUpDown numerikAdet;
    }
}

