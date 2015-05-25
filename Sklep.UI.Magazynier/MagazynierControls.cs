using Contract;
using Sklep.MagazynContract;
using Sklep.MagazynSklepu.Impl;
using System;
using System.Windows.Forms;

namespace Sklep.UI.Magazynier
{
    public partial class MagazynierControls : UserControl
    {
        private IUżytkownik uzytkownik;

        private KatalogProduktów katalog;
        private IZarządzanieProduktami<Produkt> zarzadzanie;

        public MagazynierControls(IPołączenieZBazą połączenie, IUżytkownik uzytkownik)
        {
            this.uzytkownik = uzytkownik;
            this.katalog = new KatalogProduktów(połączenie);
            zarzadzanie = new SystemZarządzania(katalog);

            InitializeComponent();

            WyswietlProdukty();
        }

        private void WyswietlProdukty()
        {
            listBox1.Items.Clear();
            foreach (Produkt produkt in katalog.ListaProduktów)
            {
                listBox1.Items.Add(produkt);
            }
            listBox1.Refresh();
        }

        private void UstawUzytkownika()
        {
            uzytkownik = ((Logowanie.LogowanieControl)Parent.Controls.Find("LogowanieControl", true)[0]).uzytkownik;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pozostalo = zarzadzanie.WyszukajProdukt(listBox1.SelectedItem.ToString()).Liczba;
            pozostaloLabel.Text = "Pozostało: " + pozostalo.ToString();
            pobierzUpDown.Maximum = pozostalo;
        }

        private void pobierzBtn_Click(object sender, EventArgs e)
        {
            zarzadzanie.WynieśZMagazynu(zarzadzanie.WyszukajProdukt(listBox1.SelectedItem.ToString()), (short)pobierzUpDown.Value);
            UstawUzytkownika();
            if (pobierzUpDown.Value == pobierzUpDown.Maximum)
            {
                MessageBox.Show("Ostatnie sztuki. Poinformuj współpracowników aby złożyć zamówienie na towar.", "Wyczerpanie zapasów");
            }
            listBox1_SelectedIndexChanged(sender, e);
        }
    }
}
