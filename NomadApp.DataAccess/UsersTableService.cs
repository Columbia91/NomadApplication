using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp.DataAccess
{
    public class UsersTableService
    {
        public static string CheckForAvailabilityLogin(string data)
        {
            string login = "";
            try
            {
                using (var context = new NomadContext())
                {
                    login = context.Users
                            .Where(u => u.Login == data)
                            .Select(u => u.Login).FirstOrDefault();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return login;
        }
        public static string CheckForAvailabilityPassword(string data)
        {
            string password = "";
            try
            {
                using(var context = new NomadContext())
                {
                    password = context.Users
                            .Where(u => u.Login == data)
                            .Select(u => u.Password).FirstOrDefault();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return password;
        }

        public static int GetUserId(string login)
        {
            int id = 0;
            try
            {
                using (var context = new NomadContext())
                {
                    id = context.Users
                        .Where(u => u.Login == login)
                        .Select(u => u.Id).FirstOrDefault();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return id;
        }
    }
}
