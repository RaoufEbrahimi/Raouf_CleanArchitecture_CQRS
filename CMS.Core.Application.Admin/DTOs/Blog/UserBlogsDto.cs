﻿using CMS.Core.Domain.Interfaces.DTOs.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Application.Admin.DTOs.Blog;

public class UsersBlogsDto : IUsersBlogsDto
{
    public int BlogId { get; set; }
    public int UserId { get; set; }
    public string BlogTitle { get; set; }
    public string UserName { get; set; }
    
}