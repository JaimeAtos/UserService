﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrappers
{
    public class PagedResponse<T> : Response<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public PagedResponse(T data, int pageNumber, int pageSize)
        {
            Data = data;
            PageNumber=pageNumber;
            PageSize=pageSize;
            Message = null;
            Succeeded = true;
            Errors = null;
        }
    }
}
