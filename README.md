# sample-crud-project-Muhamad-Azmi-Izwan
Hai, 
I am Muhamad Azmi Izwan Bin Mahalim. This is my sample project for a basic CRUD application.
The project is a small project that simply want to show you the basic CRUD feature in the program.
In this project I will be using EF framework and sqlite to build the web app. The communication to get the data,
to insert the data, update the data and delete data will be through Postman.

# Challenges that was faced.
1. Development Environment
    - Challenges : the missing package that has not been installed where the program will find it as an error and the program will not be able to run.
    - Solution : Double check and making sure to use the correct version of the .Net 6.0, the required tool as it no longer part of .Net, and the required package such as sqlite has been install correctly and it has exist in the project.

2. Understanding the connection
    - Challenges : The connection to communicate in Postman need to used the correct one as it will lead to an error during testing on the postman.
    - Solution : The connection need to be understand as it was already been declared on the LaunchSetting.json file on which localhost and their respective port that we currently used.

3. Testing with Postman
    - Challenges : Testing with Postman can be a little confusing as we need to understand the method the request will be send to program as well as any data that need to put in the body.
    - Solution : We can understand it much more clearly after we testing it through all the different method. Making sure the method, the connection link to communicate with local device, and the json input need to be correct.

# Step to start program.
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




