using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace PufferfishMod.Items.Weapons.Guns
{
    public class PufferBlaster : ModItem
    {
        public override void SetDefaults()
        {

            item.damage = 50;  //gun damage
            item.ranged = true;   //its a gun so set this to true
            item.width = 64;     //gun image width
            item.height = 64;   //gun image  height

            item.useTime = 6;  //how fast 
            item.useAnimation = 20;
            item.useStyle = 5;    //
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 8f;
            item.useAmmo = AmmoID.Bullet; 
        }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault(" Angry Puffer Blaster");
      Tooltip.SetDefault("This is a Pufferfish blaster, some say it was created by the pufferfish God I suggest you use spike bullets.");
    }


        public override void AddRecipes()  //How to craft this gun
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Spike"),20);
            recipe.AddIngredient(mod.ItemType("Fin"), 2);
            recipe.AddIngredient(ItemID.Megashark, 1);//you need 1 megashark
            recipe.AddTile(TileID.MythrilAnvil);   //at mythral anvil
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
