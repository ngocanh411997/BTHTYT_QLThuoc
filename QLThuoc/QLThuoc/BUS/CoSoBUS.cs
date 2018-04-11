using QLThuoc.DAL;
using QLThuoc.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.BUS
{

    public class CoSoBUS
    {
        CoSoDAL da = new CoSoDAL();

        public DataTable GetData()
        {
            return da.GetData();
        }

        public string TangMa()
        {
            return da.TangMa();
        }
        public int InsertData(CoSo CS)
        {
            return da.InsertData(CS);
        }
        public int UpdateData(CoSo CS)
        {
            return da.UpdateData(CS);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public DataTable TimKiemCS(string strTimKiem)
        {
            return da.TimKiemCS(strTimKiem);
        }
    }

}
