using System;
using System.Text.RegularExpressions;

namespace MedicalFlow.Domain.ValueObjects
{
    // Obiekt Wartości (Value Object) - niezmienny (immutable) z wbudowaną walidacją
    public class Pesel : IEquatable<Pesel>
    {
        public string Value { get; }

        public Pesel(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Numer PESEL nie może być pusty.", nameof(value));

            // Usuwamy ewentualne spacje i myślniki
            var cleanValue = value.Trim().Replace("-", "");

            // Weryfikacja formatu: dokładnie 11 cyfr
            if (!Regex.IsMatch(cleanValue, @"^\d{11}$"))
                throw new ArgumentException("PESEL musi składać się z dokładnie 11 cyfr.", nameof(value));

            Value = cleanValue;
        }

        // Automatyczna konwersja na string dla wygody
        public override string ToString() => Value;

        // Wartości w Value Objects porównujemy po zawartości, a nie po referencji w pamięci
        public override bool Equals(object obj) => obj is Pesel other && Equals(other);
        public bool Equals(Pesel other) => other != null && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();

        public static implicit operator string(Pesel pesel) => pesel?.Value;
        public static explicit operator Pesel(string value) => new Pesel(value);
    }
}