using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class BookingMessageRepository : BaseRepository<BookingMessage>, IBookingMessageRepository
    {
        public BookingMessageRepository(DataContext context) : base(context)
        {
        }

        public Task<IEnumerable<BookingMessage>> GetBookingMessagesByClientIdAsync(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<BookingMessage> GetBookingMessageByClientIdAsync(int userId, int messageId)
        {
            throw new System.NotImplementedException();
        }
    }
}