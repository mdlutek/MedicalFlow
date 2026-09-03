using System;
using DevExpress.Xpo;
using MedicalFlow.Domain.Enums;

namespace MedicalFlow.Infrastructure.Xpo.Entities
{
    public class Visit : XPObject
    {
        public Visit(Session session) : base(session) { }

        private Patient _patient;
        [Association("Patient-Visits")]
        public Patient Patient
        {
            get => _patient;
            set => SetPropertyValue(nameof(Patient), ref _patient, value);
        }

        private Doctor _doctor;
        [Association("Doctor-Visits")]
        public Doctor Doctor
        {
            get => _doctor;
            set => SetPropertyValue(nameof(Doctor), ref _doctor, value);
        }

        private DateTime _scheduledStartTime;
        public DateTime ScheduledStartTime
        {
            get => _scheduledStartTime;
            set => SetPropertyValue(nameof(ScheduledStartTime), ref _scheduledStartTime, value);
        }

        private DateTime _scheduledEndTime;
        public DateTime ScheduledEndTime
        {
            get => _scheduledEndTime;
            set => SetPropertyValue(nameof(ScheduledEndTime), ref _scheduledEndTime, value);
        }

        private VisitStatus _status;
        public VisitStatus Status
        {
            get => _status;
            set => SetPropertyValue(nameof(Status), ref _status, value);
        }

        private string _notes;
        [Size(SizeAttribute.Unlimited)] // Odpowiednik NVARCHAR(MAX) w MS SQL
        public string Notes
        {
            get => _notes;
            set => SetPropertyValue(nameof(Notes), ref _notes, value);
        }

        // Relacja 1:1 - Przypisany bilet kolejkowy
        private QueueTicket _queueTicket;
        public QueueTicket QueueTicket
        {
            get => _queueTicket;
            set => SetPropertyValue(nameof(QueueTicket), ref _queueTicket, value);
        }
    }
}