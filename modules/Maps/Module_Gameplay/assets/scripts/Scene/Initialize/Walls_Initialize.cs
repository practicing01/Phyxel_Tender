function Module_Gameplay::Walls_Initialize(%this)
{

%Vector_2D_Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Dirt);

%Vector_2D_Grid_Half_Offset=
(%this.Vector_2D_Background_Grid_Size.X*%Vector_2D_Tile_Size.X)*0.5
SPC
(%this.Vector_2D_Background_Grid_Size.Y*%Vector_2D_Tile_Size.Y)*0.5;

%Vector_2D_Wall_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Wall);

%Vector_2D_Wall_Size.X=%Vector_2D_Tile_Size.X*0.5;

//Horizontal walls.

for (%y=-1;%y<%this.Vector_2D_Background_Grid_Size.Y;%y++)
{

for (%x=-1;%x<%this.Vector_2D_Background_Grid_Size.X;%x++)
{

%Vector_2D_Position=
((%x*%Vector_2D_Tile_Size.X)-%Vector_2D_Grid_Half_Offset.X)+(%Vector_2D_Tile_Size.X/**0.5*/)
SPC
((%y*%Vector_2D_Tile_Size.Y)-%Vector_2D_Grid_Half_Offset.Y)+(%Vector_2D_Tile_Size.Y/**0.5*/);

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;

Size=%Vector_2D_Wall_Size;

Image="Module_Gameplay:Image_Wall";

Animation="Module_Gameplay:Animation_Wall";

class="Class_Wall";

SceneLayer=14;

SceneGroup=2;

DefaultDensity=0;

DefaultRestitution=0;

Module_ID_Parent=%this;

BodyType="kinematic";

Vector_2D_Wall_Move_Start="0 0";

Vector_2D_Wall_Move_End="0 0";

//BlendColor="1 1 1 0.25";

};

%Sprite_Wall.setCollisionGroups(0,1);

%Int_Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Phyxel_Tender.add(%Sprite_Wall);

%Sprite_Wall.Vector_2D_Wall_Move_Start=
((-1*%Vector_2D_Tile_Size.X)-%Vector_2D_Grid_Half_Offset.X)+(%Vector_2D_Tile_Size.X/**0.5*/)
SPC
((%y*%Vector_2D_Tile_Size.Y)-%Vector_2D_Grid_Half_Offset.Y)+(%Vector_2D_Tile_Size.Y/**0.5*/);

%Sprite_Wall.Vector_2D_Wall_Move_End=
(((%this.Vector_2D_Background_Grid_Size.X-1)*%Vector_2D_Tile_Size.X)-%Vector_2D_Grid_Half_Offset.X)+(%Vector_2D_Tile_Size.X/**0.5*/)
SPC
(((%y)*%Vector_2D_Tile_Size.Y)-%Vector_2D_Grid_Half_Offset.Y)+(%Vector_2D_Tile_Size.Y/**0.5*/);

%Sprite_Wall.moveTo(%Sprite_Wall.Vector_2D_Wall_Move_End,%this.Float_Wall_Speed,true,true);

}

}

//Vertical walls.

%Vector_2D_Wall_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Wall);

%Vector_2D_Wall_Size.Y=%Vector_2D_Tile_Size.Y*0.5;

for (%y=-1;%y<%this.Vector_2D_Background_Grid_Size.Y;%y++)
{

for (%x=-1;%x<%this.Vector_2D_Background_Grid_Size.X;%x++)
{

%Vector_2D_Position=
((%x*%Vector_2D_Tile_Size.X)-%Vector_2D_Grid_Half_Offset.X)+(%Vector_2D_Tile_Size.X/**0.5*/)
SPC
((%y*%Vector_2D_Tile_Size.Y)-%Vector_2D_Grid_Half_Offset.Y)+(%Vector_2D_Tile_Size.Y/**0.5*/);

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;

Size=%Vector_2D_Wall_Size;

Image="Module_Gameplay:Image_Wall";

Animation="Module_Gameplay:Animation_Wall";

class="Class_Wall";

SceneLayer=14;

SceneGroup=2;

DefaultDensity=0;

DefaultRestitution=0;

Module_ID_Parent=%this;

BodyType="kinematic";

Vector_2D_Wall_Move_Start="0 0";

Vector_2D_Wall_Move_End="0 0";

//BlendColor="1 1 1 0.25";

};

%Sprite_Wall.setCollisionGroups(0,1);

%Int_Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Phyxel_Tender.add(%Sprite_Wall);

%Sprite_Wall.Vector_2D_Wall_Move_Start=
((%x*%Vector_2D_Tile_Size.X)-%Vector_2D_Grid_Half_Offset.X)+(%Vector_2D_Tile_Size.X/**0.5*/)
SPC
((-1*%Vector_2D_Tile_Size.Y)-%Vector_2D_Grid_Half_Offset.Y)+(%Vector_2D_Tile_Size.Y/**0.5*/);

%Sprite_Wall.Vector_2D_Wall_Move_End=
(((%x)*%Vector_2D_Tile_Size.X)-%Vector_2D_Grid_Half_Offset.X)+(%Vector_2D_Tile_Size.X/**0.5*/)
SPC
(((%this.Vector_2D_Background_Grid_Size.Y-1)*%Vector_2D_Tile_Size.Y)-%Vector_2D_Grid_Half_Offset.Y)+(%Vector_2D_Tile_Size.Y/**0.5*/);

%Sprite_Wall.moveTo(%Sprite_Wall.Vector_2D_Wall_Move_End,%this.Float_Wall_Speed,true,true);

}

}

}
