using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
	public class UserView
	{
		private UserViewModel _viewModel;
		public UserView(UserViewModel viewModel)
		{
			_viewModel = viewModel;
		}

		public void Display()
		{
            Console.WriteLine("Welcome");
            Console.WriteLine($"User: {_viewModel.Name}");
			Console.WriteLine($"Role: {_viewModel.Role}");
			Console.WriteLine($"Email: {_viewModel.Email}");
            Console.WriteLine($"Faculty number: {_viewModel.FacultyNumber}");
		}

		public void Display2()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("===== USER DETAILS =====");
			sb.AppendLine($"-> Name: {_viewModel.Name}");
			sb.AppendLine($"-> Role: {_viewModel.Role}");
			sb.AppendLine($"-> Email: {_viewModel.Email}");
			sb.AppendLine($"-> Faculty #: {_viewModel.FacultyNumber}");
			sb.AppendLine("=========================");

            Console.WriteLine(sb);
        }
	}
}
