using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOUMCO.Class
{
    public class InwardInfo
    {
        public int inwardId { get; set; }
        public InwardDetail objInwardDetail { get; set; }
        public string billNo { get; set; }
        public DateTime billDate { get; set; }
        public string supplierName { get; set; }
        public string description { get; set; }
        public List<InwardDetailForSP> lstInwardDetailForSP = new List<InwardDetailForSP>();
        public List<InwardDetail> lstInwardDetail = new List<InwardDetail>();
    }

    public class InwardInfoForSP
    {
        public int inwardId { get; set; }
        public string billNo { get; set; }
        public DateTime billDate { get; set; }
        public string supplierName { get; set; }
        public string description { get; set; }
        public List<InwardDetailForSP> lstInwardDetail = new List<InwardDetailForSP>();
        public InwardDetailForSP objInwardDetail { get; set; }
    }

    public class InwardDetailForSP
    {
        public int ProductId { get; set; }
        public int InwardDetailId { get; set; }
        public decimal InwardLength { get; set; }
        public decimal InwardHeight { get; set; }
        public decimal InwardWidth { get; set; }
        public int Quantity { get; set; }
    }

    public class InwardDetail
    {
        public int inwardDetailId { get; set; }
        public int inwardId { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public int productTypeId { get; set; }
        public string productTypeName { get; set; }
        public int productSizeId { get; set; }
        public string productSizeName { get; set; }
        public decimal length { get; set; }
        public decimal heigth { get; set; }
        public decimal width { get; set; }
        public int quantity { get; set; }
    }
}
