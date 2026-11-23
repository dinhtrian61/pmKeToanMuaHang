--Tạo database
CREATE DATABASE PurchaseAccounting1;
GO

USE PurchaseAccounting1;
GO

-- Bảng phân quyền
CREATE TABLE Roles
(
    RoleID INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(50) NOT NULL
);

INSERT INTO Roles(RoleName)
VALUES
(N'Admin'),
(N'User');

-- Bảng Users
CREATE TABLE Users
(
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    RoleID INT NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

INSERT INTO Users(Username,Password,Email,RoleID)
VALUES
('admin1','123','admin@gmail.com',1),
('user1','123','user@gmail.com',2);

-- Bảng nhà cung cấp
CREATE TABLE Suppliers
(
    SupplierID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20),
    Address NVARCHAR(200),
    Email NVARCHAR(100)
);

INSERT INTO Suppliers(SupplierName,Phone,Address,Email)
VALUES
(N'Công ty Minh Long','0901111111',N'Hà Nội','minhlong@gmail.com'),
(N'Công ty Hòa Phát','0902222222',N'Hà Nội','hoaphat@gmail.com'),
(N'Công ty Thành Công','0903333333',N'Hải Phòng','thanhcong@gmail.com'),
(N'Công ty Á Châu','0904444444',N'Đà Nẵng','achau@gmail.com'),
(N'Công ty Phú Quý','0905555555',N'HCM','phuquy@gmail.com'),
(N'Công ty Đông Á','0906666666',N'Hà Nội','donga@gmail.com'),
(N'Công ty Nam Việt','0907777777',N'HCM','namviet@gmail.com'),
(N'Công ty Đại Phát','0908888888',N'Hải Phòng','daiphat@gmail.com'),
(N'Công ty An Phát','0909999999',N'Hà Nội','anphat@gmail.com'),
(N'Công ty Việt Nhật','0910000000',N'HCM','vietnhat@gmail.com');

-- Bảng sản phẩm
CREATE TABLE Products
(
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    Stock INT DEFAULT 0
);

INSERT INTO Products(ProductName,UnitPrice,Stock)
VALUES
(N'Bút bi Thiên Long',5000,500),
(N'Bút chì',3000,400),
(N'Sổ tay',20000,200),
(N'Giấy A4',70000,300),
(N'Bìa hồ sơ',5000,150),
(N'Kẹp giấy',2000,600),
(N'Băng keo',10000,200),
(N'Máy tính Casio',250000,50),
(N'Mực in',350000,70),
(N'Bảng trắng',500000,30);

-- Bảng trạng thái đơn nhập
CREATE TABLE OrderStatus
(
    StatusID INT PRIMARY KEY,
    StatusName NVARCHAR(50) NOT NULL
);

INSERT INTO OrderStatus
VALUES
(1,'Pending'),
(2,'Approved'),
(3,'Ordered'),
(4,'Received'),
(5,'Cancelled');

-- Bảng phiếu nhập (thêm EmployeeID)
CREATE TABLE PurchaseOrders
(
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierID INT NOT NULL,
    EmployeeID INT NOT NULL,
    OrderDate DATE NOT NULL,
    StatusID INT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID),
    FOREIGN KEY (EmployeeID) REFERENCES Users(UserID),
    FOREIGN KEY (StatusID) REFERENCES OrderStatus(StatusID)
);

INSERT INTO PurchaseOrders(SupplierID,EmployeeID,OrderDate,StatusID)
VALUES
(1,1,'2024-01-10',4),
(2,2,'2024-01-12',4),
(3,1,'2024-01-15',3),
(4,2,'2024-01-18',2),
(5,1,'2024-01-20',4),
(6,2,'2024-02-01',4),
(7,1,'2024-02-05',3),
(8,2,'2024-02-10',4),
(9,1,'2024-02-12',4),
(10,2,'2024-02-15',2);

-- Bảng chi tiết phiếu nhập
CREATE TABLE PurchaseOrderDetails
(
    DetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    Amount AS (Quantity * UnitPrice),

    FOREIGN KEY (OrderID) REFERENCES PurchaseOrders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

INSERT INTO PurchaseOrderDetails(OrderID,ProductID,Quantity,UnitPrice)
VALUES
(1,1,5,5000),
(1,2,100,3000),
(2,3,50,20000),
(2,4,30,70000),
(3,5,500,5000),
(3,6,200,2000),
(4,7,50,10000),
(4,8,200,250000),
(5,9,200,350000),
(5,10,100,500000),
(6,1,3,5000),
(7,2,200,3000),
(8,3,70,20000),
(9,4,40,70000),
(10,5,300,5000);

-- Bảng thanh toán
CREATE TABLE Payments
(
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    PaymentDate DATE NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,

    FOREIGN KEY (OrderID) REFERENCES PurchaseOrders(OrderID)
);

INSERT INTO Payments(OrderID, PaymentDate, Amount)
VALUES
(1,'2024-01-11',2000000),
(1,'2024-01-15',3000000),
(2,'2024-01-13',3200000),
(3,'2024-01-16',4000000),
(3,'2024-01-20',3800000),
(4,'2024-01-19',2100000),
(5,'2024-01-22',3000000),
(5,'2024-01-25',3400000),
(6,'2024-02-03',2000000),
(6,'2024-02-08',2300000),
(7,'2024-02-06',5200000),
(8,'2024-02-12',2000000),
(8,'2024-02-18',1900000),
(9,'2024-02-13',5000000),
(9,'2024-02-20',3600000),
(10,'2024-02-16',2000000),
(10,'2024-02-22',2700000);