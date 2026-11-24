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
                listBoxUserCart.Items.Add($"Кол-во: {cartItem.Count} | {cartItem.Product}");
                price += cartItem.Product.Price * cartItem.Count;
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
            if (index >= 0)
            {
                newCart.Delete(index);
                ChangeCart();
                listBoxUserCart.SelectedIndex = Math.Min(index, listBoxUserCart.Items.Count - 1);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int index = listBoxUserCart.SelectedIndex;
            if (index >= 0)
            {
                newCart.AddCount(index);
                ChangeCart();
                listBoxUserCart.SelectedIndex = index;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int index = listBoxUserCart.SelectedIndex;
            if (index >= 0)
            {
                newCart.MinusCount(index);
                ChangeCart();
                listBoxUserCart.SelectedIndex = Math.Min(index, listBoxUserCart.Items.Count - 1);
            }
        }
    }
}
