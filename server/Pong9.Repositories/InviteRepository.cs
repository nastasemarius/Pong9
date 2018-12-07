using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pong9.Data.DTO;
using Pong9.Data.Entities;
using Pong9.IRepositories;
using Pong9.Persistence;

namespace Pong9.Repositories
{
    public class InviteRepository : IInviteRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public InviteRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Invite> GetAllInvites()
        {
            return _applicationDbContext.Invites.ToList();
        }

        public Invite GetInviteById(Guid id)
        {
            return _applicationDbContext.Invites.SingleOrDefault(i => i.InviteId == id);
        }

        public void CreateInvite(InviteDTO inviteDto)
        {
            var invite = Invite.CreateInvite();
            invite.UpdateInvite(inviteDto.Source, inviteDto.Destination, inviteDto.Booking);
            _applicationDbContext.Invites.Add(invite);
            _applicationDbContext.SaveChanges();
        }

        public void EditInvite(Guid id, InviteDTO inviteDto)
        {
            var inviteToEdit = _applicationDbContext.Invites.Find(id);
            inviteToEdit.UpdateInvite(inviteDto.Source, inviteDto.Destination, inviteDto.Booking);
            _applicationDbContext.SaveChanges();
        }

        public void DeleteInvite(Invite invite)
        {
            _applicationDbContext.Invites.Remove(invite);
            _applicationDbContext.SaveChanges();
        }
    }
}
