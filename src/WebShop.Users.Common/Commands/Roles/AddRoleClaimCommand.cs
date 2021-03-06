﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Messaging;

namespace WebShop.Users.Common.Commands
{
   public  class AddRoleClaimCommand:ICommand
    {
        [JsonIgnore]
        public String RoleName { get; }
        public String ClaimName { get;  }
        public String ClaimType { get;  }

        [JsonConstructor]
        public AddRoleClaimCommand(String roleName, String claimType, String claimName)
        {
            RoleName = roleName;
            ClaimType = claimType;
            ClaimName = claimName;
        }
    }
}
