using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Others;

namespace Welcome
{
	public class Program
	{
		public static void Main(string[] args)
		{
			User user = new User(1, "Stela", "stela123", UserRolesEnum.STUDENT, "ssusanina@tu-sofia.bg", "501222047", new DateTime(2028, 8, 15));
			UserViewModel userViewModel = new UserViewModel(user);
			UserView userView = new UserView(userViewModel);

			userView.Display();
			userView.Display2();
		}
	}
}