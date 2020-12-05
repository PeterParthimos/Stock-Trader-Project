using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrader
{
    static class Program
    {
        static List<User> users = new List<User>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            users = SqlLiteDataAccess.LoadPeople();

            Console.WriteLine("Answer is here: " + users[0].CashBalance);
        }
    }
}
