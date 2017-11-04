using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EasyCrud.Models;
using EasyCrud.Repository;

namespace EasyCrud.Controllers
{
[Route("api/[controller]")]
public class ProgrammerController : Controller
{
public IProgrammerRepository ProgrammerRepo {
        get; set;
}

public ProgrammerController(IProgrammerRepository _repo)
{
        ProgrammerRepo = _repo;
}

[HttpGet]
public IEnumerable<Programmer> GetAll()
{
        return ProgrammerRepo.GetAll();
}

[HttpGet("{id}", Name = "GetProgrammer")]
public IActionResult GetById(long id)
{
        var item = ProgrammerRepo.Find(id);
        if (item == null)
        {
                return NotFound();
        }
        return new ObjectResult(item);
}

[HttpPost]
public IActionResult Create([FromBody] Programmer item)
{
        if (item == null)
        {
                return BadRequest();
        }

        ProgrammerRepo.Add(item);
        return CreatedAtRoute("GetProgrammer", new { Controller = "Programmer", id = item.Id }, item);
}

[HttpPut("{id}")]
public IActionResult Update(long id, [FromBody] Programmer item)
{
        if (item == null)
        {
                return BadRequest();
        }
        var programmerObj = item;

        // foreach (var prop in programmerObj.GetType().GetProperties())
        // {
        //         if(prop.Name != "Id") {
        //                 prop.SetValue(programmerObj, item.GetType().GetProperty(prop.Name).GetValue(item, null));
        //         }
        // }
        // if (programmerObj == null)
        // {
        //         return NotFound();
        // }

        programmerObj.Id = id;
        programmerObj.Availability.Id = id;
        programmerObj.BankInfo.Id = id;
        programmerObj.BestTime.Id = id;
        programmerObj.Knoledge.Id = id;

        ProgrammerRepo.Update(programmerObj);
        return new NoContentResult();
}

[HttpDelete("{id}")]
public void Delete(long id)
{
        ProgrammerRepo.Remove(id);
}
}
}
