using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV3
{
    class CSDL_OOP
    {
        private static CSDL_OOP _Instance;
        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CSDL_OOP(); return _Instance;
            }
            private set
            {

            }
        }
        private CSDL_OOP() { }
        public List<SV> GetAllSV()
        {
            List<SV> data = new List<SV>();
            foreach(DataRow i in CSDL.Instance.DTSV.Rows)
            {
                data.Add(GetSV(i));
            }
            return data;
        }
        public SV GetSV(DataRow s)
        {
            return new SV
            {
                MSSV = (int)s["Name"],
                //...
            };
        }
        public List<LSH> GetAllLSH()
        {
            List<LSH> data = new List<LSH>();
            foreach(DataRow i in CSDL.Instance.DTLSH.Rows)
            {
                data.Add(GetLSH(i));
            }
            return data;
        }
        public LSH GetLSH(DataRow i)
        {
            return new LSH
            {
                ID_Lop = (int)i["ID_Lop"],
            };
        }
        public List<SV> GetListSV(int ID)
        {
            List<SV> data = new List<SV>();
            foreach(SV i in GetAllSV())
            {
                if(i.ID_Lop == ID)
                {
                    data.Add(i);
                }
            }
            return data;
        }
    }
}
