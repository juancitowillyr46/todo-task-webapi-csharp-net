using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Application.Wrappers
{
    public class ApiResponse<T>
    {
        public bool? Success { get; set; }
        public string? Message { get; set; }
        public List<string>? Errors { get; set; }
        public T? Data { get; set; }

        public ApiResponse()
        {

        }

        public ApiResponse(T data, string? message = null)
        {
            Success = true;
            Message = message;
            Data = data;
        }

        public ApiResponse(string message)
        {
            Success = false;
            Message = message;
        }
    }
}
