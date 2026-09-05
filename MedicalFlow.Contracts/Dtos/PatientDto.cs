namespace MedicalFlow.Contracts.Dtos
{
    // Czysty model danych przesyłany przez sieć (JSON)
    public class PatientDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName => $"{LastName} {FirstName}";
    }

    public class CreateOrUpdatePatientDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public string PhoneNumber { get; set; }
    }
}