﻿using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartEF2.Extensions
{
    public class CreateUserOperation : MigrationOperation
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
