﻿namespace ZamanliExeCalistirici
{
    partial class FormZamanliProgramCalistirici
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProgramTanimlari = new System.Windows.Forms.TabPage();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnProgramSec = new System.Windows.Forms.Button();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabZamanTanimlari = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTanimliZamanGun = new System.Windows.Forms.ComboBox();
            this.listViewTanimliZamanlar = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZamanEkle = new System.Windows.Forms.Button();
            this.txtZamanEkleDakika = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZamanEkleSaat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbZamanTanimlaGun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabGecmis = new System.Windows.Forms.TabPage();
            this.btnGecmisFiltrele = new System.Windows.Forms.Button();
            this.gecmisTarih2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.gecmisTarih1 = new System.Windows.Forms.DateTimePicker();
            this.listViewGecmis = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabProgramTanimlari.SuspendLayout();
            this.tabZamanTanimlari.SuspendLayout();
            this.tabGecmis.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProgramTanimlari);
            this.tabControl1.Controls.Add(this.tabZamanTanimlari);
            this.tabControl1.Controls.Add(this.tabGecmis);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 482);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProgramTanimlari
            // 
            this.tabProgramTanimlari.Controls.Add(this.btnDurdur);
            this.tabProgramTanimlari.Controls.Add(this.btnCalistir);
            this.tabProgramTanimlari.Controls.Add(this.lblDurum);
            this.tabProgramTanimlari.Controls.Add(this.label10);
            this.tabProgramTanimlari.Controls.Add(this.btnOnayla);
            this.tabProgramTanimlari.Controls.Add(this.btnProgramSec);
            this.tabProgramTanimlari.Controls.Add(this.txtDosyaYolu);
            this.tabProgramTanimlari.Controls.Add(this.label1);
            this.tabProgramTanimlari.Location = new System.Drawing.Point(4, 25);
            this.tabProgramTanimlari.Name = "tabProgramTanimlari";
            this.tabProgramTanimlari.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgramTanimlari.Size = new System.Drawing.Size(645, 453);
            this.tabProgramTanimlari.TabIndex = 0;
            this.tabProgramTanimlari.Text = "PROGRAM TANIMLARI";
            this.tabProgramTanimlari.UseVisualStyleBackColor = true;
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.Red;
            this.btnDurdur.ForeColor = System.Drawing.Color.White;
            this.btnDurdur.Location = new System.Drawing.Point(326, 356);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(222, 49);
            this.btnDurdur.TabIndex = 7;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnCalistir
            // 
            this.btnCalistir.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCalistir.ForeColor = System.Drawing.Color.Blue;
            this.btnCalistir.Location = new System.Drawing.Point(85, 356);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(222, 49);
            this.btnCalistir.TabIndex = 6;
            this.btnCalistir.Text = "BAŞLAT";
            this.btnCalistir.UseVisualStyleBackColor = false;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDurum.Location = new System.Drawing.Point(202, 242);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(15, 20);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(9, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "DURUM:";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(206, 151);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(222, 49);
            this.btnOnayla.TabIndex = 3;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnProgramSec
            // 
            this.btnProgramSec.Location = new System.Drawing.Point(509, 107);
            this.btnProgramSec.Name = "btnProgramSec";
            this.btnProgramSec.Size = new System.Drawing.Size(112, 24);
            this.btnProgramSec.TabIndex = 2;
            this.btnProgramSec.Text = "GÖZAT";
            this.btnProgramSec.UseVisualStyleBackColor = true;
            this.btnProgramSec.Click += new System.EventHandler(this.btnProgramSec_Click);
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(193, 108);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(302, 22);
            this.txtDosyaYolu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAM YOLU:";
            // 
            // tabZamanTanimlari
            // 
            this.tabZamanTanimlari.Controls.Add(this.label7);
            this.tabZamanTanimlari.Controls.Add(this.cmbTanimliZamanGun);
            this.tabZamanTanimlari.Controls.Add(this.listViewTanimliZamanlar);
            this.tabZamanTanimlari.Controls.Add(this.label6);
            this.tabZamanTanimlari.Controls.Add(this.btnZamanEkle);
            this.tabZamanTanimlari.Controls.Add(this.txtZamanEkleDakika);
            this.tabZamanTanimlari.Controls.Add(this.label5);
            this.tabZamanTanimlari.Controls.Add(this.txtZamanEkleSaat);
            this.tabZamanTanimlari.Controls.Add(this.label4);
            this.tabZamanTanimlari.Controls.Add(this.label3);
            this.tabZamanTanimlari.Controls.Add(this.cmbZamanTanimlaGun);
            this.tabZamanTanimlari.Controls.Add(this.label2);
            this.tabZamanTanimlari.Location = new System.Drawing.Point(4, 25);
            this.tabZamanTanimlari.Name = "tabZamanTanimlari";
            this.tabZamanTanimlari.Padding = new System.Windows.Forms.Padding(3);
            this.tabZamanTanimlari.Size = new System.Drawing.Size(645, 453);
            this.tabZamanTanimlari.TabIndex = 1;
            this.tabZamanTanimlari.Text = "ZAMAN TANIMLARI";
            this.tabZamanTanimlari.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(65, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "GÜN FİLTRELEMESİ:";
            // 
            // cmbTanimliZamanGun
            // 
            this.cmbTanimliZamanGun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTanimliZamanGun.FormattingEnabled = true;
            this.cmbTanimliZamanGun.Location = new System.Drawing.Point(281, 161);
            this.cmbTanimliZamanGun.Name = "cmbTanimliZamanGun";
            this.cmbTanimliZamanGun.Size = new System.Drawing.Size(137, 24);
            this.cmbTanimliZamanGun.TabIndex = 11;
            this.cmbTanimliZamanGun.SelectedIndexChanged += new System.EventHandler(this.cmbTanimliZamanGun_SelectedIndexChanged);
            // 
            // listViewTanimliZamanlar
            // 
            this.listViewTanimliZamanlar.Location = new System.Drawing.Point(26, 203);
            this.listViewTanimliZamanlar.Name = "listViewTanimliZamanlar";
            this.listViewTanimliZamanlar.Size = new System.Drawing.Size(594, 228);
            this.listViewTanimliZamanlar.TabIndex = 10;
            this.listViewTanimliZamanlar.TileSize = new System.Drawing.Size(400, 36);
            this.listViewTanimliZamanlar.UseCompatibleStateImageBehavior = false;
            this.listViewTanimliZamanlar.View = System.Windows.Forms.View.List;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(8, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "TANIMLI ZAMANLAR:";
            // 
            // btnZamanEkle
            // 
            this.btnZamanEkle.Location = new System.Drawing.Point(527, 54);
            this.btnZamanEkle.Name = "btnZamanEkle";
            this.btnZamanEkle.Size = new System.Drawing.Size(75, 37);
            this.btnZamanEkle.TabIndex = 8;
            this.btnZamanEkle.Text = "EKLE";
            this.btnZamanEkle.UseVisualStyleBackColor = true;
            this.btnZamanEkle.Click += new System.EventHandler(this.btnZamanEkle_Click);
            // 
            // txtZamanEkleDakika
            // 
            this.txtZamanEkleDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtZamanEkleDakika.Location = new System.Drawing.Point(444, 61);
            this.txtZamanEkleDakika.Name = "txtZamanEkleDakika";
            this.txtZamanEkleDakika.Size = new System.Drawing.Size(45, 24);
            this.txtZamanEkleDakika.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(419, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = ":";
            // 
            // txtZamanEkleSaat
            // 
            this.txtZamanEkleSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtZamanEkleSaat.Location = new System.Drawing.Point(372, 61);
            this.txtZamanEkleSaat.Name = "txtZamanEkleSaat";
            this.txtZamanEkleSaat.Size = new System.Drawing.Size(45, 24);
            this.txtZamanEkleSaat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(285, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ZAMAN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(50, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "GÜN:";
            // 
            // cmbZamanTanimlaGun
            // 
            this.cmbZamanTanimlaGun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZamanTanimlaGun.FormattingEnabled = true;
            this.cmbZamanTanimlaGun.Location = new System.Drawing.Point(114, 59);
            this.cmbZamanTanimlaGun.Name = "cmbZamanTanimlaGun";
            this.cmbZamanTanimlaGun.Size = new System.Drawing.Size(137, 24);
            this.cmbZamanTanimlaGun.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZAMAN TANIMLA:";
            // 
            // tabGecmis
            // 
            this.tabGecmis.Controls.Add(this.btnGecmisFiltrele);
            this.tabGecmis.Controls.Add(this.gecmisTarih2);
            this.tabGecmis.Controls.Add(this.label9);
            this.tabGecmis.Controls.Add(this.gecmisTarih1);
            this.tabGecmis.Controls.Add(this.listViewGecmis);
            this.tabGecmis.Controls.Add(this.label8);
            this.tabGecmis.Location = new System.Drawing.Point(4, 25);
            this.tabGecmis.Name = "tabGecmis";
            this.tabGecmis.Padding = new System.Windows.Forms.Padding(3);
            this.tabGecmis.Size = new System.Drawing.Size(645, 453);
            this.tabGecmis.TabIndex = 2;
            this.tabGecmis.Text = "GEÇMİŞ";
            this.tabGecmis.UseVisualStyleBackColor = true;
            // 
            // btnGecmisFiltrele
            // 
            this.btnGecmisFiltrele.Location = new System.Drawing.Point(503, 55);
            this.btnGecmisFiltrele.Name = "btnGecmisFiltrele";
            this.btnGecmisFiltrele.Size = new System.Drawing.Size(96, 26);
            this.btnGecmisFiltrele.TabIndex = 15;
            this.btnGecmisFiltrele.Text = "FİLTRELE";
            this.btnGecmisFiltrele.UseVisualStyleBackColor = true;
            // 
            // gecmisTarih2
            // 
            this.gecmisTarih2.Location = new System.Drawing.Point(280, 57);
            this.gecmisTarih2.Name = "gecmisTarih2";
            this.gecmisTarih2.Size = new System.Drawing.Size(200, 22);
            this.gecmisTarih2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(254, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "-";
            // 
            // gecmisTarih1
            // 
            this.gecmisTarih1.Location = new System.Drawing.Point(48, 57);
            this.gecmisTarih1.Name = "gecmisTarih1";
            this.gecmisTarih1.Size = new System.Drawing.Size(200, 22);
            this.gecmisTarih1.TabIndex = 12;
            // 
            // listViewGecmis
            // 
            this.listViewGecmis.Location = new System.Drawing.Point(24, 103);
            this.listViewGecmis.Name = "listViewGecmis";
            this.listViewGecmis.Size = new System.Drawing.Size(594, 328);
            this.listViewGecmis.TabIndex = 11;
            this.listViewGecmis.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(20, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "PROGRAMIN ÇALIŞMA GEÇMİŞİ:";
            // 
            // FormZamanliProgramCalistirici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 482);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FormZamanliProgramCalistirici";
            this.Text = "Zamanlı Program Çalıştırıcı";
            this.Load += new System.EventHandler(this.FormZamanliProgramCalistirici_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabProgramTanimlari.ResumeLayout(false);
            this.tabProgramTanimlari.PerformLayout();
            this.tabZamanTanimlari.ResumeLayout(false);
            this.tabZamanTanimlari.PerformLayout();
            this.tabGecmis.ResumeLayout(false);
            this.tabGecmis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProgramTanimlari;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnProgramSec;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabZamanTanimlari;
        private System.Windows.Forms.TabPage tabGecmis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTanimliZamanGun;
        private System.Windows.Forms.ListView listViewTanimliZamanlar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnZamanEkle;
        private System.Windows.Forms.TextBox txtZamanEkleDakika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZamanEkleSaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbZamanTanimlaGun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGecmisFiltrele;
        private System.Windows.Forms.DateTimePicker gecmisTarih2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker gecmisTarih1;
        private System.Windows.Forms.ListView listViewGecmis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label10;
    }
}

