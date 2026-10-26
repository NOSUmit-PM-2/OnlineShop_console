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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormOnlineShop_2026
{
    public partial class UserCart : Form
    {
        Cart newCart;

        public UserCart()
        {
            InitializeComponent();
        }

        public UserCart(Cart cart)
        {
            InitializeComponent();
            newCart = cart;
            ChangeCart();
        }

        void ChangeCart()
        {
            listBoxUserCart.Items.Clear();

            decimal price = 0;
            foreach (CartItem cartItem in newCart.getAll())
            {
                listBoxUserCart.Items.Add(cartItem.Product);
                price += cartItem.Product.Price;
            }
            labelPrice.Text = $"Цена: {price.ToString()}";
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxUserCart.SelectedIndex;
            newCart.Delete(index);
            ChangeCart();
        }
    }
}
