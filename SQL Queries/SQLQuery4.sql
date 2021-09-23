-------------------------------------------------------------------USER

--CREATE TABLE [dbo].[User](
--userID INT IDENTITY(1,1) NOT NULL,
--username VARCHAR(20) NOT NULL, 
--password VARCHAR(20) NOT NULL
--);

--SELECT*FROM [User]
--DROP Table [User]

-------------------------------------------------------------------ORDERS

--GO
--CREATE TABLE [dbo].[Orders](
--[OrderID] INT IDENTITY(1,1) NOT NULL,
--[EventID] INT  NOT NULL,
--[TicketQuantity] INT NOT NULL,
--[FirstName] VARCHAR(20) NOT NULL,
--[LastName] VARCHAR(20) NOT NULL,
--[Email] VARCHAR (20) NOT NULL, 
--[PhoneNumber] INT NULL
--);

--ALTER table Orders
--add constraint UNQ_ORDER_ID unique (orderID)

--SELECT * FROM Orders
--DROP Table Orders

-------------------------------------------------------------------EVENT

--GO
--CREATE TABLE [dbo].[Event](
--[EventID] INT IDENTITY(1,1) NOT NULL,
--[EventName] VARCHAR(50) NOT NULL,
--[EventType] VARCHAR(20) NOT NULL,
--[EventVenue] VARCHAR(20) NOT NULL,
--[EventDateTime] VARCHAR(20) NOT NULL,
--[EventCounty] VARCHAR(15) NOT NULL,
--[TicketPrice] INT NOT NULL
--);

--ALTER table Event
--add constraint UNQ_EVENT_ID unique (eventID)

--SELECT * FROM Event
--DROP Table Event

--INSERT INTO Event VALUES('First Event', 'Seminar','The City Hall','21/9/21','Cork','10');

-------------------------------------------------------------------ORDERLINE

--GO
--CREATE TABLE OrderLine(
--orderLineID INT IDENTITY(1,1) NOT NULL,
--orderID INT NOT NULL, 
--eventID INT NOT NULL,
--ticketQuantity INT NOT NULL
--);

SELECT * FROM OrderLine
--DROP Table OrderLine













