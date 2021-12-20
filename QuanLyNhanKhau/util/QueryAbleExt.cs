using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanKhau.util
{
    public static class ObjectExtensionMethods
    {
        public static IQueryable<T> ToQueryable<T>(this T obj) where T : Model.User
        {
            return new List<T> { obj }.AsQueryable();
        }
    }
}
