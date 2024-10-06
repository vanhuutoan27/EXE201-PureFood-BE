using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Azure;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.Models.Requests;
using PureFood.Core.SeedWorks;
using PureFood.Core.Services;

namespace PureFood.Data.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public PaymentService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<CreatePaymentRequest> CreatePayment(CreatePaymentRequest request)
        {
            var model = new Payment
            {
                PaymentId = Guid.NewGuid(),
                OrderId = request.OrderId,
                Amount = request.Amount,
                CustomerId = request.CustomerId
            };
            _repositoryManager.PaymentRepository.Add(model);
            await _repositoryManager.SaveAsync();
            var result = _mapper.Map<CreatePaymentRequest>(model);
            return result;
        }

        public async Task<PageResult<PaymentRespone>> GetAllPayment(int page, int limit)
        {
            try
            {
                var listPayments = await _repositoryManager.PaymentRepository.GetAllPayment(page, limit);
                var paymentResponse = _mapper.Map<IEnumerable<PaymentRespone>>(listPayments.Items).ToList();

                return new PageResult<PaymentRespone>
                {
                    CurrentPage = page,
                    TotalItems = listPayments.TotalItems,
                    TotalPages = (int)Math.Ceiling(listPayments.TotalItems / (double)limit),
                    Items = paymentResponse  // Ensure it's a list
                };

            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public async Task<PaymentRespone> GetPaymentByOrderId(Guid id)
        {
            // Đợi kết quả trả về từ GetbyOrderId bằng cách sử dụng await
            var order = await _repositoryManager.PaymentRepository.GetbyOderId(id);

            // Ánh xạ đối tượng Payment sang PaymentResponse
            var response = _mapper.Map<PaymentRespone>(order);

            return response;
        }


        public async Task<PaymentRespone> GetPaymentId(Guid id)
        {
            var paymentId = await _repositoryManager.PaymentRepository.GetById(id);

            var respone = _mapper.Map<PaymentRespone>(paymentId);
            return respone;
        }
    }
}