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
            catalog.Add(new Product("Вертолет", 100, "Игрушечный"));
            catalog.Add(new Product("Майка", 1005, "С принтом"));
            catalog.Add(new Product("Тапки", 250, "Пляжные"));
            catalog.Add(new Product("Тетрадь", 17, "По информатике"));
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
            int index = listBoxCatalog.SelectedIndex;
            if (index < 0)
                return;

            Product product = catalog[index + 1];
            labelProductName.Text = product.Name;
            labelDescription.Text = product.Description + "\r\nЦена: " + product.Price;
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            int index = listBoxCatalog.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Выберите товар в списке");
                return;
            }
            cart.Add(catalog[index + 1]);
        }

        private void buttonOpenCart_Click(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart(cart);
            formCart.ShowDialog();
        }
    }
}
