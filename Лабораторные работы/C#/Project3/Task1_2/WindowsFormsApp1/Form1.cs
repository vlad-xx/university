using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp1
{


    /// <summary>
    /// главное окно
    /// </summary>
    public partial class MainForm : Form
    {


        #region главные переменные

        int[] mainArr;

        /* 
        * ................................
        * длина массива
        * начало диапазона
        * конец диапазона
        * ................................
        */

        // параметры массива
        int arrLength;
        int rangeFrom;
        int rangeTo;

        #endregion


        #region форма

        /// <summary>
        /// инициализация компонентов формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // установка параметров графика среднего времени
            setParamsChartMidTime(
                "Анализ временной эффективности методов",
                "Кол-во элементов",
                "Среднее время сортировки массива (наносек.)"
                );

        }
        
        #endregion 


        #region график

        /// <summary>
        /// установка параметров графика среднего времени
        /// </summary>
        /// <param name="mainTitle">заголовок графика</param>
        /// <param name="xTitle">заголовок по оси X</param>
        /// <param name="yTitle">заголовок по оси Y</param>
        private void setParamsChartMidTime(string mainTitle, string xTitle, string yTitle) 
        {
            // заголовок графика
            chartMidTime.Titles.Add(mainTitle);

            // заголовки осей
            chartMidTime.ChartAreas[0].AxisX.Title = xTitle;
            chartMidTime.ChartAreas[0].AxisY.Title = yTitle;
        }


        /// <summary>
        /// добавить линию на график
        /// </summary>
        /// <param name="points">точки для отрисовик графика</param>
        /// <param name="nameLine">название линии</param>
        private void addLine(int[] points, string nameLine)
        {
            // создание линии
            Series line = new Series(nameLine);
            line.Points.DataBindY(points);
            line.ChartType = SeriesChartType.Line;
            line.BorderWidth = 2;

            // добавление линии
            try
            {
                chartMidTime.Series.Add(line);
            }
            catch (Exception)
            {
                addLine(points, nameLine + "*");
            }
        }


        /// <summary>
        /// получить точки для отрисовки линии
        /// </summary>
        /// <param name="midTime">среднее время метода сортировки</param>
        /// <returns>точки для отрисовки линии</returns>
        private int[] getPoints(int midTime)
        {
            // задать точки
            int[] points = new int[arrLength];
            int y = 0;
            for (int i = 0; i < arrLength; i++)
            {
                points[i] = y;
                y += midTime / arrLength;
            }

            return points;
        }

        #endregion


        #region замер времени

        /// <summary>
        /// подсчет среднего времени
        /// </summary>
        /// <param name="arrTime">массив содержащий время сортировки на каждой операции</param>
        /// <param name="numIters">число операций</param>
        /// <returns>время сортировки (в наносек.)</returns>
        private int calcMidTime(int[] arrTime, int numIters)
        {
            // сложение времени
            int midTime = 0;
            foreach (int time in arrTime)
                midTime += time;

            return midTime / numIters;
        }


        /// <summary>
        /// получить время работы метода сортировки
        /// </summary>
        /// <param name="methodSort">метод сортировки</param>
        /// <param name="arr">сортируемый массив</param>
        /// <returns>время сортировки (в наносек.)</returns>
        private int getTimeMethodSortNS(Action<int[]> methodSort)
        {
            // замер времени
            Stopwatch stopWatch = new Stopwatch();
            if (methodSort == null)
            {
                stopWatch.Start();
                MethodsSort.quickSort(mainArr, 0, mainArr.Length - 1);
                stopWatch.Stop();
            }
            else
            {
                stopWatch.Start();
                methodSort(mainArr);
                stopWatch.Stop();
            }

            return Convert.ToInt32(stopWatch.Elapsed.TotalMilliseconds * 1000000);

        }

        /// <summary>
        /// установить среднее время
        /// </summary>
        /// <param name="methodSort">метод сортировки</param>
        /// <param name="numIters">число операций</param>
        private void setMidTime(Action<int[]> methodSort, int numIters)
        {
            // проверка заданных данных
            if (!checkData())
                return;


            // замер времени на каждой операции
            int[] arrTime = new int[numIters];
            List<string> arrStory = new List<string>();
            for (int i = 0; i < numIters; i++)
            {
                mainArr = MethodsSort.getRandomArr(arrLength, rangeFrom, rangeTo);
                System.Threading.Thread.Sleep(250);
                if (methodSort == null)
                    arrTime[i] = getTimeMethodSortNS(null);
                else
                    arrTime[i] = getTimeMethodSortNS(methodSort);

                arrStory.Add($"[{string.Join(", ", mainArr)}]");
            }

            int midTime = calcMidTime(arrTime, numIters);


            // сообщение о проведенной операции
            MessageBox.Show($"Название: {getNameMethod()}\n" +
                $"Длина массива: {arrLength}\n" +
                $"Среднее время сортировки: {midTime}");

            MessageBox.Show(string.Join("\n\n", arrStory));


            // добавление линии на график
            addLine(getPoints(midTime), $"{getNameMethod()}: {arrLength}");
            
        }

        #endregion


        #region вводимые данные

        /// <summary>
        /// проверка заданных данных 
        /// </summary>
        /// <returns>
        /// true - если данные заданы верно
        /// false - если данные заданы неверно
        /// </returns>
        private bool checkData()
        {
            try
            {
                arrLength = Convert.ToInt32(txtBoxLenArr.Text);
                rangeFrom = Convert.ToInt32(txtBoxRangeFrom.Text);
                rangeTo = Convert.ToInt32(txtBoxRangeTo.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверно заданы значения");
                return false;
            }

            // проверка диапазона
            if (rangeFrom >= rangeTo)
            {
                MessageBox.Show("начало диапазона больше или равно концу диапазона");
                return false;
            }

            return true;
        }


        /// <summary>
        /// запись в текстовое поле (длина массива) только чисел
        /// </summary>
        private void txtBoxLenArr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        /// <summary>
        /// запись в текстовое поле (начало диапазона) только чисел
        /// </summary>
        private void txtBoxRangeFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        /// <summary>
        /// запись в текстовое поле (конец массива) только чисел
        /// </summary>
        private void txtBoxRangeTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        #endregion


        #region поле выбора

        /// <summary>
        /// получить имя выбранного метода
        /// </summary>
        /// <returns>имя выбранного метода</returns>
        private string getNameMethod()
        {
            return comboBoxSelectionMethodsSort.SelectedItem.ToString();
        }


        /// <summary>
        /// получить индекс выбранного метода
        /// </summary>
        /// <returns>имя выбранного метода</returns>
        private int getIndexMethod()
        {
            return comboBoxSelectionMethodsSort.SelectedIndex;
        }

        #endregion


        #region кнопки

        /// <summary>
        /// открытие окна визуализации методов сортировки
        /// </summary>
        private void btnOpenVisualMethodsSortForm_Click(object sender, EventArgs e)
        {

            int indexMethod = getIndexMethod();
            if (indexMethod != -1)
            {
                VisualMethodsSortForm form = new VisualMethodsSortForm(
                    getNameMethod(), indexMethod);
                form.Show();
            }
            else 
            {
                MessageBox.Show("Метод не выбран");
            }
        }


        /// <summary>
        /// запустить вычисление среднего времени сортировки
        /// </summary>
        /// объект вызывающий событие, событие
        private void btnMidTime_Click(object sender, EventArgs e)
        {
            int indexMethod = getIndexMethod();
            if (indexMethod == -1)
            {
                MessageBox.Show("Метод не выбран");
                return;
            }

            MessageBox.Show($"Анализ врменной эффективности\n{getNameMethod()}");
            switch (indexMethod) 
            {
                case 0:
                    setMidTime(MethodsSort.bubbleSort, 10);
                    break;

                case 1:
                    setMidTime(MethodsSort.insertionSort, 10);
                    break;

                case 2:
                    setMidTime(MethodsSort.selectionSort, 10);
                    break;

                case 3:
                    setMidTime(MethodsSort.shakerSort, 10);
                    break;

                case 4:
                    setMidTime(MethodsSort.shellSort, 10);
                    break;

                case 5:
                    setMidTime(null, 10);
                    break;
            }
        }


        /// <summary>
        /// запустить очистку графика
        /// </summary>
        /// объект вызывающий событие, событие
        private void btnClearChartMidTime_Click(object sender, EventArgs e)
        {
            chartMidTime.Series.Clear();
        }

        #endregion

    }
}
