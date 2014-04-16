function Module_Gameplay::Shrubbery_Initialize(%this)
{

%Vector_2D_Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Dirt);

%Vector_2D_Grid_Half_Offset=
(%this.Vector_2D_Background_Grid_Size.X*%Vector_2D_Tile_Size.X)*0.5
SPC
(%this.Vector_2D_Background_Grid_Size.Y*%Vector_2D_Tile_Size.Y)*0.5;

%Vector_2D_Shrub_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Shrub);

for (%y=0;%y<%this.Vector_2D_Background_Grid_Size.Y;%y++)
{

for (%x=0;%x<%this.Vector_2D_Background_Grid_Size.X;%x++)
{

%Vector_2D_Position=
((%x*%Vector_2D_Tile_Size.X)-%Vector_2D_Grid_Half_Offset.X)+(%Vector_2D_Tile_Size.X*0.5)
SPC
((%y*%Vector_2D_Tile_Size.Y)-%Vector_2D_Grid_Half_Offset.Y)+(%Vector_2D_Tile_Size.Y*0.5);

%Sprite_Shrub=new Sprite()
{

Position=%Vector_2D_Position;

Size=%Vector_2D_Shrub_Size;

Image="Module_Gameplay:Image_Shrub";

class="Class_Shrub";

SceneLayer=15;

SceneGroup=2;

DefaultDensity=0;

DefaultRestitution=1;

Module_ID_Parent=%this;

//BodyType="static";

};

%Sprite_Shrub.setCollisionGroups(0,1);

%Int_Collision_Shape_Index=%Sprite_Shrub.createPolygonBoxCollisionShape(%Sprite_Shrub.Size);

Scene_Phyxel_Tender.add(%Sprite_Shrub);

%this.SimSet_Shrubbery.add(%Sprite_Shrub);

Scene_Phyxel_Tender.createDistanceJoint(%Sprite_Shrub,"","0 0",%Sprite_Shrub.Position,
0,
0,//%this.Joint_Distance_Frequency,
1,//%this.Joint_Distance_Damping_Ratio,
false);

//Make 3 going up from the center

for (%z=0;%z<3;%z++)
{

%Vector_2D_Shrub_Position=%Vector_2D_Position;

%Vector_2D_Shrub_Position.Y+=%Vector_2D_Shrub_Size.Y*(%z+1);

%Sprite_Shrub=new Sprite()
{

Position=%Vector_2D_Shrub_Position;

Size=%Vector_2D_Shrub_Size;

Image="Module_Gameplay:Image_Shrub";

class="Class_Shrub";

SceneLayer=15;

SceneGroup=2;

DefaultDensity=0;

DefaultRestitution=1;

Module_ID_Parent=%this;

//BodyType="static";

};

%Sprite_Shrub.setCollisionGroups(0,1);

%Int_Collision_Shape_Index=%Sprite_Shrub.createPolygonBoxCollisionShape(%Sprite_Shrub.Size);

Scene_Phyxel_Tender.add(%Sprite_Shrub);

%this.SimSet_Shrubbery.add(%Sprite_Shrub);

Scene_Phyxel_Tender.createDistanceJoint(%Sprite_Shrub,"","0 0",%Sprite_Shrub.Position,
0,
0,//%this.Joint_Distance_Frequency,
1,//%this.Joint_Distance_Damping_Ratio,
false);

}

//Make 3 going down from the center

for (%z=0;%z<3;%z++)
{

%Vector_2D_Shrub_Position=%Vector_2D_Position;

%Vector_2D_Shrub_Position.Y-=%Vector_2D_Shrub_Size.Y*(%z+1);

%Sprite_Shrub=new Sprite()
{

Position=%Vector_2D_Shrub_Position;

Size=%Vector_2D_Shrub_Size;

Image="Module_Gameplay:Image_Shrub";

class="Class_Shrub";

SceneLayer=15;

SceneGroup=2;

DefaultDensity=0;

DefaultRestitution=1;

Module_ID_Parent=%this;

//BodyType="static";

};

%Sprite_Shrub.setCollisionGroups(0,1);

%Int_Collision_Shape_Index=%Sprite_Shrub.createPolygonBoxCollisionShape(%Sprite_Shrub.Size);

Scene_Phyxel_Tender.add(%Sprite_Shrub);

%this.SimSet_Shrubbery.add(%Sprite_Shrub);

Scene_Phyxel_Tender.createDistanceJoint(%Sprite_Shrub,"","0 0",%Sprite_Shrub.Position,
0,
0,//%this.Joint_Distance_Frequency,
1,//%this.Joint_Distance_Damping_Ratio,
false);

}

//Make 3 going left from the center

for (%z=0;%z<3;%z++)
{

%Vector_2D_Shrub_Position=%Vector_2D_Position;

%Vector_2D_Shrub_Position.X-=%Vector_2D_Shrub_Size.X*(%z+1);

%Sprite_Shrub=new Sprite()
{

Position=%Vector_2D_Shrub_Position;

Size=%Vector_2D_Shrub_Size;

Image="Module_Gameplay:Image_Shrub";

class="Class_Shrub";

SceneLayer=15;

SceneGroup=2;

DefaultDensity=0;

DefaultRestitution=1;

Module_ID_Parent=%this;

//BodyType="static";

};

%Sprite_Shrub.setCollisionGroups(0,1);

%Int_Collision_Shape_Index=%Sprite_Shrub.createPolygonBoxCollisionShape(%Sprite_Shrub.Size);

Scene_Phyxel_Tender.add(%Sprite_Shrub);

%this.SimSet_Shrubbery.add(%Sprite_Shrub);

Scene_Phyxel_Tender.createDistanceJoint(%Sprite_Shrub,"","0 0",%Sprite_Shrub.Position,
0,
0,//%this.Joint_Distance_Frequency,
1,//%this.Joint_Distance_Damping_Ratio,
false);

}

//Make 3 going right from the center

for (%z=0;%z<3;%z++)
{

%Vector_2D_Shrub_Position=%Vector_2D_Position;

%Vector_2D_Shrub_Position.X+=%Vector_2D_Shrub_Size.X*(%z+1);

%Sprite_Shrub=new Sprite()
{

Position=%Vector_2D_Shrub_Position;

Size=%Vector_2D_Shrub_Size;

Image="Module_Gameplay:Image_Shrub";

class="Class_Shrub";

SceneLayer=15;

SceneGroup=2;

DefaultDensity=0;

DefaultRestitution=1;

Module_ID_Parent=%this;

//BodyType="static";

};

%Sprite_Shrub.setCollisionGroups(0,1);

%Int_Collision_Shape_Index=%Sprite_Shrub.createPolygonBoxCollisionShape(%Sprite_Shrub.Size);

Scene_Phyxel_Tender.add(%Sprite_Shrub);

%this.SimSet_Shrubbery.add(%Sprite_Shrub);

Scene_Phyxel_Tender.createDistanceJoint(%Sprite_Shrub,"","0 0",%Sprite_Shrub.Position,
0,
0,//%this.Joint_Distance_Frequency,
1,//%this.Joint_Distance_Damping_Ratio,
false);

}

}

}

}
