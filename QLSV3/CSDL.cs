using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV3
{
    class CSDL
    {
        private static CSDL _Instance;
        public DataTable DTSV { get; set; }
        public DataTable DTLSH { get; set; }
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CSDL(); return _Instance;
            }
            private set
            {

            }
        }
        private CSDL()
        {
            DTLSH = new DataTable();
            DTLSH.Columns.AddRange(new DataColumn[] 
            {
                new DataColumn("ID_Lop", typeof(int)),
                new DataColumn("NameLop", typeof(string))
            });

            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[] 
            { 
                new DataColumn("MSSV",typeof(string)),
                new DataColumn("Name",typeof(string)),
                new DataColumn("Gender",typeof(bool)),
                new DataColumn("NS",typeof(DateTime)),
                new DataColumn("ID_Lop",typeof(int)),
            });
        }
        public void AddDr(SV s)
        {
            DataRow dr = DTSV.NewRow();
            dr["MSSV"] = s.MSSV;
            dr["Name"] = s.Name;
            dr["NS"] = s.NS;
            dr["Gender"] = s.Gender;
            dr["ID_Lop"] = s.ID_Lop;
        }
        public void EditDr(SV s)
        {
            foreach(DataRow i in DTSV.Rows)
            {
                if((int)i["MSSV"] == s.MSSV)
                {
                    i["Name"] = s.Name;
                }
            }
        }
        public void DelDR(List<string> LDel)
        {
            foreach(string m in LDel)
            {
                foreach(DataRow i in DTSV.Rows)
                {
                    if(i["MSSV"] == m)
                    {
                        DTSV.Rows.Remove(i);
                        break;
                    }
                }
            }
        }
    }
}
