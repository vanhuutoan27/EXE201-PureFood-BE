using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.SeedWorks;
using System.Net;

namespace PureFood.API.Controllers
{
    [Route("api/v1/suppliers")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public SupplierController(IServiceManager service)
        {
            _serviceManager = service;
            _resultModel = new ResultModel();
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10)
        {
            var suppliers = await _serviceManager.SupplierService.getAll(page, limit);
            if (suppliers == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No suppliers found."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = suppliers,
                Message = "suppliers retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpGet]
        [Route("{supplierId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewById(Guid supplierId)
        {
            var getSupplier = await _serviceManager.SupplierService.getSupplierById(supplierId);

            if (getSupplier == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null,
                    Message = "Id does not exist!."

                };
            }
            else
                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Data = getSupplier,
                    Message = "supplier retrieved successfully."
                };

            return Ok(_resultModel);
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> AddReview(CreateSupplierRequest request)
        {
            var Supplier = await _serviceManager.SupplierService.createSupplier(request);
            if (Supplier == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Unable to add supplier. Please try again."
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,

                Message = "supplier added successfully."
            };
            return Ok(_resultModel);
        }

        [HttpPut]
        [Route("{supplierId:guid}")]
        public async Task<ActionResult<ResultModel>> UdpdateReview(Guid supplierId, CreateSupplierRequest request)
        {
            var getSupplier = await _serviceManager.SupplierService.updateSupplier(supplierId, request);
            if (getSupplier == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "supplier not found."
                };
                return BadRequest(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,

                Message = "supplier updated successfully."
            };
            return Ok(_resultModel);
        }

        [HttpDelete]
        [Route("{supplierId:guid}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid supplierId)
        {
            var getSupplier = await _serviceManager.SupplierService.deleteSupplier(supplierId);
            if (getSupplier == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "supplier not found."

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "supplier deleted successfully."
            };
            return Ok(_resultModel);
        }
    }
}
