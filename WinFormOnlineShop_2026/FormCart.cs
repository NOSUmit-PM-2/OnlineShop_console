
using OnlineShop;

namespace WinFormOnlineShop_2026
{
    public partial class FormCart : Form
    {
        Cart cart;

        public FormCart(Cart cart)
        {
            InitializeComponent();

            this.cart = cart;

            ShowCart();
        }

        void ShowCart()
        {
            listBoxCart.Items.Clear();

            foreach (CartItem item in cart.getAll())
            {
                listBoxCart.Items.Add(
                    $"{item.Product.Name} - {item.Product.Price} руб. x {item.Count}"
                );
            }

            labelTotal.Text = "Итого: " + cart.GetTotal() + " руб.";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int index = listBoxCart.SelectedIndex;

            if (index != -1)
            {
                cart.Increase(index);
                ShowCart();
                listBoxCart.SelectedIndex = index;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int index = listBoxCart.SelectedIndex;

            if (index != -1)
            {
                cart.Decrease(index);
                ShowCart();

                if (index < listBoxCart.Items.Count)
                {
                    listBoxCart.SelectedIndex = index;
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCart_Load(object sender, EventArgs e)
        {

        }
    }
}
