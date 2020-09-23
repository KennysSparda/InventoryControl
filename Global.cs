using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl
{
    class Global
    {
        public static string version = "1.1";
        public static bool logged = false;
        public static int level = 0; // 0 = Básico , 1 = Gerente , 2 = Master

        public static string local = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string dbname = "inventory_control.db";
        public static string localdb = local + @"\db\";
    }
}
