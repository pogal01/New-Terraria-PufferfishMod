using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PufferfishMod.NPCs
{
    public class PufferFishLuckyFin : ModNPC
    {
        public override void SetDefaults()
        {
            npc.width = 70;
            npc.height = 50;
            npc.damage = 30;
            npc.defense = 10;
            npc.lifeMax = 110;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 16;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            Main.npcFrameCount[npc.type] = 1;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lucky Finned Pufferfish");

        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Tile tile = Main.tile[spawnInfo.spawnTileX, spawnInfo.spawnTileY];
            return spawnInfo.player.ZoneBeach ? 0.09f : 0f;
            
        }
        public override void FindFrame(int frameHeight)
        {


            npc.spriteDirection = npc.direction;
        }
        public virtual void EditSpawnRange(Player player, ref int spawnRangeX, ref int spawnRangeY,
         ref int safeRangeX, ref int safeRangeY)
        {
            spawnRangeX = 200;
            spawnRangeY = 200;
            safeRangeX = 75;
            safeRangeY = 75;
        }
        public override void NPCLoot()  //Npc drop
        {
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Fin"), 1); //Item spawn
            }

        }
    }
}
