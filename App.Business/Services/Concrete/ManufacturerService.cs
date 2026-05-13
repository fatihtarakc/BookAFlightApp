namespace App.Business.Services.Concrete
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly ICacheService<Manufacturer> cacheService;
        private readonly IManufacturerRepository manufacturerRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IStringLocalizer<MessageResources> stringLocalizer;
        private readonly ILogger<ManufacturerService> logger;
        public ManufacturerService(ICacheService<Manufacturer> cacheService, IManufacturerRepository manufacturerRepository, IUnitOfWork unitOfWork, IStringLocalizer<MessageResources> stringLocalizer, ILogger<ManufacturerService> logger)
        {
            this.cacheService = cacheService;
            this.manufacturerRepository = manufacturerRepository;
            this.unitOfWork = unitOfWork;
            this.stringLocalizer = stringLocalizer;
            this.logger = logger;
        }
    }
}