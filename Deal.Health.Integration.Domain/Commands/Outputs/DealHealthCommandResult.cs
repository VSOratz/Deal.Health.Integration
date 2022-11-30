using MvcContrib.PortableAreas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deal.Health.Integration.Domain.Commands.Outputs
{
    class DealHealthCommandResult : ICommandResult
    {
        public DealHealthCommandResult(bool sucess, string message, object data)
        {
            Success = sucess;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
