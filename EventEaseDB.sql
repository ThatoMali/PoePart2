-- Switch to master database
USE master;

-- Drop database if it exists
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'WebsiteBookingDatabase')

    DROP DATABASE WebsiteBookingDatabase;

-- Create the new database
CREATE DATABASE Website_;
-- Switch to the new database
USE Website_;

-- Venue Table
CREATE TABLE Venue (
    VenueID INT IDENTITY(1,1) PRIMARY KEY,  -- Auto-incrementing VenueID
    VenueName VARCHAR(350) NOT NULL,
    Location VARCHAR(350) NOT NULL,
    Capacity INT NOT NULL,
    Image_Url VARCHAR(500)
);

-- Insert example data
INSERT INTO Venue (VenueName, Location, Capacity, Image_Url)
VALUES ('Concert Hall', 'New York City', 5000, 'http://example.com/venue-image.jpg');

-- Event Table
CREATE TABLE Event_ (
    EventID INT IDENTITY(1,1) PRIMARY KEY,  -- Auto-incrementing EventID
    EventName VARCHAR(350) NOT NULL,
    EventDate DATE NOT NULL DEFAULT GETDATE(),
    Description VARCHAR(MAX),
    VenueID INT NULL,
    FOREIGN KEY (VenueID) REFERENCES Venue(VenueID)
);

-- Insert example data
INSERT INTO Event_ (EventName, EventDate,Description,VenueID)
VALUES ('Spring Music Festival', '2025-05-10','YES',1);

-- Booking Table
CREATE TABLE Booking(
    BookingID INT IDENTITY(1,1) PRIMARY KEY,  -- Auto-incrementing BookingID
    EventID INT NOT NULL,
    VenueID INT NOT NULL,
     BookingDate DATE NOT NULL DEFAULT GETDATE()
    FOREIGN KEY (EventID) REFERENCES Event_(EventId),
    FOREIGN KEY (VenueID) REFERENCES Venue(VenueId),
    CONSTRAINT UQ_Booking UNIQUE (EventId, VenueId)
);

    INSERT INTO Booking (EventID, VenueID, BookingDate)
    VALUES (1, 1, '2025-05-10');


-- Final Data Check (only select from the three tables)
SELECT * FROM Venue;
SELECT * FROM Event_;
SELECT * FROM Booking