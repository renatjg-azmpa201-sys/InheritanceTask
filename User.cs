using System;
using System.Text.RegularExpressions;

namespace LoginType_Task
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        private string email = "No any Email input";
        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    email = value;
            }
        }

        public User(string username, string password, string email = "No any Email input")
        {
            Username = username;
            Password = password;
            Email = email;
        }




        public void CheckUsername(string? username)
        {
            while (true)
            {
                // Treat null/whitespace as invalid and prompt again
                if (!string.IsNullOrWhiteSpace(username) && username.Length > 6 && !username.Contains(' '))
                {
                    Username = username;
                    break;
                }

                Console.Write("Invalid Username. Please enter again: ");
                username = Console.ReadLine();
            }
        }
        public void CheckPassword(string password)
        {
            while (true)
            {
                // Treat null/whitespace as invalid and prompt again
                if (!string.IsNullOrWhiteSpace(password) && password.Length > 6 && !password.Contains(' ') && password.Any(char.IsUpper) && password.Any(char.IsDigit))
                {
                    Password = password;
                    break;
                }

                Console.Write("Invalid Password. Your password must have one upper letter and one digit. Please enter again: ");
                password = Console.ReadLine();
            }
        }

        public void CheckEmail(string email)
        {

            string pattern = @"^[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]@\w+(\.\w{2,3})$";

            while (true)
            {
                if (!string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, pattern))
                {
                    Email = email;
                    break;
                }

                Console.Write("Invalid Email. Please enter again: ");
                email = Console.ReadLine();
            }
        }
        public void PrintUserInfo()
        {
            Console.WriteLine($"Username: {Username}, Password: {Password}, Email: {Email}");
        }


    }
}
