using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Entities;
using Web.DL;
namespace Web.BL
{
    // 
    public class Master_BL_LoginData
    {
        public string GetData_DoanhNghiep(String TenData)
        {
            string Chuoi = "";
            Master_DL_LoginData BLL = new Master_DL_LoginData();
            Master_Entity_LoginData obj = new Master_Entity_LoginData();
            obj = BLL.GetData_DoanhNghiep(TenData);
            try
            {
                if (obj.Server != null)
                {
                    //connectionString="Persist Security Info=False;Initial Catalog=ACMAN_HOADON_DIENTU; Data Source=171.244.27.197; user id=acman_hoadondientu; password=acman_hoadondientu!@#; Connection Timeout=140;"
                    Chuoi = "Persist Security Info=False;Initial Catalog=" + obj.Server.ToUpper().ToString();
                    Chuoi += "; user id=" + obj.TenData.ToUpper().ToString() + "; password=" + obj.PassWord.ToUpper().ToString() + "; Connection Timeout=140;";
                }

            }
            catch (Exception)
            {

            }

            return Chuoi;

        }
    }
}
