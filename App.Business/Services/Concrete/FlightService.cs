namespace App.Business.Services.Concrete
{
    public class FlightService : IFlightService
    {
        private readonly ICacheService<Flight> cacheService;
        private readonly IFlightRepository flightRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IStringLocalizer<MessageResources> stringLocalizer;
        private readonly ILogger<FlightService> logger;
        public FlightService(ICacheService<Flight> cacheService, IFlightRepository flightRepository, IUnitOfWork unitOfWork, IStringLocalizer<MessageResources> stringLocalizer, ILogger<FlightService> logger)
        {
            this.cacheService = cacheService;
            this.flightRepository = flightRepository;
            this.unitOfWork = unitOfWork;
            this.stringLocalizer = stringLocalizer;
            this.logger = logger;
        }
    }
}