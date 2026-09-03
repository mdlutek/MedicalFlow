using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using MedicalFlow.Domain.Enums;
using MedicalFlow.Infrastructure.Xpo.Entities;
using System;
using System.Data.SqlTypes;
using System.Linq;

namespace MedicalFlow.Infrastructure.Xpo
{
    public static class XpoConnectionHelper
    {
        // Przechowujemy instancję bezpiecznej wielowątkowo warstwy danych
        private static IDataLayer _dataLayer;

        // Generujemy poprawny connection string XPO dla serwera '.' (localhost) i autoryzacji Windows
        // Wygeneruje format: "XpoProvider=MSSqlServer;Data Source=.;Initial Catalog=MedicalFlowDb;Integrated Security=SSPI;"
        private static readonly string FallbackConnectionString =
           MSSqlConnectionProvider.GetConnectionString(".", "MedicalFlowDb");

        public static void InitXpo(string connectionString = null)
        {
            string conn = string.IsNullOrWhiteSpace(connectionString) ? FallbackConnectionString : connectionString;

            // Rejestracja słownika metadanych z naszymi encjami
            var dict = new ReflectionDictionary();
            dict.GetDataStoreSchema(
                typeof(Patient),
                typeof(Doctor),
                typeof(Visit),
                typeof(QueueTicket)
            );

            // AutoCreateOption.DatabaseAndSchema automatycznie utworzy bazę i tabele, jeśli nie istnieją
            IDataStore store = XpoDefault.GetConnectionProvider(conn, AutoCreateOption.DatabaseAndSchema);

            // Konfiguracja wielowątkowej warstwy danych (bezpieczna dla aplikacji WinForms i Web)
            _dataLayer = new ThreadSafeDataLayer(dict, store);
            XpoDefault.DataLayer = _dataLayer;

            // Wymusza jawne tworzenie sesji UnitOfWork (dobra praktyka)
            XpoDefault.Session = null; 
        }

        // ZAWSZE przekazujemy instancję _dataLayer do nowej sesji UnitOfWork
        public static UnitOfWork CreateUnitOfWork()
        {
            if (_dataLayer == null)
            {
                // Bezpiecznik: jeśli InitXpo nie zostało jeszcze wywołane, inicjalizujemy bazę
                InitXpo();
            }

            // Jawne przekazanie _dataLayer eliminuje problem stub providera
            return new UnitOfWork(_dataLayer);
        }

        public static void SeedInitialData()
        {
            using(var unitOfWork = CreateUnitOfWork())
            {
                var hasDoctor = new XPQuery<Doctor>(unitOfWork).Any();

                if (!hasDoctor)
                {
                    var doctor = new Doctor(unitOfWork)
                    {
                        FirstName = "Jan",
                        LastName = "Kowalski",
                        Specialization = "Kardiolog",
                        CabinetNumber = "104"
                    };

                    var patient = new Patient(unitOfWork)
                    {
                        FirstName = "Anna",
                        LastName = "Nowak",
                        Pesel = "92010112345",
                        PhoneNumber = "500-600-700"
                    };

                    var visit = new Visit(unitOfWork)
                    {
                        Doctor = doctor,
                        Patient = patient,
                        ScheduledStartTime = DateTime.Today.AddHours(10),
                        ScheduledEndTime = DateTime.Today.AddHours(10).AddMinutes(30),
                        Status = VisitStatus.Scheduled,
                        Notes = "Wizyta kontrolna"
                    };

                    // Zapisanie zmian w bazie
                    unitOfWork.CommitChanges();
                }
            }
        }
    }
}