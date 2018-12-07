using Pong9.Data.Entities;
using System;
using System.Collections.Generic;

namespace Pong9.IRepositories
{
    public interface IInviteRepository
    {
        IEnumerable<Invite> GetAllInvites();
        Invite GetInviteById(Guid id);
        void CreateInvite(Invite invite);
        void EditInvite(Invite invite);
        void DeleteInvite(Invite invite);
    }
}
