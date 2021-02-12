using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    public class ActivitiesController: BaseApiController
    {
        private DataContext _context;
        public ActivitiesController(DataContext context)
        {
          _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> getActivites() {
          var res = await _context.activities.ToListAsync();
          return res;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> getActivitty(Guid id) {
           var res = await _context.activities.FindAsync(id);
           return res;
        }
    }
}