﻿namespace DevHabit.Entities;

public sealed class HabitTag
{
    public string HabitId { get; set; }
    public string TagId { get; set; }
    public DateTime CreateAtUtc { get; set; }
}
