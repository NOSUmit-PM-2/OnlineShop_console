
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

            buttonAddToCart.Click += buttonAddToCart_Click;
            buttonOpenCart.Click += buttonOpenCart_Click;

            catalog.Add(new Product("Вертолет", 100, "игрушка веселая"));
            catalog.Add(new Product("Майка", 1005, "с принтом"));
            catalog.Add(new Product("Тапки", 250, "пляжные"));
            catalog.Add(new Product("Тетрадь", 17, "по информатике"));

            ShowCatalog();
        }

        void ShowCatalog()
        {
            int i = 0;

            foreach (Product product in catalog)
                listBoxCatalog.Items.Add($"{++i} {product}");
        }

        void ShowProduct(int index)
        {
            labelProductName.Text = catalog[index + 1].Name;
            labelDescription.Text = catalog[index + 1].Description;
            labelPrice.Text = catalog[index + 1].Price.ToString();
        }

        private void listBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProduct(listBoxCatalog.SelectedIndex);
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            int index = listBoxCatalog.SelectedIndex;

            if (index != -1)
            {
                cart.Add(catalog[index + 1]);
                MessageBox.Show("Товар добавлен в корзину");
            }
        }

        private void buttonOpenCart_Click(object sender, EventArgs e)
        {
            FormCart form = new FormCart(cart);
            form.ShowDialog();
        }
    }
}
