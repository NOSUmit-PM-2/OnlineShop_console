using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Food: Product
    {
        DateTime productionDate;
        int expirationDays;
        public DateTime ExpirationDate
        {
            get 
            {
                return  productionDate.AddDays(expirationDays);
            }
        }

        public Food(string name, decimal price, string description, string productionDate, int expirationDays):base(name, price, description)
        {
            this.productionDate = Convert.ToDateTime(productionDate);
            this.expirationDays = expirationDays;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Годен до: {ExpirationDate.Date.ToShortDateString()}";
        }
    }
}
