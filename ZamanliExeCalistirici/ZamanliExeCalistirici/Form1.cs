using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ZamanliExeCalistirici
{
    public partial class FormZamanliProgramCalistirici : Form
    {
        List<Zaman> TanimliZamanlar;

        public FormZamanliProgramCalistirici()
        {
            InitializeComponent();
        }

        private void FormZamanliProgramCalistirici_Load(object sender, EventArgs e)
        {
            Baslangic();
            TanimliZamanlariCek();
        }

        private void TanimliZamanlariCek() // KAYIT DOSYASINDAN TANIMLANMIŞ ZAMANLARI AL
        {
            try
            {
                XMLOku();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void AnaFonksiyon()
        {
            while (true)
            {
                if (lblDurum.Text.Equals("DEAKTİF"))
                    return;
                if (string.IsNullOrEmpty(txtDosyaYolu.Text))
                    return;

            }
        }

        private void Baslangic()
        {
            try
            {
                ZamanTanimlaGunDoldurucu();
                ZamanTanimlamaFiltrelemeGunDoldurucu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void ZamanTanimlamaFiltrelemeGunDoldurucu() // TANIMLANMIŞ ZAMANLARI LİSTELEME FİLTRELEMESİ COMBOBOX
        {
            try
            {
                cmbTanimliZamanGun.Items.Add("TÜM GÜNLER");
                cmbTanimliZamanGun.Items.Add("PAZARTESİ");
                cmbTanimliZamanGun.Items.Add("SALI");
                cmbTanimliZamanGun.Items.Add("ÇARŞAMBA");
                cmbTanimliZamanGun.Items.Add("PERŞEMBE");
                cmbTanimliZamanGun.Items.Add("CUMA");
                cmbTanimliZamanGun.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void ZamanTanimlaGunDoldurucu() // ZAMAN TANIMLAMADA BULUNAN COMBOBOXA GÜNLERİ EKLEMEKTEDİR
        {
            try
            {
                cmbZamanTanimlaGun.Items.Add("PAZARTESİ");
                cmbZamanTanimlaGun.Items.Add("SALI");
                cmbZamanTanimlaGun.Items.Add("ÇARŞAMBA");
                cmbZamanTanimlaGun.Items.Add("PERŞEMBE");
                cmbZamanTanimlaGun.Items.Add("CUMA");
                cmbZamanTanimlaGun.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnProgramSec_Click(object sender, EventArgs e) // GÖZAT BUTONUNA BASINCA AÇILAN EKRANDIR
        {
            try
            {
                OpenFileDialog programSecimEkrani = new OpenFileDialog();
                programSecimEkrani.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                if (programSecimEkrani.ShowDialog() == DialogResult.OK)
                {
                    txtDosyaYolu.Text = programSecimEkrani.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            
        }

        private void btnOnayla_Click(object sender, EventArgs e) // ÇALIŞACAK PROGRAMIN SEÇİLİP KONTROL EDİLDİĞİ ALANDIR
        {
            try
            {
                if (string.IsNullOrEmpty(txtDosyaYolu.Text))
                {
                    MessageBox.Show("ÇALIŞACAK PROGRAMIN DOSYA YOLUNU BELİRTİNİZ");
                    btnProgramSec.Focus();
                    return;
                }
                XMLGuncelle();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnZamanEkle_Click(object sender, EventArgs e) // TANIMLA ZAMAN EKLE BUTONUNA BASINCA ÇALIŞACAK KISIMDIR
        {
            try
            {
                if (txtZamanEkleSaat.Text.Equals("24"))
                    txtZamanEkleSaat.Text = "0";
                if (Convert.ToInt32(txtZamanEkleSaat.Text) > 24) // SAAT 24'DEN BÜYÜK OLAMAZ
                {
                    MessageBox.Show("EKLENECEK ZAMANIN SAAT BİLGİSİ 24'DEN KÜÇÜK OLMALIDIR");
                    txtZamanEkleSaat.Focus();
                    return;
                }
                if (Convert.ToInt32(txtZamanEkleDakika.Text) > 59) // DAKİKA 59DAN BÜYÜK OLAMAZ
                {
                    MessageBox.Show("EKLENECEK ZAMANIN DAKİKA BİLGİSİ 60'DAN KÜÇÜK OLMALIDIR");
                    txtZamanEkleDakika.Focus();
                    return;
                }
                Zaman EklenecekZaman = new Zaman(cmbZamanTanimlaGun.SelectedIndex.ToString(), txtZamanEkleSaat.Text, txtZamanEkleDakika.Text);
                TanimliZamanlar.Add(EklenecekZaman);
                XMLGuncelle();
                ListeGuncelleyici();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void XMLGuncelle()
        {
            XmlTextWriter yaz = new XmlTextWriter("ZamanliExeCalistir.xml", System.Text.UTF8Encoding.UTF8);
            yaz.Formatting = Formatting.Indented;
            try
            {
                yaz.WriteStartDocument(); 
                yaz.WriteStartElement("TanimliExe");
                yaz.WriteStartElement("Bilgiler");
                yaz.WriteStartElement("TanimliZamanlar");
                foreach(Zaman zaman in TanimliZamanlar)
                {
                    yaz.WriteElementString("Gün", zaman.Gun.ToString());
                    yaz.WriteElementString("Saat", zaman.Saat.ToString());
                    yaz.WriteElementString("Dakika", zaman.Dakika.ToString());
                }
                yaz.WriteEndElement();
                yaz.WriteStartElement("DosyaYolu");
                yaz.WriteElementString("Yol", txtDosyaYolu.Text);
                yaz.WriteEndElement();
                yaz.WriteEndElement();
                yaz.WriteStartElement("Aktiflik");
                yaz.WriteElementString("Durum", lblDurum.Text);
                yaz.WriteEndElement();
                yaz.WriteEndElement();
                yaz.Close();
                Console.WriteLine("XML dosyası oluşturuldu ve veriler eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void ListeGuncelleyici()
        {
            try
            {
                listViewTanimliZamanlar.Items.Clear();
                TanimliZamanlar = TanimliZamanlar.OrderBy(o => o.Gun).ToList();
                foreach (Zaman zaman in TanimliZamanlar)
                {
                    switch (cmbTanimliZamanGun.SelectedIndex)
                    {
                        case 0:
                            listViewTanimliZamanlar.Items.Add(GunuAl(zaman.Gun) + "   " + zaman.Saat + ":" + zaman.Dakika);
                            break;
                        case 1:
                            if (zaman.Gun == 0)
                            {
                                listViewTanimliZamanlar.Items.Add(GunuAl(zaman.Gun) + "   " + zaman.Saat + ":" + zaman.Dakika);
                            }
                            break;
                        case 2:
                            if (zaman.Gun == 1)
                            {
                                listViewTanimliZamanlar.Items.Add(GunuAl(zaman.Gun) + "   " + zaman.Saat + ":" + zaman.Dakika);
                            }
                            break;
                        case 3:
                            if (zaman.Gun == 2)
                            {
                                listViewTanimliZamanlar.Items.Add(GunuAl(zaman.Gun) + "   " + zaman.Saat + ":" + zaman.Dakika);
                            }
                            break;
                        case 4:
                            if (zaman.Gun == 3)
                            {
                                listViewTanimliZamanlar.Items.Add(GunuAl(zaman.Gun) + "   " + zaman.Saat + ":" + zaman.Dakika);
                            }
                            break;
                        case 5:
                            if (zaman.Gun == 4)
                            {
                                listViewTanimliZamanlar.Items.Add(GunuAl(zaman.Gun) + "   " + zaman.Saat + ":" + zaman.Dakika);
                            }
                            break;
                        case 6:
                            if (zaman.Gun == 5)
                            {
                                listViewTanimliZamanlar.Items.Add(GunuAl(zaman.Gun) + "   " + zaman.Saat + ":" + zaman.Dakika);
                            }
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private string GunuAl(int i)
        {
            switch (i)
            {
                case 0:
                    return "PAZARTESİ";
                case 1:
                    return "SALI";
                case 2:
                    return "ÇARŞAMBA";
                case 3:
                    return "PERŞEMBE";
                case 4:
                    return "CUMA";
            }
            return "";
        }

        private void XMLOku()
        {
            try
            {
                TanimliZamanlar = new List<Zaman>();
                XmlTextReader oku = new XmlTextReader("ZamanliExeCalistir.xml");
                try
                {
                    string gun = "-1";
                    string saat = "-1";
                    string dakika = "-1";

                    while (oku.Read()) //Dosyadaki veriler tükenene kadar okuma işlemi devam eder.
                    {
                        if (oku.NodeType == XmlNodeType.Element)//Düğümlerdeki veri element türünde ise okuma gerçekleşir.
                        {
                            switch (oku.Name)//Elementlerin isimlerine göre okuma işlemi gerçekleşir.
                            {
                                case "Yol":
                                    txtDosyaYolu.Text = oku.ReadString();
                                    break;
                                case "Durum":
                                    lblDurum.Text = oku.ReadString();
                                    if (lblDurum.Text.Equals("AKTİF"))
                                        lblDurum.ForeColor = Color.Green;
                                    else
                                        lblDurum.ForeColor = Color.Red;
                                    break;
                                case "Gün":
                                    gun = oku.ReadString();
                                    break;
                                case "Saat":
                                    saat = oku.ReadString();
                                    break;
                                case "Dakika":
                                    dakika = oku.ReadString();
                                    break;
                            }
                        }
                        if((!string.Equals(gun,"-1") && (!string.Equals(saat,"-1")) && (!string.Equals(dakika,"-1"))))
                        {
                            TanimliZamanlar.Add(new Zaman(gun, saat, dakika));
                            saat = "-1";
                            dakika = "-1";
                            gun = "-1";
                        }
                    }
                    oku.Close();
                    ListeGuncelleyici();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            try
            {
                lblDurum.ForeColor = Color.Green;
                lblDurum.Text = "AKTİF";
                XMLGuncelle();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lblDurum.ForeColor = Color.Red;
                lblDurum.Text = "DEAKTİF";
                XMLGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void cmbTanimliZamanGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TanimliZamanlar == null)
                return;
            if (TanimliZamanlar.Count == 0)
                return;
            ListeGuncelleyici();
        }
    }
}
