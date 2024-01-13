using youtube.Systems;
using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;

namespace youtube.Players
{
	public class ExampleKeybindPlayer : ModPlayer
	{
		public override void ProcessTriggers(TriggersSet triggersSet)
		{
			if (KeybindSystem.RandomBuffKeybind.JustPressed)
			{

				int randomNum2 = Main.rand.Next(1, 11);

				if (randomNum2 > 8)
				{
					int randomNum = Main.rand.Next(1, 11);
					int randomItem = Main.rand.Next(ItemID.Count);
					Player.QuickSpawnItem(new Terraria.DataStructures.EntitySource_SpawnNPC(), randomItem, 1);

					if (randomNum > 5)
					{
						int buff = Main.rand.Next(BuffID.Count);
						Player.AddBuff(buff, 600);
						Main.NewText($"La suerte esta de tu lado!");
						return;
					}
					int randomNPC = Main.rand.Next(NPCID.Count);
					NPC.NewNPC(new Terraria.DataStructures.EntitySource_SpawnNPC(), (int)Player.position.X - 120, (int)Player.position.Y, randomNPC);
					Main.NewText("Mala suerte, se ha creado un enemigo");
					return;
				}

				Main.NewText("Parece que no ha sucedido nada, que mal!");
			}
		}
	}
}