using System.ComponentModel.DataAnnotations;

namespace Inspection_Api.Models;

public class InspectionType
{
    public int Id { get; set; }

    [StringLength(20)]
    public string InspectionName { get; set; } = string.Empty;
}
