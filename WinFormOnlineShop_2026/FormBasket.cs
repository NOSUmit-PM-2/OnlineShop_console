using OnlineShop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormOnlineShop_2026
{
    public partial class FormBasket : Form
    {
        Catalog basket = new Catalog();
        public FormBasket(Catalog basket)
        {
            InitializeComponent();
            this.basket = basket;
        }
        void ShowCatalog()
        {
            foreach (Product product in basket.getAll())
                listBoxBasket.Items.Add($"{product.Name} Цена за штуку: {product.Price} Кол-во: {product.Quantity} шт");
        }

        private void FormBasket_Load(object sender, EventArgs e)
        {
            ShowCatalog();
        }
    }
}
