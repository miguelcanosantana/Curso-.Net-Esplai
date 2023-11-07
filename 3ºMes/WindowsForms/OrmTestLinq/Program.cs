using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrmTestLinq
{
    public partial class employees
    {
        public override string ToString()
        {
            String text;
            text = first_name + " " + last_name;

            if (phone_number != null)
            {
                text += " | " + phone_number;
            }


            return text;
        }
    }

    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
