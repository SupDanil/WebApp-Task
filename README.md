## Description

Cross-browser web application on ASP.Net (Core / Mvc) for working with data,
 consisting of three dependent tables.  Consists of two services:
   1. Backend API
   2. Frontend website

The application allows you to edit data.
Use command "ef database update" in terminal to populate the database with values.

### Frontend:

 1. Responsive design.
 2. At the top of the page is the site header of a certain height.
 3. When scrolling vertically, the header is always visible.

### Backend:
 
 1. ManagerController - Main controller where get and post requests are handled.
 2. Manager/Index - The start page, which shows three tables from the database, linked by a key, using SQLserver to communicate with the database.
 3. Manager/AddOrEdit - This method describes the work to delete, edit, and add a new record.  View added visual decorations for buttons using BOOTSTRAP.


Project Stack:

• ASP.NET CORE
• MVC
• ENTITY FRAMEWORK 
• HTML
• CSS
• BOOTSTRAP 
