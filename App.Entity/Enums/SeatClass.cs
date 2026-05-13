namespace App.Entity.Enums
{
    public enum SeatClass
    {
        Economy = 1,
        [Display(Name = "Premium Economy")]
        PremiumEco,
        Business,
        [Display(Name = "First Class")]
        FirstClass
    }
}