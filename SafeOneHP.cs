using Terraria;
using Terraria.ModLoader;

namespace SafeOneHP
{
	public class SafeOneHPPlayer : ModPlayer
	{
		public override void ResetEffects()
		{
			// Безопасно фиксируем максимум здоровья на 1 HP
			Player.statLifeMax2 = 1;
		}

		public override void PostUpdateEquips()
		{
			Player.statLifeMax2 = 1;
			if (Player.statLife > 1)
			{
				Player.statLife = 1;
			}
		}
	}

	public class SafeOneHP : Mod
	{
	}
}