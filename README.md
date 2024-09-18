# C# CRUD Project

This project is a simple **CRUD (Create, Read, Update, Delete)** application built using **C#**, **ASP.NET Core**, and **Entity Framework Core**. It demonstrates basic database operations via a web interface.

## Features

- **Create**: Add new records.
- **Read**: View and list all records.
- **Update**: Edit existing records.
- **Delete**: Remove records from the database.
- **Database**: Uses Entity Framework Core with SQL Server.
- **UI**: Clean and responsive interface with Razor Pages and Bootstrap.

## Technologies Used

- **C#**
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **SQL Server**
- **Bootstrap**

## Installation

### Prerequisites

Ensure you have the following installed on your system:
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or an alternative (SQLite, MySQL)
- [Visual Studio](https://visualstudio.microsoft.com/) or another C# IDE


### Steps to Set Up The Project File

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/Zihan231/CRUD-Project.git
   cd CRUD-Project
   ```
2. **Open the Solution:**
Open the .sln file in Visual Studio or your preferred C# development environment.

3. **Restore Dependencies:**
Ensure that all necessary dependencies are restored. In Visual Studio, this is typically done automatically. Alternatively, use the following command in the NuGet Package Manager Console
    
   ```bash
   Update-Package -reinstall
   ```
4. **Build the Project:**
Build the solution to ensure that everything is set up correctly. In Visual Studio, use the Build menu and select Build Solution.

5. **Run the Application:**
Start the application by pressing F5 in Visual Studio or running the appropriate executable from the command line.

### Steps to Set Up The Database In SSMS

1. **Download Sql Sript**
   Find the .Sql file from this repository and download that.
2. **Set up Sql Scrip in SSMS**
   Open SSMS and Select Write new Query. Then Select Open New File. Then Select the Downloaded File from your Computer.
3. **Query Execution**
   Select the Execution Button on top left of the Window. Now the database should be created

### Connecting Database To The Project Code

1. **Open the Project**
   Open the Project file and then locate the .Sln file and double click on that file the and that should be open.

2. **Changing the Connection String**
   Find the SqlConnection String and replace the existing Connection string with your connection String.

3. **Save the edited code and run**

##Now the Project Is Ready To Run##
   
    
## Authors

- [@Zihan231](https://github.com/Zihan231)
