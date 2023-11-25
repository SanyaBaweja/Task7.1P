﻿using System;
namespace Iteration6
{
    public class Bag : Item, IHaveInventory
    {
        Inventory _inventory = new Inventory();
        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {


        }
        public Game_Object Locate(string id)
        {
            if (AreYou(id) == true)
            {
                return this;
            }
            return _inventory.Fetch(id);
        }
        public override string FullDescription
        {
            get
            {
                return ("In this " + Name + " you can see:\n\t" + Inv.ItemList);
            }
        }
        public Inventory Inv
        {
            get
            {
                return _inventory;
            }
        }
    }
}

