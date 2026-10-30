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
            listBoxCartItems = new ListBox();
            labelTotalSum = new Label();
            buttonPlus = new Button();
            buttonMinus = new Button();
            SuspendLayout();
            // 
            // listBoxCartItems
            // 
            listBoxCartItems.FormattingEnabled = true;
            listBoxCartItems.ItemHeight = 15;
            listBoxCartItems.Location = new Point(12, 12);
            listBoxCartItems.Name = "listBoxCartItems";
            listBoxCartItems.Size = new Size(377, 424);
            listBoxCartItems.TabIndex = 0;
            // 
            // labelTotalSum
            // 
            labelTotalSum.AutoSize = true;
            labelTotalSum.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTotalSum.Location = new Point(533, 84);
            labelTotalSum.Name = "labelTotalSum";
            labelTotalSum.Size = new Size(79, 32);
            labelTotalSum.TabIndex = 1;
            labelTotalSum.Text = "Итого";
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonPlus.Location = new Point(660, 225);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(47, 44);
            buttonPlus.TabIndex = 2;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMinus.Location = new Point(533, 225);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(52, 44);
            buttonMinus.TabIndex = 3;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(labelTotalSum);
            Controls.Add(listBoxCartItems);
            Name = "FormCart";
            Text = "FormCart";
            Load += FormCart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCartItems;
        private Label labelTotalSum;
        private Button buttonPlus;
        private Button buttonMinus;
    }
}