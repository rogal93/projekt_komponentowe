using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sklep.UI.Main
{
    public partial class MainWindow : Form
    {
        private Control news, czat, logowanie, magazynier, kierownik, admin;

        private List<Control> listaKontrolek;

        #region konstruktor

        public MainWindow(Control news, Control czat, Control logowanie,
            Control magazynier, Control kierownik, Control admin)
        {
            this.news = news;
            this.czat = czat;
            this.logowanie = logowanie;
            this.magazynier = magazynier;
            this.kierownik = kierownik;
            this.admin = admin;

            listaKontrolek = new List<Control> { news, czat, logowanie, magazynier, kierownik, admin };

            InitializeComponent();

            menu.Visible = false;

            DodajKontrolkiDoPanela();
            PokazKontrolke(logowanie);
        }

        #endregion

        #region metody

        private void PokazKontrolke(Control kontrolka)
        {
            UkryjKontrolki();
            kontrolka.Visible = true;
        }

        private void UkryjKontrolki()
        {
            foreach (Control item in listaKontrolek)
            {
                item.Visible = false;
            }
        }

        private void DodajKontrolkiDoPanela()
        {
            foreach (Control item in listaKontrolek)
            {
                panel.Controls.Add(item);
            }
        }

        private void Rozlacz()
        {
            if (((Komunikator.KomunikatorControl)czat).polaczony)
            {
                ((Komunikator.KomunikatorControl)czat).polaczony = false;
                ((Komunikator.KomunikatorControl)czat).Rozlacz();
            }
        }

        #endregion

        #region Menu
        private void UsunPodkreslenia()
        {
            newsletterToolStripMenuItem.Font = new Font(newsletterToolStripMenuItem.Font, FontStyle.Regular);
            komunikatorToolStripMenuItem.Font = new Font(komunikatorToolStripMenuItem.Font, FontStyle.Regular);
            magazynierToolStripMenuItem.Font = new Font(magazynierToolStripMenuItem.Font, FontStyle.Regular);
            kierownikToolStripMenuItem.Font = new Font(kierownikToolStripMenuItem.Font, FontStyle.Regular);
            administratorToolStripMenuItem.Font = new Font(administratorToolStripMenuItem.Font, FontStyle.Regular);
        }
        private void newsletterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PokazKontrolke(news);
            UsunPodkreslenia();
            (sender as ToolStripMenuItem).Font = new Font((sender as ToolStripMenuItem).Font, FontStyle.Underline);
        }

        private void komunikatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PokazKontrolke(czat);
            UsunPodkreslenia();
            (sender as ToolStripMenuItem).Font = new Font((sender as ToolStripMenuItem).Font, FontStyle.Underline);
        }

        private void magazynierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PokazKontrolke(magazynier);
            UsunPodkreslenia();
            (sender as ToolStripMenuItem).Font = new Font((sender as ToolStripMenuItem).Font, FontStyle.Underline);
        }

        private void kierownikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PokazKontrolke(kierownik);
            UsunPodkreslenia();
            (sender as ToolStripMenuItem).Font = new Font((sender as ToolStripMenuItem).Font, FontStyle.Underline);
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PokazKontrolke(admin);
            UsunPodkreslenia();
            (sender as ToolStripMenuItem).Font = new Font((sender as ToolStripMenuItem).Font, FontStyle.Underline);
        }

        #endregion

        #region przyciski

        private void wylogujBtn_Click(object sender, EventArgs e)
        {
            Rozlacz();

            menu.Visible = false;
            UkryjKontrolki();
            PokazKontrolke(logowanie);

            wylogujBtn.Visible = false;
            exitBtn.Visible = true;

            Application.Restart();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Rozlacz();
            Application.Exit();
        }

        #endregion

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rozlacz();
        }
    }
}
