function Module_Gameplay::Background_Initialize(%this)
{

%Vector_2D_Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Dirt);

%Vector_2D_Grid_Half_Offset=
(%this.Vector_2D_Background_Grid_Size.X*%Vector_2D_Tile_Size.X)*0.5
SPC
(%this.Vector_2D_Background_Grid_Size.Y*%Vector_2D_Tile_Size.Y)*0.5;

%CompositeSprite_Background=new CompositeSprite()
{

SceneLayer=30;
BodyType="static";

};

%CompositeSprite_Background.SetBatchLayout("off");
%CompositeSprite_Background.SetBatchSortMode("z");
%CompositeSprite_Background.SetBatchIsolated(true);

for (%y=0;%y<%this.Vector_2D_Background_Grid_Size.Y;%y++)
{

for (%x=0;%x<%this.Vector_2D_Background_Grid_Size.X;%x++)
{

%Vector_2D_Position=
((%x*%Vector_2D_Tile_Size.X)-%Vector_2D_Grid_Half_Offset.X)+(%Vector_2D_Tile_Size.X*0.5)
SPC
((%y*%Vector_2D_Tile_Size.Y)-%Vector_2D_Grid_Half_Offset.Y)+(%Vector_2D_Tile_Size.Y*0.5);

%CompositeSprite_Background.addSprite();

%CompositeSprite_Background.setSpriteLocalPosition(%Vector_2D_Position);

%CompositeSprite_Background.setSpriteSize(%Vector_2D_Tile_Size);

%CompositeSprite_Background.setSpriteImage("Module_Gameplay:Image_Dirt");

}

}

Scene_Phyxel_Tender.add(%CompositeSprite_Background);

}
