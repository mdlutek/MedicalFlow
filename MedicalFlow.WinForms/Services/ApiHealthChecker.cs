using DevExpress.Utils.Paint;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MedicalFlow.WinForms.Services
{
    public class ApiHealthChecker
    {
        private const string HealthUrl = "http://localhost:8080/api/health";

        public bool CheckConnection(int timeoutSeconds = 5)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
                    var response = client.GetAsync(HealthUrl).GetAwaiter().GetResult();
                                        
                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
