using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace QuanLy.DAO
{
   public  class KiemTraDAO
    {
       private static KiemTraDAO istance;

       public static KiemTraDAO Istance
       {
           get
           {
               if (istance == null)
                   istance = new KiemTraDAO();
               return istance;
           }
           private set { istance = value; }
       }
       private KiemTraDAO() { }
        
       public bool CheckMaHD(string MaHD)
       {
            string query = "sp_CheckMaHD @MaHD";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{MaHD});
            return result.Rows.Count > 0;
       }
       public bool CheckMaDV(string MaDV)
       {
           string query = "sp_CheckMaDV @MaDV";
           DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaDV });
           return result.Rows.Count > 0;
       }
       public bool CheckMaNV(string MaNV)
       {
           string query = "sp_CheckMaNV @MaNV";
           DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaNV });
           return result.Rows.Count > 0;
       }
       public bool CheckMaPB(string MaPB)
       {
           string query = "sp_CheckMaPB @MaPB";
           DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaPB });
           return result.Rows.Count > 0;
       }
       public bool CheckMaKhu(string MaKhu)
       {
           string query = "sp_CheckMaKhu @MaKhu";
           DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaKhu });
           return result.Rows.Count > 0;
       }
       public bool CheckMaTro(string MaTro)
       {
           string query = "sp_CheckMaTro @MaTro";
           DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaTro });
           return result.Rows.Count > 0;
       }
    }
}
