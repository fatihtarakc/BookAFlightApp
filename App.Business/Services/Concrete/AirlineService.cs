namespace App.Business.Services.Concrete
{
    public class AirlineService : IAirlineService 
    {
        private readonly ICacheService<Airline> cacheService;
        private readonly IAirlineRepository airlineRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IStringLocalizer<MessageResources> stringLocalizer;
        private readonly ILogger<AirlineService> logger;
        public AirlineService(ICacheService<Airline> cacheService, IAirlineRepository airlineRepository, IUnitOfWork unitOfWork, IStringLocalizer<MessageResources> stringLocalizer, ILogger<AirlineService> logger)
        {
            this.cacheService = cacheService;
            this.airlineRepository = airlineRepository;
            this.unitOfWork = unitOfWork;
            this.stringLocalizer = stringLocalizer;
            this.logger = logger;
        }
    }
}