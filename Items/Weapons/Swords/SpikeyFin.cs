using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace PufferfishMod.Items.Weapons.Swords   //where is located
{
    public class SpikeyFin : ModItem
    {
        public override void SetDefaults()
        {

            item.damage = 35;            //Sword damage
            item.melee = true;            //if it's melee
            item.width = 64;              //Sword width
            item.height = 64;             //Sword height

            item.useTime = 32;          //how fast 
            item.useAnimation = 25;     
            item.useStyle = 1;        //Style is how this item is used, 1 is the style of the sword
            item.knockBack = 15;      //Sword knockback
            item.value = 100;        
            item.rare = 6;
            item.UseSound = SoundID.Item1;       //1 is the sound of the sword
            item.autoReuse = true;   //if it's capable of autoswing.
            item.useTurn = true;        
        }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Spiky Fin");
      Tooltip.SetDefault("It was made by the pufferfish ");
    }

        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);      
            recipe.AddIngredient(mod.ItemType("Spike"), 8);   //you need 1 DirtBlock
           recipe.AddIngredient(mod.ItemType("Fin"), 2); 
		   recipe.AddTile(TileID.WorkBenches);   //at work bench
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
