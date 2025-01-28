using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Model.Integration
{
    public class ResultViewModel
    {
        public bool Result { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
        public object Data { get; set; }
        public static ResultViewModel Error() { return new ResultViewModel { Result = false}; }
        public static ResultViewModel Error(params string[] errors) { return new ResultViewModel { Result = false,Errors = errors.ToList()}; }
        public static ResultViewModel Error(List<string> errors) { return new ResultViewModel { Result = false,Errors = errors}; }
        public static ResultViewModel OK() { return new ResultViewModel { Result = true}; }
        public static ResultViewModel OK(object data) { return new ResultViewModel { Result = true,Data = data}; }
    }
}
