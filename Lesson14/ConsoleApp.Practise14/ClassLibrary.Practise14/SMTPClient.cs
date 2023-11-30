using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;
using System.Net;

namespace ClassLibrary.Practise14
{
    public class Client
    {
		public string FromEmail { get; set; }
		public string SMTPPass { get; set; }
		public string SMTPUser { get; set; }
		public string SMTPHost { get; set; }
		public string SMTPPort { get; set; }
		public string ToEmail { get; set; }

		public void SendMessage()
		{
			SMTPPort = ConfigurationSettings.AppSettings["Port"];
			SMTPHost = ConfigurationSettings.AppSettings["SMTPGmail"];
			SMTPPass = ConfigurationSettings.AppSettings["SMTPPass"];
			FromEmail = ConfigurationSettings.AppSettings["SMTPEmail"];
			try
			{
				SmtpClient client = new SmtpClient("smtp.gmail.com");
				client.Port = SMTPPort;
				client.Credentials = new NetworkCredential("agroculturedrons@gmail.com", "aahjbhhrgixfgixd");
				client.EnableSsl = true;

				string subject = "Test";
				string body = "test";

				MailMessage message = new MailMessage("agroculturedrons@gmail.com", "iliyasuken@gmail.com", subject, body);

				client.Send(message);

				Console.WriteLine("Email sent successfully");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Exception caught: {ex}");
			}

		}
	}
}
