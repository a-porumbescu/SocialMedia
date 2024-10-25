using api.DTOs.Stock;
using api.Models;

namespace api.Interfaces;

public interface IStockRepository
{
    public Task<List<Stock>> GetAllAsync();
    public Task<Stock?> GetByIdAsync(int id); //FirstOrDefault can be null
    public Task<Stock> CreateAsync(Stock stockModel);
    public Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
    public Task<Stock?> DeleteAsync(int id);
}