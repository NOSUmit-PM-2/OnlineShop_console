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
            int itemInd = listBoxCatalog.SelectedIndex;
            var item = catalog[itemInd];

            labelProductName.Text = item.Name;
            labelDescription.Text = item.Description;
            labelProductPrice.Text = $"{item.Price.ToString()} руб.";
        }

        private void FormCatalog_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxCatalog.SelectedItem != null)
            {
                int selectedItemIndex = listBoxCatalog.SelectedIndex;
                Product selectedProd = catalog[selectedItemIndex];

                cart.Add(selectedProd);
            }
            else
                MessageBox.Show("Выберите товар");
        }

        private void cartViewBtn_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(cart);
            cartForm.ShowDialog();
        }
    }
}
