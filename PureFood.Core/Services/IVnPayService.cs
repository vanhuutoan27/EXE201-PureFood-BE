using Microsoft.AspNetCore.Http;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;

namespace PureFood.Core.Services
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(PaymentInformationModel model, HttpContext context);
        PaymentResponseModel PaymentExecute(IQueryCollection collections);
    }
}
