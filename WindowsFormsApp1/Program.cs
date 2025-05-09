using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

    }
}
//Віртуальні методи (virtual) – це методи, які можна перевизначити у похідному класі для зміни або розширення їхньої поведінки
//Абстрактні класи – це класи, які не можна створити напряму, вони можуть містити як реалізовані, так і нереалізовані (абстрактні) методи. Використовуються як базові для похідних класів