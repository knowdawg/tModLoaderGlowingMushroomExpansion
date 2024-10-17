using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Mono.CompilerServices.SymbolWriter;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using FirstMod.Content.Projectiles;

namespace FirstMod.Content.Items{

    public class MushroomWhip : ModItem{

		public override void SetDefaults() {
			// This method quickly sets the whip's properties.
			// Mouse over to see its parameters.
			Item.DefaultToWhip(ModContent.ProjectileType<MushroomWhipProjectile>(), 12, 2, 4);
			Item.rare = ItemRarityID.Green;   
		}

		public override bool MeleePrefix() {
			return true;
		}

        public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GlowingMushroom, 15);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();

            recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GlowingMushroom, 15);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
    }

}