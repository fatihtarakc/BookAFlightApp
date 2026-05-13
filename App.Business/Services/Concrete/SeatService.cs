namespace App.Business.Services.Concrete
{
    public class SeatService : ISeatService
    {
        private readonly ICacheService<Seat> cacheService;
        private readonly ISeatRepository seatRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IStringLocalizer<MessageResources> stringLocalizer;
        private readonly ILogger<SeatService> logger;
        public SeatService(ICacheService<Seat> cacheService, ISeatRepository seatRepository, IUnitOfWork unitOfWork, IStringLocalizer<MessageResources> stringLocalizer, ILogger<SeatService> logger)
        {
            this.cacheService = cacheService;
            this.seatRepository = seatRepository;
            this.unitOfWork = unitOfWork;
            this.stringLocalizer = stringLocalizer;
            this.logger = logger;
        }
    }
}