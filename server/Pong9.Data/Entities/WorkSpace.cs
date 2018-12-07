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
        
        public WorkSpace CreateWorkSpace(string name, string urlTag)
        {
            var instance = new WorkSpace
            {
                WorkSpaceId = Guid.NewGuid(),
                Users = new HashSet<User>(),
                Name = name,
                UrlTag = urlTag
            };

            return instance;
        }
    }
}
