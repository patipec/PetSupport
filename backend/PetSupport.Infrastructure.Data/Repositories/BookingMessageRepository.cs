using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class BookingMessageRepository: BaseRepository<BookingMessage>, IBookingMessageRepository
    {
        public BookingMessageRepository(DataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<BookingMessage>> GetBookingMessagesByClientId(int clientId)
        {
            return await _context.BookingMessages
                .Where(m => m.ClientId == clientId)
                .OrderBy(m=>m.SendData)
                .ToListAsync();
        }
    }
}