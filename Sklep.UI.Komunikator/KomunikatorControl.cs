using Contract;
using Czat.Contract;
using Sklep.UI.Komunikator.UslugaKomunikatora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;

namespace Sklep.UI.Komunikator
{
    public partial class KomunikatorControl: UserControl
    {
        #region pola

        private KomunikatorCallback callbackObject;
        private InstanceContext clientContext;
        private CzatServiceClient chatProxy;
        private List<string> imiona;
        public bool polaczony = false;

        private Sklep.UI.Komunikator.UslugaKomunikatora.ICzatService czat;
        private IUżytkownik uzytkownik;

        #endregion

        #region konstruktor

        public KomunikatorControl(Sklep.UI.Komunikator.UslugaKomunikatora.ICzatService czat)
        {
            this.czat = czat;

            InitializeComponent();

            callbackObject = new KomunikatorCallback(przychodzaceTxt);
            clientContext = new InstanceContext(callbackObject);
            chatProxy = new CzatServiceClient(clientContext);
        }

        #endregion

        #region przyciski

        private void odbiorcaBtn_Click(object sender, EventArgs e)
        {
            if (odbiorcaCombo.Items.Count > 0)
            {
                for (int i = 0; i < odbiorcaCombo.Items.Count; i++)
                {
                    odbiorcaCombo.Items.RemoveAt(0);
                }
            }
            imiona = chatProxy.getImiona().ToArray().ToList();
            foreach (var imie in imiona)
            {
                if (imie != uzytkownik.NazwaUzytkownika)
                {
                    odbiorcaCombo.Items.Add(imie);
                }
            }
        }

        private void wyslijBtn_Click(object sender, EventArgs e)
        {
            string tresc = wysylanieTxt.Text;
            przychodzaceTxt.Text += "Ja: " + tresc + "\r\n";
            chatProxy.WyślijWiadomość(tresc, odbiorcaCombo.SelectedItem.ToString());
            wysylanieTxt.Text = "";
        }

        private void polaczBtn_Click(object sender, EventArgs e)
        {
            (sender as Button).Visible = false;
            polaczony = true;
            uzytkownik = ((Logowanie.LogowanieControl)Parent.Controls.Find("LogowanieControl", true)[0]).uzytkownik;
            chatProxy.Połącz(uzytkownik.NazwaUzytkownika);

            odbiorcaBtn.Enabled = true;
            odbiorcaCombo.Enabled = true;
        }

        #endregion

        public void Rozlacz()
        {
            chatProxy.Rozłącz();
        }

        private void odbiorcaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            wysylanieTxt.Enabled = true;
            wyslijBtn.Enabled = true;
        }

        private void wysylanieTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wyslijBtn_Click(sender, e);
            }
        }

        private void przychodzaceTxt_TextChanged(object sender, EventArgs e)
        {
            przychodzaceTxt.SelectionStart = przychodzaceTxt.TextLength;
            przychodzaceTxt.ScrollToCaret();
        }

    }
}
