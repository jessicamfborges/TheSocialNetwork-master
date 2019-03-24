using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajuine.DataAccess.Contexts;
using Cajuine.DomainModel.Entities;
using Cajuine.DomainModel.Interfaces.Repositories;

namespace Cajuine.DataAccess.Repositories
{
    public class ProfileEntityFrameworkRepository : IProfileRepository
    {
        private SocialNetworkContext db = new SocialNetworkContext();

        public void Create(Profile profile)
        {
            db.Profiles.Add(profile);
            db.SaveChanges();
        }

        public void Delete(Guid profileId)
        {
            Profile profile = Read(profileId);
            db.Profiles.Remove(profile);
            db.SaveChanges();
        }

        public Profile Read(Guid profileId)
        {
            //return db.Profiles.Find(profileId);
            return db.Profiles.Include(p => p.Friends).SingleOrDefault(p => p.Id == profileId);
        }

        public IEnumerable<Profile> ReadAll()
        {
           return db.Profiles.Include(p => p.Friends);
        }

        public void Update(Profile profile)
        {
            db.Entry(profile).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
