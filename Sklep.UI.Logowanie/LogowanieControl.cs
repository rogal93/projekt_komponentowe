using Contract;
using System;
using System.Windows.Forms;

namespace Sklep.UI.Logowanie
{
    public partial class LogowanieControl : UserControl
    {
        #region pola

        public IUżytkownik uzytkownik;
        private IFunkcjeAdministracyjne adminFunkcje;
        private IFunkcjeUżytkownika funkcjeUzytkownika;

        #endregion

        #region konstruktor

        public LogowanieControl(IUżytkownik uzytkownik, IFunkcjeAdministracyjne adminFunkcje, IFunkcjeUżytkownika funkcjeUzytkownika)
        {
            this.uzytkownik = uzytkownik;
            this.adminFunkcje = adminFunkcje;
            this.funkcjeUzytkownika = funkcjeUzytkownika;
            
            InitializeComponent();
        }

        #endregion

        #region metody

        private void UstawZakladki()
        {
            if (uzytkownik.Uprawnienia == "magazynier")
            {
                ParentForm.MainMenuStrip.Items[3].Visible = false;
                ParentForm.MainMenuStrip.Items[4].Visible = false;
            }
            else if (uzytkownik.Uprawnienia == "kierownik")
            {
                ParentForm.MainMenuStrip.Items[4].Visible = false;
            }
        }

        private void StworzNoweKonto(string login, string haslo, string mail)
        {
            adminFunkcje.DodajPodmiot(mail, haslo, login, "magazynier");
        }

        #endregion

        #region przyciski

        private void rejestracjaBtn_Click(object sender, EventArgs e)
        {
            string login = rejLoginTxt.Text;
            string haslo = rejHasloTxt.Text;
            string mail = rejMailTxt.Text;
            if (haslo == potwierdzenieTxt.Text)
            {
                StworzNoweKonto(login, haslo, mail);
                rejLoginTxt.Text = "";
                rejHasloTxt.Text = "";
                rejMailTxt.Text = "";
                potwierdzenieTxt.Text = "";
            }
            else
            {
                MessageBox.Show("Niepoprawne potwierdzenie hasła.", "Błąd rejestracji");
            }
        }
        

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string login = loginTxt.Text;
            string haslo = hasloTxt.Text;
            
            uzytkownik = funkcjeUzytkownika.Zaloguj(login, haslo);
            if (uzytkownik == null)
            {
                MessageBox.Show("Logowanie nie powiodło się. Sprobuj jeszcze raz z innymi danymi.", "Błąd logowania");
                return;
            }

            UstawZakladki();

            if (uzytkownik != null)
            {
                this.Visible = false;
                this.Parent.Parent.Controls.Find("menu", false)[0].Visible = true;
                uzytkownik.Aktywny = true;
                ParentForm.Controls.Find("wylogujBtn", true)[0].Visible = true;
                ParentForm.Controls.Find("exitBtn", true)[0].Visible = false;

                loginTxt.Text = "";
                hasloTxt.Text = "";
            }
            else
            {
                MessageBox.Show("Próba logowania nie powiodła się. Błędna nazwa użytkownika lub hasło.", "Logowanie");
            }
        }

        #endregion

        #region radioButtony

        private void radioLogowanie_CheckedChanged(object sender, EventArgs e)
        {
            logowanieBox.Enabled = true;
            rejestracjaBox.Enabled = false;
        }

        private void radioRejestracja_CheckedChanged(object sender, EventArgs e)
        {
            logowanieBox.Enabled = false;
            rejestracjaBox.Enabled = true;
        }

        #endregion
    }
}
