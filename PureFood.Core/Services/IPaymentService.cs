using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.Models.Requests;



namespace PureFood.Core.Services
{
    public interface IPaymentService
    {
         Task<PageResult<PaymentRespone>> GetAllPayment(int page, int limit);
         Task<CreatePaymentRequest>CreatePayment(CreatePaymentRequest request);
         Task<PaymentRespone>GetPaymentId(Guid id);
         Task<PaymentRespone>GetPaymentByOrderId(Guid id);
    }
}