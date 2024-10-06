using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.SeedWorks;

namespace PureFood.Core.Repositories
{
    public interface IPaymentRepository  : IRepositoryBase<Payment ,Guid>
    {
        Task<PageResult<Payment>>GetAllPayment(int page , int limit );
        Task<Payment>GetById(Guid paymentId);
        Task<Payment>GetbyOderId(Guid orderId);
    }
}