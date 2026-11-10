namespace WinFormOnlineShop_2026
{
    partial class FormBasket
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
            panel1 = new Panel();
            listBoxBasket = new ListBox();
            panel2 = new Panel();
            labelCost = new Label();
            buttonMinus = new Button();
            buttonPlus = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(listBoxBasket);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 450);
            panel1.TabIndex = 0;
            // 
            // listBoxBasket
            // 
            listBoxBasket.Dock = DockStyle.Fill;
            listBoxBasket.FormattingEnabled = true;
            listBoxBasket.ItemHeight = 15;
            listBoxBasket.Location = new Point(0, 0);
            listBoxBasket.Margin = new Padding(50);
            listBoxBasket.Name = "listBoxBasket";
            listBoxBasket.Size = new Size(416, 450);
            listBoxBasket.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelCost);
            panel2.Controls.Add(buttonMinus);
            panel2.Controls.Add(buttonPlus);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(422, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 450);
            panel2.TabIndex = 1;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Segoe UI", 18F);
            labelCost.Location = new Point(47, 83);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(136, 32);
            labelCost.TabIndex = 2;
            labelCost.Text = "Стоимость:";
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(47, 191);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(70, 58);
            buttonMinus.TabIndex = 1;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(123, 191);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(67, 58);
            buttonPlus.TabIndex = 0;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // FormBasket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormBasket";
            Text = "FormBasket";
            Load += FormBasket_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBoxBasket;
        private Panel panel2;
        private Label labelCost;
        private Button buttonMinus;
        private Button buttonPlus;
    }
}