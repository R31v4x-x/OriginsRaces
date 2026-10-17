using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using MrPlagueRaces.Common.Races;

namespace OriginsRaces.Common.Races.DefiledRace
{
	public class DefiledRace : Race
	{
		public override void Load()
		{
			DisplayName = "Defiled";
			Description = "This is the default description of the Defiled race.";
			AbilitiesDescription = "Describe unique racial abilities here.";
			StarterShirt = true;
			StarterPants = true;
			HairColor = new Color(255, 255, 255);
			SkinColor = new Color(255, 255, 255);
			DetailColor = new Color(255, 255, 255);
			EyeColor = new Color(255, 255, 255);
			ShirtColor = new Color(255, 255, 255);
			UnderShirtColor = new Color(255, 255, 255);
			PantsColor = new Color(255, 255, 255);
			ShoeColor = new Color(255, 255, 255);
		}

		public override void ResetEffects(Player player)
		{
			var mrPlagueRacesPlayer = player.GetModPlayer<MrPlagueRaces.MrPlagueRacesPlayer>();
			if (ModContent.GetInstance<MrPlagueRaces.MrPlagueRacesConfig>().raceStats) {
				//put racial stat changes here. Defense, Health, etc.
				player.moveSpeed += 0.15f;
				player.statLifeMax2 -= (player.statLifeMax2 / 3);
				player.endurance += 0.3f;
			}
		}
	}
}