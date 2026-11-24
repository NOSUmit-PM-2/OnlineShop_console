namespace WinFormOnlineShop_2026
{
    partial class FormCart
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
            buttonPlus = new Button();
            buttonMinus = new Button();
            labelTotal = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // listBoxCart
            // 
            listBoxCart.FormattingEnabled = true;
            listBoxCart.Location = new Point(66, 60);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(441, 104);
            listBoxCart.TabIndex = 0;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(174, 207);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(94, 29);
            buttonPlus.TabIndex = 1;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(300, 207);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(94, 29);
            buttonMinus.TabIndex = 2;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(38, 311);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(97, 20);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "Итого: 0 руб.";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(237, 312);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(buttonClose);
            Controls.Add(labelTotal);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(listBoxCart);
            Name = "FormCart";
            Text = "Корзина";
            Load += FormCart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCart;
        private Button buttonPlus;
        private Button buttonMinus;
        private Label labelTotal;
        private Button buttonClose;
    }
}