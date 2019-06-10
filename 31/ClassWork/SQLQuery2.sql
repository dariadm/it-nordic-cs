CREATE DATABASE AirportInfo
GO
USE AirportInfo
GO
CREATE TABLE [AirportInfo].[dbo].[DepartureBoard ]( 
	[FlightNumber] [char](10) NOT NULL, 
	[DepartureCity] [char](20) NULL, 
	[DepartureCountry] [char](30) NOT NULL, 
	[ArrivalCity] [char](20) NOT NULL, 
	[ArrivalCountry] [char](30) NOT NULL,
	[DepartureTime]	[smalldatetime] NOT NULL,
	[ArrivalTime] [smalldatetime] NOT NULL,
	[FlightTime] [tinyint] NOT NULL,
	[Airline] [char](50) NOT NULL,
	[AircraftType] [char](20) NOT NULL
	) ON [PRIMARY] 
GO

INSERT INTO [AirportInfo].[dbo].[DepartureBoard ]( 
	[FlightNumber], 
	[DepartureCity], 
	[DepartureCountry], 
	[ArrivalCity], 
	[ArrivalCountry],
	[DepartureTime],
	[ArrivalTime],
	[FlightTime],
	[Airline],
	[AircraftType])
VALUES ('U3234', 'Moscow', 'Russia', 'Berlin', 'Germany', '2018-09-03 14:35:00', '2018-09-03 15:35:00', 2, 'AirBerlin', 'Boeing-737')
GO

INSERT INTO [AirportInfo].[dbo].[DepartureBoard ]( 
	[FlightNumber], 
	[DepartureCity], 
	[DepartureCountry], 
	[ArrivalCity], 
	[ArrivalCountry],
	[DepartureTime],
	[ArrivalTime],
	[FlightTime],
	[Airline],
	[AircraftType])
VALUES ('RV3234', 'Moscow', 'Russia', 'Paris', 'France', '2019-02-15 10:50:00', '2019-02-15 13:35:00', 4, 'AirFrance', 'Airbus-380')
GO 

SELECT * FROM [dbo].[DepartureBoard ]
GO 

DROP TABLE [dbo].[DepartureBoard ]

DROP DATABASE AirportInfo