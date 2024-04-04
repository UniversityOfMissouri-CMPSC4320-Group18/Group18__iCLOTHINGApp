using System;
namespace Group18__iCLOTHINGApp.Models
{
	public class Email
	{
		public String emailNo { get; set; }
        public DateOnly emailDate { get; set; }
        public String emailSubject { get; set; }
        public String emailBody { get; set; }

		public String toString()
		{
			return "emailNo: " + emailNo + ", emailDate: " + emailDate + ", emailSubject: " + emailSubject + ", emailBody: " + emailBody;
		}

        public Email()
		{
		}
	}
}

