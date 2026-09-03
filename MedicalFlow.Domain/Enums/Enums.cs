using System;

namespace MedicalFlow.Domain.Enums
{
    public enum VisitStatus
    {
        Scheduled = 0,    // Zaplanowana
        WaitingInQueue = 1, // Pacjent przyszedł do przychodni (czeka w kolejce)
        InProgress = 2,   // W gabinecie u lekarza
        Completed = 3,    // Zakończona
        Cancelled = 4     // Odwołana
    }
}
