namespace EasyCrud.Models
{
    public class BankInfo
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Bank { get; set; }
        public string Agency { get; set; }
        public int AccType { get; set; }
        public string AccNumber { get; set; }

        // public virtual Programmer Programmer { get; set; }
    }
}
