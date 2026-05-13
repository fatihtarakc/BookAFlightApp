namespace App.Business.Services.Concrete
{
    public class ScheduleService : IScheduleService 
    {
        private readonly ICacheService<Schedule> cacheService;
        private readonly IScheduleRepository scheduleRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IStringLocalizer<MessageResources> stringLocalizer;
        private readonly ILogger<ScheduleService> logger;
        public ScheduleService(ICacheService<Schedule> cacheService, IScheduleRepository scheduleRepository, IUnitOfWork unitOfWork, IStringLocalizer<MessageResources> stringLocalizer, ILogger<ScheduleService> logger)
        {
            this.cacheService = cacheService;
            this.scheduleRepository = scheduleRepository;
            this.unitOfWork = unitOfWork;
            this.stringLocalizer = stringLocalizer;
            this.logger = logger;
        }
    }
}