# Notes Application

The Notes Application is a simple Windows Forms application developed in C# for managing notes. It allows users to create, view, import, and update notes stored in a SQL Server database.

## Features

- **Create Notes**: Users can create new notes by entering a title and content.
- **View Notes**: Existing notes are displayed in a DataGridView, allowing users to view all notes at a glance.
- **Import Notes**: Users can import notes from text files, making it easy to transfer notes from other sources.
- **Update Notes**: Existing notes can be updated with new titles and content.
- **Navigate Between Forms**: Users can navigate between different forms using buttons, providing a seamless user experience.

## Getting Started

To run the Notes Application locally on your machine, follow these steps:

1. **Clone the Repository:**
   Clone this repository to your local machine using Git. Open a terminal or command prompt and run the following command:

   ```
   git clone <repository_url>
   ```

2. **Open the Solution:**
   Open the solution file (`Notes.sln`) in Visual Studio.

3. **Set Up the Database:**
   Ensuring that an SQL Server instance running locally or accessible from the machine. Update the connection string in the `NoteManager` class (`NoteManager.cs`) to point to the SQL Server instance.

4. **Build and Run:**
   Build the solution in Visual Studio and run the project (`F5` or `Ctrl + F5`).

5. **Explore the Application:**
   Once the application is running, we can navigate between different forms using the provided buttons. Create new notes, view existing notes, import notes from files, delete them, and update notes as needed.

## Technologies Used

- C# (.NET Framework)
- Windows Forms (WinForms)
- SQL Server
- Git

## Contributing

Contributions to the Notes Application are welcome! If you have any ideas for improvements, bug fixes, or new features, feel free to open an issue or submit a pull request.
