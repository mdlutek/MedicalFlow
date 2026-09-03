using DevExpress.XtraPrinting.Native.WebClientUIControl;
using MedicalFlow.Domain.Dtos;
using Newtonsoft.Json; 
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MedicalFlow.WinForms.Services
{
    public class PatientApiClient
    {
        private readonly HttpClient _httpClient;
        // Adres pod jakim działa Twoje API (np. z Dockera lub IIS Express)
        private const string BaseUrl = "http://localhost:8080/api/patients";

        public PatientApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<PatientDto>> GetPatientsAsync()
        {
            var response = await _httpClient.GetStringAsync(BaseUrl);
            return JsonConvert.DeserializeObject<List<PatientDto>>(response);
        }

        public async Task<bool> CreatePatientAsync(CreateOrUpdatePatientDto dto)
        {
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(BaseUrl, content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdatePatientAsync(int id, CreateOrUpdatePatientDto dto)
        {
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Wysłanie żądania PUT ze zaktualizowanym obiektem DTO
            var response = await _httpClient.PutAsync($"{BaseUrl}/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePatientAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}