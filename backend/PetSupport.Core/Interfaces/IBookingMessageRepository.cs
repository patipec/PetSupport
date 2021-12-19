using System.Collections.Generic;
using System.Threading.Tasks;
using PetSupport.Core.Entities;

namespace PetSupport.Core.Interfaces
{
    public interface IBookingMessageRepository : IBaseRepository<BookingMessage>
    {
        Task<IEnumerable<BookingMessage>> GetBookingMessagesByClientIdAsync(int userId);

        Task<BookingMessage> GetBookingMessageByClientIdAsync(int userId, int messageId);
    }
}