using Microsoft.EntityFrameworkCore;

namespace DevHabit.Database;

public class DBContext :DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options)
    {
    }
}
