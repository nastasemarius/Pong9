using System;
using System.ComponentModel.DataAnnotations;
using Pong9.Data.Entities;
using Pong9.Data.Enums;

namespace Pong9.Api.Models.UserModels
{
    public class UserRenameModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}
