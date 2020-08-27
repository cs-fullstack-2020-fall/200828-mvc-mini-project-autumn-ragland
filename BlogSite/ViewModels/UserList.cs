using System.Collections.Generic;
using BlogSite.Models;
using System;

namespace BlogSite.ViewModels
{
    public class UserList
    {
        public List<User> mockUsers = new List<User> ();
        // populate mock data when instanciated
        public UserList()
        {
            this.mockUsers.Add(new User("User", "One", "user1", "This is User One!", new List<Blog>(){new Blog("My First Blog Post", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.")}, true, 1));

            this.mockUsers.Add(new User("User", "Two", "user2", "This is User Two!", new List<Blog>(){new Blog("Welcome to My Blog", " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."), new Blog("Wow My Second Blog Post", "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur")}, false, 2));

            this.mockUsers.Add(new User("User", "Three", "user3", "This is User Three!", new List<Blog>(), false, 3));
        }
    }
}