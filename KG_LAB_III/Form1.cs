using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KG_LAB_III
{
    public partial class Form1 : Form
    {

        int[,] kv = new int[4, 3]; // матрица тела
        int[,] osi = new int[4, 3]; // матрица координат осей
        int[,] matr_sdv = new int[3, 3]; //матрица преобразования
        int k, l; // элементы матрицы сдвига
        bool f = true;
        int[,] T90 = new int[2, 3];
        int[,] T180 = new int[2, 3];
        int[,] T270 = new int[2, 3];



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Init_T90()
        {
            T90[0,0] = 0; T90[0,1] = 1; T90[0, 2] = 1;
            T90[1,0] = -1; T90[1, 1] = 0; T90[1, 2] = 1;
        }
        private void Init_T180()
        {
            T180[0, 0] = -1; T180[0, 1] = 0; T180[0, 2] = 1;
            T180[1, 0] = 0; T180[1, 1] = -1; T180[1, 2] = 1;
        }
        private void Init_T270()
        {
            T270[0, 0] = 0; T270[0, 1] = -1; T270[0, 2] = 1;
            T270[1, 0] = 1; T270[1, 1] = 0; T270[1, 2] = 1;
        }
        //инициализация матрицы тела
        private void Init_kvadrat()
        {
            kv[0, 0] = -40; kv[0, 1] = 50; kv[0, 2] = 1;
            kv[1, 0] = 40; kv[1, 1] = -30; kv[1, 2] = 1;
            kv[2, 0] = 38; kv[2, 1] = 10; kv[2, 2] = 1;
            kv[3, 0] = -50; kv[3, 1] = -50; kv[3, 2] = 1;
        }

        //инициализация матрицы сдвига
        private void Init_matr_preob(int k1, int l1)
        {
            matr_sdv[0, 0] = 1; matr_sdv[0, 1] = 0; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = 0; matr_sdv[1, 1] = 1; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }

        //инициализация матрицы осей
        private void Init_osi()
        {
            osi[0, 0] = 0; osi[0, 1] = pictureBox1.Height / 2; osi[0, 2] = 1;
            osi[1, 0] = pictureBox1.Width; osi[1, 1] = pictureBox1.Height / 2; osi[1, 2] = 1;
            osi[2, 0] = pictureBox1.Width / 2; osi[2, 1] = 0; osi[2, 2] = 1;
            osi[3, 0] = pictureBox1.Width / 2; osi[3, 1] = pictureBox1.Height; osi[3, 2] = 1;
        }

        //умножение матриц
        private int[,] Multiply_matr(int[,] a, int[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            int[,] r = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    r[i, j] = 0;
                    for (int ii = 0; ii < m; ii++)
                    {
                        r[i, j] += a[i, ii] * b[ii, j];
                    }
                }
            }
            return r;
        }

        //вывод квадрата на экран
        private void Draw_Kv()
        {

            Init_kvadrat(); //инициализация матрицы тела
            Init_matr_preob(k, l); //инициализация матрицы преобразования
            int[,] kv1 = Multiply_matr(kv, matr_sdv); //перемножение матриц

            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen, kv1[3, 0], kv1[3, 1], kv1[0, 0], kv1[0, 1]);
            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen

        }
        //вывод осей на экран
        private void Draw_osi()
        {
            Init_osi(); //инициализация матрицы осей
            Pen myPen = new Pen(Color.Red, 1);// цвет линии и ширина
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            // рисуем ось ОХ
            g.DrawLine(myPen, osi[0, 0], osi[0, 1], osi[1, 0], osi[1, 1]);
            // рисуем ось ОУ
            g.DrawLine(myPen, osi[2, 0], osi[2, 1], osi[3, 0], osi[3, 1]);
            g.Dispose();
            myPen.Dispose();
        }

        private void Turn(int angle)
        {
            if (angle == 90)
            {
                Init_T90();
                kv = Multiply_matr(kv, T90); // Присваивание результата умножения обратно переменной kv
                Draw_Kv();
            }
            else if (angle == 180)
            {
                Init_T180();
                kv = Multiply_matr(kv, T180); // Присваивание результата умножения обратно переменной kv
                Draw_Kv();
            }
            else if (angle == 270)
            {
                Init_T270();
                kv = Multiply_matr(kv, T270); // Присваивание результата умножения обратно переменной kv
                Draw_Kv();
            }
        }

        private void buttonDrawAxes_Click(object sender, EventArgs e)
        {
            k = pictureBox1.Width / 2;
            l = pictureBox1.Height / 2;
            Draw_osi();
        }

        private void buttonDrawFigure_Click(object sender, EventArgs e)
        {
            //середина pictureBox
            k = pictureBox1.Width / 2;
            l = pictureBox1.Height / 2;
            //вывод квадратика в середине
            Draw_Kv();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void buttonSlideOxRt_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            Draw_osi();
            k += 5; //изменение соответствующего элемента матрицы сдвига
            Draw_Kv(); //вывод квадратика
        }

        private void buttonSlideOxLt_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            Draw_osi();
            k -= 5; //изменение соответствующего элемента матрицы сдвига
            Draw_Kv(); //вывод квадратика
        }

        private void buttonSlideOyDown_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            Draw_osi();
            l += 5; //изменение соответствующего элемента матрицы сдвига
            Draw_Kv(); //вывод квадратика
        }

        private void buttonSlideOyUp_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            Draw_osi();
            l -= 5; //изменение соответствующего элемента матрицы сдвига
            Draw_Kv(); //вывод квадратика
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            buttonStart.Text = "Стоп";
            if (f == true)
                timer1.Start();
            else
            {
                timer1.Stop();
                buttonStart.Text = "Старт";
            }
            f = !f;
        }

        private void Scale(int factor)
        {
            for (int i = 0; i < 4; i++)
            {
                kv[i, 0] *= factor;
                kv[i, 1] *= factor;
            }
            Draw_Kv();
        }
        private void buttonReflect_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Scale(2);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Scale(1/2);
        }

        private void buttonTurnLt_Click(object sender, EventArgs e)
        {
            Turn(90);
        }

        private void buttonTurnRt_Click(object sender, EventArgs e)
        {

        }

        private void buttonReflectOX_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            k++;
            Draw_Kv();
            Thread.Sleep(100);

        }

        
    }
}
