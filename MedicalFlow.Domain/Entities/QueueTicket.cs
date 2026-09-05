using System;

namespace MedicalFlow.Domain.Entities
{
    // Encja Domenowa - bilet w kolejce pacjentów do gabinetu
    public class QueueTicket
    {
        public int Id { get; private set; }
        public string TicketNumber { get; private set; } // np. "A-01", "K-12"
        public DateTime IssuedAt { get; private set; }
        public bool IsCalled { get; private set; }       // Czy bilet wyświetla się na ekranie TV jako "Aktualny"
        public bool IsCompleted { get; private set; }    // Czy wizyta z tym biletem dobiegła końca

        // Konstruktor odtwarzający bilet z bazy danych
        public QueueTicket(int id, string ticketNumber, DateTime issuedAt, bool isCalled, bool isCompleted)
        {
            if (string.IsNullOrWhiteSpace(ticketNumber))
                throw new ArgumentException("Numer biletu nie może być pusty.", nameof(ticketNumber));

            Id = id;
            TicketNumber = ticketNumber.Trim().ToUpper();
            IssuedAt = issuedAt;
            IsCalled = isCalled;
            IsCompleted = isCompleted;
        }

        // Konstruktor dla nowo generowanego biletu w rejestracji (czas zawsze w UTC)
        public QueueTicket(string ticketNumber)
            : this(0, ticketNumber, DateTime.UtcNow, isCalled: false, isCompleted: false)
        {
        }

        // --- METODY BIZNESOWE (CYKL ŻYCIA BILETU) ---

        // Wywołanie pacjenta do gabinetu (pojawia się na ekranie TV)
        public void Call()
        {
            if (IsCompleted)
                throw new InvalidOperationException("Nie można wywołać biletu, który został już zakończony.");

            IsCalled = true;
        }

        // Zakończenie obsługi pacjenta
        public void Complete()
        {
            IsCalled = false;
            IsCompleted = true;
        }

        // Cofnięcie wywołania (np. pomyłka lekarza)
        public void Recall()
        {
            if (!IsCompleted)
            {
                IsCalled = false;
            }
        }
    }
}