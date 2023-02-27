namespace Design.Services;

using System.Collections.Generic;
using Design.DTOs;
using Design.Models;
using System.Collections.Concurrent;
using System.Threading.Tasks;

public class FakeCrudSerivce<TModel, TRequest> : ICrudService<TModel, TRequest>
    where TModel : BaseModel, new()
    where TRequest : BaseRequest<TModel>
{
    private ConcurrentDictionary<int, TModel> _items = new();
    private int _itemId;

    public async Task<TModel> CreateAsync(TRequest request)
    {
        var item = new TModel
        {
            ID = Interlocked.Increment(ref _itemId)
        };
        _items[item.ID] = item;
        request.UpdateModel(item);
        return (item);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        if (!_items.ContainsKey(id))
        {
            return false;
        }
        return _items.Remove(id, out var _);
    }

    public async Task<TModel> GetAsync(int id)
    {
        if (_items.TryGetValue(id, out var item))
        {
            return item;
        }
        return null;
    }

    public async Task<IEnumerable<TModel>> GetAllAsync()
    {
        return _items.Values;
    }

    public async Task<TModel?> UpdateAsync(int id, TRequest request)
    {
        var item = await GetAsync(id);
        if (item is null)
        {
            return null;
        }
        request.UpdateModel(item);
        return item;
    }
}