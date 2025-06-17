using DevHabit.Entities;
using Newtonsoft.Json;

namespace DevHabit.DTOs.Habits;

public sealed record HabitsCollectionDto
{
    public List<HabitDto> Data { get; init; }
}

public sealed record HabitWithTagDto : HabitDto
{
    [JsonProperty(Order = int.MaxValue)]
    public required string[] Tags { get; set; }
}

public record HabitDto
{
    public required string Id { get; set; }
    public required string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public required HabitType Type { get; set; }
    public required FrequencyDto Frequency { get; set; }
    public required TargetDto Target { get; set; }
    public required HabitStatus Status { get; set; }
    public required bool IsArchived { get; set; }
    public DateOnly? EndDate { get; set; }
    public MilestoneDto? Milestone { get; set; }
    public required DateTime CreatedAtUtc { get; set; }
    public DateTime? UpdateAtUtc { get; set; }
    public DateTime? LastCompleteAtUtc { get; set; }
}

public sealed record FrequencyDto
{
    public required FrequencyType Type { get; set; }
    public required int TimesPerPeriod { get; set; }
}


public sealed record TargetDto
{
    public required int Value { get; set; }
    public required string Unit { get; set; }
}


public sealed record MilestoneDto
{
    public required int Target { get; set; }
    public required int Current { get; set; }
}


