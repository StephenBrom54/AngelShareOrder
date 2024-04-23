CREATE TABLE Orders (
    Id INT PRIMARY KEY IDENTITY(1,1),
    SenderName NVARCHAR(100),
    SenderEmail NVARCHAR(100),
    Recipient NVARCHAR(100),
    RecipientEmail NVARCHAR(100),
    RecipientPhone NVARCHAR(15),
    Address NVARCHAR(255)
);


SELECT * FROM Orders;
