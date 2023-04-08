using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {

        // компонентная объектная модель - component object model - COM
        /*
         * COM - это стандарт программирования, разработанный компанией Microsoft
         * Описывает правила создания программных компонентов, 
         * при использовании которых нет необходимости учитывать, 
         * в какой среде программирования создавался тот или иной модуль
         */

        /* 
         * Атрибут STAThreadAttribute используется для контроля потока
         * Атрибут обеспечивает механизм связи между 
         * текущим потоком и другими потоками, 
         * которые могут захотеть связаться с ним через COM.
         */

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
