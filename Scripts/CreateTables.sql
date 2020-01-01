-- Create student table 01-01-2020

CREATE table student(
	studentId varchar(250) primary key not null,
	StudentName varchar(250) not null,
	studentCode varchar(250) not null,		-- ganIT202001
	ClassId varchar(250),					-- IT001
	CollegeId varchar(250),					-- SSGMCECOL
	email varchar(250),
	number varchar(250),
	AddressId varchar(250)
) 
 
