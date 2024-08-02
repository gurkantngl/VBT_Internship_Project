using Azure.Core;
using Core.Entities.Concrete;

namespace Core;

public interface ITokenHelper
{
    AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
}
