using System;

namespace MedicalFlow.Domain.Entities
{
    // Encja Domenowa (Aggregate Root) - czysty C#, zero zależności do bazy danych
    public class Doctor
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Specialization { get; private set; }
        public string CabinetNumber { get; private set; }

        public string DisplayName => $"lek. {FirstName} {LastName} ({Specialization})";

        // Konstruktor wymuszający poprawność danych (inwarianty biznesowe)
        public Doctor(int id, string firstName, string lastName, string specialization, string cabinetNumber)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("Imię lekarza nie może być puste.", nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Nazwisko lekarza nie może być puste.", nameof(lastName));

            if (string.IsNullOrWhiteSpace(specialization))
                throw new ArgumentException("Specjalizacja jest wymagana.", nameof(specialization));

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Specialization = specialization;
            CabinetNumber = cabinetNumber;
        }

        // Konstruktor dla nowo tworzonego lekarza (przed zapisem w bazie, Id = 0)
        public Doctor(string firstName, string lastName, string specialization, string cabinetNumber)
            : this(0, firstName, lastName, specialization, cabinetNumber)
        {
        }

        // Metoda biznesowa modyfikująca stan obiektu (brak publicznych setterów!)
        public void AssignToCabinet(string newCabinetNumber)
        {
            if (string.IsNullOrWhiteSpace(newCabinetNumber))
                throw new ArgumentException("Numer gabinetu nie może być pusty.", nameof(newCabinetNumber));

            CabinetNumber = newCabinetNumber;
        }

        public void UpdateSpecialization(string newSpecialization)
        {
            if (string.IsNullOrWhiteSpace(newSpecialization))
                throw new ArgumentException("Specjalizacja nie może być pusta.", nameof(newSpecialization));

            Specialization = newSpecialization;
        }
    }
}