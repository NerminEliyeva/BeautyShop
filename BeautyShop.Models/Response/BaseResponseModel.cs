using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Models.Response
{
    public class BaseResponseModel<T>
    {
        public string? Message { get; set; }
        public bool IsSuccess { get; set; }
        public T? Obj { get; set; }
    }
}
