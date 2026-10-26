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
    public partial class FormCart : Form
    {

        private Cart currentCart;
        public FormCart(Cart mainCart)
        {
            InitializeComponent();
            currentCart = mainCart;
            ShowCart();
        }

        private void ShowCart()
        {
            listBoxCartItems.Items.Clear();
            foreach (CartItem item in currentCart.getAll())
            {
                decimal totalItemPrice = item.Product.Price * item.Count;
                string s = $"{item.Product.Name} | Цена одного: {item.Product.Price}р | Кол-во: {item.Count} шт. | Стоимость: {totalItemPrice}руб.";
                listBoxCartItems.Items.Add(s);
            }

            labelTotalSum.Text = $"ИТОГО: {currentCart.TotalPrice} руб.";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            CartItem selectedItem = currentCart.getAll()[listBoxCartItems.SelectedIndex];//достаем этот товар из корзины по его индексу в списке
            currentCart.Add(selectedItem.Product);
            ShowCart();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            CartItem selectedItem = currentCart.getAll()[listBoxCartItems.SelectedIndex];//достаем этот товар из корзины по его индексу в списке
            currentCart.Delete(selectedItem.Product);
            ShowCart();
        }
    }
}
