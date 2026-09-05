using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalFlow.Domain.Entities;

namespace MedicalFlow.Application.Interfaces
{
    public interface IQueueTicketRepository
    {
        Task<QueueTicket> GetByIdAsync(int id);

        // Kluczowe metody pod planowany moduł Webowy (ekran TV w poczekalni):
        Task<QueueTicket> GetCurrentCalledTicketAsync();   // Kto aktualnie wchodzi do gabinetu
        Task<List<QueueTicket>> GetWaitingTicketsAsync();  // Lista oczekujących numerków

        Task AddAsync(QueueTicket ticket);
        Task UpdateAsync(QueueTicket ticket);
    }
}