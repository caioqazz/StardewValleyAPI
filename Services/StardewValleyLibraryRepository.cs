using StardewValleyAPI.API.DbContexts;
using StardewValleyAPI.API.Entities;
using StardewValleyAPI.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StardewValleyAPI.API.Services
{
    public class StardewValleyLibraryRepository : IStardewValleyLibraryRepository, IDisposable
    {
        private readonly StardewValleyLibraryContext _context;

        public StardewValleyLibraryRepository(StardewValleyLibraryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddWeapon(Weapon weapon)
        {
            if (weapon == null)
            {
                throw new ArgumentNullException(nameof(weapon));
            }

            // the repository fills the id (instead of using identity columns)
            weapon.Id = Guid.NewGuid();

            //foreach (var course in weapon.Courses)
            //{
            //    course.Id = Guid.NewGuid();
            //}

            _context.Weapons.Add(weapon);
        }

        public bool WeaponExists(Guid weaponId)
        {
            if (weaponId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(weaponId));
            }

            return _context.Weapons.Any(a => a.Id == weaponId);
        }

        public void DeleteWeapon(Weapon weapon)
        {
            if (weapon == null)
            {
                throw new ArgumentNullException(nameof(weapon));
            }

            _context.Weapons.Remove(weapon);
        }

        public Weapon GetWeapon(Guid weaponId)
        {
            if (weaponId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(weaponId));
            }

            return _context.Weapons.FirstOrDefault(a => a.Id == weaponId);
        }

        public IEnumerable<Weapon> GetWeapons()
        {
            return _context.Weapons.ToList<Weapon>();
        }

        public IEnumerable<Weapon> GetWeapons(IEnumerable<Guid> weaponIds)
        {
            if (weaponIds == null)
            {
                throw new ArgumentNullException(nameof(weaponIds));
            }

            return _context.Weapons.Where(a => weaponIds.Contains(a.Id))
                .OrderBy(a => a.Name)
                .ToList();
        }

        public IEnumerable<Weapon> GetWeapons(WeaponsResourceParameters weaponsResourceParameters)
        {
            if (weaponsResourceParameters == null)
            {
                throw new ArgumentNullException(nameof(weaponsResourceParameters));
            }

            if (string.IsNullOrWhiteSpace(weaponsResourceParameters.Type)
                 && string.IsNullOrWhiteSpace(weaponsResourceParameters.SearchQuery)
                 && string.IsNullOrWhiteSpace(weaponsResourceParameters.CriticalStrikeChance)
                 && string.IsNullOrWhiteSpace(weaponsResourceParameters.Stats))
            {
                return GetWeapons();
            }

            var collection = _context.Weapons as IQueryable<Weapon>;

            if (!string.IsNullOrWhiteSpace(weaponsResourceParameters.Type))
            {
                var type = weaponsResourceParameters.Type.Trim();
                collection = collection.Where(a => a.Type == type);
            }

            if (!string.IsNullOrWhiteSpace(weaponsResourceParameters.Stats))
            {
                var stats = weaponsResourceParameters.Stats.Trim();
                collection = collection.Where(a => a.Stats.Contains(stats));
            }
            if (!string.IsNullOrWhiteSpace(weaponsResourceParameters.CriticalStrikeChance))
            {
                var criticalStrikeChance = weaponsResourceParameters.CriticalStrikeChance.Trim();
                collection = collection.Where(a => a.CriticalStrikeChance.Contains(criticalStrikeChance));
            }
            if (!string.IsNullOrWhiteSpace(weaponsResourceParameters.SearchQuery))
            {

                var searchQuery = weaponsResourceParameters.SearchQuery.Trim();
                collection = collection.Where(a => a.Name.Contains(searchQuery)
                    || a.Description.Contains(searchQuery));
            }

            return collection.ToList();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }
    }
}
