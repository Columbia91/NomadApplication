using NomadApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp.DataAccess
{
    public class SubscriptionLogService
    {
        public static void InsertToTable(int months, int userId)
        {
            try
            {
                using(var context = new NomadContext())
                {
                    context.SubscriptionLogs.Add(new SubscriptionLog
                    {
                        UserId = userId,
                        SubscriptionStart = DateTime.Now,
                        SubscriptionEnd = DateTime.Now.AddMonths(months),
                        PricePerMonth = 100,
                        MagazinePrice = 75
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
