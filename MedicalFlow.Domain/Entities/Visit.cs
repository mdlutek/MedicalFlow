using System;
using MedicalFlow.Domain.Enums;

namespace MedicalFlow.Domain.Entities
{
    // Encja Domenowa / Aggregate Root - Wizyta Lekarska
    public class Visit
    {
        public int Id { get; private set; }
        public int PatientId { get; private set; }
        public Patient Patient { get; private set; }
        public int DoctorId { get; private set; }
        public Doctor Doctor { get; private set; }

        public DateTime ScheduledStartTime { get; private set; }
        public DateTime ScheduledEndTime { get; private set; }
        public VisitStatus Status { get; private set; }
        public string Notes { get; private set; }

        public int? QueueTicketId { get; private set; }
        public QueueTicket QueueTicket { get; private set; }

        // Konstruktor odtwarzający obiekt z bazy danych
        public Visit(
            int id,
            int patientId,
            int doctorId,
            DateTime scheduledStartTime,
            DateTime scheduledEndTime,
            VisitStatus status,
            string notes,
            int? queueTicketId = null)
        {
            if (scheduledEndTime <= scheduledStartTime)
                throw new ArgumentException("Czas zakończenia wizyty musi być późniejszy niż czas rozpoczęcia.");

            Id = id;
            PatientId = patientId;
            DoctorId = doctorId;
            ScheduledStartTime = scheduledStartTime;
            ScheduledEndTime = scheduledEndTime;
            Status = status;
            Notes = notes;
            QueueTicketId = queueTicketId;
        }

        // Konstruktor dla nowej rezerwacji wizyty
        public Visit(int patientId, int doctorId, DateTime startTime, DateTime endTime)
            : this(0, patientId, doctorId, startTime, endTime, VisitStatus.Scheduled, string.Empty, null)
        {
        }

        // --- REGUŁY I METODY BIZNESOWE (MASZYNA STANÓW) ---

        // 1. Pacjent zgłasza się w rejestracji (pobiera bilet kolejkowy)
        public void CheckInPatient(QueueTicket ticket)
        {
            if (Status != VisitStatus.Scheduled)
                throw new InvalidOperationException("Do kolejki można dodać tylko wizytę zaplanowaną.");

            QueueTicket = ticket ?? throw new ArgumentNullException(nameof(ticket));
            QueueTicketId = ticket.Id;
            Status = VisitStatus.WaitingInQueue;
        }

        // 2. Lekarz zaprasza pacjenta do gabinetu
        public void StartVisit()
        {
            if (Status != VisitStatus.WaitingInQueue && Status != VisitStatus.Scheduled)
                throw new InvalidOperationException("Nie można rozpocząć wizyty o bieżącym statusie.");

            Status = VisitStatus.InProgress;
            QueueTicket?.Call(); // Bilet wyświetla się na ekranie TV
        }

        // 3. Zakończenie wizyty i wpisanie diagnozy / notatki medycznej
        public void CompleteVisit(string medicalNotes)
        {
            if (Status != VisitStatus.InProgress)
                throw new InvalidOperationException("Tylko wizyta w trakcie realizacji może zostać zakończona.");

            Notes = medicalNotes;
            Status = VisitStatus.Completed;
            QueueTicket?.Complete();
        }

        // 4. Odwołanie wizyty
        public void Cancel(string reason)
        {
            if (Status == VisitStatus.Completed)
                throw new InvalidOperationException("Nie można odwołać wizyty, która już się odbyła.");

            Notes = string.IsNullOrWhiteSpace(Notes) ? $"Odwołano: {reason}" : $"{Notes} | Odwołano: {reason}";
            Status = VisitStatus.Cancelled;
            QueueTicket?.Complete();
        }

        // Metody pomocnicze do wstrzyknięcia powiązanych encji przy ładowaniu
        public void AttachDetails(Patient patient, Doctor doctor, QueueTicket ticket)
        {
            Patient = patient;
            Doctor = doctor;
            QueueTicket = ticket;
        }
    }
}