using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanKhau.Services
{
    class Location
    {
        public string Provine { get; set; }
        public string District { get; set; }
        public string Village { get; set; }
        public string Parser(string s)
        {
            var split = s.Split('|');
            if (split.Length == 3)
            {
                Provine = split[0];
                District = split[1];
                Village = split[2];
            }
            return s;
        }
        public string get()
        {
            return this.ToString();
        }
        public override string ToString()
        {
            return this.Provine + "|" + District + "|" + this.Village;
        }
    }
}
