using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhaSach.Data
{
    public class TaiKhoanData
    {
        DataService data = new DataService();
        SqlCommand cmd = new SqlCommand();
        public void SuaTaiKhoan(string strSQL)
        {
            cmd.CommandText = strSQL;
            data.AddTypeUpdate(cmd, 1);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Mật khẩu đã thay đổi");
            }
            catch
            {
                MessageBox.Show("Không đổi được");
            }
        }        
    }
}
