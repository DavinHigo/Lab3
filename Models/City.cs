using System;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models;

public class City
{
    [Key]
    public int CityId { get; set; }
    public string? CityName { get; set; }
    public int Population { get; set; }
    public string? Province { get; set; }
}
