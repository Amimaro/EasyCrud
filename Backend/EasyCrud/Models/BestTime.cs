namespace EasyCrud.Models
{
    public class BestTime
    {
        public long Id { get; set; }

        // Morning (from 08:00 to 12:00) / Manhã (de 08:00 ás 12:00)
        public bool Op1 { get; set; }
        // Afternoon (from 1:00 p.m. to 6:00 p.m.) / Tarde (de 13:00 ás 18:00)
        public bool Op2 { get; set; }
        // Night (7:00 p.m. to 10:00 p.m.) /Noite (de 19:00 as 22:00)
        public bool Op3 { get; set; }
        // Dawn (from 10 p.m. onwards) / Madrugada (de 22:00 em diante)
        public bool Op4 { get; set; }
        // Business (from 08:00 a.m. to 06:00 p.m.) / Comercial (de 08:00 as 18:00)
        public bool Op5 { get; set; }

        // public virtual Programmer Programmer { get; set; }
    }
}
