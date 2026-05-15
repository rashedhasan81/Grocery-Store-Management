# Grocery Store Management System

## American International University-Bangladesh (AIUB)
**Department of Computer Science**  
**Faculty of Science and Technology**

### Course Information
- **Course:** CSC2210 - Object Oriented Programming 2
- **Semester:** Spring 2025-2026
- **Section:** M

### Project Title
## Grocery Store Management System

### Supervised By
**Dr. Md. Iftekharul Mobin**

---

## Team Members

| Name | ID |
|------|----|
| MD. TAWSHIF HOSSAIN | 24-58072-2 |
| MD RASHED MUSHAROF | 23-53306-3 |
| ASHIQUR RAHMAN | 24-55921-1 |
| SHARMIN AKHTER MIM | 24-55914-1 |

---

# Table of Contents

- [Introduction](#introduction)
- [Objectives](#objectives)
- [Case Study](#case-study)
- [System Design](#system-design)
- [Database Query](#database-query)
- [Features and Facilities](#features-and-facilities)
- [Conclusion](#conclusion)

---

# Introduction

In modern times, online grocery shopping has become an essential part of daily life. Customers expect a fast and simple way to browse products, add items to a cart, and place orders from home.

At the same time, store administrators need efficient tools to manage inventory, monitor sales, and handle user activities.

This project presents a **Grocery Store Management System** developed using **C# Windows Forms**.

The system provides a complete platform where:

- Customers can shop online
- Admins can manage products and inventory
- Super Admins can control users and system operations

The goal is to create a simple, user-friendly, and efficient system that reflects a real-world grocery shopping environment.

---

> **Project Status:**  
> This project is currently under active development. Additional features, improvements, and bug fixes will be completed before the viva examination.

# Objectives

The main objectives of this system are:

- Provide an easy-to-use platform for online grocery shopping
- Manage inventory efficiently
- Maintain customer records securely
- Automate order processing
- Reduce manual errors
- Improve system accuracy

---

# Case Study

This system models a real-world grocery shopping platform involving three types of users:

- **Customer**
- **Admin**
- **Super Admin**

All users are stored in a single system, and their roles are determined automatically based on the stored user type.

## Customer Workflow

A customer registers by providing:

- Full Name
- Email
- Phone Number
- Address
- Username
- Password

After successful registration, the customer logs in and accesses the **Customer Dashboard**, where they can:

- View Products
- Manage Cart
- Track Orders
- Update Profile
- Logout

Customers can browse grocery items such as:

- Rice
- Sugar
- Cooking Oil
- Pulses

Each product contains:

- Product ID
- Category
- Price
- Stock
- Unit
- Description

Customers can:

- Add products to cart
- Update quantities
- Remove items
- Checkout
- Select payment method
- Track order status

After receiving orders, customers can:

- Submit reviews
- Provide ratings
- Submit complaints

---

## Admin Workflow

Admins can:

- Add products
- Update products
- Remove products
- Monitor inventory
- View stock alerts
- Track sales performance

---

## Super Admin Workflow

Super Admin has full system control and can:

- Manage users
- Block/Unblock accounts
- Monitor admin activities
- Manage branch information
- Review customer feedback
- Handle complaints

---

# System Design

## Database Schema
![Database Schema](schema.png)

The system contains the following major tables:

- Users
- Products
- Branch
- Cart
- CartItems
- Orders
- OrderDetails
- Reviews
- Complaints

---

# Database Query

## Create Database

```sql
CREATE DATABASE GroceryStore;
USE GroceryStore;
```

---

## Users Table

```sql
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    FullName VARCHAR(100),
    Email VARCHAR(100),
    Phone VARCHAR(20),
    Address VARCHAR(200),
    Username VARCHAR(50) UNIQUE,
    Password VARCHAR(50),
    UserType VARCHAR(20)
);
```

---

## Products Table

```sql
CREATE TABLE Products (
    ProductID VARCHAR(10) PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2),
    Stock INT,
    Unit VARCHAR(20),
    Description VARCHAR(255)
);
```

---

## Branch Table

```sql
CREATE TABLE Branch (
    BranchID INT PRIMARY KEY IDENTITY,
    Name VARCHAR(100),
    Location VARCHAR(100)
);
```

---

## Cart Table

```sql
CREATE TABLE Cart (
    CartID INT PRIMARY KEY IDENTITY,
    UserID INT,
    IsActive BIT DEFAULT 1,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
```

---

## CartItems Table

```sql
CREATE TABLE CartItems (
    CartItemID INT PRIMARY KEY IDENTITY,
    CartID INT,
    ProductID VARCHAR(10),
    Quantity INT,
    Total DECIMAL(10,2),
    FOREIGN KEY (CartID) REFERENCES Cart(CartID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
```

---

## Orders Table

```sql
CREATE TABLE Orders (
    OrderID VARCHAR(10) PRIMARY KEY,
    UserID INT,
    BranchID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(10,2),
    DeliveryCharge DECIMAL(10,2),
    Discount DECIMAL(10,2),
    PayableAmount DECIMAL(10,2),
    PaymentMethod VARCHAR(50),
    Status VARCHAR(50),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (BranchID) REFERENCES Branch(BranchID)
);
```

---

## OrderDetails Table

```sql
CREATE TABLE OrderDetails (
    ID INT PRIMARY KEY IDENTITY,
    OrderID VARCHAR(10),
    ProductID VARCHAR(10),
    Quantity INT,
    Price DECIMAL(10,2),
    Total DECIMAL(10,2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
```

---

## Reviews Table

```sql
CREATE TABLE Reviews (
    ReviewID INT PRIMARY KEY IDENTITY,
    UserID INT,
    OrderID VARCHAR(10),
    Rating DECIMAL(3,1),
    ReviewText VARCHAR(500),
    ReviewDate DATE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);
```

---

## Complaints Table

```sql
CREATE TABLE Complaints (
    ComplaintID INT PRIMARY KEY IDENTITY,
    UserID INT,
    ComplaintText VARCHAR(500),
    ComplaintDate DATE,
    Status VARCHAR(50),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
```

---

# Features and Facilities

- User registration and secure login
- Role-based access control
- Product browsing and search
- Product details view
- Add to cart functionality
- Cart management
- Checkout system
- Order placement
- Order tracking
- Review and feedback system
- Inventory management
- Stock alerts
- Admin dashboard analytics
- User account management
- Complaint handling system

---

# Technologies Used

- **Programming Language:** C#
- **Framework:** Windows Forms
- **Database:** SQL Server
- **IDE:** Visual Studio

---

# Conclusion

The **Grocery Store Management System** successfully provides a complete platform for online grocery shopping and management.

It integrates:

- Customer interaction
- Order processing
- Inventory management
- Administrative control

The system offers a practical implementation of a real-world grocery store application using **C# Windows Forms**.

It ensures:

✔ Efficiency  
✔ User-friendliness  
✔ Organized workflow  
✔ Better management

---

# Future Improvements

Possible future enhancements:

- Online payment gateway integration
- Mobile app version
- AI-based product recommendation
- Delivery tracking system
- Discount coupon system

---
# Project Screenshots

## 1. Login Form
![Login Form](1.jpeg)

## 2. Registration Form
![Registration Form](2.jpeg)

## 3. Customer Dashboard
![Customer Dashboard](3.jpeg)

## 4. Product List
![Product List](4.jpeg)

## 5. Product Details
![Product Details](5.jpeg)

## 6. Cart Form
![Cart Form](6.jpeg)

## 7. Checkout / Place Order Form
![Checkout Form](7.jpeg)

## 8. My Orders Form
![My Orders](8.jpeg)

## 9. Profile Form
![Profile Form](9.jpeg)

## 10. Admin Inventory Management
![Admin Inventory](10.png)

## 11. Admin Dashboard
![Admin Dashboard](11.png)

## 12. Super Admin Panel
![Super Admin](12.png)
# License

This project is developed for academic purposes at **AIUB**.
