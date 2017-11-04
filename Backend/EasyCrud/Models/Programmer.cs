namespace EasyCrud.Models
{
    public class Programmer
    {
        public long Id { get; set; }
        //Basic
        public string Email { get; set; }
        public string Name { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
        public string Linkedin { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Portfolio { get; set; }
        public int Salary { get; set; }
        public string Bank { get; set; }
        public string Link { get; set; }

        public virtual BankInfo BankInfo { get; set; }
        public virtual Knoledge Knoledge { get; set; }
        public virtual BestTime BestTime { get; set; }
        public virtual Availability Availability { get; set; }
    }
}
