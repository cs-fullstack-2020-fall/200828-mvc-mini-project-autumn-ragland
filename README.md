# 20 08 28 MVC Mini Project 

### Project Concepts

- Create complex models 
- Render data from models in views
- Define routes using controller methods
- Demonstrate an understanding of .NET conventions
- Utilize bootstrap for styling
- Demonstrate good version control practices through pushing at benchmarks with meaningful commit messages
- Demonstrate appropriate planning, use of resources, and testing

### Project Objectives

- Create a .NET MVC `Blog Post Site` application to view site users and their associated blog posts as well as add users. 
- Provide a typed or written draft of models needed in accordance with project details
- Provide wire-frames for all views in accordance with project details
- Provide postman collection for routes created in accordance with project details
- Include useful/meaningful comments in project files
- Use bootstrap to style project views
- Remove/replace any unnecessary/unused links in default MVC application

### Project Details

- Define a list of users with three populated users
	- User : id, first name, last name, user name, short bio, highlighted or not highlighted, list of blog posts
	- Blog Posts : title, body, date published (the date should be auto generated as today's date)

- Navigation to View All Users and View Highlighted Users

- View All Users
	- Use a partial view to display each user from the list of users
	- Display each user's full name, user name, and id
	- If a user has 1 or more blog posts display the number of blog posts and a link to View All Blog Posts in addition to the base information
	- If a user is highlighted update the styling of that users information in some way using bootstrap

- View Highlighted Users
	- Use a partial view to display only highlighted users from the list of users
	- Display each user's full name, user name, and id
	- If a user has 1 or more blog posts display the number of blog posts and a link to View All Blog Posts in addition to the base information
	- Update the styling of each user's information in some way using bootstrap

- View User Blogs
	- Accessed through a link in each users information if that user has 1 or more blog posts
	- Use a partial view to display the details of each blog post in a users list of blog posts

- Add a User
	- POST request to add a user to the list of users *this data will not be persisted*
	- When post request is sent, if user is highlighted display highlighted users with newest user
	- When post request is sent, if new user is not highlighted display all users with newest user

### Project Resources
- [Anchor Tag Helpers in ASP.NET](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/built-in/anchor-tag-helper?view=aspnetcore-3.1#anchor-tag-helper-attributes)
- [Passing Data to Views](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/mvc-music-store/mvc-music-store-part-3)
- [Simple Routing](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-3.1#set-up-conventional-route)
- [Using Partial Views](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-3.1#set-up-conventional-route)
- [Date Time](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-3.1#set-up-conventional-route)
