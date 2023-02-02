using System;
using Design.DTO;
using Design.Models;

public interface IOrderService
{
    Product GetOrder(int id);
    void DeleteOrder(int id);
    void UpdateProduct(int id, ProductRequest dto);
    object Find(int id);
}