using StardewValleyAPI.API.Entities;
using StardewValleyAPI.ResourceParameters;
using System;
using System.Collections.Generic;

namespace StardewValleyAPI.API.Services
{
    public interface IStardewValleyLibraryRepository
    {
        IEnumerable<Weapon> GetWeapons();
        Weapon GetWeapon(Guid weaponId);
        IEnumerable<Weapon> GetWeapons(IEnumerable<Guid> weaponIds);
        void AddWeapon(Weapon weapon);
        void DeleteWeapon(Weapon weapon);
        bool WeaponExists(Guid weaponId);
        IEnumerable<Weapon>  GetWeapons(WeaponsResourceParameters weaponsResourceParameters);
        bool Save();
    }
}
