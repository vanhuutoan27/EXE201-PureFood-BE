﻿using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models.content;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.SeedWorks;

namespace PureFood.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VnPayController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public VnPayController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            _resultModel = new ResultModel();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePaymentUrl([FromBody] PaymentInformationModel model)
        {
            var paymentUrl = _serviceManager.VnPayService.CreatePaymentUrl(model, HttpContext);
            return Ok(paymentUrl);
        }

        //[HttpGet("payment-callback")]
        //public async Task<IActionResult> PaymentCallback()
        //{
        //    //var response = _serviceManager.VnPayService.PaymentExecute(Request.Query);
        //    //var paymentResponseModel = response;

        //    //// Parse order description để lấy rentalId từ chuỗi trả về
        //    //var parts = paymentResponseModel.OrderDescription?.Split(' ') ?? new string[0];
        //    //Guid orderId = Guid.Empty;

        //    //if (parts.Length > 1)
        //    //{
        //    //    Guid.TryParse(parts[1], out orderId);
        //    //}

        //    //// Nếu thanh toán thành công
        //    //if (response.Success)
        //    //{
        //    //    var paymentRequest = new CreatePaymentRequest
        //    //    {
        //    //        PaymentStatus = "FullyPaid",
        //    //        Amount = paymentResponseModel.AmountOfRental,
        //    //        OrderId = rentalId,
        //    //    };
        //    //    await _serviceManager.paymentService.AddPayment(paymentRequest);

        //    //    // Redirect người dùng đến trang thanh toán thành công trên frontend
        //    //    return Redirect($"http://localhost:1024/payment-status?status=success&rentalId={rentalId}");
        //    //}
        //    //else
        //    //{
        //    //    var paymentRequest = new CreatePaymentRequest
        //    //    {
        //    //        PaymentStatus = PaymentStatus.Deleted,
        //    //        Amount = paymentResponseModel.AmountOfRental,
        //    //        RentalId = rentalId,
        //    //    };

        //    //    await _serviceManager.paymentService.AddPayment(paymentRequest);

        //    //    // Redirect người dùng đến trang thanh toán thất bại trên frontend
        //    //    return Redirect($"http://localhost:1024/payment-status?status=failed&rentalId={rentalId}");
        //    //}
        //}

    }
}
