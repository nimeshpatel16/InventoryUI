using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOUMCO.Class
{
    public class OutwardInfo
    {
        public int outwardId { get; set; }
        public OutwardDetail objOutwardDetail { get; set; }
        public string invoiceNo { get; set; }
        public DateTime invoiceDate { get; set; }
        public string partyName { get; set; }
        public string description { get; set; }
        public List<OutwardDetail> lstOutwardDetail = new List<OutwardDetail>();
        
    }

    public class OutwardDetail
    {
        public int outwardDetailId { get; set; }
        public int outwardId { get; set; }
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
        public int productLedgerId { get; set; }
    }


    public class OutwardGetAvailableQuantity
    {
        public int productId { get; set; }
        public decimal length { get; set; }
        public decimal width { get; set; }
        public int quantity { get; set; }
    }

    public class OutwardResultAvailableQuantity
    {
        public int ledgerId { get; set; }
        public int productId { get; set; }
        public int inwardId { get; set; }
        public int inwardDetailId { get; set; }
        public decimal length { get; set; }
        public decimal width { get; set; }
        public int unitToUse { get; set; }
    }
}
