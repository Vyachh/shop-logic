
namespace Магазин
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.productList = new System.Windows.Forms.ListView();
            this.imageHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.productsList_Img = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.balance_lbl = new System.Windows.Forms.Label();
            this.Buy_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ShoppingCart_productList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_AddToCart = new System.Windows.Forms.Button();
            this.btn_DelFromCart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceOfItemsInCart = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemsCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChangeCount = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsCountUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // productList
            // 
            this.productList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.imageHeader,
            this.nameHeader,
            this.priceHeader});
            this.productList.FullRowSelect = true;
            this.productList.HideSelection = false;
            this.productList.Location = new System.Drawing.Point(3, 18);
            this.productList.MultiSelect = false;
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(320, 315);
            this.productList.TabIndex = 3;
            this.productList.UseCompatibleStateImageBehavior = false;
            this.productList.View = System.Windows.Forms.View.Details;
            this.productList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // imageHeader
            // 
            this.imageHeader.Text = "Изображение";
            this.imageHeader.Width = 107;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Название продукта";
            this.nameHeader.Width = 114;
            // 
            // priceHeader
            // 
            this.priceHeader.Text = "Цена, кг.";
            this.priceHeader.Width = 98;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productsList_Img
            // 
            this.productsList_Img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("productsList_Img.ImageStream")));
            this.productsList_Img.TransparentColor = System.Drawing.Color.Transparent;
            this.productsList_Img.Images.SetKeyName(0, "apelsines.jpg");
            this.productsList_Img.Images.SetKeyName(1, "kartofel.png");
            this.productsList_Img.Images.SetKeyName(2, "kolbasa.jpg");
            this.productsList_Img.Images.SetKeyName(3, "makarones.jpg");
            this.productsList_Img.Images.SetKeyName(4, "muka.jpg");
            this.productsList_Img.Images.SetKeyName(5, "p_O.jpg");
            this.productsList_Img.Images.SetKeyName(6, "salt.png");
            this.productsList_Img.Images.SetKeyName(7, "selderei.jpg");
            this.productsList_Img.Images.SetKeyName(8, "sir.jpg");
            this.productsList_Img.Images.SetKeyName(9, "sugar.jpg");
            this.productsList_Img.Images.SetKeyName(10, "xleb.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ваш баланс составляет:";
            // 
            // balance_lbl
            // 
            this.balance_lbl.AutoSize = true;
            this.balance_lbl.Location = new System.Drawing.Point(141, 2);
            this.balance_lbl.Name = "balance_lbl";
            this.balance_lbl.Size = new System.Drawing.Size(0, 13);
            this.balance_lbl.TabIndex = 5;
            // 
            // Buy_btn
            // 
            this.Buy_btn.BackColor = System.Drawing.Color.Transparent;
            this.Buy_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Buy_btn.Location = new System.Drawing.Point(3, 5);
            this.Buy_btn.Name = "Buy_btn";
            this.Buy_btn.Size = new System.Drawing.Size(115, 27);
            this.Buy_btn.TabIndex = 7;
            this.Buy_btn.Text = "Купить";
            this.Buy_btn.UseVisualStyleBackColor = false;
            this.Buy_btn.Click += new System.EventHandler(this.Buy_btn_Click);
            // 
            // ShoppingCart_productList
            // 
            this.ShoppingCart_productList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShoppingCart_productList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader1});
            this.ShoppingCart_productList.FullRowSelect = true;
            this.ShoppingCart_productList.HideSelection = false;
            this.ShoppingCart_productList.Location = new System.Drawing.Point(3, 16);
            this.ShoppingCart_productList.MultiSelect = false;
            this.ShoppingCart_productList.Name = "ShoppingCart_productList";
            this.ShoppingCart_productList.Size = new System.Drawing.Size(363, 315);
            this.ShoppingCart_productList.TabIndex = 8;
            this.ShoppingCart_productList.UseCompatibleStateImageBehavior = false;
            this.ShoppingCart_productList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Изображение";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Название продукта";
            this.columnHeader5.Width = 114;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Цена, кг.";
            this.columnHeader6.Width = 62;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Количество";
            this.columnHeader1.Width = 75;
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddToCart.Location = new System.Drawing.Point(329, 18);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(100, 49);
            this.btn_AddToCart.TabIndex = 9;
            this.btn_AddToCart.Text = "Добавить в корзину";
            this.btn_AddToCart.UseVisualStyleBackColor = false;
            this.btn_AddToCart.Click += new System.EventHandler(this.btn_AddToCart_Click);
            // 
            // btn_DelFromCart
            // 
            this.btn_DelFromCart.BackColor = System.Drawing.Color.Transparent;
            this.btn_DelFromCart.ForeColor = System.Drawing.Color.Black;
            this.btn_DelFromCart.Location = new System.Drawing.Point(3, 42);
            this.btn_DelFromCart.Name = "btn_DelFromCart";
            this.btn_DelFromCart.Size = new System.Drawing.Size(115, 28);
            this.btn_DelFromCart.TabIndex = 10;
            this.btn_DelFromCart.Text = "Убрать из корзины";
            this.btn_DelFromCart.UseVisualStyleBackColor = false;
            this.btn_DelFromCart.Click += new System.EventHandler(this.btn_DelToCart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ваша корзина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Вы выбрали товаров на сумму:";
            // 
            // priceOfItemsInCart
            // 
            this.priceOfItemsInCart.AutoSize = true;
            this.priceOfItemsInCart.Location = new System.Drawing.Point(175, 334);
            this.priceOfItemsInCart.Name = "priceOfItemsInCart";
            this.priceOfItemsInCart.Size = new System.Drawing.Size(0, 13);
            this.priceOfItemsInCart.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ShoppingCart_productList);
            this.panel1.Controls.Add(this.priceOfItemsInCart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(449, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 358);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.balance_lbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_AddToCart);
            this.panel2.Controls.Add(this.productList);
            this.panel2.Location = new System.Drawing.Point(8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 358);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(2, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 46);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите количество \r\nпродуктов:";
            // 
            // ItemsCountUpDown
            // 
            this.ItemsCountUpDown.Location = new System.Drawing.Point(5, 53);
            this.ItemsCountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ItemsCountUpDown.Name = "ItemsCountUpDown";
            this.ItemsCountUpDown.Size = new System.Drawing.Size(99, 20);
            this.ItemsCountUpDown.TabIndex = 11;
            this.ItemsCountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ChangeCount
            // 
            this.ChangeCount.Location = new System.Drawing.Point(5, 79);
            this.ChangeCount.Name = "ChangeCount";
            this.ChangeCount.Size = new System.Drawing.Size(99, 23);
            this.ChangeCount.TabIndex = 14;
            this.ChangeCount.Text = "Изменить";
            this.ChangeCount.UseVisualStyleBackColor = true;
            this.ChangeCount.Click += new System.EventHandler(this.ChangeCount_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ChangeCount);
            this.panel3.Controls.Add(this.ItemsCountUpDown);
            this.panel3.Location = new System.Drawing.Point(372, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 115);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OliveDrab;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Buy_btn);
            this.panel4.Controls.Add(this.btn_DelFromCart);
            this.panel4.Location = new System.Drawing.Point(372, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 76);
            this.panel4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "paco";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Магазин.Properties.Resources.supermarket_shopboard_with_wicker_baskets_and_lug_boxes_with_tomatoes_cucumbers_and_avocados_88135_12323;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 421);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Моделирование работы магазина (демонстрация товаров, формирование и печать чека)";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsCountUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView productList;
        private System.Windows.Forms.ColumnHeader imageHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader priceHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList productsList_Img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balance_lbl;
        private System.Windows.Forms.Button Buy_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView ShoppingCart_productList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_AddToCart;
        private System.Windows.Forms.Button btn_DelFromCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label priceOfItemsInCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ItemsCountUpDown;
        private System.Windows.Forms.Button ChangeCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
    }
}