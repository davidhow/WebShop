﻿using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Messaging;
using WebShop.Users.Common.Dtos.Roles;

namespace WebShop.Users.Common.Queries
{
    public class RoleGetClaimsQuery : IQuery<IEnumerable<RoleClaimViewDto>>
    {
        public String RoleName { get; set; }
    }
}
