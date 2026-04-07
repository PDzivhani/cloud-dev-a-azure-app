using System.ComponentModel.DataAnnotations;

namespace MyFirstAzureWebAppNet8.Models;

public class Project
{
    public int projectId { get; set; }

    [Required]
    [StringLength(120)]
    public string projectName {get; set; } = string.Empty;

    [Required]
    public string Description { get; set; } = string.Empty;

    [StringLength(200)]
    public string? TechStack {get;set; }

    [StringLength(200)]
    public string? AzureServices { get; set; }

    [StringLength(250)]
    public string? GithubUrl { get; set; }

     [StringLength(250)]
    public string? LiveDemoUrl { get; set; }

    [Required]
    [StringLength(30)]
    public string Status { get; set; } = string.Empty;

    public DateTime DateStarted { get; set; } = DateTime.UtcNow;
    public DateTime? LastUpdated { get; set; }

}