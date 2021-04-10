using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_3Layer.DAO
{
    class ClassDAO
    {
        private static ClassDAO instance;

        public static ClassDAO Instance {
            get
            {
                if (instance == null) instance = new ClassDAO();
                return instance;
            }
            private set { }
        }
        private ClassDAO() { }

        public List<Class> loadClass()
        {
            List<Class> listClass = new List<Class>();
            foreach(DataRow cls in CSDL.Instance.DTLSH.Rows)
            {
                Class cl = new Class(cls);
                listClass.Add(cl);
            }
            return listClass;
        }
    }
}
