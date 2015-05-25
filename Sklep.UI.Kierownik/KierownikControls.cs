using Contract;
using Sklep.MagazynContract;
using Sklep.MagazynSklepu.Impl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sklep.UI.Kierownik
{
    public partial class KierownikControls : UserControl
    {
        #region pola

        private IUżytkownik uzytkownik;
        private IFunkcjeUżytkownika funkcjeUzytkownika;
        private IFunkcjeAdministracyjne admin;

        private List<IUżytkownik> pracownicy;
        private IMenadżerZamówień zamowienia;
        private KatalogProduktów katalog;
        private IZarządzanieProduktami<Produkt> zarzadzanie;

        #endregion

        #region konstruktor

        public KierownikControls(IUżytkownik uzytkownik, IFunkcjeUżytkownika funkcjeUzytkownika,
            IFunkcjeAdministracyjne admin, IPołączenieZBazą polaczenie)
        {
            this.uzytkownik = uzytkownik;
            this.funkcjeUzytkownika = funkcjeUzytkownika;
            this.admin = admin;
            katalog = new KatalogProduktów(polaczenie);
            zamowienia = new Zamówienia(katalog);
            zarzadzanie = new SystemZarządzania(katalog);

            pracownicy = new List<IUżytkownik>();
            InitializeComponent();

            cenaUpDown.DecimalPlaces = 2;
            cenaUpDown.Increment = 0.1M;
        }

        #endregion

        #region metody

        private void WyswietlProdukty()
        {
            zamowieniaListBox.Items.Clear();
            foreach (Produkt produkt in katalog.ListaProduktów)
            {
                zamowieniaListBox.Items.Add(produkt);
            }
            zamowieniaListBox.Refresh();
        }

        private void OdswiezMagazynierow()
        {
            pracownicy = funkcjeUzytkownika.Wyszukaj("");
            magazynierzyListBox.Items.Clear();
            foreach (IUżytkownik user in pracownicy)
            {
                if (user.Uprawnienia == "magazynier")
                {
                    magazynierzyListBox.Items.Add(user.NazwaUzytkownika);
                }
            }
            magazynierzyListBox.Refresh();
        }

        #endregion

        #region radioButtony

        private void magazynierzyRadio_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                usunDokupGroupBox.Enabled = false;
                dodawanieGroupBox.Enabled = false;
                zwolnieniaGroupBox.Enabled = true;
            }
            
            OdswiezMagazynierow();
        }

        private void usunDokupRadio_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                usunDokupGroupBox.Enabled = true;
                dodawanieGroupBox.Enabled = false;
                zwolnieniaGroupBox.Enabled = false;
            }

            WyswietlProdukty();
        }

        private void nowyRadio_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                usunDokupGroupBox.Enabled = false;
                dodawanieGroupBox.Enabled = true;
                zwolnieniaGroupBox.Enabled = false;
            }
        }

        #endregion

        #region przyciski

        private void zwolnijBtn_Click(object sender, EventArgs e)
        {
            if (magazynierzyListBox.SelectedItem.ToString() != "")
            {
                string nazwa = magazynierzyListBox.SelectedItem.ToString();
                DialogResult dialogResult = MessageBox.Show("Czy jesteś pewien, że chcesz zwolnić " + nazwa
                    + "?", "Zwolnienie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    admin.UsuńPodmiot((int)funkcjeUzytkownika.Wyszukaj(nazwa)[0].ID);
                    OdswiezMagazynierow();
                }
            }
            else
            {
                MessageBox.Show("Wybierz pracownika.", "Brak wyboru");
            }
        }



        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (nazwaTxt.Text != "" && liczbaUpDown.Value > 0 && cenaUpDown.Value > 0 &&
                kategoriaCombo.SelectedItem.ToString() != "" && data.Value > DateTime.Now)
            {
                string nazwa = nazwaTxt.Text;
                decimal cena = liczbaUpDown.Value;
                int liczba = (int)cenaUpDown.Value;
                string kategoria = kategoriaCombo.SelectedItem.ToString();
                string termin = data.Value.Day.ToString() + "-" + data.Value.Month.ToString() + "-" + data.Value.Year.ToString();

                katalog.DodajProdukt(new Produkt(nazwa, cena, liczba, kategoria, termin));
                MessageBox.Show("Dodano nowy produkt.", "Nowy produkt");

                nazwaTxt.Text = "";
                liczbaUpDown.Value = 0;
                cenaUpDown.Value = 0.00M;
            }
        }

        private void usunBtn_Click(object sender, EventArgs e)
        {
            string nazwa = zamowieniaListBox.SelectedItem.ToString();
            if (nazwa != "")
            {
                DialogResult dialogResult = MessageBox.Show("Czy jesteś pewien, że chcesz usunąć " + nazwa
                    + "?", "Usuwanie produktu", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    zamowienia.UsuńProdukt(zarzadzanie.WyszukajProdukt(nazwa));
                    MessageBox.Show("Usunięto produkt.", "Usuwanie");
                    WyswietlProdukty();
                }
            }
        }

        private void dokupBtn_Click(object sender, EventArgs e)
        {
            string nazwa = zamowieniaListBox.SelectedItem.ToString();
            if (nazwa != "")
            {
                short liczba = (short)dokupUpDown.Value;
                zamowienia.Zamów(zarzadzanie.WyszukajProdukt(nazwa), liczba);
                MessageBox.Show("Dokupiono produkt.", "Zamówienie");
                dokupUpDown.Value = 0;
            }
        }

        #endregion
    }
}

