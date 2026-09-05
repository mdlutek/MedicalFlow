using System;
using System.Net.Http;

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
