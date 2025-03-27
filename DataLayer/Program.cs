using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others;

using (var db = new DatabaseContext())
{
	db.Database.EnsureCreated();
	db.Add<DatabaseUser>(new DatabaseUser()
	{
		Name = "user",
		Password = "password",
		Expires = DateTime.Now,
		Role = UserRolesEnum.STUDENT,
		Email = "email",
		FacultyNumber = "1",
	});

	db.SaveChanges();
	var users = db.Users.ToList();

	Console.WriteLine("Enter name: ");
	var name = Console.ReadLine();
	var user = db.Users.Where(u => u.Name == name).FirstOrDefault();
	if (user != null)
	{
		Console.WriteLine("Enter password: ");
		var password = Console.ReadLine();
		if (user.Password != password)
		{
            Console.WriteLine("Невалидни данни");
			return;
        }

        Console.WriteLine("Валиден потребител");
    }
}