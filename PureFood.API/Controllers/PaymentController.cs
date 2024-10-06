using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models.content;
using PureFood.Core.Models.Requests;
using PureFood.Core.SeedWorks;

namespace PureFood.API.Controllers
{
    [Route("api/v1/payments")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public PaymentController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            _resultModel = new ResultModel();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPayment(int page = 1, int limit = 10)
        {
            var listProduct = await _serviceManager.PaymentService.GetAllPayment(page, limit);

            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listProduct,
                Message = "Lấy danh sách thanh toán thành công."
            });
        }
        [HttpGet]
        [Route("{paymentId}")]
        public async Task<IActionResult> GetPaymentId(Guid paymentId)
        {
            var listProduct = await _serviceManager.PaymentService.GetPaymentId(paymentId);
            if (listProduct == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy danh sách thanh toán."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listProduct,
                Message = "Lấy danh sách thanh toán thành công."
            });
        }
        [HttpGet]
        [Route("order/{orderId}")]
        public async Task<IActionResult> GetPaymentByOderId(Guid orderId)
        {
            var listProduct = await _serviceManager.PaymentService.GetPaymentByOrderId(orderId);
            if (listProduct == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy danh sách thanh toán."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listProduct,
                Message = "Lấy danh sách thanh toán thành công."
            });
        }
        
        [HttpPost]
        public async Task<IActionResult> AddPayment(CreatePaymentRequest request)
        {
            var payment = await _serviceManager.PaymentService.CreatePayment(request);

            if (payment == null)
            {
                _resultModel = new ResultModel
                {
                    Data = null,
                    Message = "Phương thức thanh toán thêm thất bại.",
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false
                };
                return BadRequest(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Data = null, 
                Message = "Phương thức thanh toán thêm thành công.",
                Status = (int)HttpStatusCode.OK,
                Success = true
            };

            return Ok(_resultModel);
        }

    }
}