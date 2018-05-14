using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThuoc.Tool
{
    class String_SQLConn
    {
        public static SqlConnection StringSQL()
        {
            string CreateFolder = @"Database";
            if (!System.IO.Directory.Exists(CreateFolder))
            {
                System.IO.Directory.CreateDirectory(CreateFolder);
            }


            string CreateFileText = @"Database\String.txt";
            if (!System.IO.File.Exists(CreateFileText))
            {
                System.IO.FileStream cr = new System.IO.FileStream(CreateFileText, System.IO.FileMode.Create);
                cr.Close();
                cr.Dispose();
            }

            System.IO.StreamReader docFile = new System.IO.StreamReader("DataBase\\String.txt");
            string ketnoi = "";
            try
            {
                string con = docFile.ReadLine();
                ketnoi = Encode.Base64ToString(con);
            }
            catch
            {

            }
            docFile.Close();
            docFile.Dispose();
            SqlConnection cnn = new SqlConnection("Data Source=" + ketnoi);
            return cnn;
        }
    }
}
