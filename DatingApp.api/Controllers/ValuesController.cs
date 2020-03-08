using DatingApp.api.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.api.Controllers
{
    [ApiController]
    [Route("[controller]")]



    public class ValuesController : ControllerBase
    {
    private readonly DataContext _context;
public ValuesController (DataContext context)
{
    _context= context;
}
        public async Task <IActionResult> GetValues()
        {
            var Values = await _context.Values.ToListAsync();
        return Ok(Values);
        }
[HttpGet("{id}")]    
public async Task<IActionResult> GetValues(int id)
{
var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

    return Ok(value);
}

        
    }
}