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
        Cart userCart = new Cart();
        decimal totalPrice;
        public CartForm()
        {
            InitializeComponent();
        }

        public CartForm(Cart cart) : this()
        {
            userCart = cart;
            getTotalPrice();
            ShowCartItems();
            labelTotalPrice.Text = $"Итого: {totalPrice} руб.";
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

        void getTotalPrice()
        {
            foreach (var item in userCart.getAll())
            {
                totalPrice += item.Count * item.Product.Price;
            }
        }

        private void CartForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedItem != null)
            {
                int itemInd = listBoxCart.SelectedIndex;
                var item = userCart[itemInd];

                item.Count--;
                totalPrice -= item.Product.Price;
                labelTotalPrice.Text = $"Итого: {totalPrice} руб.";

                if (item.Count == 0)
                    userCart.Delete(item);

                ShowCartItems();
            }
            else
                MessageBox.Show("Выберите товар");
        }

        private void buttonInc_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedItem != null)
            {
                int itemInd = listBoxCart.SelectedIndex;
                var item = userCart[itemInd];

                item.Count++;
                totalPrice += item.Product.Price;
                labelTotalPrice.Text = $"Итого: {totalPrice} руб.";

                ShowCartItems();
            }
            else
                MessageBox.Show("Выберите товар");
        }

        private void listBoxCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemInd = listBoxCart.SelectedIndex;
            var item = userCart[itemInd];

            labelProductName.Text = item.Product.Name;
            labelDescription.Text = item.Product.Description;
            labelCountProduct.Text = $"Количество: {item.Count}";
        }
    }
}
