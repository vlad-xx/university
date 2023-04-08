using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp1
{

    public partial class VisualMethodsSortForm : Form
    {


        #region главные переменные

        /// <summary>
        /// главный массив
        /// </summary>
        ObservableCollection<int> mainArr;


        /// <summary>
        /// индекс метода сортировки
        /// </summary>
        int indexMethodSort;


        // цвета элементов графика
        Color colorPurple = Color.FromArgb(255, 213, 0, 255);
        Color colorRed = Color.FromArgb(255, 255, 0, 115);
        Color colorYellow = Color.FromArgb(255, 255, 238, 0);
        Color colorGreen = Color.FromArgb(255, 0, 255, 94);

        #endregion




        /// <summary>
        /// форма
        /// </summary>
        /// <param name="nameMethod">имя выбранного метода</param>
        /// <param name="indexMethod">индекс выбранного метода</param>
        public VisualMethodsSortForm(string nameMethod, int indexMethod) 
        {
            InitializeComponent();

            indexMethodSort = indexMethod;


            // установка графика отображающего элементы массива
            setParamsChartArr(
                nameMethod,
                "Индекс элемента",
                "Значение элемента"
                );
            updateDataChart();

        }

        #region график

        /// <summary>
        /// установка графика отображающего элементы массива
        /// </summary>
        /// <param name="mainTitle">заголовок графика</param>
        /// <param name="xTitle">заголовок по оси X</param>
        /// <param name="yTitle">заголовок по оси Y</param>
        private void setParamsChartArr(string mainTitle, string xTitle, string yTitle)
        {
            // заголовок графика
            chartArr.Titles.Add($"{mainTitle}");

            // обозначения осей графика
            chartArr.ChartAreas[0].AxisX.Title = xTitle;
            chartArr.ChartAreas[0].AxisY.Title = yTitle;


            // значения на осях
            chartArr.ChartAreas[0].AxisX.Minimum = -1;
            chartArr.ChartAreas[0].AxisX.Interval = 1;
            chartArr.ChartAreas[0].AxisY.Interval = 1;
            
            chartArr.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }


        /// <summary>
        /// обновить данные графика
        /// </summary>
        private void updateDataChart()
        {
            chartArr.Series.Clear();

            // создание списка
            int[] arr = MethodsSort.getRandomArr(10, 1, 11);
            mainArr = new ObservableCollection<int>(arr);
            mainArr.CollectionChanged += MainArr_CollectionChanged;

            // вывод элементов массива
            Series arrSeries = new Series("массив");
            arrSeries.Color = colorPurple;
            arrSeries.ChartType = SeriesChartType.Column;
            // добавление элементов на график
            chartArr.Series.Add(arrSeries);

            for (int i = 0; i < mainArr.Count; i++)
            {
                arrSeries.Points.AddXY(i, mainArr[i]);
                arrSeries.Points[i].Label = $"[{mainArr[i]}]";
                changeColor(i, colorPurple);
                updateChart();
            }
        }

        #endregion
        


        /// <summary>
        /// изменение цвета элемента графика
        /// </summary>
        /// <param name="index">индекс элемента</param>
        /// <param name="color">цвет элемента</param>
        private void changeColor(int index, Color color) 
        {
            chartArr.Series["массив"].Points[index].Color = color;
        }


        /// <summary>
        /// изменение значения элемента графика
        /// </summary>
        /// <param name="index">индекс элемента</param>
        /// <param name="newValue">новое значение элемента</param>
        private void setValue(int index, int newValue) 
        {
            chartArr.Series["массив"].Points[index].SetValueY(newValue);
            chartArr.Series["массив"].Points[index].Label = $"[{newValue}]";
        }


        /// <summary>
        /// обновление графика
        /// </summary>
        /// <param name="isSleep">требуется ли пауза (по умолчанию true)</param>
        private void updateChart(bool isSleep = true) 
        {
            chartArr.Update();

            if (isSleep)
                System.Threading.Thread.Sleep(250);
        }

        private void MainArr_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {

                case NotifyCollectionChangedAction.Replace:

                    changeColor(e.OldStartingIndex, colorRed);
                    updateChart();

                    setValue(e.OldStartingIndex, Convert.ToInt32(e.NewItems[0]));
                    changeColor(e.NewStartingIndex, colorYellow);
                    updateChart();
                    break;
            }
        }

        /// <summary>
        /// запуск визуальной сортировки
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // запуск метода 
            switch (indexMethodSort)
            {
                case 0:
                    showBubbleSort();
                    break;

                case 1:
                    showInsertionSort();
                    break;

                case 2:
                    showSelectionSort();
                    break;

                case 3:
                    showShakerSort();
                    break;

                case 4:
                    showShellSort();
                    break;

                case 5:
                    showQuickSort(0, mainArr.Count - 1);
                    break;
            }

            for (int i = 0; i < mainArr.Count; i++)
            {
                changeColor(i, colorGreen);
                updateChart();
            }

            MessageBox.Show($"{string.Join(", ", mainArr)}");

        }


        private void btnRand_Click(object sender, EventArgs e)
        {
            updateDataChart();
        }


        /// <summary>
        /// сортировка методом пузырька
        /// </summary>
        private void showBubbleSort()
        {
            for (int i = 0; i < mainArr.Count; i++)
            {
                for (int j = i + 1; j < mainArr.Count; j++)
                {
                    // сравнение элементов
                    if (mainArr[i] > mainArr[j])
                    {
                        // обмен элементов
                        int buf = mainArr[i];
                        mainArr[i] = mainArr[j];
                        mainArr[j] = buf;
                    }
                }
            }

        }

        /// <summary>
        /// сортировка методом прямого включения
        /// </summary>
        private void showInsertionSort()
        {

            // buf // временная переменная для хранения значения элемента сортируемого массива
            // item // индекс предыдущего элемента
            for (int i = 1; i < mainArr.Count; i++)
            {
                int buf = mainArr[i]; // инициализируем временную переменную текущим значением элемента массива
                int item = i - 1; // запоминаем индекс предыдущего элемента массива
                while (item >= 0 && mainArr[item] > buf) // пока индекс не равен 0 и предыдущий элемент массива больше текущего
                {
                    mainArr[item + 1] = mainArr[item]; // перестановка элементов массива
                    mainArr[item] = buf;
                    item--;
                }
            }

        }


        /// <summary>
        /// сортировка методом прямого выбора
        /// </summary>
        private void showSelectionSort()
        {
            for (int i = 0; i < mainArr.Count - 1; i++)
            {
                // поиск минимального числа
                int min = i;
                for (int j = i + 1; j < mainArr.Count; j++)
                {
                    if (mainArr[j] < mainArr[min])
                        min = j;
                }

                // обмен элементов
                int buf = mainArr[min];
                mainArr[min] = mainArr[i];
                mainArr[i] = buf;
            }
        }


        /// <summary>
        /// сортировка методом шейкера
        /// </summary>
        private void showShakerSort()
        {
            for (var i = 0; i < mainArr.Count / 2; i++)
            {
                var swapFlag = false;
                //проход слева направо
                for (var j = i; j < mainArr.Count - i - 1; j++)
                {
                    if (mainArr[j] > mainArr[j + 1])
                    {
                        var temp = mainArr[j];
                        mainArr[j] = mainArr[j + 1];
                        mainArr[j + 1] = temp;
                        swapFlag = true;
                    }
                }

                //проход справа налево
                for (var j = mainArr.Count - 2 - i; j > i; j--)
                {
                    if (mainArr[j - 1] > mainArr[j])
                    {
                        var temp = mainArr[j - 1];
                        mainArr[j - 1] = mainArr[j];
                        mainArr[j] = temp;
                        swapFlag = true;
                    }
                }

                //если обменов не было выходим
                if (!swapFlag)
                {
                    break;
                }
            }

        }



        /// <summary>
        /// сортировка методом шелла
        /// </summary>
        private void showShellSort()
        {
            int buf;
            int n = mainArr.Count;
            for (int step = n / 2; step > 0; step /= 2)
            {
                for (int i = step; i < n; i++)
                {
                    buf = mainArr[i];
                    int j;
                    for (j = i; j >= step; j -= step)
                    {
                        if (buf < mainArr[j - step])
                            mainArr[j] = mainArr[j - step];
                        else
                            break;
                    }
                    mainArr[j] = buf;
                }
            }
        }


        /// <summary>
        /// сортировка методом хоара
        /// </summary>
        /// <param name="leftIndex">начало массива</param>
        /// <param name="rightIndex">конец массива</param>
        private void showQuickSort(int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = mainArr[leftIndex];
            while (i <= j)
            {
                while (mainArr[i] < pivot)
                {
                    i++;
                }

                while (mainArr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = mainArr[i];
                    mainArr[i] = mainArr[j];
                    mainArr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                showQuickSort(leftIndex, j);
            if (i < rightIndex)
                showQuickSort(i, rightIndex);

        }
    }
}
