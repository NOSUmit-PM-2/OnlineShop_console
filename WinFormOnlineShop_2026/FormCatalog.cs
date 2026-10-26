using OnlineShop;

namespace WinFormOnlineShop_2026
{
    public partial class FormCatalog : Form
    {
        Catalog catalog = new Catalog();
        Cart userCart = new Cart();
        Product choosenProduct = null;

        public FormCatalog()
        {
            InitializeComponent();
            catalog.Add(new Product("Вертолет", 100, "игрушка"));
            catalog.Add(new Product("Майка", 1005, "с принтом"));
            catalog.Add(new Product("Тапки", 250, "пляжные"));
            catalog.Add(new Product("Тетрадь", 17, "в клетку"));
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
            if (listBoxCatalog.SelectedItem != choosenProduct)
            {
                string text = listBoxCatalog.SelectedItem.ToString();
                int index = int.Parse(text.Split(' ')[0]);

                choosenProduct = catalog[index];
                labelProductName.Text = $"{choosenProduct.Name} - {choosenProduct.Price}";
                labelDescription.Text = choosenProduct.Description;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (choosenProduct != null)
            {
                userCart.Add(choosenProduct);
            }
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            UserCart cartForm = new UserCart(userCart);
            cartForm.Show();
        }
    }
}
