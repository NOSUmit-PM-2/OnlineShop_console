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
            button1 = new Button();
            labelDescription = new Label();
            labelProductName = new Label();
            label2 = new Label();
            cartViewBtn = new Button();
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
            panelCatalog.Margin = new Padding(3, 4, 3, 4);
            panelCatalog.Name = "panelCatalog";
            panelCatalog.Size = new Size(412, 600);
            panelCatalog.TabIndex = 0;
            // 
            // listBoxCatalog
            // 
            listBoxCatalog.FormattingEnabled = true;
            listBoxCatalog.Location = new Point(31, 84);
            listBoxCatalog.Margin = new Padding(3, 4, 3, 4);
            listBoxCatalog.Name = "listBoxCatalog";
            listBoxCatalog.Size = new Size(354, 464);
            listBoxCatalog.TabIndex = 1;
            listBoxCatalog.SelectedIndexChanged += listBoxCatalog_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 40);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Список товаров";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(412, 0);
            splitter1.Margin = new Padding(3, 4, 3, 4);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 600);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panelProduct
            // 
            panelProduct.BackColor = SystemColors.ControlLight;
            panelProduct.Controls.Add(cartViewBtn);
            panelProduct.Controls.Add(button1);
            panelProduct.Controls.Add(labelDescription);
            panelProduct.Controls.Add(labelProductName);
            panelProduct.Controls.Add(label2);
            panelProduct.Dock = DockStyle.Fill;
            panelProduct.Location = new Point(415, 0);
            panelProduct.Margin = new Padding(3, 4, 3, 4);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(499, 600);
            panelProduct.TabIndex = 2;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(295, 518);
            button1.Name = "button1";
            button1.Size = new Size(159, 30);
            button1.TabIndex = 4;
            button1.Text = "Добавить в корзину";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelDescription
            // 
            labelDescription.BackColor = SystemColors.ActiveCaption;
            labelDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelDescription.ForeColor = SystemColors.ActiveCaptionText;
            labelDescription.Location = new Point(127, 191);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(327, 176);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Название товара";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelProductName.Location = new Point(127, 137);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(245, 37);
            labelProductName.TabIndex = 2;
            labelProductName.Text = "Название товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 100);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 1;
            label2.Text = "Карточка товара";
            // 
            // cartViewBtn
            // 
            cartViewBtn.Location = new Point(393, 12);
            cartViewBtn.Name = "cartViewBtn";
            cartViewBtn.Size = new Size(94, 29);
            cartViewBtn.TabIndex = 5;
            cartViewBtn.Text = "Корзина";
            cartViewBtn.UseVisualStyleBackColor = true;
            cartViewBtn.Click += cartViewBtn_Click;
            // 
            // FormCatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelProduct);
            Controls.Add(splitter1);
            Controls.Add(panelCatalog);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
        private Button cartViewBtn;
    }
}
