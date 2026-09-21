using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.Requests;

public class CreateCompanyDto
{
    public string Name { get; set; } = string.Empty;
    public string? TaxCode { get; set; }
    public string? Address { get; set; }
    public string? Website { get; set; }
    public BusinessType? BusinessType { get; set; }
    public CompanySize? CompanySize { get; set; }
    public Guid? BusinessFieldId { get; set; }
}
