﻿using System;
namespace Iteration6
{
    public class Player : Game_Object, IHaveInventory
    {
        Inventory _inventory = new Inventory();
        Location _loc;

        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            
        }

        public Game_Object Locate(string id)
        {
            if (AreYou(id) == true)
            {
                return this;
            }
            else if (_loc.Locate(id) != null)
            {
                return _loc.Locate(id);
            }
            else if (_loc.Inv.Fetch(id) != null)
            {
                return _loc.Inv.Fetch(id);

            }
            return _inventory.Fetch(id);
        }
    
        public Inventory Inv
        {
            get
            {
                return _inventory;
            }
        }
        public Location Loc
        {
            get
            {
                return _loc;
            }
            set
            {
                _loc = value;
            }
        }
        public override string FullDescription 
        {
            get
            {
                return ("You are " + Name + " " + base.FullDescription + "." + "\nYou are carrying\n" + Inv.ItemList);
            }
        }
        
    }
}

