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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) // выход
        {
            Application.Exit();
        }
        private void btn_OpenF2_Click(object sender, EventArgs e)
        {
            try
            {
                int balance = Convert.ToInt32(totalsum_textBox.Text); // Получаю баланс из textBox.Text
                if (balance >= 50) // 50 руб - минимальная стоимость единицы товара в магазине
                {
                    Form2 f2 = new Form2(balance); // Переношу баланс во вторую форму с магазином
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ваш баланс должен быть больше 50 руб., чтобы войти в магазин", "Ошибка");
                }
            }
            catch
            {
                MessageBox.Show("Введите сумму вашего счета", "Ошибка"); // При введении неправильного формата выдастся ошибка
            }
        }
    }
}
