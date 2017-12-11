using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace PufferfishMod.Items.Weapons.Swords   //where is located
{
    public class TrueSpikeyFin : ModItem
    {
        public override void SetDefaults()
        {

            item.damage = 120;            //Sword damage
            item.melee = true;            //if it's melee
            item.width = 90;              //Sword width
            item.height = 90;             //Sword height

            item.useTime = 50;          //how fast 
            item.useAnimation = 25;     
            item.useStyle = 1;        //Style is how this item is used, 1 is the style of the sword
            item.knockBack = 15;      //Sword knockback
            item.value = 100;        
            item.rare = 6;
            item.UseSound = SoundID.Item1;       //1 is the sound of the sword
            item.autoReuse = true;   //if it's capable of autoswing.
            item.useTurn = true;
            item.shoot = mod.ProjectileType("Spikep");
            item.shootSpeed = 8f;
        }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("True Spiky Fin");
      Tooltip.SetDefault("It was made by the pufferfish However, something has happend to it");
    }

        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofFright, 15);
            recipe.AddIngredient(mod.ItemType("SpikeyFin"), 1);   //you need 1 DirtBlock
		    recipe.AddTile(TileID.MythrilAnvil);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(1) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("DustName"));
            }
        }
    }
}
