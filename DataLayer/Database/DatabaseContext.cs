using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace DataLayer.Database
{
	public class DatabaseContext: DbContext
	{
		public DbSet<DatabaseUser> Users { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string databaseFile = "Welcome.db";
			string databasePath = Path.Combine(solutionFolder, databaseFile);
			optionsBuilder.UseSqlite($"Data Source={databasePath}");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

			var user = new DatabaseUser()
			{
				Id = 1,
				Name = "John Doe",
				Password = "1234",
				Role = UserRolesEnum.ADMIN,
				Expires = DateTime.Now.AddDays(1),
				Email = "email",
				FacultyNumber = "1",
			};

			var user2 = new DatabaseUser()
			{
				Id = 2,
				Name = "Stela Susanina",
				Password = "4567",
				Role = UserRolesEnum.STUDENT,
				Expires = DateTime.Now.AddDays(2),
				Email = "email",
				FacultyNumber = "1",
			};

			var user3 = new DatabaseUser()
			{
				Id = 3,
				Name = "John Smith",
				Password = "john",
				Role = UserRolesEnum.PROFESSOR,
				Expires = DateTime.Now.AddDays(3),
				Email = "email",
				FacultyNumber = "1",
			};

			modelBuilder.Entity<DatabaseUser>().HasData(user);
			modelBuilder.Entity<DatabaseUser>().HasData(user2);
			modelBuilder.Entity<DatabaseUser>().HasData(user3);

			base.OnModelCreating(modelBuilder);
		}
	}
}
