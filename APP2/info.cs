using System;
using System.Net;
using System.Net.Mail;
using System;

namespace APP2
{
    public class info
    {
        private MailMessage CorreoElectronico;
        private SmtpClient EnvioCorreo;
        private String MailFrom;
        private String Password;
        public Attachment Anexos;

        public info()
        {
            //vichgleza@gmail.com
            CorreoElectronico = new MailMessage("luis02enrique04@gmail.com", "vichgleza@gmail.com");
            EnvioCorreo = new SmtpClient("smtp.gmail.com", 587);
            MailFrom = "luis02enrique04@gmail.com";
            Password = "vaneypichis";
        }

        public bool EnviarMail(string Mensaje, string asunto)
        {
            try
            {
                CorreoElectronico.Body = Mensaje;
                CorreoElectronico.Subject = asunto;

                EnvioCorreo.Credentials = new NetworkCredential(MailFrom, Password);
                EnvioCorreo.EnableSsl = true;
                EnvioCorreo.DeliveryMethod = SmtpDeliveryMethod.Network;
                // CorreoElectronico.Body = Mensaje;

                if (Anexos != null)
                {
                    CorreoElectronico.Attachments.Add(Anexos);
                }


                EnvioCorreo.Send(CorreoElectronico);

                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

    }
}
