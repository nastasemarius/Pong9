using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pong9.Data.Entities
{
    public class WorkSpace
    {
        [Key]
        public Guid WorkSpaceId { get; set; }

        public string Name { get; set; }

        public string UrlTag { get; set; }


        public DateTime CreatedAt { get; set; }
        
        public ICollection<User> Users { get; set; }
        
        public static WorkSpace CreateWorkSpace()
        {
            var instance = new WorkSpace
            {
                WorkSpaceId = Guid.NewGuid(),
                Users = new HashSet<User>(),
                CreatedAt = DateTime.UtcNow
            };

            return instance;
        }

        public void UpdateWorkSpace(string name, string urlTag, ICollection<User> users)
        {
            Name = name;
            UrlTag = urlTag;
            Users = users;
        }
    }
}
