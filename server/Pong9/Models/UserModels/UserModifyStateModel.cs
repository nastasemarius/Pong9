using Pong9.Data.Enums;

namespace Pong9.Api.Models.UserModels
{
    public class UserModifyStateModel
    {
        public string WorkSpaceId { get; set; }

        public UserRole Roles { get; set; }
    }
}
