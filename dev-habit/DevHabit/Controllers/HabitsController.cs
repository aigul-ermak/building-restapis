using DevHabit.Database;
using DevHabit.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevHabit.Controllers;

[ApiController]
[Route("habits")]
public sealed class HabitsController(ApplicationDbContext dbContext) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetHabits()
    {
        List<Habit> habits = await dbContext.Habits.ToListAsync();

        return Ok(habits);
    }
}
