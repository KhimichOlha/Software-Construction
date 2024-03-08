namespace Product.UI
{
    partial class MainForm
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
            tcAddProduct = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            lbNameProduct = new Label();
            tbNameProduct = new TextBox();
            tbPriceProduct = new TextBox();
            lbPriceProduct = new Label();
            tbunitOfMeasurement = new TextBox();
            lbunitOfMeasurement = new Label();
            lbDate = new Label();
            dtDate = new DateTimePicker();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            lbRegisterIncoming = new Label();
            lb = new Label();
            tcAddProduct.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tcAddProduct
            // 
            tcAddProduct.Controls.Add(tabPage1);
            tcAddProduct.Controls.Add(tabPage2);
            tcAddProduct.Controls.Add(tabPage3);
            tcAddProduct.Controls.Add(tabPage4);
            tcAddProduct.Controls.Add(tabPage5);
            tcAddProduct.Dock = DockStyle.Fill;
            tcAddProduct.Location = new Point(0, 0);
            tcAddProduct.Name = "tcAddProduct";
            tcAddProduct.SelectedIndex = 0;
            tcAddProduct.Size = new Size(840, 511);
            tcAddProduct.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtDate);
            tabPage1.Controls.Add(lbDate);
            tabPage1.Controls.Add(tbunitOfMeasurement);
            tabPage1.Controls.Add(lbunitOfMeasurement);
            tabPage1.Controls.Add(tbPriceProduct);
            tabPage1.Controls.Add(lbPriceProduct);
            tabPage1.Controls.Add(tbNameProduct);
            tabPage1.Controls.Add(lbNameProduct);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(832, 478);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add product";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Basket";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbNameProduct
            // 
            lbNameProduct.AutoSize = true;
            lbNameProduct.Location = new Point(26, 21);
            lbNameProduct.Name = "lbNameProduct";
            lbNameProduct.Size = new Size(106, 20);
            lbNameProduct.TabIndex = 0;
            lbNameProduct.Text = "Назва товару ";
            // 
            // tbNameProduct
            // 
            tbNameProduct.Location = new Point(26, 53);
            tbNameProduct.Name = "tbNameProduct";
            tbNameProduct.Size = new Size(125, 27);
            tbNameProduct.TabIndex = 1;
            tbNameProduct.TextChanged += textBox1_TextChanged;
            // 
            // tbPriceProduct
            // 
            tbPriceProduct.Location = new Point(26, 141);
            tbPriceProduct.Name = "tbPriceProduct";
            tbPriceProduct.Size = new Size(125, 27);
            tbPriceProduct.TabIndex = 3;
            // 
            // lbPriceProduct
            // 
            lbPriceProduct.AutoSize = true;
            lbPriceProduct.Location = new Point(26, 103);
            lbPriceProduct.Name = "lbPriceProduct";
            lbPriceProduct.Size = new Size(41, 20);
            lbPriceProduct.TabIndex = 2;
            lbPriceProduct.Text = "Ціна";
            // 
            // tbunitOfMeasurement
            // 
            tbunitOfMeasurement.Location = new Point(26, 214);
            tbunitOfMeasurement.Name = "tbunitOfMeasurement";
            tbunitOfMeasurement.Size = new Size(125, 27);
            tbunitOfMeasurement.TabIndex = 5;
            // 
            // lbunitOfMeasurement
            // 
            lbunitOfMeasurement.AutoSize = true;
            lbunitOfMeasurement.Location = new Point(26, 191);
            lbunitOfMeasurement.Name = "lbunitOfMeasurement";
            lbunitOfMeasurement.Size = new Size(124, 20);
            lbunitOfMeasurement.TabIndex = 4;
            lbunitOfMeasurement.Text = "Одиниця виміру";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(26, 270);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(108, 20);
            lbDate.TabIndex = 8;
            lbDate.Text = "Дата поставки";
            lbDate.Click += label5_Click;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(26, 311);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(250, 27);
            dtDate.TabIndex = 9;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(832, 478);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Залишки на складі";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lb);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(832, 478);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Пробуткова накладна";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(lbRegisterIncoming);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(832, 478);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Видаткова накладна";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // lbRegisterIncoming
            // 
            lbRegisterIncoming.AutoSize = true;
            lbRegisterIncoming.Dock = DockStyle.Fill;
            lbRegisterIncoming.Location = new Point(3, 3);
            lbRegisterIncoming.Name = "lbRegisterIncoming";
            lbRegisterIncoming.Size = new Size(0, 20);
            lbRegisterIncoming.TabIndex = 0;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(2, 1);
            lb.Name = "lb";
            lb.Size = new Size(50, 20);
            lb.TabIndex = 0;
            lb.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 511);
            Controls.Add(tcAddProduct);
            Name = "MainForm";
            Text = "Main";
            tcAddProduct.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAddProduct;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox tbunitOfMeasurement;
        private Label lbunitOfMeasurement;
        private TextBox tbPriceProduct;
        private Label lbPriceProduct;
        private TextBox tbNameProduct;
        private Label lbNameProduct;
        private Label lbDate;
        private DateTimePicker dtDate;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label lbRegisterIncoming;
        private Label lb;
    }
}
