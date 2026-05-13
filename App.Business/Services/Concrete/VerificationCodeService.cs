namespace App.Business.Services.Concrete
{
    public class VerificationCodeService : IVerificationCodeService
    {
        private readonly ICacheService<VerificationCode> cacheService;
        private readonly IVerificationCodeRepository verificationCodeRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IStringLocalizer<MessageResources> stringLocalizer;
        private readonly ILogger<VerificationCodeService> logger;
        public VerificationCodeService(ICacheService<VerificationCode> cacheService, IVerificationCodeRepository verificationCodeRepository, IUnitOfWork unitOfWork, IStringLocalizer<MessageResources> stringLocalizer, ILogger<VerificationCodeService> logger)
        {
            this.cacheService = cacheService;
            this.verificationCodeRepository = verificationCodeRepository;
            this.unitOfWork = unitOfWork;
            this.stringLocalizer = stringLocalizer;
            this.logger = logger;
        }
    }
}