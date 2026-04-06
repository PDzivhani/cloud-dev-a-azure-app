using System.ComponentModel.DataAnnotations;

namespace MyFirstAzureWebAppNet8.Models;

public class LearningEntry
{
    public int Id { get; set; }

    [Required]
    [StringLength(150)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Module { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Topic { get; set; } = string.Empty;
   
   [Required]
    public string Content { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Category { get; set; } = string.Empty;

    [StringLength(200)]
    public string? Tags { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public DateTime? LastUpdated { get; set; }
}   