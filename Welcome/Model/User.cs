using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
	public class User
	{
		public virtual int Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
		public UserRolesEnum Role { get; set; }
		public string Email { get; set; }
		public string FacultyNumber { get; set; }
		public DateTime Expires {  get; set; }
		public User() { }
		public User(int id, string name, string password, UserRolesEnum role, string email, string facultyNumber, DateTime expires)
		{
			Id = id;
			Name = name;
			Password = password;
			Role = role;
			Email = email;
			FacultyNumber = facultyNumber;
			Expires = expires;
		}
    }
}
