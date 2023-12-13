using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба_5_2_зад
{
    public partial class mainForm : Form
    {
        private static short n = 4;
        private short[,] tileSize = new short[n, 2]; //список возможных размеров плитки
        private short[] tileCount = new short[n]; //список для выбора количества плитки

        public mainForm()
        {
            InitializeComponent();
            tileSize[0, 0] = 10; //ширина
            tileSize[0, 1] = 10; //высота

            tileSize[1, 0] = 15;
            tileSize[1, 1] = 15;

            tileSize[2, 0] = 10;
            tileSize[2, 1] = 15;

            tileSize[3, 0] = 20;
            tileSize[3, 1] = 20;

            //заполение списка "количество" tileCount[0] = 8;
            tileCount[1] = 10;
            tileCount[2] = 12;
            tileCount[3] = 20;
            for (int i = 0; i < n; i++) //заполняем список "размеры плитки"
                                 comboBoxTileSize.Items.Add(String.Format("{0}*{1}", tileSize[i, 0], tileSize[i, 1]));
                for (int i = 0; i < n; i++) //заполняем список "количество"
                                 comboBoxTileCount.Items.Add(String.Format("{0}", tileCount[i]));
            comboBoxTileSize.SelectedIndex = 0;
            comboBoxTileCount.SelectedIndex = 0;

        }

        private void textBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = (dynamic)sender; //преобразуем к общему объекту

            //запрещаем ввод любых символов, кроме цифр	и клавиши backspace
            //запрещаем ввод, если в поле уже 4 символа
            if ((((e.KeyChar < '0') || (e.KeyChar > '9')) && (e.KeyChar != '\b')) || ((txtBox.Text.Length > 3) && (e.KeyChar != '\b')))
            {
                e.Handled = true;
            }

        }

        private void textBoxResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = (dynamic)sender; //преобразуем к общему объекту

            //запрещаем ввод любых символов, кроме цифр	и клавиши backspace
            //запрещаем ввод, если в поле уже 4 символа
            if ((((e.KeyChar < '0') || (e.KeyChar > '9')) && (e.KeyChar != '\b')) || ((txtBox.Text.Length > 3) && (e.KeyChar != '\b')))
            {
                e.Handled = true;
            }

        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = (dynamic)sender; //преобразуем к общему объекту

            //запрещаем ввод любых символов, кроме цифр	и клавиши backspace
            //запрещаем ввод, если в поле уже 4 символа
            if ((((e.KeyChar < '0') || (e.KeyChar > '9')) && (e.KeyChar != '\b')) || ((txtBox.Text.Length > 3) && (e.KeyChar != '\b')))
            {
                e.Handled = true;
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            double w = Convert.ToDouble(textBoxWidth.Text); //ширина поверхности
            double h = Convert.ToDouble(textBoxHeight.Text); //высота поверхности

            double a = tileSize[comboBoxTileSize.SelectedIndex, 0]; //ширина плитки
            double b = tileSize[comboBoxTileSize.SelectedIndex, 1]; //высота плитки

            short c = tileCount[comboBoxTileCount.SelectedIndex]; //кол-во плиток в упаковке

            //расчет количества упаковок c "округлением" результата в большую сторону
            double res = Math.Ceiling((w / a) * (h / b) / c);

            textBoxResult.Text = res.ToString(); //вывод результата в текстовое поле

        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Выйти из программы?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false; //разрешаем выход из программы
            else
        e.Cancel = true;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
           
                Form2 formHelp = new Form2(); //создание экземпляра формы
                formHelp.ShowDialog();  //открытие формы в модальном режиме
            

        }
    }
}
