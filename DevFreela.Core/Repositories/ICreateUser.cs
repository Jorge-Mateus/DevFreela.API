﻿using DevFreela.Core.DTOs;
using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Repositories
{
    public interface ICreateUser
    {
        Task AddAsync(User create);
        Task SaveChangesAsync();
    }
}