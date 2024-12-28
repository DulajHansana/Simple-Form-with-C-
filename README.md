# Student Management System (CRUD Application)

<p>The <strong>Student Management System</strong> is a <strong>C# Windows Forms Application</strong> that implements CRUD (Create, Read, Update, Delete) functionality for managing student records. It integrates with a <strong>Microsoft SQL Server</strong> database and provides a clean, user-friendly interface for easy data management.</p>

<h2>Features</h2>
<ul>
  <li><strong>Add Student Records:</strong> Create new entries by specifying student details (name, age, course).</li>
  <li><strong>View All Records:</strong> Display all student records in a DataGridView for browsing and selection.</li>
  <li><strong>Update Records:</strong> Edit existing student information and save changes seamlessly.</li>
  <li><strong>Delete Records:</strong> Remove specific student entries from the database.</li>
</ul>

<h2>Built With</h2>
<ul>
  <li><strong>Programming Language:</strong> C#</li>
  <li><strong>GUI Framework:</strong> Windows Forms</li>
  <li><strong>Database:</strong> Microsoft SQL Server (LocalDB)</li>
  <li><strong>Database Connectivity:</strong> ADO.NET (SqlClient)</li>
</ul>

<h2>Prerequisites</h2>
<p>To run this application, ensure you have the following installed:</p>
<ul>
  <li><a href="https://visualstudio.microsoft.com/">Visual Studio (Community Edition or Higher)</a>: Required for building and running the application.</li>
  <li><a href="https://www.microsoft.com/sql-server">Microsoft SQL Server</a>: The database for storing and managing student records.</li>
  <li><a href="https://learn.microsoft.com/sql/ssms">SQL Server Management Studio (SSMS)</a>: Used to configure the database and run SQL scripts.</li>
</ul>

<h2>Installation and Setup</h2>
<h3>Clone the Repository:</h3>
<pre>
<code>
git clone https://github.com/yourusername/student-management-system.git
cd student-management-system
</code>
</pre>

<h3>Set Up the Database:</h3>
<ol>
  <li>Open <strong>SQL Server Management Studio (SSMS)</strong>.</li>
  <li>Run the following SQL script to create the database and the <code>students</code> table:</li>
</ol>
<pre>
<code>
CREATE DATABASE student_db;

USE student_db;

CREATE TABLE students (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    age INT NOT NULL,
    course NVARCHAR(100) NOT NULL
);
</code>
</pre>

<h3>Configure the Database Connection:</h3>
<ol>
  <li>Open the project in <strong>Visual Studio</strong>.</li>
  <li>Navigate to the file <code>DatabaseHelper.cs</code>.</li>
  <li>Replace the placeholder connection string with your own SQL Server details:</li>
</ol>
<pre>
<code>
private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=student_db;Integrated Security=True;";
</code>
</pre>

<h3>Run the Application:</h3>
<ol>
  <li>Build and execute the project in <strong>Visual Studio</strong>.</li>
  <li>Use the intuitive GUI to perform the following:
    <ul>
      <li>Add a new student record.</li>
      <li>View all student records.</li>
      <li>Update an existing student record.</li>
      <li>Delete a student record.</li>
    </ul>
  </li>
</ol>

<h2>Screenshots</h2>
<ul>
  <li><strong>Main Interface:</strong> <em>(Insert a screenshot of the main application window)</em></li>
  <li><strong>Add Record Form:</strong> <em>(Insert a screenshot of the Add Record form)</em></li>
  <li><strong>View Records in DataGridView:</strong> <em>(Insert a populated DataGridView screenshot)</em></li>
</ul>

<h2>License</h2>
<p>This project is licensed under the <strong>MIT License</strong>. See the LICENSE file for more details.</p>
