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
            listBoxCartItems.Location = new Point(25, 39);
            listBoxCartItems.Name = "listBoxCartItems";
            listBoxCartItems.Size = new Size(517, 624);
            listBoxCartItems.TabIndex = 0;
            // 
            // labelTotalSum
            // 
            labelTotalSum.AutoSize = true;
            labelTotalSum.BackColor = SystemColors.AppWorkspace;
            labelTotalSum.Font = new Font("Segoe UI", 15F);
            labelTotalSum.Location = new Point(644, 39);
            labelTotalSum.Name = "labelTotalSum";
            labelTotalSum.Size = new Size(109, 35);
            labelTotalSum.TabIndex = 1;
            labelTotalSum.Text = "ИТОГО: ";
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 20F, FontStyle.Italic);
            buttonPlus.Location = new Point(644, 592);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(54, 58);
            buttonPlus.TabIndex = 2;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI", 20F, FontStyle.Italic);
            buttonMinus.Location = new Point(730, 592);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(54, 58);
            buttonMinus.TabIndex = 3;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 703);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(labelTotalSum);
            Controls.Add(listBoxCartItems);
            Name = "FormCart";
            Text = "FormCart";
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