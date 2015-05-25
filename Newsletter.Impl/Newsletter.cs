using Contract;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Newsletter.Impl
{
    public class Newsletter : INewsletterService
    {
        public void WyślijMaila(string nadawca, string hasło, List<string> odbiorcy, string temat, string treść)
        {
            MailMessage wiadomosc = new MailMessage();
            wiadomosc.From = new MailAddress(nadawca);

            foreach (string odbiorca in odbiorcy)
            {
                try
                {
                    wiadomosc.To.Add(new MailAddress(odbiorca));
                }
                catch (FormatException)
                { 
                    MessageBox.Show("Zły format adresu mailowego: " + odbiorca + ". Nie wysłano maila.", "Błędny mail");
                }
            }
            wiadomosc.Subject = temat;
            wiadomosc.Body = treść;

            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(nadawca, hasło);
                smtp.EnableSsl = true;

                smtp.Send(wiadomosc);

                MessageBox.Show("Wysyłanie zakończone pomyślnie.", "Wysłano");
            }
            catch (Exception)
            {
                MessageBox.Show("Nie ma żadnego adresata.", "Brak adresatów");
            }
        }
    }
}
