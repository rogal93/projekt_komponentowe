using Contract;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sklep.UI.Newsletter
{
    public partial class NewsletterControl : UserControl
    {
        #region pola

        private INewsletterService news;
        private IUżytkownik uzytkownik;
        private IFunkcjeUżytkownika funkcjeUzytkownika;

        private List<IUżytkownik> grupaOdbiorcow;
        private List<string> odbiorcy;
        private string nadawca, haslo, temat, tresc;

        #endregion

        public NewsletterControl(INewsletterService news, IFunkcjeUżytkownika funkcjeUzytkownika)
        {
            odbiorcy = new List<string>();
            this.funkcjeUzytkownika = funkcjeUzytkownika;
            this.news = news;
            InitializeComponent();
        }

        #region metody

        private void UstawDaneDoWysylania()
        {
            nadawca = uzytkownik.Mail;
            haslo = hasloTxt.Text;
            temat = tematTxt.Text;
            tresc = trescTxt.Text;
        }

        private void UstawUzytkownika()
        {
            uzytkownik = ((Logowanie.LogowanieControl)Parent.Controls.Find("LogowanieControl", true)[0]).uzytkownik;
        }

        #endregion

        #region przyciski

        private void allWyslijBtn_Click(object sender, EventArgs e)
        {
            if (hasloTxt.Text != "")
            {
                UstawUzytkownika();
                UstawDaneDoWysylania();

                grupaOdbiorcow = funkcjeUzytkownika.Wyszukaj("");

                odbiorcy = new List<string>();
                foreach (var item in grupaOdbiorcow)
                {
                    odbiorcy.Add(item.Mail);
                }
                news.WyślijMaila(nadawca, haslo, odbiorcy, temat, tresc);
            }
            else
            {
                MessageBox.Show("Wpisz hasło do Twojego adresu poczty elektronicznej.", "Brak hasła");
            }

        }
        private void wyslijBtn_Click(object sender, EventArgs e)
        {
            UstawUzytkownika();
            UstawDaneDoWysylania();

            news.WyślijMaila(nadawca, haslo, odbiorcy, temat, tresc);
        }

        #endregion

        private void odbiorcaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            odbiorcy = new List<string>();
            foreach (IUżytkownik user in grupaOdbiorcow)
            {
                if (user.NazwaUzytkownika == odbiorcaCombo.SelectedItem.ToString())
                {
                    odbiorcy.Add(user.Mail);
                    break;
                }
            }

            wyslijBtn.Enabled = true;
        }

        #region radioButtony

        private void toAllRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (toAllRadio.Checked)
            {
                odbiorcaCombo.Enabled = false;
                allWyslijBtn.Enabled = true;
            }
        }

        private void jedenRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (jedenRadio.Checked)
            {
                odbiorcaCombo.Enabled = true;
                allWyslijBtn.Enabled = false;
            }
            grupaOdbiorcow = funkcjeUzytkownika.Wyszukaj("");

            if (odbiorcaCombo.Items.Count > 0)
            {
                for (int i = 0; i < odbiorcaCombo.Items.Count; i++)
                {
                    odbiorcaCombo.Items.RemoveAt(0);
                }
            }

            foreach (IUżytkownik user in grupaOdbiorcow)
            {
                odbiorcaCombo.Items.Add(user.NazwaUzytkownika);
            }
        }

        #endregion
    }
}
