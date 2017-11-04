namespace EasyCrud.Models
{
    public class Availability
    {
        public long Id { get; set; }

        // Up to 4 hours per day / Até 4 horas por dia
        public bool Op1 { get; set; }
        // 4 to 6 hours per day / De 4 á 6 horas por dia
        public bool Op2 { get; set; }
        // 6 to 8 hours per day /De 6 á 8 horas por dia
        public bool Op3 { get; set; }
        // Up to 8 hours a day (are you sure?) / Acima de 8 horas por dia (tem certeza?)
        public bool Op4 { get; set; }
        // Only weekends / Apenas finais de semana
        public bool Op5 { get; set; }

        // public virtual Programmer Programmer { get; set; }
    }
}
