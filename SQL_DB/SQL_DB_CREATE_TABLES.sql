CREATE DATABASE KCDB;

USE KCDB;

Create Table [PERSONS] (
  [PersonID] int identity(1, 1) NOT NULL,
  [FirstName] nvarchar(30) NOT NULL,
  [MidName] nvarchar(30) NULL,
  [LastName] nvarchar(30) NOT NULL,
  [Address] nvarchar(30) NULL,
  PRIMARY KEY ([PersonID])
);



Create Table [FEES] (
FeeID int identity(1, 1) NOT NULL,
SubscriptionFee smallMoney NOT NULL,
PRIMARY KEY ([FeeID])
);


Create Table [BELT_RANKS] (
  [RankID] int identity(1, 1) NOT NULL,
  [RankName] nvarchar(50) NOT NULL,
  [TestFee] smallMoney NOT NULL,
  PRIMARY KEY ([RankID])
);



Create Table [PHONES] (
  [PhoneID] int identity(1, 1) NOT NULL,
  [PersonID] int REFERENCES PERSONS(PersonID) NOT NULL,
  [Number] varchar(30) NOT NULL,
  PRIMARY KEY ([PhoneID])
); 


Create Table [INSTRACTORS] (
  [InstractorID] int identity(1, 1) NOT NULL,
  [PersonID] int REFERENCES PERSONS(PersonID) NOT NULL,
  PRIMARY KEY ([InstractorID]) 
); 


Create Table [MEMBERS] (
  [MemberID] int identity(1, 1) NOT NULL,
  [PersonID] int REFERENCES PERSONS(PersonID) NOT NULL,
  [LastBeltRankID] int REFERENCES BELT_RANKS(RankID) NOT NULL,
  [IsActive] bit NOT NULL,
  PRIMARY KEY ([MemberID]) 
);


Create Table [METHODS] (
  [MethodID] int identity(1, 1) NOT NULL,
  [MethodName] nvarchar(20) NOT NULL,
  PRIMARY KEY ([MethodID]) 
); 


Create Table [PAYMENTS] (
  [PaymentID] int identity(1, 1) NOT NULL,
  [MethodID] int REFERENCES METHODS(MethodID) NOT NULL,
  [MemberID] int REFERENCES MEMBERS(MemberID) NOT NULL,
  [AmountPaid] smallMoney NOT NULL,
  [Date] Date NOT NULL,
  [Note] nvarchar(200) NULL,
  PRIMARY KEY ([PaymentID]) 
); 


Create Table [PROFILES] (
  [ProfileID] int identity(1, 1) NOT NULL,
  [InstractorID] int REFERENCES INSTRACTORS (InstractorID) NOT NULL,
  [MemberID] int REFERENCES MEMBERS (MemberID) NOT NULL,
  AssignDate Date NOT NULL,
  PRIMARY KEY ([ProfileID])
);


Create Table [SUBSCRIPTIONS] (
  [SubscriptionID] int identity(1, 1) NOT NULL,
  [MemberID] int REFERENCES MEMBERS (MemberID) NOT NULL,
  [PaymentID] int REFERENCES PAYMENTS (PaymentID) NOT NULL,
  [Fee] smallmoney NOT NULL,
  [StartDate] Date NOT NULL,
  [EndDate] Date NOT NULL,
  PRIMARY KEY ([SubscriptionID])
);


Create Table [BELT_TESTS] (
  [TestID] int identity(1, 1) NOT NULL,
  [TestedByInstructorID] int REFERENCES INSTRACTORS (InstractorID) NOT NULL,
  [MemberID] int REFERENCES MEMBERS (MemberID) NOT NULL,
  [RankID] int REFERENCES BELT_RANKS (RankID) NOT NULL,
  [PaymentID] int REFERENCES PAYMENTS (PaymentID) NOT NULL,
  [Result] bit NOT NULL,
  [Date] Date NOT NULL,
  PRIMARY KEY ([TestID])
);