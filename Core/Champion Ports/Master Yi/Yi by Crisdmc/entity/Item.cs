using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EloBuddy; 
 using LeagueSharp.Common; 
 namespace crisMasterYi.entity
{
    class Item
    {
        public int id { get; set; }
        public String name { get; set; }

        public Item(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
