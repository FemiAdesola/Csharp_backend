## Top to Down

### User stories
- Who are the users of the eCommerce? 
- How many different components/subsystem would it required?

### Necessary
+ Inventory
+ Product
+ Category
+ Order
+ Shipping
+ User
+ Review

## E-commerce:
### Inventory => namespace/feature
+ Product
+ Category
+ Cart
+ Review
### Order => namespace/feature
+ OrderItem

### Shipping => namespace/feature
+ Logistic

### User types
+ Customer
+ Staff member

#### what users can do + Customer:
- User stories
  + View a product
  + Add a product to cart
  + Order the product
  + Review the product

- Staff member:
  + View all the products => methods + Update all the products => methods
  + View all the transactions/orders/shipping etc => methods


## Entities/attributes/relationships
### Product:
+ ID
+ Title
+ Image
+ Category
+ Price
+ IsAvailable
+ Order

### Review
+ ID
+ User
+ Product
+ Rating
+ Message/comment

### Category
+ ID
+ Name
+ Image
### ProductVariant
+ ProductID
- Attributes
  + Key (size,color, brand)
  + Value (S, M, L, XL, XXL, red/blue/yellow, Samsung/LG/Nokia/Mac/Window)

### Order
+ Date
+ Price
+ TotalPrice
+ OrderItem
[
  + ProductID
  + Quantity
]

### Methods
+ GetAll...
+ GetSingle...
+ Create...
+ Update...
+ Delete...

![Diagram](/img/Diagram.png)