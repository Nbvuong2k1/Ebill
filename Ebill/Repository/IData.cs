using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ebill.Models;
using System.Data.SqlClient;

namespace Ebill.Repository
{
    internal interface IData
    {
        void SaveBillDetails(BillDetail details);
        void SaveBillItems(List<Items> items, SqlConnection con,int id);
         List<BillDetail> GetAllDetail();
        BillDetail GetDetail(int Id);
    }
}
