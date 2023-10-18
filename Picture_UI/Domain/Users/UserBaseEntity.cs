using Domain.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public  class UserBaseEntity
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        public int?  FriendsID { get; set; }
        public Friend Friend { get; set; }
        public int ImageID { get; set; }

    }
}
