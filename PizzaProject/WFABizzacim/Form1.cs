using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFABizzacim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kenar =string.Empty;
        List<Pizza> _pizzaList;
        List<Ebatlar> _ebatList;
        Siparis siparis;
        private void Form1_Load(object sender, EventArgs e)
        {

            #region Ebat


            _ebatList = new List<Ebatlar>();
            _ebatList.Add(new Ebatlar() { eName = "Küçük", ePara = 1 });
            _ebatList.Add(new Ebatlar() { eName = "Orta", ePara = 1.2m });
            _ebatList.Add(new Ebatlar() { eName = "Büyük", ePara = 1.75m });
            _ebatList.Add(new Ebatlar() { eName = "Maxi", ePara = 2 });
            #endregion
            #region Pizza List

            _pizzaList = new List<Pizza>();

            _pizzaList.Add(new Pizza() { pName = "Klasik", pFiyat = 14 });
            _pizzaList.Add(new Pizza() { pName = "Karışık", pFiyat = 17 });
            _pizzaList.Add(new Pizza() { pName = "Extravaganza", pFiyat = 21 });
            _pizzaList.Add(new Pizza() { pName = "İtalione", pFiyat = 20 });
            _pizzaList.Add(new Pizza() { pName = "Turkish", pFiyat = 23 });
            _pizzaList.Add(new Pizza() { pName = "Tuna", pFiyat = 18 });
            _pizzaList.Add(new Pizza() { pName = "Seafeed", pFiyat = 19 });
            _pizzaList.Add(new Pizza() { pName = "Kastamonu", pFiyat = 20 });
            _pizzaList.Add(new Pizza() { pName = "Calypso", pFiyat = 24 });
            _pizzaList.Add(new Pizza() { pName = "Akdeniz", pFiyat = 21 });
            _pizzaList.Add(new Pizza() { pName = "Karadeniz", pFiyat = 21 });

            #endregion

            _ebatList.ToList().ForEach(x =>
            {
                cmbEbat.Items.Add(x.eName);
            });

            _pizzaList.ToList().ForEach(x =>
            {
                lstPizza.Items.Add(x.pName);
            });
        }

        private void btnSiparisOnay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(siparis.SiparisOnayla());
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string ebatAl = cmbEbat.Items[cmbEbat.SelectedIndex].ToString();
                string pazzaAl = lstPizza.Items[lstPizza.SelectedIndex].ToString();
                StringBuilder malzeAdd = new StringBuilder();
                secilenMalzeme().ForEach(x =>
                {
                    malzeAdd.Append(x);
                });

                siparisHesapla();
                toplamFiyat += topla;
                lbltoplamTutar.Text = toplamFiyat.ToString();
                List<string> malzemeler = secilenMalzeme();
                string duzen = string.Format("{0},{1},{2},{3} : {4} x {5} =  {6}",
                                             ebatAl,
                                             pazzaAl,
                                             KenarKontrol(),
                                             malzeAdd.ToString(),
                                             numerikAdet,
                                             fiyat,
                                             topla);

                lstSiparisler.Items.Add(duzen);
                adet += 1;
                siparis = new Siparis(adet, lbltoplamTutar.Text);
                Temizle();
            }
            catch
            {
                MessageBox.Show("Lütfen Seçimleriniz Yapın");
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            txtTutar.Clear();
            siparisHesapla();
        }
        string KenarKontrol()
        {
            if (rdkalinKenar.Checked)
            {
                return "Kalın Kenar";
            }
            return "İnce Kenar";
        }

        decimal ebatFiyat = 0;
        decimal pizzaFiyat = 0;
        decimal toplamFiyat = 0m;
        decimal topla = 0m;
        decimal fiyat = 0m;
        int adet = 0;
        void Hesap(string ebat, string pizaa)
        {
            try
            {

                ebatFiyat = _ebatList.FirstOrDefault(x => x.eName == ebat).ePara;
                pizzaFiyat = _pizzaList.FirstOrDefault(x => x.pName == pizaa).pFiyat;
            }
            catch
            {
                MessageBox.Show("Lütfen Seçimlerinizi Yapınız");
            }
        }
        
    
        private void Temizle()
        {
            numerikAdet.Value = 1;
            txtTutar.Text = "0";
            rdinceKenar.Checked = true;
            rdkalinKenar.Checked = false;
            lstPizza.SelectedIndex = 0;
            cmbEbat.SelectedIndex = 0;
            foreach (CheckBox item in grpMazlemeler.Controls)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                }
            }

        }
        private List<string> secilenMalzeme()
        {
            List<string> secilen = new List<string>(); ;
            foreach (CheckBox item in grpMazlemeler.Controls)
            {
                if (item.Checked)
                {
                    secilen.Add(item.Text + ",");
                }
            }
            return secilen;

        }

       
        void siparisHesapla()
        {
            try
            {
                string ebatAl = cmbEbat.Items[cmbEbat.SelectedIndex].ToString();
                string pazzaAl = lstPizza.Items[lstPizza.SelectedIndex].ToString();
                Hesap(ebatAl, pazzaAl);

                int adet = Convert.ToInt32(numerikAdet.Value);
                fiyat = ebatFiyat + pizzaFiyat;
                topla = adet * fiyat;

                txtTutar.Text = topla.ToString();
            }
            catch
            {
                MessageBox.Show("Seçimlerinizi Doğru Yapın");

            }
        }

       

    }

    public class Siparis
    {
        public Siparis()
        { }
        int adet = 0;
        string tutar = "";
        public Siparis(int adet, string tutar)
        {
            this.adet = adet;
            this.tutar= tutar;

        }
        public string SiparisOnayla()
        {
            return string.Format("Toplam {0} Adet siparişinizin \n {1} TL Tutarındadır",adet,tutar);
        }


    }

    public class Ebatlar
    {
        public string eName { get; set; }
        public decimal ePara { get; set; }
    }
    public class Pizza
    {
        public string pName { get; set; }
        public decimal pFiyat { get; set; }
    }
}
