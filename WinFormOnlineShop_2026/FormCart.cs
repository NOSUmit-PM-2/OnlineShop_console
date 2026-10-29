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
            ShowCart(-1);
        }

        void ShowCart(int selectedIndex)
        {
            listViewCart.Items.Clear();
            foreach (CartItem item in cart.getAll())
            {
                ListViewItem row = new ListViewItem(item.Product.Name);
                row.SubItems.Add(item.Product.Price.ToString());
                row.SubItems.Add(item.Count.ToString());
                row.SubItems.Add(item.Sum.ToString());
                row.Tag = item;
                listViewCart.Items.Add(row);
            }

            if (selectedIndex >= 0 && selectedIndex < listViewCart.Items.Count)
                listViewCart.Items[selectedIndex].Selected = true;

            labelTotal.Text = "Итого к оплате: " + cart.TotalPrice + " руб.";
            labelEmpty.Visible = cart.Count == 0;
        }

        CartItem? GetSelectedItem()
        {
            if (listViewCart.SelectedItems.Count == 0)
                return null;
            return listViewCart.SelectedItems[0].Tag as CartItem;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            CartItem? item = GetSelectedItem();
            if (item == null)
                return;
            int index = listViewCart.SelectedIndices[0];
            cart.Increase(item);
            ShowCart(index);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            CartItem? item = GetSelectedItem();
            if (item == null)
                return;
            int index = listViewCart.SelectedIndices[0];
            cart.Decrease(item);
            ShowCart(index);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CartItem? item = GetSelectedItem();
            if (item == null)
                return;
            int index = listViewCart.SelectedIndices[0];
            cart.Delete(item);
            ShowCart(index);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
