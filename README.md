
**Project Overview**

To be able to assist staff members in managing farmers and their product submissions, Agri-Energy Connect is a web based prototype system. Where Farmers and Employees are two primary user roles, each with their own unique features 

**Setting Up Development Environment** 

1. Requirements:
   --------------------------------------------------------------------------------------------------------------   
•.Net 6 Framework 

•Visual Studio 2022 

•Either SQL Server Express or LocalDB 

2. NuGet packages to install: 
   --------------------------------------------------------------------------------------------------------------
•Microsoft.EntityFrameworkCore.SqlServer 

•Microsoft.EntityFrameworkCore.Tools 

•Microsoft.AspNetCore.Authentication.Cookies  

3. Clone Repository
   --------------------------------------------------------------------------------------------------------------   
•Open the Project in Visual Studio 

•Open PROGPOE2.sln 


4.Database Configuration 
--------------------------------------------------------------------------------------------------------------
Go to appsettings.json for your connection string 

![Screenshot 2025-05-15 122122](https://github.com/user-attachments/assets/4cf3dc54-69eb-42fb-aca2-9da7cbeaf8c0)

5.Run Migrations 
--------------------------------------------------------------------------------------------------------------
•Open tools menu 

•Then navigate to NuGet Package Manager 

•Then to Package Manager Console to open the console  

![Screenshot 2025-05-14 170556](https://github.com/user-attachments/assets/45b55d7f-0256-4858-8a27-50a199c443c8)

 
•Once Open run the following command and press enter and it should succed 
![Screenshot 2025-05-14 170734](https://github.com/user-attachments/assets/6caad9bb-84e3-4e99-aa3b-233a858ff8b6)
 

**Build and Run** 
--------------------------------------------------------------------------------------------------------------

•Press F5 or click run in Visual Studio 

•Build and Run the Web App 

•Once the build runs you will be taken to the Home Page

•Next you can navigate to the registration form to create a Farmer or Employee account 

•Once registered you may log in with those credentials 

•Finally, you will access the functionalities according to the role you are logged into 

 

**System Functionalities/User Roles**

**Farmer** 
--------------------------------------------------------------------------------------------------------------
•Submit new products 

•View their personal products in a table 

 

**Employee**  
--------------------------------------------------------------------------------------------------------------
•Add new Farmer profiles

•View all the farmers products 

•Ability to filter products by searching category and date 

Reset filters  


**Stakeholder Notes** 
--------------------------------------------------------------------------------------------------------------
•Simple UI 

•Secure Authentication 

•Role-based Navigation 

Web UI
--------------------------------------------------------------------------------------------------------------

Home Page
--------------------------------------------------------------------------------------------------------------
![Home page](https://github.com/user-attachments/assets/025591c3-d8a3-4901-8ea5-687e23b239cd)

Register Form
--------------------------------------------------------------------------------------------------------------
![Register](https://github.com/user-attachments/assets/5145295e-2b5d-49b5-bafd-b2e87a0b1fa8)

Login Form
--------------------------------------------------------------------------------------------------------------
![Login](https://github.com/user-attachments/assets/1b6701e1-f912-4366-96ce-10df942e7417)

Logged in Form
--------------------------------------------------------------------------------------------------------------
![Logged in](https://github.com/user-attachments/assets/da6a344b-bfd4-41b6-9b1d-0f88267a8c07)

Employee Dash
--------------------------------------------------------------------------------------------------------------
![Employee dash](https://github.com/user-attachments/assets/57295aca-2510-4b85-9615-5f91f00f17f6)

Employee Filter
--------------------------------------------------------------------------------------------------------------
![Filter](https://github.com/user-attachments/assets/528c9e17-227c-4237-95eb-7ef2322fdcce)

Farmer Logged in
--------------------------------------------------------------------------------------------------------------
![Farmer](https://github.com/user-attachments/assets/5bb43d81-5159-4124-a60a-6f46571bd058)

Add Farmer
--------------------------------------------------------------------------------------------------------------
![Add farmer](https://github.com/user-attachments/assets/22558e02-4c24-4934-aac2-8933eacfc3bc)

Farmer Products
--------------------------------------------------------------------------------------------------------------
![farmer products](https://github.com/user-attachments/assets/891affa5-84ed-461f-9712-2b695f0623b5)
