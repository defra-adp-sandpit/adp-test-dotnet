using System.ComponentModel.DataAnnotations;

namespace Adp.Test.Dotnet.Api.Models;

public class ItemRequest
{
    public int? Id { get; set; }
    [Required]
    public required string Name { get; set; }
}

