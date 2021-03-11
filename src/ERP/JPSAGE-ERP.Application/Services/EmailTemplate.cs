using System;
using System.IO;

namespace JPSAGE_ERP.Application.Services
{
    public class EmailTemplate : IEmailTemplate
    {
        /// <summary>
        /// Method use to get the HTML template for sending 
        /// out emails to users
        /// </summary>
        /// <param name="link"></param>
        /// <param name="htmlPath"></param>
        /// <returns></returns>
        public string GetEmailTemplate(string link, string htmlPath, string username, string password, string name)
        {
            string html;

            if (File.Exists(htmlPath))
            {
                html = File.ReadAllText(htmlPath);
            }
            else
            {
                throw new FormatException("The email template is not provided");
            }

            string msgBody = html.Replace("{email_link}", link);
            msgBody = msgBody.Replace("{name_}", name);
            msgBody = msgBody.Replace("{username_}", username);
            msgBody = msgBody.Replace("{password_}", password);

            return msgBody;
        }
    }
}
