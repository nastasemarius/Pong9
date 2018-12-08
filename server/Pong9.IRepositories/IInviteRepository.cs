using Pong9.Data.Entities;
using System;
using System.Collections.Generic;
using Pong9.Data.DTO;

namespace Pong9.IRepositories
{
    public interface IInviteRepository
    {
        IEnumerable<Invite> GetAllInvites();
        Invite GetInviteById(Guid id);
        void CreateInvite(InviteDTO inviteDto);
        void EditInvite(Guid id, InviteDTO inviteDto);
        void DeleteInvite(Invite invite);
    }
}
