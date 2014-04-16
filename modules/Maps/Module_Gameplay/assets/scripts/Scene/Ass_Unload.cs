function Module_Gameplay::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Dirt.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Fog.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Shrub.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Carcass.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Leaf.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Wall.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Flame.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Explosion.getAssetId());

}
