using System;
using MedicalFlow.Domain.ValueObjects;

namespace MedicalFlow.Domain.Entities
{
    // Encja Domenowa - czysty C#, brak bibliotek bazodanowych
    public class Patient
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Pesel Pesel { get; private set; } // Zastosowanie Obiektu Wartości
        public string PhoneNumber { get; private set; }

        public string FullName => $"{LastName} {FirstName}";

        // Konstruktor odtwarzający obiekt z bazy danych (z istniejącym Id)
        public Patient(int id, string firstName, string lastName, Pesel pesel, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("Imię pacjenta nie może być puste.", nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Nazwisko pacjenta nie może być puste.", nameof(lastName));

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel ?? throw new ArgumentNullException(nameof(pesel));
            PhoneNumber = phoneNumber;
        }

        // Konstruktor dla nowo rejestrowanego pacjenta (przed zapisem w bazie, Id = 0)
        public Patient(string firstName, string lastName, Pesel pesel, string phoneNumber)
            : this(0, firstName, lastName, pesel, phoneNumber)
        {
        }

        // Metody biznesowe modyfikujące stan (hermetyzacja)
        public void UpdateContactDetails(string newPhoneNumber)
        {
            PhoneNumber = newPhoneNumber;
        }

        public void ChangeName(string newFirstName, string newLastName)
        {
            if (string.IsNullOrWhiteSpace(newFirstName) || string.IsNullOrWhiteSpace(newLastName))
                throw new ArgumentException("Imię i nazwisko nie mogą być puste.");

            FirstName = newFirstName;
            LastName = newLastName;
        }
    }
}