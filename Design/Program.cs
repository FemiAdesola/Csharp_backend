using System;
using System.Collections.Generic;
using Design.Models;
using static System.Console;

WriteLine("############# New Product ################");
// Product.CreateProduct(2, "Shoe", 35.00f, "Andy shoes are designed to keeping in...", "https://google.com.png", new Category(1, "Addidas", "https://google.com.png"));
var product = Product.Products.FirstOrDefault(product => product.ID == product.ID);
WriteLine(product);

WriteLine("############# Product Update ################");
var productUpdate = Product.Products.Find(product => product.ID == 2);
productUpdate.UpdateProduct( "Shoe", 35.00f, "New shoe from joppa");
WriteLine(productUpdate);

WriteLine("############# New User ################");
User.CreateUser(1, "Ade","Sola", "ade@sola.com", "ade123", Design.Role.Admin);
var user = User.Users.FirstOrDefault(user => user.ID == 1);
WriteLine(user);

WriteLine("############# Order ################");
Order.CreateOrder(1, DateTime.Now.ToLocalTime(), true, new User(2) ,new Cart("shoes", 20, 20.00, 50.00f)); // Question on how to pass only userid
var order = Order.Orders.FirstOrDefault(order => order.OrderId == 1);
WriteLine(order);