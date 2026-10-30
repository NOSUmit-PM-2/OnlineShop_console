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
			label1 = new Label();
			listViewCart = new ListView();
			columnHeaderNumber = new ColumnHeader();
			columnHeaderName = new ColumnHeader();
			columnHeaderPrice = new ColumnHeader();
			columnHeaderCount = new ColumnHeader();
			columnHeaderCost = new ColumnHeader();
			buttonInc = new Button();
			label2 = new Label();
			buttonDec = new Button();
			buttonRem = new Button();
			labelSum = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(108, 15);
			label1.TabIndex = 0;
			label1.Text = "Товары в корзине:";
			// 
			// listViewCart
			// 
			listViewCart.Columns.AddRange(new ColumnHeader[] { columnHeaderNumber, columnHeaderName, columnHeaderPrice, columnHeaderCount, columnHeaderCost });
			listViewCart.FullRowSelect = true;
			listViewCart.Location = new Point(12, 27);
			listViewCart.MultiSelect = false;
			listViewCart.Name = "listViewCart";
			listViewCart.Size = new Size(643, 364);
			listViewCart.TabIndex = 1;
			listViewCart.UseCompatibleStateImageBehavior = false;
			listViewCart.View = View.Details;
			listViewCart.SelectedIndexChanged += listViewCart_SelectedIndexChanged;
			// 
			// columnHeaderNumber
			// 
			columnHeaderNumber.Text = "№";
			// 
			// columnHeaderName
			// 
			columnHeaderName.Text = "Название";
			columnHeaderName.Width = 120;
			// 
			// columnHeaderPrice
			// 
			columnHeaderPrice.Text = "Цена за шт";
			columnHeaderPrice.Width = 120;
			// 
			// columnHeaderCount
			// 
			columnHeaderCount.Text = "Количество";
			columnHeaderCount.Width = 120;
			// 
			// columnHeaderCost
			// 
			columnHeaderCost.Text = "Стоимость";
			columnHeaderCost.Width = 120;
			// 
			// buttonInc
			// 
			buttonInc.Location = new Point(661, 27);
			buttonInc.Name = "buttonInc";
			buttonInc.Size = new Size(127, 47);
			buttonInc.TabIndex = 2;
			buttonInc.Text = "Увеличить количество";
			buttonInc.UseVisualStyleBackColor = true;
			buttonInc.Click += buttonInc_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(661, 9);
			label2.Name = "label2";
			label2.Size = new Size(110, 15);
			label2.TabIndex = 3;
			label2.Text = "Выбранный товар:";
			// 
			// buttonDec
			// 
			buttonDec.Location = new Point(661, 80);
			buttonDec.Name = "buttonDec";
			buttonDec.Size = new Size(127, 47);
			buttonDec.TabIndex = 4;
			buttonDec.Text = "Уменьшить количество";
			buttonDec.UseVisualStyleBackColor = true;
			buttonDec.Click += buttonDec_Click;
			// 
			// buttonRem
			// 
			buttonRem.Location = new Point(661, 133);
			buttonRem.Name = "buttonRem";
			buttonRem.Size = new Size(127, 47);
			buttonRem.TabIndex = 5;
			buttonRem.Text = "Удалить товар";
			buttonRem.UseVisualStyleBackColor = true;
			buttonRem.Click += buttonRem_Click;
			// 
			// labelSum
			// 
			labelSum.AutoSize = true;
			labelSum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			labelSum.Location = new Point(249, 408);
			labelSum.Name = "labelSum";
			labelSum.Size = new Size(56, 21);
			labelSum.TabIndex = 6;
			labelSum.Text = "Итого:";
			// 
			// FormCart
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(labelSum);
			Controls.Add(buttonRem);
			Controls.Add(buttonDec);
			Controls.Add(label2);
			Controls.Add(buttonInc);
			Controls.Add(listViewCart);
			Controls.Add(label1);
			Name = "FormCart";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ListView listViewCart;
		private Button buttonInc;
		private Label label2;
		private Button buttonDec;
		private Button buttonRem;
		private Label labelSum;
		private ColumnHeader columnHeaderNumber;
		private ColumnHeader columnHeaderName;
		private ColumnHeader columnHeaderPrice;
		private ColumnHeader columnHeaderCount;
		private ColumnHeader columnHeaderCost;
	}
}