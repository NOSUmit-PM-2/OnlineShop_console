namespace WinFormOnlineShop_2026
{
    partial class FormCart
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            listViewCart = new ListView();
            columnName = new ColumnHeader();
            columnPrice = new ColumnHeader();
            columnCount = new ColumnHeader();
            columnSum = new ColumnHeader();
            labelEmpty = new Label();
            panelTop = new Panel();
            labelTitle = new Label();
            panelRight = new Panel();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonDelete = new Button();
            panelBottom = new Panel();
            labelTotal = new Label();
            buttonClose = new Button();
            panelTop.SuspendLayout();
            panelRight.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            listViewCart.BorderStyle = BorderStyle.None;
            listViewCart.Columns.AddRange(new ColumnHeader[] { columnName, columnPrice, columnCount, columnSum });
            listViewCart.Controls.Add(labelEmpty);
            listViewCart.Dock = DockStyle.Fill;
            listViewCart.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listViewCart.FullRowSelect = true;
            listViewCart.HideSelection = false;
            listViewCart.Location = new Point(0, 60);
            listViewCart.MultiSelect = false;
            listViewCart.Name = "listViewCart";
            listViewCart.Size = new Size(520, 290);
            listViewCart.TabIndex = 0;
            listViewCart.UseCompatibleStateImageBehavior = false;
            listViewCart.View = View.Details;
            columnName.Text = "Товар";
            columnName.Width = 200;
            columnPrice.Text = "Цена";
            columnPrice.TextAlign = HorizontalAlignment.Right;
            columnPrice.Width = 90;
            columnCount.Text = "Кол-во";
            columnCount.TextAlign = HorizontalAlignment.Center;
            columnCount.Width = 80;
            columnSum.Text = "Сумма";
            columnSum.TextAlign = HorizontalAlignment.Right;
            columnSum.Width = 120;
            labelEmpty.AutoSize = true;
            labelEmpty.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelEmpty.ForeColor = SystemColors.GrayText;
            labelEmpty.Location = new Point(20, 50);
            labelEmpty.Name = "labelEmpty";
            labelEmpty.Size = new Size(116, 21);
            labelEmpty.TabIndex = 6;
            labelEmpty.Text = "Корзина пуста";
            panelTop.BackColor = Color.FromArgb(45, 62, 80);
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(650, 60);
            panelTop.TabIndex = 3;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(16, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(190, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Ваша корзина";
            panelRight.BackColor = Color.WhiteSmoke;
            panelRight.Controls.Add(buttonDelete);
            panelRight.Controls.Add(buttonMinus);
            panelRight.Controls.Add(buttonPlus);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(520, 60);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(130, 290);
            panelRight.TabIndex = 2;
            buttonPlus.BackColor = Color.FromArgb(0, 120, 215);
            buttonPlus.Cursor = Cursors.Hand;
            buttonPlus.FlatAppearance.BorderSize = 0;
            buttonPlus.FlatStyle = FlatStyle.Flat;
            buttonPlus.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonPlus.ForeColor = Color.White;
            buttonPlus.Location = new Point(15, 20);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(100, 45);
            buttonPlus.TabIndex = 1;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            buttonMinus.BackColor = Color.FromArgb(0, 120, 215);
            buttonMinus.Cursor = Cursors.Hand;
            buttonMinus.FlatAppearance.BorderSize = 0;
            buttonMinus.FlatStyle = FlatStyle.Flat;
            buttonMinus.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMinus.ForeColor = Color.White;
            buttonMinus.Location = new Point(15, 75);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(100, 45);
            buttonMinus.TabIndex = 2;
            buttonMinus.Text = "−";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            buttonDelete.BackColor = Color.FromArgb(200, 70, 70);
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(15, 140);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 35);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            panelBottom.BackColor = Color.FromArgb(235, 240, 245);
            panelBottom.Controls.Add(labelTotal);
            panelBottom.Controls.Add(buttonClose);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 350);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(650, 70);
            panelBottom.TabIndex = 1;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTotal.Location = new Point(16, 20);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(250, 28);
            labelTotal.TabIndex = 5;
            labelTotal.Text = "Итого к оплате: 0 руб.";
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(535, 18);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(100, 35);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 420);
            Controls.Add(listViewCart);
            Controls.Add(panelRight);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            MinimumSize = new Size(560, 380);
            Name = "FormCart";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Корзина";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelRight.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewCart;
        private ColumnHeader columnName;
        private ColumnHeader columnPrice;
        private ColumnHeader columnCount;
        private ColumnHeader columnSum;
        private Label labelEmpty;
        private Panel panelTop;
        private Label labelTitle;
        private Panel panelRight;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonDelete;
        private Panel panelBottom;
        private Label labelTotal;
        private Button buttonClose;
    }
}
