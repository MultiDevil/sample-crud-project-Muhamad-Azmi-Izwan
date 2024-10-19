# sample-crud-project-Muhamad-Azmi-Izwan
Hai, 
I am Muhamad Azmi Izwan Bin Mahalim. This is my sample project for a basic CRUD application.
The project is a small project that simply want to show you the basic CRUD feature in the program.
In this project I will be using EF framework and sqlite to build the web app. The communication to get the data,
to insert the data, update the data and delete data will be through Postman.

Step to start program.
1. Clone the repository into the local drive.

2. Installing the prerequisites:
    - .NET SDK 6.0
    - Suitable IDE such as Visual Studio
    - Recommended Database : Sqlite
    - Postman

3. Installing .Net Tool:
    - .Net Tool (.Net 6): 
        - dotnet tool install --global dotnet-ef --version 6.*

4. Install any additional package for the project :
    - Microsoft.EntityFrameworkCore.Sqlite
    - Microsoft.EntityFrameworkCore.Design

5. (Optional)(If the database and the migration is not exist) Migrate the Database
    - dotnet ef migrations add InitialCreate
    - dotnet ef database update

6. Then run it.

7. Using Postman to communicate.
    - to get all data
        http://localhost:{port}/api/product

    - to get specific data
        http://localhost:5023/api/product/{id}

    - to insert new data
        http://localhost:5023/api/product

        Json input
        {
            "name": "house",
            "price": 99999.99
        }

    - to update data
        http://localhost:5023/api/product/{id}

        Json input
        {
            "id":{id},
            "name": "Updated Laptop",
            "price": 99999.99
        }

    - to delete data
        http://localhost:5023/api/product/{id}




