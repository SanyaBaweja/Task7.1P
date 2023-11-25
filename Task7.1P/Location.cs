using System;
using Iteration6;
namespace Iteration6
{
	public class Location:Game_Object, IHaveInventory
           
	{
        Inventory _inv = new Inventory();

        
        public Location(string name, string desc):base(new string[] { "room" }, name, desc)
		{
			
		}
        public Game_Object Locate(string id)
        {

            if (AreYou(id) == true)
            {
                return this;
            }
            else
            {
                return _inv.Fetch(id);
            }
        }
        public override string FullDescription
        {
            get
            {
                return ("You are in the " + Name +"\n" + base.FullDescription + ".\nIn this room you can see:\n" + _inv.ItemList);
            }
        }
        public Inventory Inv
        {
            get
            {
                return _inv;
            }
        }
    }
}

