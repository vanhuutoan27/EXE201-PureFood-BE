using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class PaymentRepository : RepositoryBase<Payment, Guid>, IPaymentRepository
    {
        public PaymentRepository(PureFoodDbContext context) : base(context)
        {
        }

        public async Task<PageResult<Payment>> GetAllPayment(int page, int limit)
        {

            IQueryable<Payment> query = _context.Payments.Include(o => o.Order).ThenInclude(o => o.User);


            int totalItems = await query.CountAsync();


            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }


            var payments = await query.ToListAsync();

            return new PageResult<Payment>
            {
                Items = payments,
                TotalItems = totalItems,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit)
            };
        }

        public async Task<Payment> GetById(Guid paymentId)
        {
            var id = await _context.Payments.Include(o => o.Order).FirstOrDefaultAsync(p => p.PaymentId == paymentId);
            return id;
        }

        public async Task<Payment> GetbyOderId(Guid orderId)
        {
            return await _context.Payments.Include(o => o.Order).FirstOrDefaultAsync(o => o.OrderId == orderId);
        }
    }
}