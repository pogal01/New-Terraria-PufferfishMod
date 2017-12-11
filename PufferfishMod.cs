using Terraria.ModLoader;

namespace PufferfishMod
{
	class PufferfishMod : Mod
	{
		public PufferfishMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
