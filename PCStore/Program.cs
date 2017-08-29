using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PCStore
{
    static class Program
    {
        //доступ к стартовому окну
        internal static LoginForm LoginWindow;
        //доступ к строке подключения
        internal static string DBConStr = null;
        //блокировка повторного открытия окна для замены пароля
        internal static bool IsOpenChangePass = false;
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBConStr = "DATA SOURCE=localhost:1521/xe;PASSWORD=stepupNew;PERSIST SECURITY INFO=True;USER ID=LKFOOTWEAR";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginWindow = new LoginForm();
            Application.Run(LoginWindow);
        }
    }
}
