﻿using QLThuoc.DAL;
using QLThuoc.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.BUS
{
    public class NhanVienBUS
    {
        NhanVienDAL da = new NhanVienDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public string TangMa()
        {
            return da.TangMa();
        }   
        public int InsertData(NhanVienEntity NV)
        {
            return da.InsertData(NV);
        }
        public int UpdateData(NhanVienEntity NV)
        {
            return da.UpdateData(NV);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
    }
}
