using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PufferfishMod.Items
{
	public class Spike : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 24;
			item.maxStack = 99;
			item.value = 1000;
			item.rare = 3;

            
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spike");
            Tooltip.SetDefault("A very pointy spike");
        }

       
	}
}