namespace App.Business.Services.Concrete
{
    public class AircraftService : IAircraftService
    {
        private readonly ICacheService<Aircraft> cacheService;
        private readonly IAircraftRepository aircraftRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IStringLocalizer<MessageResources> stringLocalizer;
        private readonly ILogger<AircraftService> logger;
        public AircraftService(ICacheService<Aircraft> cacheService, IAircraftRepository aircraftRepository, IUnitOfWork unitOfWork, IStringLocalizer<MessageResources> stringLocalizer, ILogger<AircraftService> logger)
        {
            this.cacheService = cacheService;
            this.aircraftRepository = aircraftRepository;
            this.unitOfWork = unitOfWork;
            this.stringLocalizer = stringLocalizer;
            this.logger = logger;
        }
    }
}