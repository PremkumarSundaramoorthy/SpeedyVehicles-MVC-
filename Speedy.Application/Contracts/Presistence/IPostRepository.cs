﻿using Speedy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speedy.Application.Contracts.Presistence
{
    public interface IPostRepository : IGenericRepository<Post>
    {
        Task Update(Post post);

        Task<Post> GetPostById(Guid id);

        Task<List<Post>> GetAllPost();
    }
}