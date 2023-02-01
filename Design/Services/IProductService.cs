using System;
using Design.DTO;
using Design.Models;

public interface IProductService
{
    Product GetProduct(int id);
    void DeleteProduct(int id);
    void UpdateProduct(int id, ProductRequest dto);
    object Find(int id);
}