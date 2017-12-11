using Terraria.ID;
using Terraria.ModLoader;

namespace PufferfishMod.Items.Weapons.Ammo
{
    public class Spiker : ModItem
    {
        public override void SetDefaults()
        {

            item.damage = 23;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;

            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = 3;
            item.shoot = mod.ProjectileType("Spiker");
            item.shootSpeed = 21f;
            item.ammo = AmmoID.Bullet;
        }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Spikey bullet");
      Tooltip.SetDefault("Spikey bullets.");
    }

        public override void AddRecipes()  //How to craft this gun
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Spike"), 1);   //you need 1 Spike
            recipe.AddTile(TileID.MythrilAnvil);   //at work bench
            recipe.SetResult(this, 50);  //50 means how many bullets you craft from 1 Spike
            recipe.AddRecipe();

        }
    }
}
