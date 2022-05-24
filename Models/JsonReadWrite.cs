using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventory.Models
{
    public class JsonReadWrite
    {
        public string Read(string fileName, string location)
        {
         
            string jsonResult;

            using (StreamReader streamReader = new StreamReader(@"C:\Users\sound\source\repos\ProductInventory\ProductInventory\Views\Home\ProductsList.json"))
            {
                jsonResult = streamReader.ReadToEnd();
            }
            return jsonResult;
        }
    }
}