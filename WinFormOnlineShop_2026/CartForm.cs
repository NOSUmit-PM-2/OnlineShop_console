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
    public partial class CartForm : Form
    {
        Cart userCart;
        public CartForm()
        {
            InitializeComponent();
        }

        public CartForm(Cart cart):this()
        {
            userCart = cart;
            ShowCartItems();
        }

        void ShowCartItems()
        {
            listBoxCart.Items.Clear();

            int i = 0;
            foreach (CartItem product in userCart.getAll())
            {
                listBoxCart.Items.Add($"{++i}: {product}");
            }
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
