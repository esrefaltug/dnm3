using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Newtonsoft.Json;

namespace dnm3
{
    /// <summary>
    /// WebService1 için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        DataTable dtCountries = new DataTable();

        [WebMethod]
        public string HelloWorld()
        {
            return "Merhaba Dünya";
        }
        [WebMethod]
        public int Sum(int a, int b)
        {
            return a + b;
        }
        [WebMethod]
        public string Countries()
        {
            dtCountries.Columns.Add("CountryName");
            dtCountries.Columns.Add("Continent");
            dtCountries.Rows.Add("Turkey","Europe");
            dtCountries.Rows.Add("Srilanka","Asia");
            dtCountries.Rows.Add("Turkey", "Europe");
            dtCountries.Rows.Add("Germany", "Europe"); 
            dtCountries.Rows.Add("Germany", "Europe");
            return JsonConvert.SerializeObject(dtCountries);
        }

    }
}
