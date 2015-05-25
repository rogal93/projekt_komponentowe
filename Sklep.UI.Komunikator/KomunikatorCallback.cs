using Sklep.UI.Komunikator.UslugaKomunikatora;
using System.ServiceModel;
using System.Windows.Forms;

namespace Sklep.UI.Komunikator
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class KomunikatorCallback : ICzatServiceCallback
    {
        private RichTextBox textBox;
        public KomunikatorCallback(RichTextBox textBox)
        {
            this.textBox = textBox;
        }

        public void WyświetlWiadomość(string nadawca, string treść)
        {
            textBox.Text += nadawca + ": " + treść + "\r\n";
            textBox.Update();
            textBox.Refresh();
        }
    }
}
