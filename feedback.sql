CREATE TABLE Feedback(
UserID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Name varchar (50) NOT NULL ,
Feedback1 varchar (5000) NOT NULL 
);


SELECT * FROM Feedback
DROP TABLE Feedback