using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OnlineShop
{
    public class Food:Product
    {
        DateTime productionDate;
        int expirationDays;
        public DateTime ExpirationDate 
        {
            get
            {
                return productionDate.AddDays(expirationDays).Date;
            }
        }

        public Food(string name, decimal price, string description, string productionDate, int expirationDays) :base(name, price, description)
        {
            this.expirationDays = expirationDays;
            this.productionDate = Convert.ToDateTime(productionDate);
        }

        public override string ToString()
        {
            return $"{base.ToString()} Годен до {ExpirationDate.ToShortDateString()}";
        }
    }
}
