namespace App.Business.Services.Concrete
{
    public class ModelService : IModelService
    {
        private readonly ICacheService<Model> cacheService;
        private readonly IModelRepository modelRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IStringLocalizer<MessageResources> stringLocalizer;
        private readonly ILogger<ModelService> logger;
        public ModelService(ICacheService<Model> cacheService, IModelRepository modelRepository, IUnitOfWork unitOfWork, IStringLocalizer<MessageResources> stringLocalizer, ILogger<ModelService> logger)
        {
            this.cacheService = cacheService;
            this.modelRepository = modelRepository;
            this.unitOfWork = unitOfWork;
            this.stringLocalizer = stringLocalizer;
            this.logger = logger;
        }
    }
}