using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FirstMod.Content.Items.Ammo{

    public class MushroomGrenadeAmmo : ModItem{

		public override void SetDefaults() {
			Item.damage = 4; // The damage for projectiles isn't actually 12, it actually is the damage combined with the projectile and the item together.
			Item.DamageType = DamageClass.Ranged;
			Item.width = 24;
			Item.height = 24;
			Item.maxStack = Item.CommonMaxStack;
			Item.consumable = true; // This marks the item as consumable, making it automatically be consumed when it's used as ammunition, or something else, if possible.
			Item.knockBack = 0.5f;
			Item.value = 10;
			Item.rare = ItemRarityID.Green;
			Item.shoot = ModContent.ProjectileType<Projectiles.MushroomGrenadeProjectile>(); // The projectile that weapons fire when using this item as ammunition.
			Item.shootSpeed = 16f; // The speed of the projectile.
			Item.ammo = AmmoID.Bullet; // The ammo class this ammo belongs to.
		}
    }
}