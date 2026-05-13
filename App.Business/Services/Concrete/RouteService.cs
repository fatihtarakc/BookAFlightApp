namespace App.Business.Services.Concrete
{
    public class RouteService : IRouteService
    {
        private readonly ICacheService<Route> cacheService;
        private readonly IRouteRepository routeRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IStringLocalizer<MessageResources> stringLocalizer;
        private readonly ILogger<RouteService> logger;
        public RouteService(ICacheService<Route> cacheService, IRouteRepository routeRepository, IUnitOfWork unitOfWork, IStringLocalizer<MessageResources> stringLocalizer, ILogger<RouteService> logger)
        {
            this.cacheService = cacheService;
            this.routeRepository = routeRepository;
            this.unitOfWork = unitOfWork;
            this.stringLocalizer = stringLocalizer;
            this.logger = logger;
        }
    }
}