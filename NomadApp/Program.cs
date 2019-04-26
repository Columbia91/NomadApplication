using NomadApp.DataAccess;
using NomadApp.Models;
using NomadAppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new NomadContext())
            //{
            //    context.Users.Add(new User
            //    { Login = "Mister", Password = "555", IsAdmin = false});
            //    context.SaveChanges();
            //}
            
            bool check = false;
            int choice = 0;
            while (!check)
            {
                Console.Clear();
                Console.Write("Добро пожаловать на сайт журнала Nomad\n" +
                "1) Войти\n" +
                "2) Выход\n" +
                "Выбор: ");
                check = int.TryParse(System.Console.ReadLine(), out choice);
                if (choice < 1 || choice > 2)
                    check = false;
            }

            if(choice == 1)
            {
                User user = Authorization.SignIn();

                check = false;
                if (user == null)
                {
                    check = true;
                    choice = 3;
                }
                while (!check)
                {
                    Console.Clear();
                    Console.Write(
                    "1) Оформить подписку\n" +
                    "2) Отменить подписку\n" +
                    "Выбор: ");
                    check = int.TryParse(System.Console.ReadLine(), out choice);
                    if (choice < 1 || choice > 2)
                        check = false;
                }

                if(choice == 1)
                {
                    check = false;
                    while (!check)
                    {
                        Console.Clear();
                        Console.Write(
                        "1) на 12 месяцев\n" +
                        "2) на 24 месяца\n" +
                        "3) на 36 месяцев\n" +
                        "Выбор: ");
                        check = int.TryParse(System.Console.ReadLine(), out choice);
                        if (choice < 1 || choice > 2)
                            check = false;
                    }
                    int months = 0;
                    if (choice == 1)
                        months = 12;
                    if (choice == 2)
                        months = 24;
                    if (choice == 3)
                        months = 36;

                    int userId = UsersTableService.GetUserId(user.Login);
                    SubscriptionLogService.InsertToTable(months, userId);
                }
                else if(choice == 2)
                {

                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
