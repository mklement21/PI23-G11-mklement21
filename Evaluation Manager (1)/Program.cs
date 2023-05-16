using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ovdje ide DBLayer.DB.SerConfiguration("EvaluationManager"),"mklement","mklement***");
            //help -> about(zadnja linija) -> sql server data tools
            //add sql server-> servername naziv ili lokacija id -> sql server autentifi -> username s maila i pass s maila
            Application.Run(new FrmLogin());
        }
    }
}
