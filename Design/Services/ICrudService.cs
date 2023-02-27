namespace Design.Services;

using System;
using Design.DTOs;
using Design.Models;
// where TRequest : BaseRequest<TModel> come from DTOs
//  where TModel : BaseModel, new()  come from basedmodel 

public interface ICrudService<TModel, TRequest> 
    where TModel : BaseModel, new() 
    where TRequest : BaseRequest<TModel>
{
    Task<TModel?> CreateAsync(TRequest request);
    Task<TModel?> GetAsync(int id);
    Task<TModel?> UpdateAsync(int id, TRequest request);
    Task<bool> DeleteAsync(int id);
    Task<IEnumerable<TModel>> GetAllAsync();
}