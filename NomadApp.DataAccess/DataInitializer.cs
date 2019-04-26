using NomadApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp.DataAccess
{
    public class DataInitializer : CreateDatabaseIfNotExists<NomadContext>
    {
        protected override void Seed(NomadContext context)
        {
            context.Users.AddRange(new List<User>
            {
                new User
                {
                    Login = "Jimmy",
                    Password = "123",
                    IsAdmin = true
                },
                new User
                {
                    Login = "Henry",
                    Password = "588",
                    IsAdmin = false
                },
                new User
                {
                    Login = "Ricky",
                    Password = "asd5",
                    IsAdmin = false
                },
                new User
                {
                    Login = "Micky",
                    Password = "not8",
                    IsAdmin = false
                },
            });
        }
    }
}
