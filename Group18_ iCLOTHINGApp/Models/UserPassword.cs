using System;
namespace Group18__iCLOTHINGApp.Models
{
	public class UserPassword
	{
		public String userID;
		public String userAccountName;
		public String userEncryptedPassword;
		public Int32 passwordExpiryTime;
		public DateOnly userAccountExpiryDate;

		public UserPassword()
		{
		}
	}
}

