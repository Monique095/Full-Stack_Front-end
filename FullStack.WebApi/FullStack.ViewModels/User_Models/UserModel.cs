using FullStack.ViewModels;
using System.Collections.Generic;

namespace WebApi.Models.Users
{
  public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        public List<AdvertModel> AdvertModel { get; set; }
    }
}