using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Todo.Data;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodolistController: ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<TodolistController> _logger;

        public TodolistController(ILogger<TodolistController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetAllTask()
        {
            var tasks = await _db.Todo.ToListAsync();
            return Ok(tasks);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<TodoItem>>> CreateNewTask(TodoItem todoItem)
        {
            _db.Todo.Add(todoItem);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}