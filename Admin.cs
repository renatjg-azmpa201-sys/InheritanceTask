using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace LoginType_Task
{
    internal class Admin : User
    {
        public bool IsSuperAdmin { get; set; }
        public string Section { get; set; }

        // Constructor – bütün dəyərlər mütləq
        public Admin(string username, string password, string email, bool isSuperAdmin, string section)
            : base(username, password, email)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section ?? throw new ArgumentException("Section cannot be empty");
        }

        // Admin məlumatlarını göstərən metod
        public void GetInfo()
        {
            Console.WriteLine("=== Admin Information ===");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"IsSuperAdmin: {IsSuperAdmin}");
            Console.WriteLine($"Section: {Section}");
        }

        // İstifadəçidən admin məlumatlarını soruşan metod
        public static Admin CreateAdminFromInput()
        {
            User temp = new User("", "", "");
            
            
            Console.Write("Enter username: ");
            string username  = Console.ReadLine();
            temp.CheckUsername(username);


            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            temp.CheckPassword(password);
            while (true)
            {
                
            Console.Write("Do you want to enter email? (true/false): ");
            string answer = Console.ReadLine();
            if (answer == "true")
            {
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            temp.CheckEmail(email);
            break;
            }
            else if (answer == "false")
            {
                Console.WriteLine("Okay next step =>"); 
                break;
                }
            else
            {
            Console.WriteLine("Invalid input. Please enter true or false.");
                
            }
            }

            bool isSuperAdmin;
            while (true)
            {
                Console.Write("Is this admin super admin? (true/false): ");
                string input = Console.ReadLine()!;
                if (bool.TryParse(input, out isSuperAdmin))
                    break;
                Console.WriteLine("Invalid input. Please enter true or false.");
            }

            // Section soruşulur
            string section;
            while (true)
            {
                Console.Write("Enter admin section: ");
                section = Console.ReadLine()!;
                if (!string.IsNullOrWhiteSpace(section))
                    break;
                Console.WriteLine("Section cannot be empty.");
            }

            // Yeni Admin obyekti yaradılır
            return new Admin(temp.Username, temp.Password, temp.Email, isSuperAdmin, section);
        }
    }
}
