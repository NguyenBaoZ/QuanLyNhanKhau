using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanKhau.util
{
    public class Location
    {
        public string General { get; set; }
        public string Provine { get; set; }
        public string District { get; set; }
        public string Village { get; set; }
        public Location(string provine, string district, string village)
        {
            this.Provine = provine;
            this.District = district;
            this.Village = village;
        }
        public Location(string provine, string district, string village, string general)
        {
            this.Provine = provine;
            this.District = district;
            this.Village = village;
            this.General = general;
        }
        public string Parser(string s)
        {
            var split = s.Split('|');
            if (split.Length == 3)
            {
                Provine = split[0];
                District = split[1];
                Village = split[2];
            }
            else if (split.Length == 4)
            {
                Provine = split[0];
                District = split[1];
                Village = split[2];
                General = split[3];
            }
            else
            {
                throw new Exception("Location Parser Error");
            }
            return s;
        }
        public string get()
        {
            return this.ToString();
        }
        public override string ToString()
        {
            return this.Provine + "|" + District + "|" + this.Village + "|" + this.General;
        }
    }
    public enum EGioiTinh
    {
        Nam, Nu, Undefine
    }
    public static class GioiTinh
    {
        public static EGioiTinh Parser(string e)
        {
            switch (e)
            {
                case "Nam":
                case "nam":
                    return EGioiTinh.Nam;
                case "nu":
                case "Nu":
                case "Nủ":
                case "Nư":
                case "Nữ":
                    return EGioiTinh.Nu;
                default:
                    return EGioiTinh.Undefine;
            }
        }
        public static String toString(this EGioiTinh e)
        {
            switch (e)
            {
                case EGioiTinh.Nam:
                    return "Nam";
                case EGioiTinh.Nu:
                    return "Nu";
                default:
                    return null;
            }
        }
    }
}
