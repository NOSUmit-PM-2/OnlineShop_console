using OnlineShop;

namespace WinFormOnlineShop_2026
{
    public partial class FormCatalog : Form
    {
        Catalog catalog = new Catalog();
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
            //foreach (Product product in catalog.getAll())
            //    listBoxCatalog.Items.Add($"{++i} {product}");

            foreach (Product product in catalog)
                listBoxCatalog.Items.Add($"{++i} {product}");
        }

        void ShowProduct(int index)
        {
            // в индексаторе подразумевается нумерациия с 1
            labelProductName.Text = catalog[index + 1].Name;
            labelDescription.Text = catalog[index + 1].Description;
            labelPrice.Text = catalog[index + 1].Price.ToString();
        }

        private void listBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProduct(listBoxCatalog.SelectedIndex);
        }
    }
}
