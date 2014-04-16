function Module_Gameplay::Leaf_Initialize(%this)
{

%Vector_2D_Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Leaf);

for (%x=0;%x<%this.SimSet_Shrubbery.getCount();%x++)
{

%Sprite_Shrub=%this.SimSet_Shrubbery.getObject(%x);

%Sprite_Leaf=new Sprite()
{

SceneLayer=17;

BodyType="static";

Size=%Vector_2D_Tile_Size;

Position=%Sprite_Shrub.Position;

Image="Module_Gameplay:Image_Leaf";

Angle=Vector2AngleToPoint(%Sprite_Shrub.Position,%this.Sprite_Carcass.Position);

};

Scene_Phyxel_Tender.add(%Sprite_Leaf);

%this.SimSet_Sprite_Leafs.add(%Sprite_Leaf);

}

return;//Angle setting for composite sprites may be gimped.

%this.CompositeSprite_Leaves=new CompositeSprite()
{

SceneLayer=14;
BodyType="static";

};

%this.CompositeSprite_Leaves.SetBatchLayout("off");
%this.CompositeSprite_Leaves.SetBatchSortMode("z");
%this.CompositeSprite_Leaves.SetBatchIsolated(true);

%Vector_2D_Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Leaf);

for (%x=0;%x<%this.SimSet_Shrubbery.getCount();%x++)
{

%Sprite_Shrub=%this.SimSet_Shrubbery.getObject(%x);

%Sprite_ID=%this.CompositeSprite_Leaves.addSprite();

%ScriptObject_Sprite_ID=new ScriptObject()
{

Sprite_ID=%Sprite_ID;

};

%this.SimSet_ID_Leafs.add(%ScriptObject_Sprite_ID);

%this.CompositeSprite_Leaves.setSpriteLocalPosition(%Sprite_Shrub.Position);

%this.CompositeSprite_Leaves.setSpriteSize(%Vector_2D_Tile_Size);

%this.CompositeSprite_Leaves.setSpriteImage("Module_Gameplay:Image_Leaf");

%Float_Angle=Vector2AngleToPoint(%this.CompositeSprite_Leaves.getSpriteLocalPosition(),%this.Sprite_Carcass.Position);

%this.CompositeSprite_Leaves.setSpriteAngle(%Float_Angle);

}

Scene_Phyxel_Tender.add(%this.CompositeSprite_Leaves);

}
