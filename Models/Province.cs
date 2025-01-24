using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models;

public class Province
{
    [Key]
    public string? ProvinceCode { get; set; }
    public string? ProvinceName { get; set; }
    public Collection<City>? Cities { get; set; }
}
