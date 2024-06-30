USE KCDB;


Select * From PERSONS;
Select * From PHONES;
Select * From MEMBERS;
Select * From BELT_RANKS;
Select * From SUBSCRIPTIONS;
Select * From PAYMENTS;
Select * From METHODS;
Select * From FEES;
Select * From BELT_TESTS;
Select * From INSTRACTORS;
Select * From PROFILES;





SELECT 
MemberID,
FirstName + ' ' + MidName + ' ' + LastName AS Name,
Address,
RankName,
IsActive
FROM MEMBERS
JOIN PERSONS ON MEMBERS.PersonID = PERSONS.PersonID
JOIN BELT_RANKS ON MEMBERS.LastBeltRankID = BELT_RANKS.RankID


EXEC sp_rename 'BELT_RANKS.TestFees', 'TestFee', 'COLUMN';

Insert into BELT_RANKS (RankName, TestFee)
values
('White Belt', 5),
('Yellow Belt', 6),
('Orange Belt', 7),
('Green Belt', 8),
('Blue Belt', 9),
('Purple Belt', 10),
('Brown Belt', 11),
('Black Belt (1st Dan)', 15),
('Black Belt (2nd Dan)', 20),
('Black Belt (3rd Dan)', 30),
('Black Belt (4th Dan)', 40),
('Black Belt (5th Dan)', 50),
('Black Belt (6th Dan)', 60),
('Black Belt (7th Dan)', 70),
('Black Belt (8th Dan)', 80),
('Black Belt (9th Dan)', 90),
('Black Belt (10th Dan)', 100);


Insert into METHODS(MethodName) 
values
('Cash'),
('Partially paid'),
('Bank'),
('Jawali'),
('One Cash'),
('Cash Wallet'),
('Deferred Payment');


INSERT INTO FEES (SubscriptionFee) values (500);


SELECT PERSONS.* , MEMBERS.* 
FROM MEMBERS
JOIN PERSONS ON MEMBERS.PersonID = PERSONS.PersonID
WHERE FirstName + ' ' + MidName + ' ' + LastName = 'K7 m a';


Select
SubscriptionID, 
FirstName + ' ' + MidName + ' ' + LastName as Name,
AmountPaid as Paid,
MethodName,
Fee,
StartDate, EndDate 
from  SUBSCRIPTIONS
JOIN MEMBERS ON SUBSCRIPTIONS.MemberID = MEMBERS.MemberID
JOIN PERSONS ON MEMBERS.PersonID = PERSONS.PersonID
JOIN PAYMENTS ON SUBSCRIPTIONS.PaymentID = PAYMENTS.PaymentID
JOIN METHODS ON PAYMENTS.MethodID = METHODS.MethodID
where StartDate BETWEEN '2024-6-1' and '2024-6-30'
AND METHODS.MethodName in('Cash', 'Jawali', 'Partially paid')

and FirstName + ' ' + MidName + ' ' + LastName = 'Khalid Mohammed Ali';



delete SUBSCRIPTIONS;




Drop Table FEES;

update FEES SET SubscriptionFee = 800;



