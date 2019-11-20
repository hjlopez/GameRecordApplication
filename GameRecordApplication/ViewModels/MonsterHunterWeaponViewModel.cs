using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;
using PagedList;

namespace GameRecordApplication.ViewModels
{
    public class MonsterHunterWeaponViewModel
    {
        public class Attack
        {
            public int display { get; set; }
            public int raw { get; set; }
        }

        public class AmmoCapacities
        {
            public List<int> normal { get; set; }
            public List<int> piercing { get; set; }
            public List<int> spread { get; set; }
            public List<int> sticky { get; set; }
            public List<int> cluster { get; set; }
            public List<int> recover { get; set; }
            public List<int> poison { get; set; }
            public List<int> paralysis { get; set; }
            public List<int> sleep { get; set; }
            public List<int> exhaust { get; set; }
            public List<int> flaming { get; set; }
            public List<int> water { get; set; }
            public List<int> freeze { get; set; }
            public List<int> thunder { get; set; }
            public List<int> dragon { get; set; }
            public List<int> slicing { get; set; }
            public List<int> wyvern { get; set; }
            public List<int> demon { get; set; }
            public List<int> armor { get; set; }
            public List<int> tranq { get; set; }
        }

        public class Attributes
        {
            public string damageType { get; set; }
            public string elderseal { get; set; }
            public int? affinity { get; set; }
            public int? defense { get; set; }
            public string shellingType { get; set; }
            public string phialType { get; set; }
            public string boostType { get; set; }
            public string deviation { get; set; }
            public AmmoCapacities ammoCapacities { get; set; }
            public string specialAmmo { get; set; }
            public List<string> coatings { get; set; }
        }

        public class Durability
        {
            public int red { get; set; }
            public int orange { get; set; }
            public int yellow { get; set; }
            public int green { get; set; }
            public int blue { get; set; }
            public int white { get; set; }
        }

        public class Crafting
        {
            public bool craftable { get; set; }
            public int? previous { get; set; }
            public List<object> branches { get; set; }
            public List<object> craftingMaterials { get; set; }
            public List<object> upgradeMaterials { get; set; }
        }

        public class Assets
        {
            public string icon { get; set; }
            public string image { get; set; }
        }

        public class Shelling
        {
            public string type { get; set; }
            public int level { get; set; }
        }

        public class Phial
        {
            public string type { get; set; }
            public int? damage { get; set; }
        }

        public class Ammo
        {
            public string type { get; set; }
            public List<int> capacities { get; set; }
        }

        public class Weapon
        {
            public int id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public int rarity { get; set; }
            public Attack attack { get; set; }
            public string elderseal { get; set; }
            public Attributes attributes { get; set; }
            public string damageType { get; set; }
            public List<Durability> durability { get; set; }
            public List<object> slots { get; set; }
            public List<object> elements { get; set; }
            public Crafting crafting { get; set; }
            public Assets assets { get; set; }
            public Shelling shelling { get; set; }
            public Phial phial { get; set; }
            public string boostType { get; set; }
            public string specialAmmo { get; set; }
            public string deviation { get; set; }
            public List<Ammo> ammo { get; set; }
            public List<string> coatings { get; set; }
        }
    }
}