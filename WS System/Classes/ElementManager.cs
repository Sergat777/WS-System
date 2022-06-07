using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WS_System.Classes
{
    internal class ElementManager
    {
        // aplication frames
        public static Frame MainAppFrame { get; set; }

        // application header
        public static DockPanel Header { get; set; }
        public static TextBlock Title { get; set; }
        public static TextBlock Greeting { get; set; }

        // 
        //public static Frame MainAppFrame { get; set; }
    }
}
