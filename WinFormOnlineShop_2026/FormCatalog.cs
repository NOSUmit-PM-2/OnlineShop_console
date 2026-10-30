using OnlineShop;

namespace WinFormOnlineShop_2026
{
    public partial class FormCatalog : Form
    {
        Catalog catalog = new Catalog();
        Cart mainCart = new Cart();

        public FormCatalog()
        {
            InitializeComponent();
            catalog.Add(new Product("Вертолет", 100, "игрушка веселая"));
            catalog.Add(new Product("Майка", 1005, "с принтом"));
            catalog.Add(new Product("Тапки", 250, "пляжные"));
            catalog.Add(new Product("Тетрадь", 17, "по информатике"));
            ShowCatalog();

            listBoxCatalog.SelectedIndex = 0;
        }

        void ShowCatalog()
        {
            int i = 0;
            foreach (Product product in catalog.getAll())
                listBoxCatalog.Items.Add($"{++i} {product}");
        }

        private void listBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCatalog.SelectedIndex != -1)
            {
                int selectedIndex = listBoxCatalog.SelectedIndex + 1;
                Product selectedProduct = catalog[selectedIndex];

                if (selectedProduct != null)
                {
                    labelProductName.Text = selectedProduct.Name;
                    labelDescription.Text = $"{selectedProduct.Description}\nЦена: {selectedProduct.Price} руб.";
                }
            }
        }

        private void FormCatalog_Load(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void labelProductName_Click(object sender, EventArgs e)
        {

        }

        private void panelCatalog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (listBoxCatalog.SelectedIndex != -1)
            {
                int selectedIndex = listBoxCatalog.SelectedIndex + 1;
                Product selectedProduct = catalog[selectedIndex];

                if (selectedProduct != null)
                {
                    mainCart.Add(selectedProduct);
                    MessageBox.Show($"{selectedProduct.Name} добавлен в корзину");
                }
            }
        }

        private void buttonOpenCart_Click(object sender, EventArgs e)
        {
            FormCart cartForm = new FormCart(mainCart);
            cartForm.ShowDialog();
        }
    }
}
