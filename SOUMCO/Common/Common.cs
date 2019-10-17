using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SOUMCO.Common
{
    public static class Common
    {

        public static string APIURL = ConfigurationManager.AppSettings["APIURL"].ToString();
        public static string APIURL_PRODUCTTYPE_SAVE = APIURL.ToString() + "ProductType/SaveProductType";
        public static string APIURL_PRODUCTTYPE_MODIFY = APIURL.ToString() + "ProductType/EditProductType";
        public static string APIURL_PRODUCTTYPE_GETALL = APIURL.ToString() + "ProductType/GetAllObject";
        public static string APIURL_PRODUCTTYPE_GETBY_ID = APIURL.ToString() + "ProductType/GetObjectByIdProductType";
        public static string APIURL_PRODUCTTYPE_DELETEBY_ID = APIURL.ToString() + "ProductType/DeleteObjectByIdProductType";

        public static string APIURL_PRODUCTSIZE_SAVE = APIURL.ToString() + "ProductSize/SaveProductSize";
        public static string APIURL_PRODUCTSIZE_MODIFY = APIURL.ToString() + "ProductSize/EditProductSize";
        public static string APIURL_PRODUCTSIZE_GETALL = APIURL.ToString() + "ProductSize/GetAllObjectList";
        public static string APIURL_PRODUCTSIZE_GETALLBY_PRODUCTTYPE_ID = APIURL.ToString() + "ProductSize/GetAllObjectByProductTypeId";
        public static string APIURL_PRODUCTSIZE_GETBY_ID = APIURL.ToString() + "ProductSize/GetObjectByIdProductSize";
        public static string APIURL_PRODUCTSIZE_DELETEBY_ID = APIURL.ToString() + "ProductSize/DeleteObjectByIdProductSize";



        public static string APIURL_PRODUCT_SAVE = APIURL.ToString() + "Product/SaveProduct";
        public static string APIURL_PRODUCT_GETALL = APIURL.ToString() + "Product/GetAllObjectProduct";
        public static string APIURL_PRODUCT_GETBY_ID = APIURL.ToString() + "Product/GetObjectByIdProduct";
        public static string APIURL_PRODUCT_GETBY_PRODUCT_TYPE_AND_SIZE = APIURL.ToString() + "Product/GetObjectByProductTypeAndSize";
        public static string APIURL_PRODUCT_MODIFY = APIURL.ToString() + "Product/EditProduct";
        public static string APIURL_PRODUCT_DELETEBY_ID = APIURL.ToString() + "Product/DeleteObjectByIdProduct";



        public static string APIURL_INWARD_SAVE= APIURL.ToString() + "Inward/SaveInward";
        public static string APIURL_INWARD_MODIFY= APIURL.ToString() + "Inward/EditInward";
        public static string APIURL_INWARD_GETALL= APIURL.ToString() + "Inward/GetAllInward";
        public static string APIURL_INWARD_GETBY_ID= APIURL.ToString() + "Inward/GetInwardById";
        public static string APIURL_INWARD_DELETEBY_ID = APIURL.ToString() + "Inward/DeleteObjectByIdInward";


        public static string APIURL_OUTWARD_DELETEBY_ID = APIURL.ToString() + "Outward/DeleteObjectByIdOutward";
        public static string APIURL_OUTWARD_GET_AVAILABLE_QTY= APIURL.ToString() + "Outward/GetAvailableQuantity";
        public static string APIURL_OUTWARD_SAVE = APIURL.ToString() + "Outward/SaveOutward";
        public static string APIURL_OUTWARD_MODIFY = APIURL.ToString() + "Outward/EditOutward";
        public static string APIURL_OUTWARD_GETALL = APIURL.ToString() + "Outward/GetAllOutward";
        public static string APIURL_OUTWARD_GETBY_ID = APIURL.ToString() + "Outward/GetOutwardById";

        public static string APIURL_DASHBOARD_GET_AVAILABLE_QTY = APIURL.ToString() + "Outward/GetAvailableSummary";

        //public static async Task<bool> SaveDataAPIAsync(string url, object obj)
        //{

        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(url);
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage response = await client.PostAsJsonAsync(url, obj);
        //        return response.IsSuccessStatusCode;

        //    }

        //}

    }
}
