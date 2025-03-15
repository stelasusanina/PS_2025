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
			User user = new User("Stela", "stela123", UserRolesEnum.STUDENT);
			UserViewModel userViewModel = new UserViewModel(user);
			UserView userView = new UserView(userViewModel);

			userView.Display();
		}
	}
}