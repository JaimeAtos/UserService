using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrappers
{
    public class Response<T>
    {
        public Response()
        {
            
        }

        public Response(T data, string message = null)
        {
            Succeeded = true;
            Data=data;
            Message=message;
        }

        public Response(string message)
        {
            Succeeded = false;
            Message = message;
        }

        public bool Succeeded { get; set; }
        public T Data { get; }
        public string Message { get; }
        public List<string> Errors { get; set; }
    }
}
