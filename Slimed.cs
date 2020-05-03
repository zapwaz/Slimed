using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace Slimed
{
	public class Slimed : Mod
	{
		public Slimed()
		{
		}

		public override void Load()
		{
			base.Load();

			var buff = BuffLoader.GetBuff(BuffID.Slimed);
			buff.Update
		}
	}
}