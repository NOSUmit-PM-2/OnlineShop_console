namespace WinFormOnlineShop_2026
{
    partial class CartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxCart = new ListBox();
            label1 = new Label();
            buttonDec = new Button();
            buttonInc = new Button();
            labelTotalPrice = new Label();
            labelDescription = new Label();
            labelProductName = new Label();
            label2 = new Label();
            labelCountProduct = new Label();
            SuspendLayout();
            // 
            // listBoxCart
            // 
            listBoxCart.FormattingEnabled = true;
            listBoxCart.Location = new Point(34, 55);
            listBoxCart.Margin = new Padding(3, 4, 3, 4);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(354, 344);
            listBoxCart.TabIndex = 3;
            listBoxCart.SelectedIndexChanged += listBoxCart_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 11);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "Список товаров";
            // 
            // buttonDec
            // 
            buttonDec.Location = new Point(518, 370);
            buttonDec.Name = "buttonDec";
            buttonDec.Size = new Size(42, 29);
            buttonDec.TabIndex = 4;
            buttonDec.Text = "-";
            buttonDec.UseVisualStyleBackColor = true;
            buttonDec.Click += buttonDec_Click;
            // 
            // buttonInc
            // 
            buttonInc.Location = new Point(461, 370);
            buttonInc.Name = "buttonInc";
            buttonInc.Size = new Size(42, 29);
            buttonInc.TabIndex = 5;
            buttonInc.Text = "+";
            buttonInc.UseVisualStyleBackColor = true;
            buttonInc.Click += buttonInc_Click;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            labelTotalPrice.Location = new Point(522, 412);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(266, 37);
            labelTotalPrice.TabIndex = 6;
            labelTotalPrice.Text = "Итого: ";
            labelTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDescription
            // 
            labelDescription.BackColor = SystemColors.ActiveCaption;
            labelDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelDescription.ForeColor = SystemColors.ActiveCaptionText;
            labelDescription.Location = new Point(461, 165);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(327, 120);
            labelDescription.TabIndex = 9;
            labelDescription.Text = "Описание товара";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelProductName.Location = new Point(461, 111);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(245, 37);
            labelProductName.TabIndex = 8;
            labelProductName.Text = "Название товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 74);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 7;
            label2.Text = "Карточка товара";
            // 
            // labelCountProduct
            // 
            labelCountProduct.AutoSize = true;
            labelCountProduct.Location = new Point(461, 299);
            labelCountProduct.Name = "labelCountProduct";
            labelCountProduct.Size = new Size(97, 20);
            labelCountProduct.TabIndex = 10;
            labelCountProduct.Text = "Количество: ";
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(labelCountProduct);
            Controls.Add(labelDescription);
            Controls.Add(labelProductName);
            Controls.Add(label2);
            Controls.Add(labelTotalPrice);
            Controls.Add(buttonInc);
            Controls.Add(buttonDec);
            Controls.Add(listBoxCart);
            Controls.Add(label1);
            Name = "CartForm";
            Text = "CartForm";
            Load += CartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCart;
        private Label label1;
        private Button buttonDec;
        private Button buttonInc;
        private Label labelTotalPrice;
        private Label labelDescription;
        private Label labelProductName;
        private Label label2;
        private Label labelCountProduct;
    }
}