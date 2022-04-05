using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CustomerResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public List<String> Errors { get; set; }

        public static CustomerResponseDto<T> Success(int statusCode, T data)
        {
            return new CustomerResponseDto<T> {  Data = data, StatusCode = statusCode, Errors=null };
        }
     public static CustomerResponseDto<T> Success(int statusCode)
        {
            return new CustomerResponseDto<T> { StatusCode = statusCode};
        }

        public static CustomerResponseDto<T> Fail (int statusCode, List<string> errors)
        {
            return new CustomerResponseDto<T> { StatusCode = statusCode, Errors=errors};
        }
        public static CustomerResponseDto<T> Fail(int statusCode, string error)
        {
            return new CustomerResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
