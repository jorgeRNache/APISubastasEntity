using System.Net;
using System.Net.Mail;

namespace ApiSubastasEntity.Utilidades
{
    public class Comunicaciones
    {

        private static readonly Lazy<Comunicaciones> instancia =
        new Lazy<Comunicaciones>(() => new Comunicaciones());

        public static Comunicaciones Instancia => instancia.Value;

        public async void EnviarEmail(string msg)
        {
            var miCorreo = "thejrn70@gmail.com";
            var pw = "unid ebjl ypdy drfq";
            var correoDestino = "thejrn120@gmail.com";


            var smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(miCorreo, pw)
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(miCorreo),
                Subject = "APISubastas Info" + DateTime.Now,
                Body = msg,
                IsBodyHtml = false,
            };
            mailMessage.To.Add(correoDestino);

            await smtpClient.SendMailAsync(mailMessage);
            

        }
    }
}
