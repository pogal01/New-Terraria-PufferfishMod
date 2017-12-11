using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PufferfishMod.Items
{
	public class Fin : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 99;
			item.value = 2;
			item.rare = 4;

          
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fin");
            Tooltip.SetDefault("A fin from a pufferfish It feels wet");
        }
    }
}