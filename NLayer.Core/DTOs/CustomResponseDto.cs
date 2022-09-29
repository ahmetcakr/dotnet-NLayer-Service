using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }

        public static CustomResponseDto<T> Success(int statusCode, T data)
        {
            return new CustomResponseDto<T> {Data = data , StatusCode = statusCode};
        }
        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> {StatusCode = statusCode };
        }
        public static CustomResponseDto<T> Fail( int statusCode ,List<String> errors)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors=errors };
        }

        public static CustomResponseDto<T> Success(List<ProductDto> productsDtos)
        {
            throw new NotImplementedException();
        }

        public static Microsoft.AspNetCore.Mvc.IActionResult Success(int v, object product)
        {
            throw new NotImplementedException();
        }

        public static CustomResponseDto<T> Success(ProductDto productsDto)
        {
            throw new NotImplementedException();
        }

        public static CustomResponseDto<T> Fail(int statusCode,String error)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<String> {error} };
        }
    }
}
