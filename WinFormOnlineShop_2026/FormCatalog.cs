using OnlineShop;
using System.Windows.Forms;

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
            listBoxCatalog.SelectedIndex = 0;
            labelProductName.Text = catalog[1].Name;
            labelDescription.Text = catalog[1].Description;
            labelDescription.Text += "\n" + "Цена товара: " + catalog[1].Price;
        }
        void ShowCatalog()
        {
            int i = 0;
            foreach (Product product in catalog.getAll())
                listBoxCatalog.Items.Add($"{++i} {product}");
        }

        private void listBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelProductName.Text = catalog[listBoxCatalog.SelectedIndex+1].Name;
            labelDescription.Text = catalog[listBoxCatalog.SelectedIndex+1].Description;
            labelDescription.Text += "\n" + "Цена товара: " + catalog[listBoxCatalog.SelectedIndex+1].Price;
        }
    }
}
