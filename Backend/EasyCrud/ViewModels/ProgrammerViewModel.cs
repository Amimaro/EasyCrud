using Microsoft.EntityFrameworkCore;
using EasyCrud.Models;

namespace EasyCrud.ViewModels
{
    public class ProgrammerViewModel
    {
        public Availability Availability { get; set; }
        public BankInfo BankInfo { get; set; }
        public BestTime BestTime { get; set; }
        public Knoledge Knoledge { get; set; }
        public Programmer Programmer { get; set; }
    }
}
