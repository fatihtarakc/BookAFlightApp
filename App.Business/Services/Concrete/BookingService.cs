namespace App.Business.Services.Concrete
{
    public class BookingService : IBookingService
    {
        private readonly ICacheService<Booking> cacheService;
        private readonly IBookingRepository bookingRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IStringLocalizer<MessageResources> stringLocalizer;
        private readonly ILogger<BookingService> logger;
        public BookingService(ICacheService<Booking> cacheService, IBookingRepository bookingRepository, IUnitOfWork unitOfWork, IStringLocalizer<MessageResources> stringLocalizer, ILogger<BookingService> logger)
        {
            this.cacheService = cacheService;
            this.bookingRepository = bookingRepository;
            this.unitOfWork = unitOfWork;
            this.stringLocalizer = stringLocalizer;
            this.logger = logger;
        }
    }
}