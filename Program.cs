using LoginType_Task;
using System.ComponentModel;

User user = new User("", "", "");

//string username;

//Console.Write("Enter any Username: ");
//username = Console.ReadLine();
//user.CheckUsername(username);

//string password;

//Console.Write("Enter any Password: ");
//password = Console.ReadLine();
//user.CheckPassword(password);

//string email;

//Console.Write("Enter any Email: ");
//email = Console.ReadLine();
//user.CheckEmail(email);


//user.PrintUserInfo();

Admin admin = Admin.CreateAdminFromInput();
admin.GetInfo();