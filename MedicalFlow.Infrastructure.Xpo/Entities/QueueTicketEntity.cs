using System;
using DevExpress.Xpo;

namespace MedicalFlow.Infrastructure.Xpo.Entities
{
    // [Persistent("QueueTicket")] gwarantuje, że tabela w MS SQL zachowa nazwę "QueueTicket"
    [Persistent("QueueTicket")]
    public class QueueTicketEntity : XPObject
    {
        public QueueTicketEntity(Session session) : base(session) { }

        private string _ticketNumber; // np. "A-01", "B-12"
        [Indexed]
        public string TicketNumber
        {
            get => _ticketNumber;
            set => SetPropertyValue(nameof(TicketNumber), ref _ticketNumber, value);
        }

        private DateTime _issuedAt;
        public DateTime IssuedAt
        {
            get => _issuedAt;
            set => SetPropertyValue(nameof(IssuedAt), ref _issuedAt, value);
        }

        private bool _isCalled; // Czy numer wyświetla się właśnie na ekranie jako "Aktualny"
        public bool IsCalled
        {
            get => _isCalled;
            set => SetPropertyValue(nameof(IsCalled), ref _isCalled, value);
        }

        private bool _isCompleted;
        public bool IsCompleted
        {
            get => _isCompleted;
            set => SetPropertyValue(nameof(IsCompleted), ref _isCompleted, value);
        }
    }
}