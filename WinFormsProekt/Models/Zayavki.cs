using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProekt.Models
{
    public class Zayavki
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string Postavchik { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string Zapros { get; set; }
        public string Otvet { get; set; }
    }
}
