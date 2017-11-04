using System.Collections.Generic;
using EasyCrud.Models;

namespace EasyCrud.Repository
{
public interface IProgrammerRepository
{
void Add(Programmer item);
IEnumerable<Programmer> GetAll();
Programmer Find(long id);
void Remove(long id);
void Update(Programmer item);
}
}
