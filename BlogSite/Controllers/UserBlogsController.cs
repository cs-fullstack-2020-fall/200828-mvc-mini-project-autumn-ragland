using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BlogSite.Models;
using BlogSite.ViewModels;
using System.Linq;

namespace BlogSite.Controllers
{
    public class UserBlogs : Controller
    {
        // create mock list of users from view model
        public UserList userList = new UserList();
        // landing page
        public IActionResult Index()
        {
            return View();
        }
        // pass mock list of users to specific view
        public IActionResult AllUsers()
        {
            ViewData["PageHeader"] = "All Users";
            return View("DisplayUsers", userList);
        }
        // pass filtered list of users to specific view
        public IActionResult HighlightedUsers()
        {
            ViewData["PageHeader"] = "Highlighted Users";

            // filter highlighted users from list of mock users
            List<User> filterHighlighted = userList.mockUsers.Where(user => user.highlighted == true).ToList();
            userList.mockUsers = filterHighlighted;

            return View("DisplayUsers", userList);
        }
        // find user by ID as pass to default view
        public IActionResult Blogs(int userID)
        {
            // match user from list of mock users
            User matchingUser = userList.mockUsers.FirstOrDefault(user => user.userID == userID);
            return View(matchingUser);
        }
        // HTTP post request
        [HttpPost]
        // add a new user to the user list mock users in the body of a post request
        public IActionResult AddUser(string fName, string lName, string userName, string bio, List<Blog> blogs, bool highlighted, int userID)
        {
            // set the userID
            userID = userList.mockUsers.Count + 1;
            // add the new user
            userList.mockUsers.Add(new User(fName, lName,userName,bio, new List<Blog>(), highlighted, userID));
            
            // render the highlighted user if highlighted user added or all user if non-highlighted user added
            User matchingUser = userList.mockUsers.FirstOrDefault(user => user.userID == userID);
            if(matchingUser.highlighted)
            {
                ViewData["PageHeader"] = "Highlighted Users";

                // filter highlighted users from list of mock users
                List<User> filterHighlighted = userList.mockUsers.Where(user => user.highlighted == true).ToList();
                userList.mockUsers = filterHighlighted;
                return View("DisplayUsers", userList);

            } else
            {
                ViewData["PageHeader"] = "All Users";
                return View("DisplayUsers", userList);
            }
        }
    }
}