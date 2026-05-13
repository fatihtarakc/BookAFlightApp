namespace App.Entity.Enums
{
    public enum BodyType
    {
        /// <summary>
        /// 3+3 Standart Tek Koridor Düzeni.
        /// Yaygın olarak Boeing 737 ve Airbus A320 ailelerinde kullanılır.
        /// </summary>
        [Display(Name = "Narrow Body(ABC-DEF)", Description = "Standart Dar Gövde (3+3) Düzeni")]
        NarrowBody = 1,

        /// <summary>
        /// 2+4+2 Çift Koridor Standart Düzen.
        /// Genellikle Airbus A330 gibi geniş gövdeli uçaklarda tercih edilir.
        /// </summary>
        [Display(Name = "Wide Body(AB-CDEF-GH)", Description = "Standart Geniş Gövde (2+4+2) Düzeni")]
        StandardWideBody,

        /// <summary>
        /// 3+4+3 Çift Koridor Yüksek Yoğunluklu Düzen.
        /// Boeing 777, 747 ve Airbus A380 gibi devasa uçaklarda kullanılır.
        /// </summary>
        [Display(Name = "Wide Body(ABC-DEFG-HJK)", Description = "Yüksek Yoğunluklu Geniş Gövde (3+4+3) Düzeni")]
        DenseWideBody,

        /// <summary>
        /// 2+2 Bölgesel Jet ve Pervaneli Uçak Düzeni.
        /// B ve E (orta) koltukları yoktur. Örn: Embraer E-Jets, ATR 72.
        /// </summary>
        [Display(Name = "Regional(AC-DF)", Description = "Bölgesel Jet / Pervaneli (2+2) Düzeni")]
        Regional,

        /// <summary>
        /// 2+2 Bölgesel Jet ve Pervaneli Uçak Düzeni.
        /// B ve E (orta) koltukları yoktur. Örn: Embraer E-Jets, ATR 72.
        /// </summary>
        [Display(Name = "Turboprop(AC-DF)", Description = "Bölgesel Jet / Pervaneli (2+2) Düzeni")]
        Turboprop
    }
}