using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Xpo;
using MedicalFlow.Domain.Entities;
using MedicalFlow.Application.Interfaces;
using MedicalFlow.Infrastructure.Xpo.Entities;

namespace MedicalFlow.Infrastructure.Xpo.Repositories
{
    public class QueueTicketRepository : IQueueTicketRepository
    {
        public async Task<QueueTicket> GetByIdAsync(int id)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = await uow.GetObjectByKeyAsync<QueueTicketEntity>(id);
                return entity != null ? MapToDomain(entity) : null;
            }
        }

        // Pobranie biletu, który jest w tej chwili wywołany do gabinetu
        public async Task<QueueTicket> GetCurrentCalledTicketAsync()
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = await new XPQuery<QueueTicketEntity>(uow)
                    .Where(t => t.IsCalled && !t.IsCompleted)
                    .OrderByDescending(t => t.IssuedAt)
                    .FirstOrDefaultAsync();

                return entity != null ? MapToDomain(entity) : null;
            }
        }

        // Pobranie listy oczekujących biletów (niewywołanych i niezakończonych)
        public async Task<List<QueueTicket>> GetWaitingTicketsAsync()
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entities = await new XPQuery<QueueTicketEntity>(uow)
                    .Where(t => !t.IsCalled && !t.IsCompleted)
                    .OrderBy(t => t.IssuedAt)
                    .ToListAsync();

                return entities.Select(MapToDomain).ToList();
            }
        }

        public async Task AddAsync(QueueTicket ticket)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = new QueueTicketEntity(uow)
                {
                    TicketNumber = ticket.TicketNumber,
                    IssuedAt = ticket.IssuedAt,
                    IsCalled = ticket.IsCalled,
                    IsCompleted = ticket.IsCompleted
                };

                await uow.CommitChangesAsync();
            }
        }

        public async Task UpdateAsync(QueueTicket ticket)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = await uow.GetObjectByKeyAsync<QueueTicketEntity>(ticket.Id);
                if (entity != null)
                {
                    entity.TicketNumber = ticket.TicketNumber;
                    entity.IsCalled = ticket.IsCalled;
                    entity.IsCompleted = ticket.IsCompleted;

                    await uow.CommitChangesAsync();
                }
            }
        }

        private static QueueTicket MapToDomain(QueueTicketEntity entity)
        {
            return new QueueTicket(
                entity.Oid,
                entity.TicketNumber,
                entity.IssuedAt,
                entity.IsCalled,
                entity.IsCompleted
            );
        }
    }
}