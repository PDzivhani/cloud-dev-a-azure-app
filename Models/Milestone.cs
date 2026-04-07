using System.ComponentModel.DataAnnotations;

namespace MyFirstAzureWebAppNet8.Models;

public class Milestone
{
    public int milestoneId { get; set; }

    [Required]
    [StringLength(120)]
    public string milestoneTitle { get; set; } = string.Empty;

    public string? milestoneDescription { get; set; }

    [Required]
    [StringLength(50)]
    public string milestoneCategory { get; set; } = string.Empty;

    public DateTime DateAchieved { get; set; } = DateTime.UtcNow;

    public DateTime? LastUpdated { get; set; }
}
