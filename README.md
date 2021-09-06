# Simple-CRUD-application-With-ASP.NET
Crud application in the context of a school workshop

## Setup Local Environment

1 - Download the project

2- On the top Go to View-> Server Explorer -> Create New SQL server Database ( Database filename: workshopDatabase ) 
and then in the project open Models/workshopDB.edmx.sql right click inside the file and press execute.

3- Go to View -> Server Object Explorer and right click on your database ( workshopDatabase ) and click on properties

4- Find the path of your database, for me it's ( C:\Users\Ilias\workshopDatabase.mdf ) 

5- Go back to Server Explorer and right click WorkshopDBContainer -> Modify Connection then browse to the path of your database

6- Go to web.config and edit the path of database for me it's ( C:\Users\user\workshopDatabase.mdf )
