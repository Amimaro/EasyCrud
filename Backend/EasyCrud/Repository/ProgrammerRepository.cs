using System.Collections.Generic;
using System.Linq;
using EasyCrud.Models;
using EasyCrud.Contexts;

namespace EasyCrud.Repository
{
public class ProgrammerRepository : IProgrammerRepository
{
ProgrammerContext _context;

public ProgrammerRepository(ProgrammerContext context)
{
        _context = context;
}

public void Add(Programmer item)
{
        _context.Programmer.Add(item);
        _context.SaveChanges();
}

public IEnumerable<Programmer> GetAll()
{
        _context.Knoledge.ToList();
        _context.BestTime.ToList();
        _context.BankInfo.ToList();
        _context.Availability.ToList();
        return _context.Programmer.ToList();
}

public Programmer Find(long id)
{
        _context.Availability.Find(id);
        _context.BankInfo.Find(id);
        _context.BestTime.Find(id);
        _context.Knoledge.Find(id);
        return _context.Programmer.Find(id);
}

public void Remove(long id)
{
        _context.Programmer.Remove(_context.Programmer.Find(id));
        _context.Availability.Remove(_context.Availability.Find(id));
        _context.BankInfo.Remove(_context.BankInfo.Find(id));
        _context.BestTime.Remove(_context.BestTime.Find(id));
        _context.Knoledge.Remove(_context.Knoledge.Find(id));
        _context.SaveChanges();
}

public void Update(Programmer item)
{
        _context.Programmer.Update(item);
        _context.SaveChanges();
}
}
}
