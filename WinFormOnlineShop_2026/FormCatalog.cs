using OnlineShop;

namespace WinFormOnlineShop_2026
{
	public partial class FormCatalog : Form
	{
		Catalog catalog = new Catalog();
		Cart cart = new Cart();

		public FormCatalog()
		{
			InitializeComponent();
			catalog.Add(new Product("Вертолет", 100, "игрушка веселая"));
			catalog.Add(new Product("Майка", 1005, "с принтом"));
			catalog.Add(new Product("Тапки", 250, "пляжные"));
			catalog.Add(new Product("Тетрадь", 17, "по информатике"));
			ShowCatalog();
		}

		private void ShowCatalog()
		{
			int i = 0;
			foreach (Product product in catalog.getAll())
			{
				listBoxCatalog.Items.Add($"{++i} {product}");
			}
			listBoxCatalog.SelectedIndex = 0;
		}

		private void listBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
		{
			Product selectedProduct = catalog[listBoxCatalog.SelectedIndex];
			labelProductName.Text = selectedProduct.Name;
			labelDescription.Text = selectedProduct.Description;
			labelPrice.Text = selectedProduct.Price.ToString();
		}

		private void buttonAddToCart_Click(object sender, EventArgs e)
		{
			Product selectedProduct = catalog[listBoxCatalog.SelectedIndex];
			cart.Add(selectedProduct);
		}

		private void buttonCart_Click(object sender, EventArgs e)
		{
			FormCart formCart = new FormCart(this.cart);
			formCart.ShowDialog();
		}
	}
}
