using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamanliExeCalistirici
{
    public partial class FormZamanliProgramCalistirici : Form
    {
        public FormZamanliProgramCalistirici()
        {
            InitializeComponent();
        }

        private void FormZamanliProgramCalistirici_Load(object sender, EventArgs e)
        {
            Baslangic();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
