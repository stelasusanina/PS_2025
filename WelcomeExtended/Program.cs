using System.Data;
using System.Xml.Linq;
using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
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
				var user = new User
				{
					Name = "John Smith",
					Password = "password123",
					Role = Welcome.Others.UserRolesEnum.STUDENT,
					Email = "jjSmith@gmail.com",
					FacultyNumber = "123"
				};

				var viewModel = new UserViewModel(user);

				var view = new UserView(viewModel);

				view.Display();

				// Throw error here

				view.DisplayError("Error");
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