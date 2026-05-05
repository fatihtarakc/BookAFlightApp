namespace App.Entity.Enums
{
    public enum Currency
    {
        [Display(Name = "₺")]
        TL = 1,
        [Display(Name = "$")]
        USD,
        [Display(Name = "€")]
        Euro
    }
}