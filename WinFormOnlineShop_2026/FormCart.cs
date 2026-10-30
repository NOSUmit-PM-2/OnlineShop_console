using OnlineShop;

namespace WinFormOnlineShop_2026
{
	public partial class FormCart : Form
	{
		Cart cart;

		public FormCart(Cart userCart)
		{
			InitializeComponent();
			this.cart = userCart;
			cart.RemoveEmpty();
			ShowCart();
		}

		private void ShowCart(int index = 0)
		{
			listViewCart.Items.Clear();
			decimal sum = 0;
			CartItem[] items = cart.getAll();
			for (int i = 0; i < cart.Count; i++)
			{
				CartItem item = items[i];
				decimal cost = item.Count * item.Product.Price;
				sum += cost;
				ListViewItem lwItem = new ListViewItem();
				lwItem.Text = (i + 1).ToString();
				lwItem.SubItems.Add(item.Product.Name);
				lwItem.SubItems.Add(item.Product.Price.ToString());
				lwItem.SubItems.Add(item.Count.ToString());
				lwItem.SubItems.Add(cost.ToString());
				listViewCart.Items.Add(lwItem);
			}
			if (items.Length > 0)
			{
				labelSum.Text = $"Итого: {sum.ToString()}";
				if (listViewCart.Items.Count > index)
				{
					listViewCart.Items[index].Selected = true;
				}
				else
				{
					listViewCart.Items[0].Selected = true;
				}
			}
			else
			{
				labelSum.Text = $"Корзина пуста. Время купить что-нибудь :)";
				DisableButtons();
			}
		}

		private void DisableButtons()
		{
			buttonInc.Enabled = false;
			buttonDec.Enabled = false;
			buttonRem.Enabled = false;
		}

		private void EnableButtons()
		{
			buttonInc.Enabled = true;
			buttonDec.Enabled = true;
			buttonRem.Enabled = true;
		}

		private void buttonDec_Click(object sender, EventArgs e)
		{
			int index = int.Parse(listViewCart.SelectedItems[0].Text) - 1;
			CartItem item = cart.getAll()[index];
			if (item.Count > 0)
			{
				item.Count -= 1;
			}
			ShowCart(index);
		}

		private void buttonInc_Click(object sender, EventArgs e)
		{
			int index = int.Parse(listViewCart.SelectedItems[0].Text) - 1;
			CartItem item = cart.getAll()[index];
			item.Count += 1;
			ShowCart(index);
		}

		private void buttonRem_Click(object sender, EventArgs e)
		{
			int index = int.Parse(listViewCart.SelectedItems[0].Text) - 1;
			CartItem item = cart.getAll()[index];
			cart.Remove(item.Product);
			ShowCart(index);
		}

		private void listViewCart_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewCart.SelectedItems.Count != 1)
			{
				DisableButtons();
			}
			else
			{
				EnableButtons();
			}
		}
	}
}
