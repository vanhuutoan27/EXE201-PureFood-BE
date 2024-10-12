using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PureFood.Core.SeedWorks;

namespace PureFood.Data.Service
{
    public class PromotionBackGroundService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<PromotionBackGroundService> _logger;
        public PromotionBackGroundService(IServiceProvider serviceProvider, ILogger<PromotionBackGroundService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    _logger.LogInformation("PromotionBackGroundService is running at: {time}", DateTimeOffset.Now);
                    // tao scope moi
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var repository = scope.ServiceProvider.GetRequiredService<IRepositoryManager>();
                        // lay tat ca voucher con hieu luc nhung da het han
                        var expriedPromotion = repository.PromotionRepository.GetExpiredPromotions();
                        foreach (var promotion in expriedPromotion)
                        {
                            // cap nhat trang thai nhung voucher da het han
                            promotion.Status = false;
                            repository.PromotionRepository.Update(promotion);
                        }
                        await repository.SaveAsync();
                    }
                    _logger.LogInformation("Promotion status update completed at: {time}", DateTimeOffset.Now);
                    // kiem tra lai moi 10 giay
                    await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi cập nhật status mã giảm giá." + ex.Message);
                }
            }
        }
    }
}
