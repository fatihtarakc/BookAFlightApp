namespace App.Business.Services.Concrete
{
    public class AirportService : IAirportService
    {
        private readonly ICacheService<Airport> cacheService;
        private readonly IAirportRepository airportRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IStringLocalizer<MessageResources> stringLocalizer;
        private readonly ILogger<AirportService> logger;
        public AirportService(ICacheService<Airport> cacheService, IAirportRepository airportRepository, IUnitOfWork unitOfWork, IStringLocalizer<MessageResources> stringLocalizer, ILogger<AirportService> logger)
        {
            this.cacheService = cacheService;
            this.airportRepository = airportRepository;
            this.unitOfWork = unitOfWork;
            this.stringLocalizer = stringLocalizer;
            this.logger = logger;
        }
    }
}