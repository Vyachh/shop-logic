using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Магазин
{
    public partial class Form2 : Form
    {


        int productIndex; // Индекс выбранного числа в списке productList
        int[] price = { 100, 70, 625, 150, 50, 900, 53, 200, 870, 75, 64 }; // Цены товаров, совпадающие с наименованиями
        string[] product =

                {"Апельсины" ,
                    "Картошка" ,
                    "Колбаса" ,
                    "Макароны" ,
                    "Мука" ,
                    "Мясо" ,
                    "Соль" ,
                    "Сельдерей" ,
                    "Сыр" ,
                    "Сахар" ,
                    "Хлеб"};                                             // Наименования продуктов
        int balanceF2;


        public Form2(int balanceF1) // Баланс, полученный из Form1
        {
            InitializeComponent();
            balanceF2 = balanceF1;
            balance_lbl.Text = balanceF1.ToString() + " руб";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            productList.Items.Clear();
            productList.SmallImageList = productsList_Img; // Загрузка изображений для списка товаров
            ShoppingCart_productList.SmallImageList = productsList_Img; // И корзины
            imageHeader.Width = productsList_Img.ImageSize.Width + 5; // Корректировка ширины столбца с изображением
            for (int i = 0; i < productsList_Img.Images.Count; i++) // Добавление единицы товара
            {
                var listViewItem = new ListViewItem(new string[] { "", product[i], price[i].ToString() + " руб" });
                listViewItem.ImageIndex = i;
                productList.Items.Add(listViewItem);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (productList.FocusedItem == null) return;
            productIndex = productList.FocusedItem.Index; // Запись выбранного индекса в переменную
        }

        private void Buy_btn_Click(object sender, EventArgs e)
        {
            string namesOfSelectedElements = ""; // Переменная для составления списка купленных товаров
            int sum = 0; // Сумма всех товаров в корзине
            for (int i = 0; i < ShoppingCart_productList.Items.Count; i++)
            {
                namesOfSelectedElements += "\n" + product[productIndexList[i]].ToString();
                sum += price[productIndexList[i]];
            }
            if (balanceF2 - sum < 0)
            {
                MessageBox.Show("У вас не хватает денег!", "Внимание");
            }
            else if (ShoppingCart_productList.Items.Count != 0)
            {
                int cartItemsCount = ShoppingCart_productList.Items.Count; // Запись количества товаров в корзине для корректной работы
                for (int i = 0; i < cartItemsCount; i++) // Очистка корзины
                {
                    ShoppingCart_productList.Items.RemoveAt(0);
                }
                balanceF2 -= sum * countOfItemsInCart;
                MessageBox.Show($"ЧЕК \n на суммму: {sum * countOfItemsInCart} руб \n Вы купили {namesOfSelectedElements}  ", "Операция выполнена успешно!");
                // Вывод чека с потраченной суммой и списком купленных товаров.
                balance_lbl.Text = balanceF2.ToString(); // Запись оставшейся суммы
                productIndexList.Clear();
                sumOfItemsInCart = 0;
                priceOfItemsInCart.Text = "";
            }
            else
            {
                MessageBox.Show("Выберите товары и добавьте в корзину", "Ошибка");
            }

        }
        int sumOfItemsInCart = 0;
        List<int> productIndexList = new List<int>(); // Список индексов для вывода его в корзину и работы с корзиной

        int countOfItemsInCart; // Количество определенного продукта
        private void btn_AddToCart_Click(object sender, EventArgs e) // Добавление выбранного товара в корзину
        {

            if (!productIndexList.Contains(productIndex))
            {
                countOfItemsInCart = 1;
                productIndexList.Add(productIndex);
                var listViewItem = new ListViewItem
                (new string[] { "", product[productIndex], price[productIndex].ToString(), countOfItemsInCart.ToString() });
                listViewItem.ImageIndex = productIndex;
                ShoppingCart_productList.Items.Add(listViewItem);
                CalculateTheSum();
            }
            else
            {
                MessageBox.Show("Товар уже добавлен в корзину", "Внимание");
            }
        }
        private void btn_DelToCart_Click(object sender, EventArgs e) // Удаление выбранного товара из корзины и из списка индексов
        {
            if (ShoppingCart_productList.FocusedItem == null) return;
            int a = ShoppingCart_productList.FocusedItem.Index;
            ShoppingCart_productList.Items.RemoveAt(a);
            int subtraction = (price[productIndexList[a]] * countOfItemsInCart);
            sumOfItemsInCart = int.Parse(priceOfItemsInCart.Text) - subtraction;
            productIndexList.RemoveAt(a);
            priceOfItemsInCart.Text = sumOfItemsInCart.ToString();
        }

        private void ChangeCount_Click(object sender, EventArgs e)
        {
            int a = ShoppingCart_productList.FocusedItem.Index;
            countOfItemsInCart = (int)ItemsCountUpDown.Value;
            ShoppingCart_productList.Items.RemoveAt(ShoppingCart_productList.FocusedItem.Index);
            ListViewItem listViewItem = new ListViewItem(new string[] { "", product[productIndexList[a]], price[productIndexList[a]].ToString(), countOfItemsInCart.ToString() });
            listViewItem.ImageIndex = productIndexList[a];
            ShoppingCart_productList.Items.Insert(a, listViewItem);
            CalculateTheSum();
        }

        private void CalculateTheSum()
        {
            int sumOfItemsInCart = 0;
            for (int i = 0; i < ShoppingCart_productList.Items.Count; i++)
            {
                sumOfItemsInCart += price[productIndexList[i]] * int.Parse(ShoppingCart_productList.Items[i].SubItems[3].Text); ;
            }
            priceOfItemsInCart.Text = sumOfItemsInCart.ToString();
            ItemsCountUpDown.Value = 1;
        }
    }
}