using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Administrator
{
    class UserError:Exception
    {
        public UserError(string s)
            :base(s)
        {}    
    };
    
    

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.Run(new MainForm());
        }
    }
}
