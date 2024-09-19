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

## Prerequisites

Ensure you have the following installed on your system:
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or an alternative (SQLite, MySQL)
- [Visual Studio](https://visualstudio.microsoft.com/) or another C# IDE


## Steps to Set Up The Database 

1. **Download Sql Sript**
   Find the `(.Sql)` file from this repository and download that.
2. **Set up Sql Scrip in SSMS**
   Open SSMS and Select Write new Query. Then Select Open New File. Then Select the Downloaded     File from your Computer.
3. **Query Execution**
   Select the Execution Button on top left of the Window. Now the database should be created

- ### Connecting Database To The Project Code

1. **Open the Project**
   Open the Project file and then locate the .Sln file and double click on that file the and that should be open.

2. **Changing the Connection String**:
   - Use `Ctrl+F` to find the SqlConnection String. 
   ````bash
          SqlConnection con = new SqlConnection("Data Source=LAPTOP-J7JBFG4A\\SQLEXPRESS;Initial Catalog=EmpCRUD;Integrated Security=True");
   ````
   - Replace the existing Connection string with your connection String.
   ````bash
          SqlConnection con = new SqlConnection("Your Connection String");
   ````

4. **Save the edited code and run**

### Database Schema
![Screenshot 2024-09-19 120133](https://github.com/user-attachments/assets/fa351267-98a7-4efa-aded-06ce99bddd90)


 ## Form Design  

- **DataGridView**: Displays records from the database.
- **Textboxes**: Input fields for adding/editing records.
- **Buttons**: Implement buttons for Create, Read, Update, Delete, and Refresh operations.
- **Label**: Identify the correct text box for correct information.
  
 ![Screenshot 2024-09-19 120735](https://github.com/user-attachments/assets/b396fd05-8b8f-4b81-80df-ddacc8489d58)


## Code Implementation 

Adding new information to the database
````bash
try{
    if (IsValid())
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-J7JBFG4A\\SQLEXPRESS;Initial Catalog=EmpCRUD;Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into info values(@id,@name,@salary,@city)", con);
        cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
        cmd.Parameters.AddWithValue("@name", textBoxName.Text);
        cmd.Parameters.AddWithValue("@salary", double.Parse(textBoxSalary.Text));
        cmd.Parameters.AddWithValue("@city", textBoxCity.Text);
        cmd.ExecuteNonQuery();
        con.Close();

        MessageBox.Show("Successfully Saved");
        ClearData();
        LoadGrid(); 

    }
}
catch (SqlException ex)
{
    MessageBox.Show(ex.Message);
}
    
````

## Video Demonstration

For a comprehensive overview of the application, including detailed explanations of its functionality and code, please watch the following video:

[![Watch the demo](https://img.youtube.com/vi/0HlTw_9HfZU/0.jpg)](https://youtu.be/0HlTw_9HfZU?si=EkbfZ_2x0aGV31Cu)

In this video, you will find:
- An in-depth demonstration of all the application's features.
- Step-by-step guidance on how each functionality works.
- Detailed explanations of the code and how different components interact.

Click the image above or [this link](https://youtu.be/0HlTw_9HfZU?si=EkbfZ_2x0aGV31Cu) to view the full demonstration.


## User Flow ##

1. When the application is opened, existing records are displayed in the DataGridView.
2. Users can:
      - User can see the information of existing Employee by their id and clicking the `Find`          button.
      - Add new records by clicking the `Save` button and submitting the required information.
      - Edit existing records by giving an `Id` and clicking the `Update` button.
      - Delete records by selecting a `id` and confirming deletion.
      - Exit the application by clicking the `Exit` button.

## How to run the Project ##

### Steps to Set Up The Project File

1. **Clone the Repository:**
    ```bash
   git clone https://github.com/Zihan231/CRUD-Project.git
    ```
2. **Open the solution `(.sln)` file in Visual Studio.**

4. **Build the solution to restore NuGet packages.**

5. **Build the Project:**
Build the solution to ensure that everything is set up correctly. In Visual Studio, use the Build menu and select Build Solution.

6. **Run the Application:**
Start the application by pressing F5 in Visual Studio or running the appropriate executable from the command line.

 
   
    
## Authors

- [@Zihan231](https://github.com/Zihan231)
