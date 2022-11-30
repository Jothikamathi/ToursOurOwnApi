using Microsoft.AspNetCore.Mvc;
using ToursApi.Models;

namespace TourWebapi.Controllers;

[ApiController]
[Route("[controller]")]
public class ToursController : ControllerBase
{
   private readonly ToursDbContext DB;
  public ToursController(ToursDbContext db)
  {
    this.DB = db;
  }

   [HttpGet("GetAllTours")]
  public IQueryable<Tour> GetAllTours()
  {
    try
    {
        return DB.Tours;
    }
    catch(System.Exception)
    {
        throw;
    }
  }
}
