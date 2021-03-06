﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : Item
{
    public Item item;

    private WorldCreation worldCreation; 

    #region generate an id for item
    int StatSets()
    {
        if (worldCreation.tierCount == 1)
        {
            itemId = Random.Range(1, 7);
            return itemId;
        }
        else if (worldCreation.tierCount == 2)
        {
            itemId = Random.Range(7, 13);
            return itemId;
        }
        else if (worldCreation.tierCount == 3)
        {
            itemId = Random.Range(13, 19);
            return itemId;
        }
        else if (worldCreation.tierCount == 4)
        {
            itemId = Random.Range(19, 25);
            return itemId;
        }
        else if (worldCreation.tierCount == 5)
        {
            itemId = Random.Range(25, 28);
            return itemId;
        }
        return itemId;
    }
    #endregion

    #region setting item values
    void StatValue()
    {
        if (itemId == 1)
        {
            itemName = "Swift & Flight";
            itemType = ItemTypes.weapon;
            weaponType = WeaponType.blades_Bow;
            itemRarity = ItemRaritys.common;
            itemDesc = "Speeds unmatched, may you take flight.";
            rage = 0;
            arcane = 0;
            speed = 2;
            lifeValue = 3;
            skillPointValue = 1;
        }
        else if (itemId == 2)
        {
            itemName = "Blade of Envy";
            itemType = ItemTypes.weapon;
            weaponType = WeaponType.twoHandedWeapon;
            itemRarity = ItemRaritys.common;
            itemDesc = "A blade, who's tale is filled with sorrow.";
            rage = 1;
            arcane = 0;
            speed = 0;
            lifeValue = 4;
            skillPointValue = 1;
        }
        else if (itemId == 3)
        {
            itemName = "Arcane Brilliance";
            itemType = ItemTypes.weapon;
            weaponType = WeaponType.magicSphere;
            itemRarity = ItemRaritys.common;
            itemDesc = "The pulsating energy is overwhelming!";
            rage = 0;
            arcane = 3;
            speed = 0;
            lifeValue = 2;
            skillPointValue = 1;
        }
        else if (itemId == 4)
        {
            itemName = "Armor of Greed";
            itemType = ItemTypes.armor;
            itemRarity = ItemRaritys.common;
            itemDesc = "Gathers all stats unto itself.";
            rage = 2;
            arcane = 2;
            speed = 2;
            lifeValue = 2;
            skillPointValue = 1;
        }
        else if (itemId == 5)
        {
            itemName = "Helmet of Greed";
            itemType = ItemTypes.helmet;
            itemRarity = ItemRaritys.common;
            itemDesc = "Gathers all stats unto itself.";
            rage = 2;
            arcane = 2;
            speed = 2;
            lifeValue = 2;
            skillPointValue = 1;
        }
        else if (itemId == 6)
        {
            itemName = "Gloves of Greed";
            itemType = ItemTypes.gloves;
            itemRarity = ItemRaritys.common;
            itemDesc = "Gathers all stats unto itself.";
            rage = 2;
            arcane = 2;
            speed = 2;
            lifeValue = 2;
            skillPointValue = 1;
        }
        else if (itemId == 7)
        {
            itemType = ItemTypes.weapon;
            itemName = "Pestilence & Famine";
            weaponType = WeaponType.blades_Bow;
            itemRarity = ItemRaritys.uncommon;
            itemDesc = "Horror unmatched.";
            rage = 0;
            arcane = 0;
            speed = 5;
            lifeValue = 5;
            skillPointValue = 2;
        }
        else if (itemId == 8)
        {
            itemType = ItemTypes.weapon;
            itemName = "Destroyer of Armies";
            weaponType = WeaponType.twoHandedWeapon;
            itemRarity = ItemRaritys.uncommon;
            itemDesc = "Can grasp victory, over even the greatest of odds.";
            rage = 4;
            arcane = 0;
            speed = 0;
            lifeValue = 6;
            skillPointValue = 2;
        }
        else if (itemId == 9)
        {
            itemType = ItemTypes.weapon;
            itemName = "Perpetual Banisher";
            weaponType = WeaponType.magicSphere;
            itemRarity = ItemRaritys.uncommon;
            itemDesc = "Removes all before it.";
            rage = 0;
            arcane = 6;
            speed = 0;
            lifeValue = 4;
            skillPointValue = 2;
        }
        else if (itemId == 10)
        {
            itemName = "Armor of Persistent Speed";
            itemType = ItemTypes.armor;
            itemRarity = ItemRaritys.uncommon;
            itemDesc = "Raises one's speed to another level.";
            rage = 0;
            arcane = 0;
            speed = 10;
            lifeValue = 6;
            skillPointValue = 2;
        }
        else if (itemId == 11)
        {
            itemName = "Helmet of Persistence Arcane";
            itemType = ItemTypes.helmet;
            itemRarity = ItemRaritys.uncommon;
            itemDesc = "Raises one's arcane to another level.";
            rage = 0;
            arcane = 12;
            speed = 0;
            lifeValue = 4;
            skillPointValue = 2;
        }
        else if (itemId == 12)
        {
            itemName = "Gloves of Persistant Rage";
            itemType = ItemTypes.gloves;
            itemRarity = ItemRaritys.uncommon;
            itemDesc = "Raises one's rage to another level.";
            rage = 8;
            arcane = 0;
            speed = 0;
            lifeValue = 8;
            skillPointValue = 2;
        }
        else if (itemId == 13)
        {
            itemType = ItemTypes.weapon;
            itemName = "Respiration & Resiliance";
            weaponType = WeaponType.blades_Bow;
            itemRarity = ItemRaritys.rare;
            itemDesc = "That which perseveres.";
            rage = 0;
            arcane = 0;
            speed = 9;
            lifeValue = 6;
            skillPointValue = 4;
        }
        else if (itemId == 14)
        {
            itemType = ItemTypes.weapon;
            itemName = "Slayer of Devils";
            weaponType = WeaponType.twoHandedWeapon;
            itemRarity = ItemRaritys.rare;
            itemDesc = "Fears not the darkest of evils.";
            rage = 6;
            arcane = 0;
            speed = 0;
            lifeValue = 9;
            skillPointValue = 4;
        }
        else if (itemId == 15)
        {
            itemType = ItemTypes.weapon;
            itemName = "Greed's Spawn";
            weaponType = WeaponType.magicSphere;
            itemRarity = ItemRaritys.rare;
            itemDesc = "Crave all things, the sin compels it.";
            rage = 0;
            arcane = 10;
            speed = 0;
            lifeValue = 5;
            skillPointValue = 4;
        }
        else if (itemId == 16)
        {
            itemName = "Armor of Resiliant Rage";
            itemType = ItemTypes.armor;
            itemRarity = ItemRaritys.rare;
            itemDesc = "Focuses on resistence, while also providing rage.";
            rage = 8;
            arcane = 0;
            speed = 0;
            lifeValue = 16;
            skillPointValue = 4;
        }
        else if (itemId == 17)
        {
            itemName = "Helmet of Resiliant Speed";
            itemType = ItemTypes.helmet;
            itemRarity = ItemRaritys.rare;
            itemDesc = "Focuses on resistence, while also providing speed.";
            rage = 0;
            arcane = 0;
            speed = 12;
            lifeValue = 12;
            skillPointValue = 4;
        }
        else if (itemId == 18)
        {
            itemName = "Gloves of Resiliant Arcane";
            itemType = ItemTypes.gloves;
            itemRarity = ItemRaritys.rare;
            itemDesc = "Focuses on resistence, while also providing arcane.";
            rage = 0;
            arcane = 16;
            speed = 0;
            lifeValue = 8;
            skillPointValue = 4;
        }
        else if (itemId == 19)
        {
            itemType = ItemTypes.weapon;
            itemName = "Light & Dark";
            weaponType = WeaponType.blades_Bow;
            itemRarity = ItemRaritys.legendary;
            itemDesc = "The Balance between all things.";
            rage = 0;
            arcane = 0;
            speed = 15;
            lifeValue = 5;
            skillPointValue = 8;
        }
        else if (itemId == 20)
        {
            itemType = ItemTypes.weapon;
            itemName = "GodSlayer";
            weaponType = WeaponType.twoHandedWeapon;
            itemRarity = ItemRaritys.legendary;
            itemDesc = "All myths were born from a grain of truth.";
            rage = 10;
            arcane = 0;
            speed = 0;
            lifeValue = 10;
            skillPointValue = 8;
        }
        else if (itemId == 21)
        {
            itemType = ItemTypes.weapon;
            itemName = "Spawn of Hope";
            weaponType = WeaponType.magicSphere;
            itemRarity = ItemRaritys.legendary;
            itemDesc = "The offspring of the one thing, we won't ever lose.";
            rage = 0;
            arcane = 20;
            speed = 0;
            lifeValue = 0;
            skillPointValue = 8;
        }
        else if (itemId == 22)
        {
            itemName = "Armor of Unlimited Arcane";
            itemType = ItemTypes.armor;
            itemRarity = ItemRaritys.legendary;
            itemDesc = "Overflowing amounts of arcane.";
            rage = 0;
            arcane = 24;
            speed = 0;
            lifeValue = 8;
            skillPointValue = 8;
        }
        else if (itemId == 23)
        {
            itemName = "Helmet of Unlimited Rage";
            itemType = ItemTypes.helmet;
            itemRarity = ItemRaritys.legendary;
            itemDesc = "Overflowing amounts of rage.";
            rage = 16;
            arcane = 0;
            speed = 0;
            lifeValue = 16;
            skillPointValue = 8;
        }
        else if (itemId == 24)
        {
            itemName = "Gloves of Unlimited Speed";
            itemType = ItemTypes.gloves;
            itemRarity = ItemRaritys.legendary;
            itemDesc = "Overflowing amounts of speed.";
            rage = 0;
            arcane = 0;
            speed = 20;
            lifeValue = 12;
            skillPointValue = 8;
        }
        else if (itemId == 25)
        {
            itemType = ItemTypes.weapon;
            itemName = "Hope & Fear";
            weaponType = WeaponType.blades_Bow;
            itemRarity = ItemRaritys.artifact;
            itemDesc = "The two strongest of emotions, side by side.";
            rage = 0;
            arcane = 0;
            speed = 25;
            lifeValue = 15;
            skillPointValue = 16;
        }
        else if (itemId == 26)
        {
            itemType = ItemTypes.weapon;
            itemName = "Fate Breaker";
            weaponType = WeaponType.twoHandedWeapon;
            itemRarity = ItemRaritys.artifact;
            itemDesc = "Will you choose to break fate?";
            rage = 20;
            arcane = 0;
            speed = 0;
            lifeValue = 20;
            skillPointValue = 16;
        }
        else if (itemId == 27)
        {
            itemType = ItemTypes.weapon;
            itemName = "Hope's Resolve";
            weaponType = WeaponType.magicSphere;
            itemRarity = ItemRaritys.artifact;
            itemDesc = "The strongest of resolves, held throughout time.";
            rage = 0;
            arcane = 30;
            speed = 0;
            lifeValue = 10;
            skillPointValue = 16;
        }
    }
    #endregion


    #region getting rarity and values based off raritys
    public void ReturnItems()
    {
        if (itemId < 7)
        {
            itemRarity = ItemRaritys.common;
            StatValue();
        }
        else if (itemId < 13 && itemId > 6)
        {
            itemRarity = ItemRaritys.uncommon;
            StatValue();
        }
        else if (itemId < 19 && itemId > 12)
        {
            itemRarity = ItemRaritys.rare;
            StatValue();
        }
        else if (itemId < 25 && itemId > 18)
        {
            itemRarity = ItemRaritys.legendary;
            StatValue();
        }
        else if (itemId <= 27 && itemId > 24)
        {
            itemRarity = ItemRaritys.artifact;
            StatValue();
        }
    }
    #endregion

    void Start ()
    {
        if (tag == "Item")
        {
            worldCreation = FindObjectOfType<WorldCreation>();

            StatSets();

            ReturnItems();

            item = this;
        }
    }
}
