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

        void ShowCatalog()
        {
            int i = 0;
            foreach (Product product in catalog.getAll())
                listBoxCatalog.Items.Add($"{++i} {product}");
        }

        private void listBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCatalog.SelectedIndex + 1;
            Product selectedProduct = catalog[selectedIndex];

            labelProductName.Text = selectedProduct.Name;
            labelDescription.Text = selectedProduct.Description;
            labelPrice.Text = $"Цена: {selectedProduct.Price} руб.";

        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCatalog.SelectedIndex + 1;
            Product selectedProduct = catalog[selectedIndex];

            cart.Add(selectedProduct);
            MessageBox.Show($"Товар {selectedProduct.Name} добавлен в корзину!");
        }

        private void buttonGoToCart_Click(object sender, EventArgs e)
        {
            FormCart windowCart = new FormCart(this.cart);
            windowCart.ShowDialog();
        }
    }
}
