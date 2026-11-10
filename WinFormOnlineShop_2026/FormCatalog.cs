using OnlineShop;
using System.Windows.Forms;

namespace WinFormOnlineShop_2026
{
    public partial class FormCatalog : Form
    {
        Catalog catalog = new Catalog();
        Catalog basket = new Catalog();
        public FormCatalog()
        {
            InitializeComponent();
            catalog.Add(new Product("Вертолет", 100, "игрушка веселая"));
            catalog.Add(new Product("Майка", 1005, "с принтом"));
            catalog.Add(new Product("Тапки", 250, "пляжные"));
            catalog.Add(new Product("Тетрадь", 17, "по информатике"));
            ShowCatalog();
            listBoxCatalog.SelectedIndex = 0;
            labelProductName.Text = catalog[1].Name;
            labelDescription.Text = catalog[1].Description;
            labelDescription.Text += "\n" + "Цена товара: " + catalog[1].Price;
        }
        void ShowCatalog()
        {
            int i = 0;
            foreach (Product product in catalog.getAll())
                listBoxCatalog.Items.Add($"{++i} {product.Name}");
        }

        private void listBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelProductName.Text = catalog[listBoxCatalog.SelectedIndex + 1].Name;
            labelDescription.Text = catalog[listBoxCatalog.SelectedIndex + 1].Description;
            labelDescription.Text += "\n" + "Цена товара: " + catalog[listBoxCatalog.SelectedIndex + 1].Price;
        }
        void AddOrIncrease(Catalog basket, Product product)
        {
            bool flag = false;
            for (int i = 1; i < basket.Count()+1;i++)
            {
                if (basket[i].Name == product.Name)
                {
                    basket[i].IncreaseQuantity();
                    flag = true;
                }
            }
            if (flag) { return; }
            if (!flag)
            basket.Add(new Product(product.Name, product.Price, product.Description, product.Quantity));
        }
        private void buttonAddToBasket_Click(object sender, EventArgs e)
        {
            AddOrIncrease(basket, catalog[listBoxCatalog.SelectedIndex + 1]);
            MessageBox.Show($"Товар {catalog[listBoxCatalog.SelectedIndex + 1].Name} добавлен в корзину.", "Добавление в корзину", MessageBoxButtons.OK);
        }

        private void buttonOpenBasket_Click(object sender, EventArgs e)
        {
            FormBasket formbasket = new FormBasket(basket);
            formbasket.ShowDialog();
        }
    }
}
