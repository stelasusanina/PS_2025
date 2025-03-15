using System;
using System.Linq;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
	public class UserViewModel
	{
		private User _user;

		public UserViewModel(User user)
		{
			_user = user;
		}

		public string Name
		{
			get { return _user.Name; }
			set { _user.Name = value; }
		}

		public string Password
		{
			get { return DecryptPassword(_user.Password); }
			set { _user.Password = EncryptPassword(value); }
		}

		public UserRolesEnum Role
		{
			get { return _user.Role; }
			set { _user.Role = value; }
		}

		public string Email
		{
			get { return _user.Email; }
			set { _user.Email = value; }
		}

		public string FacultyNumber
		{
			get { return _user.FacultyNumber; }
			set { _user.FacultyNumber = value; }
		}

		private string EncryptPassword(string password)
		{
			return string.Join("-", password.Select(c => ((int)c).ToString()));
		}

		private string DecryptPassword(string encryptedPassword)
		{
			return new string(encryptedPassword.Split('-').Select(n => (char)int.Parse(n)).ToArray());
		}
	}
}
