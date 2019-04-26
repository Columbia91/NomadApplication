using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp.Models
{
    public class SubscriptionLog
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime SubscriptionStart { get; set; } // начало подписки
        public DateTime SubscriptionEnd { get; set; } // конец подписки
        public double PricePerMonth { get; set; } // оплата за месяц
        public double MagazinePrice { get; set; }
    }
}
