namespace WinFormOnlineShop_2026
{
    partial class FormCatalog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelCatalog = new Panel();
            listBoxCatalog = new ListBox();
            label1 = new Label();
            splitter1 = new Splitter();
            panelProduct = new Panel();
            buttonOpenCart = new Button();
            buttonAddToCart = new Button();
            labelDescription = new Label();
            labelProductName = new Label();
            label2 = new Label();
            panelCatalog.SuspendLayout();
            panelProduct.SuspendLayout();
            SuspendLayout();
            // 
            // panelCatalog
            // 
            panelCatalog.Controls.Add(listBoxCatalog);
            panelCatalog.Controls.Add(label1);
            panelCatalog.Dock = DockStyle.Left;
            panelCatalog.Location = new Point(0, 0);
            panelCatalog.Name = "panelCatalog";
            panelCatalog.Size = new Size(255, 450);
            panelCatalog.TabIndex = 0;
            panelCatalog.Paint += panelCatalog_Paint;
            // 
            // listBoxCatalog
            // 
            listBoxCatalog.FormattingEnabled = true;
            listBoxCatalog.ItemHeight = 15;
            listBoxCatalog.Location = new Point(12, 63);
            listBoxCatalog.Name = "listBoxCatalog";
            listBoxCatalog.Size = new Size(224, 349);
            listBoxCatalog.TabIndex = 1;
            listBoxCatalog.SelectedIndexChanged += listBoxCatalog_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Список товаров";
            label1.Click += label1_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(255, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 450);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panelProduct
            // 
            panelProduct.BackColor = SystemColors.ControlLight;
            panelProduct.Controls.Add(buttonOpenCart);
            panelProduct.Controls.Add(buttonAddToCart);
            panelProduct.Controls.Add(labelDescription);
            panelProduct.Controls.Add(labelProductName);
            panelProduct.Controls.Add(label2);
            panelProduct.Dock = DockStyle.Fill;
            panelProduct.Location = new Point(258, 0);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(542, 450);
            panelProduct.TabIndex = 2;
            // 
            // buttonOpenCart
            // 
            buttonOpenCart.Location = new Point(430, 12);
            buttonOpenCart.Name = "buttonOpenCart";
            buttonOpenCart.Size = new Size(103, 50);
            buttonOpenCart.TabIndex = 5;
            buttonOpenCart.Text = "Корзина";
            buttonOpenCart.UseVisualStyleBackColor = true;
            buttonOpenCart.Click += buttonOpenCart_Click;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Location = new Point(430, 360);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(85, 52);
            buttonAddToCart.TabIndex = 4;
            buttonAddToCart.Text = "Добавить в корзину";
            buttonAddToCart.UseVisualStyleBackColor = true;
            buttonAddToCart.Click += buttonAddToCart_Click;
            // 
            // labelDescription
            // 
            labelDescription.BackColor = SystemColors.ActiveCaption;
            labelDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelDescription.ForeColor = SystemColors.ActiveCaptionText;
            labelDescription.Location = new Point(111, 143);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(286, 132);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Название товара";
            labelDescription.Click += labelDescription_Click;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelProductName.Location = new Point(111, 103);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(186, 30);
            labelProductName.TabIndex = 2;
            labelProductName.Text = "Название товара";
            labelProductName.Click += labelProductName_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 75);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Карточка товара";
            label2.Click += label2_Click;
            // 
            // FormCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelProduct);
            Controls.Add(splitter1);
            Controls.Add(panelCatalog);
            Name = "FormCatalog";
            Text = "Каталог";
            Load += FormCatalog_Load;
            panelCatalog.ResumeLayout(false);
            panelCatalog.PerformLayout();
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCatalog;
        private Splitter splitter1;
        private Panel panelProduct;
        private ListBox listBoxCatalog;
        private Label label1;
        private Label labelProductName;
        private Label label2;
        private Label labelDescription;
        private Button buttonOpenCart;
        private Button buttonAddToCart;
    }
}
