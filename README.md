# CRUD Application in C# (Windows Forms)

This is a simple CRUD (Create, Read, Update, Delete) application built using C# and Windows Forms. The application demonstrates how to perform basic database operations with a user-friendly interface.

## Features

- **Create**: Add new records to the database.
- **Read**: View records in a list or grid format.
- **Update**: Modify existing records.
- **Delete**: Remove records from the database.
- **Search**: Find specific records based on various criteria.

## Technologies Used

- **Programming Language**: C#
- **User Interface**: Windows Forms (WinForms)
- **Database**: Microsoft SQL Server
- **IDE**: Visual Studio 

## Project Workflow

### 1. User Interface (Windows Forms)

- **Main Form**: Contains buttons for `Create`, `Edit`, `Read`, `Update`, `Delete`, and `Refresh` operations, along with a `DataGridView` to display records.

- **Add/Edit Form**: A separate form is used for entering or modifying record details. This form pops up when a user chooses to add a new record or edit an existing one.

- **Message Boxes**: Used to confirm critical actions such as record creation, modification, and deletion. For example:
  - Confirming whether the user wants to delete a record.
  - Displaying success messages when operations are completed.

### 2. Database Operations

- **Create**: Allows users to add a new record by opening the `Add/Edit` form, filling in the details, and submitting it to the database.

- **Read**: Fetches and displays all records from the database in the `DataGridView` on the main form, typically loaded when the application starts or when the "Refresh" button is clicked.

- **Update**: Enables the user to modify an existing record. The user selects a record in the `DataGridView`, edits the details in the `Add/Edit` form, and submits the changes to update the record in the database.

- **Delete**: Provides the option to remove a record by selecting it from the `DataGridView`, confirming the action in a message box, and deleting the record from the database.

### Prerequisites

Ensure you have the following installed on your system:
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or an alternative (SQLite, MySQL)
- [Visual Studio](https://visualstudio.microsoft.com/) or another C# IDE

## Installation

### Steps to Set Up The Project File

1. **Clone the Repository:**
    ```bash
   git clone https://github.com/Zihan231/CRUD-Project.git
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
