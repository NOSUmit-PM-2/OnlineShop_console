namespace WinFormOnlineShop_2026
{
    partial class UserCart
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
            listBoxUserCart = new ListBox();
            buttonQuit = new Button();
            labelPrice = new Label();
            buttonDelete = new Button();
            buttonAdd = new Button();
            buttonMinus = new Button();
            SuspendLayout();
            // 
            // listBoxUserCart
            // 
            listBoxUserCart.FormattingEnabled = true;
            listBoxUserCart.ItemHeight = 15;
            listBoxUserCart.Location = new Point(14, 11);
            listBoxUserCart.Name = "listBoxUserCart";
            listBoxUserCart.Size = new Size(231, 544);
            listBoxUserCart.TabIndex = 0;
            // 
            // buttonQuit
            // 
            buttonQuit.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            buttonQuit.Location = new Point(251, 488);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(154, 100);
            buttonQuit.TabIndex = 1;
            buttonQuit.Text = "Выход";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelPrice.Location = new Point(251, 171);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(68, 25);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Цена: ";
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDelete.Location = new Point(251, 396);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(154, 72);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Убрать товар";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI Black", 30.75F, FontStyle.Bold);
            buttonAdd.Location = new Point(251, 302);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(69, 72);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI Semibold", 30.75F, FontStyle.Bold);
            buttonMinus.Location = new Point(336, 302);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(69, 72);
            buttonMinus.TabIndex = 5;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // UserCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 600);
            Controls.Add(buttonMinus);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelete);
            Controls.Add(labelPrice);
            Controls.Add(buttonQuit);
            Controls.Add(listBoxUserCart);
            Name = "UserCart";
            Text = "UserCart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxUserCart;
        private Button buttonQuit;
        private Label labelPrice;
        private Button buttonDelete;
        private Button buttonAdd;
        private Button buttonMinus;
    }
}