using DevExpress.Xpo;

namespace MedicalFlow.Infrastructure.Xpo.Entities
{
    public class Doctor : XPObject
    {
        public Doctor(Session session) : base(session) { }

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

        private string _specialization;
        public string Specialization
        {
            get => _specialization;
            set => SetPropertyValue(nameof(Specialization), ref _specialization, value);
        }

        private string _cabinetNumber;
        public string CabinetNumber
        {
            get => _cabinetNumber;
            set => SetPropertyValue(nameof(CabinetNumber), ref _cabinetNumber, value);
        }

        [Association("Doctor-Visits")]
        public XPCollection<Visit> Visits => GetCollection<Visit>(nameof(Visits));

        public string DisplayName => $"lek. {FirstName} {LastName} ({Specialization})";
    }
}