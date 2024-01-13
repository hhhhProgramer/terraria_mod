using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace youtube
{

	public class Youtube : ModPlayer
	{
		public static void OnEnterWorld(Player player)
		{
			Main.NewText("¡Hola, bienvenido al mundo de Terraria!");
		}
	}
}