using Terraria.ID;
using Terraria.ModLoader;

namespace Slimed.Items
{
	public class DoubleShot : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Double Shot");
			Tooltip.SetDefault("Made from two bows.");
		}

		public override void SetDefaults() 
		{
			item.damage = 8;
			item.shoot = ProjectileID.HolyArrow;
			item.shootSpeed = 15;
			item.noMelee = true;
			item.autoReuse = true;
			item.ranged = true;
			item.width = 20;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = ItemRarityID.LightRed;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenBow, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}