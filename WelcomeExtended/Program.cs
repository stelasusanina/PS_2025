using System.Data;
using System.Xml.Linq;
using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using WelcomeExtended.Loggers;

namespace WelcomeExtended
{
	public class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				// Example 2
				//var user = new User
				//{
				//	Id = 2,
				//	Name = "John Smith",
				//	Password = "password123",
				//	Role = Welcome.Others.UserRolesEnum.STUDENT,
				//	Email = "jjSmith@gmail.com",
				//	FacultyNumber = "123",
				//	Expires = new DateTime(2027, 5, 21)
				//};

				//var viewModel = new UserViewModel(user);

				//var view = new UserView(viewModel);

				//view.Display();

				// Throw error here

				//view.DisplayError("Error");

				UserData userData = new UserData();

				User student = new User
				{
					Name = "Stela",
					Password = "123",
					Role = UserRolesEnum.STUDENT,
				};
				User student2 = new User()
				{
					Name = "Student2",
					Password = "123",
					Role = UserRolesEnum.STUDENT,
				};
				User teacher = new User()
				{
					Name = "Teacher",
					Password = "1234",
					Role = UserRolesEnum.PROFESSOR,
				};
				User admin = new User()
				{
					Name = "Admin",
					Password = "12345",
					Role = UserRolesEnum.ADMIN,
				};

				userData.AddUser(student);
				userData.AddUser(student2);
				userData.AddUser(teacher);
				userData.AddUser(admin);

				Console.WriteLine("Enter name: ");
				var user = Console.ReadLine();
				Console.WriteLine("Enter password: ");
				var pass = Console.ReadLine();

				UserHelper.ValidateCredentials(userData, user, pass);
				var data = UserHelper.GetUser(userData, user, pass);
				if (data == null)
				{
					Console.WriteLine("User not found");
				}
				else
				{
					Console.WriteLine(UserHelper.ToString(data));
				}
			}
			catch (Exception e)
			{
				var log = new ActionOnError(Delegates.Log);
				log(e.Message);
			}
			finally
			{
				Console.WriteLine("Executed in any case!");
			}
        }
	}
}