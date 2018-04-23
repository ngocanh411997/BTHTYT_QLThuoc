﻿using QLThuoc.Entity;
using QLThuoc.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.DAL
{
    public class HoaDonXuatDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("HDX_SelectAll", null);
        }
        public int InsertData(HoaDonXuatEntity HDX)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHoaDon",HDX.MaHoaDon),
                new SqlParameter("MaKH",HDX.MaKH),
                new SqlParameter("NgayXuat",HDX.NgayXuat),
                new SqlParameter("MaNVXuat",HDX.MaNVXuat)
            };
            return conn.ExcuteSQL("ThemHDX", para);
        }
        public int UpdateData(HoaDonXuatEntity HDX)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHoaDon",HDX.MaHoaDon),
                new SqlParameter("MaKH",HDX.MaKH),
                new SqlParameter("NgayXuat",HDX.NgayXuat),
                new SqlParameter("MaNVXuat",HDX.MaNVXuat)
        };
            return conn.ExcuteSQL("SuaHDX", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHoaDon",ID)
        };
            return conn.ExcuteSQL("XoaHDX", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From HoaDonXuat", "DX");
        }
        public DataTable TimKiemHDX(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
        /////////////////////////////
        public DataTable DataCTHDX(string strCTHDX)
        {
            return conn.GetData(strCTHDX);
        }
        public int InsertDataCT(ChiTietHoaDonXuatEntity CTHDX)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHDX",CTHDX.MaHDX),
                new SqlParameter("MaThuoc",CTHDX.MaThuoc),
                new SqlParameter("DonViTinh",CTHDX.DonViTinh),
                new SqlParameter("SoLuong",CTHDX.SoLuong),
                new SqlParameter("Gia",CTHDX.Gia)

            };
            return conn.ExcuteSQL("ThemCTHDX", para);
        }
        public int UpdateDataCT(ChiTietHoaDonXuatEntity CTHDX)
        {
            SqlParameter[] para =
           {
               new SqlParameter("MaHDX",CTHDX.MaHDX),
                new SqlParameter("MaThuoc",CTHDX.MaThuoc),
                new SqlParameter("DonViTinh",CTHDX.DonViTinh),
                new SqlParameter("SoLuong",CTHDX.SoLuong),
                new SqlParameter("Gia",CTHDX.Gia)
            };
            return conn.ExcuteSQL("SuaCTHDX", para);
        }
        public int DeleteDataCT(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHDX",ID)
        };
            return conn.ExcuteSQL("XoaCTHDX", para);
        }
    }
}