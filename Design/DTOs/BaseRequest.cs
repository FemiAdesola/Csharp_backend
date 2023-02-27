namespace Design.DTOs;

using System.ComponentModel.DataAnnotations;
using Design.Models;

public abstract class BaseRequest<TModel> where TModel : BaseModel
{
    public abstract void UpdateModel(TModel model);
}