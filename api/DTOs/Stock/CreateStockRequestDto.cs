using System.ComponentModel.DataAnnotations;

namespace api.DTOs.Stock;

public class CreateStockRequestDto
{
    [Required]
    [MaxLength(10, ErrorMessage = "Symbol max length is 10")]
    public string Symbol { get; set; } = string.Empty;
    [Required]
    [MaxLength(20, ErrorMessage = "Company name max length is 20")]
    public string CompanyName { get; set; } = string.Empty;
    [Required]
    [Range(1, 1000000000)]
    public decimal PurchasePrice { get; set; }
    [Required]
    [Range(0.001, 100)]
    public decimal LastDiv { get; set; }
    [Required]
    [MaxLength(10, ErrorMessage = "Industry max length is 10")]
    public string Industry { get; set; } = string.Empty;
    [Required]
    [Range(1, 5000000000)]
    public long MarketCap { get; set; }
}