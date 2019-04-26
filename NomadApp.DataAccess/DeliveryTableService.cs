using NomadApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp.DataAccess
{
    public class DeliveryTableService
    {
        public static void InsertToTable(int userId)
        {
            try
            {
                using(var context = new NomadContext())
                {
                    context.Deliveries.Add(new Delivery
                    {
                        UserId = userId,
                        DeadLineDate = DateTime.Now.AddDays(10),
                        Status = "Не доставлено"
                    });
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
