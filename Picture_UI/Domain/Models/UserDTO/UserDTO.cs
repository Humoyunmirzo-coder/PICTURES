﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.UserDTO
{
    public  class UserDTO : UserBaseEntityDTO
    {
        public int Id { get; set; }
        public int ImageID { get; set; }
    }
}