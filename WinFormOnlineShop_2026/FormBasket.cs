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
        void UpdateCatalog()
        {
            listBoxBasket.Items.Clear();
            foreach (Product product in basket.getAll())
                listBoxBasket.Items.Add($"{product.Name} Цена за штуку: {product.Price} Кол-во: {product.Quantity} шт");
        }
        private void FormBasket_Load(object sender, EventArgs e)
        {
            ShowCatalog();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                basket[listBoxBasket.SelectedIndex + 1].IncreaseQuantity();
                UpdateCatalog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выбери товар!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (basket[listBoxBasket.SelectedIndex + 1].Quantity > 1)
                {
                    basket[listBoxBasket.SelectedIndex + 1].DeincreaseQuantity();
                    UpdateCatalog();
                }
                else
                {
                    basket.RemoveAt(listBoxBasket.SelectedIndex);
                    UpdateCatalog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выбери товар!", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
