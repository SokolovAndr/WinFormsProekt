using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsProekt.Models;

namespace WinFormsProekt
{
    public static class SingleTon
    {
        public static Users User { get; set; }
        public static AppContext DB { get; set; }
        static SingleTon()
        {
            DB = new AppContext();
        }
    }
}
