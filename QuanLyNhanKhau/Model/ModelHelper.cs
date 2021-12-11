using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanKhau.Model
{
    class ModelHelper
    {
        private static ModelHelper instance = null;
        public Authentication Auth { get; set; }
        public static ModelHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ModelHelper();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private ModelHelper()
        {
            this.Auth = new Authentication();
        }
    }
}
