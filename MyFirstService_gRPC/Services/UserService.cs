using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstService_gRPC
{
    public class UserService : User.UserBase
    {
        public override Task<UserReply> GetUserById(UserIdRequest request, ServerCallContext context)
        {
            return Task.FromResult(new UserReply
            {
                Name = "Denis",
                PersonNumber = 1,
                Surename = "Predala"
            });
        }
    }
}
