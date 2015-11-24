## Day Cohort 10 Data Access Demo
### Nashville Software School
---
Today we looked different ways of accessing a SQL Server database while reviewing object oriented concepts.
After class I added a second solution to demonstrate how the same functionality can be achieved with Entity Framework.

This code requires a SQL Express installation on the local machine, with SQL Authentication (Mixed Mode) enabled and the sa password set to "Access123". It also assumes there's a database named TestDB containing a table named Student with the properties Id (int, identity) and Name (varchar).

We used SQL Management Studio to create these objects in class, however once you have created a new database the Student table can be created by executing /Scripts/CreateStudent.sql.