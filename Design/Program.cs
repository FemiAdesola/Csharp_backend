using System;
using System.Collections.Generic;
using Design.Models;
using static System.Console;

WriteLine("############# New Product ################");
Product.CreateProduct(2, "Shoe", 35.00f, "new shoe from joppa");
var product = Product.Products.FirstOrDefault(product => product.ID == product.ID);
WriteLine(product);

WriteLine("############# Product Update ################");
var productUpdate = Product.Products.Find(product => product.ID == 4);
productUpdate.UpdateProduct(3, "Shoe", 35.00f, "new shoe from joppa");
WriteLine(productUpdate);

WriteLine("############# New User ################");
User.CreateUser(1, "Ade","Sola", "ade@sola.com", "ade123", Design.Role.Admin);
var user = User.Users.FirstOrDefault(user => user.ID == 1);
WriteLine(user);