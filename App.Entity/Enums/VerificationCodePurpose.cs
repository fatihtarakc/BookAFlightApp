namespace App.Entity.Enums
{
    public enum VerificationCodePurpose
    {
        [Display(Name = "Registration")]
        Registration = 1,

        [Display(Name = "Password Reset")]
        PasswordReset,

        [Display(Name = "Email Change")]
        EmailChange,

        [Display(Name = "Phone Number Change")]
        PhoneNumberChange,

        [Display(Name = "Two Factor Authentication")]
        TwoFactorAuthentication,
    }
}