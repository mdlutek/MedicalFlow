using System;
using DevExpress.Xpo;

namespace MedicalFlow.Infrastructure.Xpo.Entities
{
    // [Persistent("Patient")] sprawia, że nazwa tabeli w bazie MS SQL pozostaje bez zmian
    [Persistent("Patient")]
    public class PatientEntity : XPObject
    {
        public PatientEntity(Session session) : base(session) { }

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set => SetPropertyValue(nameof(FirstName), ref _firstName, value);
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set => SetPropertyValue(nameof(LastName), ref _lastName, value);
        }

        private string _pesel;
        [Indexed(Unique = true)] // PESEL musi być unikalny w bazie
        public string Pesel
        {
            get => _pesel;
            set => SetPropertyValue(nameof(Pesel), ref _pesel, value);
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => SetPropertyValue(nameof(PhoneNumber), ref _phoneNumber, value);
        }

        // Relacja 1:N - Pacjent może posiadać wiele wizyt
        [Association("Patient-Visits")]
        public XPCollection<VisitEntity> Visits => GetCollection<VisitEntity>(nameof(Visits));

        // Pomocnicza właściwość tylko do odczytu (wyświetlanie w siatce)
        public string FullName => $"{LastName} {FirstName}";
    }
}