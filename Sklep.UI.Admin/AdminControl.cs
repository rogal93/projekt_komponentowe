using Contract;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sklep.UI.Admin
{
    public partial class AdminControl : UserControl
    {
        #region pola

        private IUżytkownik uzytkownik;
        private IFunkcjeUżytkownika funkcjeUzytkownika;
        private IFunkcjeAdministracyjne admin;
        private IPołączenieZBazą polaczenie;

        private List<IUżytkownik> pracownicy;

        #endregion

        #region konstruktor

        public AdminControl(IUżytkownik uzytkownik, IFunkcjeUżytkownika funkcjeUzytkownika,
            IFunkcjeAdministracyjne admin, IPołączenieZBazą polaczenie)
        {
            this.uzytkownik = uzytkownik;
            this.funkcjeUzytkownika = funkcjeUzytkownika;
            this.admin = admin;
            this.polaczenie = polaczenie;

            InitializeComponent();

            OdswiezPracownikow();
        }

        #endregion

        #region metoda

        public void OdswiezPracownikow()
        {
            pracownicy = funkcjeUzytkownika.Wyszukaj("");
            pracownicyListBox.Items.Clear();
            foreach (IUżytkownik user in pracownicy)
            {
                pracownicyListBox.Items.Add(user.NazwaUzytkownika);
            }
            pracownicyListBox.Refresh();
        }

        #endregion

        #region listBox

        private void pracownicyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            edycjaBox.Enabled = true;
            uzytkownik = funkcjeUzytkownika.Wyszukaj(pracownicyListBox.SelectedItem.ToString())[0];
            nazwaTxt.Text = uzytkownik.NazwaUzytkownika;
            hasloTxt.Text = uzytkownik.Haslo;
            mailTxt.Text = uzytkownik.Mail;
            if (uzytkownik.Uprawnienia == "magazynier")
            {
                uprawnieniaCombo.SelectedItem = uprawnieniaCombo.Items[2];
            }
            else if (uzytkownik.Uprawnienia == "kierownik")
            {
                uprawnieniaCombo.SelectedItem = uprawnieniaCombo.Items[1];
            }
            else
            {
                uprawnieniaCombo.SelectedItem = uprawnieniaCombo.Items[0];
            }
        }

        #endregion

        #region przyciski

        private void edytujBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewien, że chcesz edytować dane użytkownika: " + uzytkownik.NazwaUzytkownika + "?",
                "Edycja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                admin.UsuńPodmiot((int)uzytkownik.ID);
                admin.DodajPodmiot(mailTxt.Text, hasloTxt.Text, nazwaTxt.Text, uprawnieniaCombo.SelectedItem.ToString());
                OdswiezPracownikow();
            }
        }

        private void zwolnijBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewien, że chcesz zwolnić " + uzytkownik.NazwaUzytkownika + "?",
                "Zwolnienie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                admin.UsuńPodmiot((int)uzytkownik.ID);
                OdswiezPracownikow();
            }
        }

        #endregion
    }
}
