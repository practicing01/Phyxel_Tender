function Module_Gameplay::Variables_Initialize(%this)
{

%this.Gui_Text_Score=0;

%this.Int_Score=0;

%this.Bool_Is_Playing=true;

%this.Script_Object_Input_Controller=0;

%this.Joint_Distance_Frequency=0.5;

%this.Joint_Distance_Damping_Ratio=0.5;

%this.Vector_2D_Phyxel_Size=Vector_2D_Vector_To_Camera_By_Resolution_Scale("2 2","800 480");

%this.Vector_2D_Grid_Size="32 32";

%this.Vector_2D_Background_Grid_Size="6 6";

%this.Float_Rogue_Tender_Speed=10;

%this.Float_Tender_Speed=9;

%this.Int_Center_Phyxel_Index=(%this.Vector_2D_Grid_Size.X*0.5)+((%this.Vector_2D_Grid_Size.Y*0.5)*%this.Vector_2D_Grid_Size.X);

%this.Float_Scroller_Speed=10;

%this.Main_Menu_Schedule=0;

%this.SimSet_Shrubbery=new SimSet();

%this.Sprite_Carcass=0;

%this.SimSet_ID_Leafs=new SimSet();

%this.SimSet_Sprite_Leafs=new SimSet();

%this.Schedule_AI=0;

%this.Float_Wall_Speed=10;

%this.Vector_2D_Projectile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Flame);

%this.Float_Projectile_Speed=11;

%this.Vector_2D_Explosion_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Explosion);

/*************************************************************************************/
/*Create Tender simset.*/

%this.SimSet_Grid_Phyxels_Tender=new SimSet();

for (%y=0;%y<%this.Vector_2D_Grid_Size.Y;%y++)
{

for (%x=0;%x<%this.Vector_2D_Grid_Size.X;%x++)
{

%Vector_2D_Position=%x SPC %y;

%Vector_2D_Position.X*=%this.Vector_2D_Phyxel_Size.X;

%Vector_2D_Position.Y*=%this.Vector_2D_Phyxel_Size.Y;

%Vector_2D_Position.X-=(%this.Vector_2D_Grid_Size.X/2)*%this.Vector_2D_Phyxel_Size.X;

%Vector_2D_Position.Y-=(%this.Vector_2D_Grid_Size.Y/2)*%this.Vector_2D_Phyxel_Size.Y;

%Sprite_Phyxel=new sprite()
{

Position=%Vector_2D_Position;

Size=%this.Vector_2D_Phyxel_Size;

Image="Module_Gameplay:Blank";

Bool_Is_Phyxel=false;

Bool_Is_Squiggler=false;

Vector_2D_Origin=%Vector_2D_Position;

Vector_2D_Original_Size=%this.Vector_2D_Phyxel_Size;

Schedule_Squiggle=0;

class="Class_Phyxel";

SceneLayer=17;

SceneGroup=0;

DefaultDensity=0;

DefaultRestitution=1;

SimSet_Distance_Joint_Connections=0;

SimSet_Weld_Joint_Connections=0;

Vector_2D_Grid_Position=%x SPC %y;

Vector_2D_Origin=%Vector_2D_Position;

Vector_2D_Original_Size=%this.Vector_2D_Phyxel_Size;

Module_ID_Parent=%this;

FixedAngle=true;

LinearDamping=0;

};

%Sprite_Phyxel.SimSet_Distance_Joint_Connections=new SimSet();

%Sprite_Phyxel.SimSet_Weld_Joint_Connections=new SimSet();

%Sprite_Phyxel.setCollisionGroups(1,2);

%Int_Collision_Shape_Index=%Sprite_Phyxel.createPolygonBoxCollisionShape(%Sprite_Phyxel.Size);

//%Sprite_Phyxel.setCollisionShapeIsSensor(%Int_Collision_Shape_Index,true);

Scene_Phyxel_Tender.add(%Sprite_Phyxel);

%this.SimSet_Grid_Phyxels_Tender.add(%Sprite_Phyxel);

}

}

//Random offset
for (%x=0;%x<%this.SimSet_Grid_Phyxels_Tender.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Grid_Phyxels_Tender.getObject(%x);

//For testing, need to make randomized positioning.
%Sprite_Phyxel.Position.X+=(%this.Vector_2D_Grid_Size.X*%this.Vector_2D_Phyxel_Size.X)*2;

%Sprite_Phyxel.Position.Y+=(%this.Vector_2D_Grid_Size.Y*%this.Vector_2D_Phyxel_Size.Y)*2;

}

/*************************************************************************************/
/*Create Rogue Tender simset.*/

%this.SimSet_Grid_Phyxels_Rogue_Tender=new SimSet();

for (%y=0;%y<%this.Vector_2D_Grid_Size.Y;%y++)
{

for (%x=0;%x<%this.Vector_2D_Grid_Size.X;%x++)
{

%Vector_2D_Position=%x SPC %y;

%Vector_2D_Position.X*=%this.Vector_2D_Phyxel_Size.X;

%Vector_2D_Position.Y*=%this.Vector_2D_Phyxel_Size.Y;

%Vector_2D_Position.X-=(%this.Vector_2D_Grid_Size.X/2)*%this.Vector_2D_Phyxel_Size.X;

%Vector_2D_Position.Y-=(%this.Vector_2D_Grid_Size.Y/2)*%this.Vector_2D_Phyxel_Size.Y;

%Vector_2D_Origin=%Vector_2D_Position;

%Sprite_Phyxel=new sprite()
{

Position=%Vector_2D_Position;

Size=%this.Vector_2D_Phyxel_Size;

Image="Module_Gameplay:Blank";

Bool_Is_Phyxel=false;

Bool_Is_Squiggler=false;

Vector_2D_Origin=%Vector_2D_Origin;

Vector_2D_Original_Size=%this.Vector_2D_Phyxel_Size;

Schedule_Squiggle=0;

class="Class_Phyxel";

SceneLayer=17;

SceneGroup=1;

DefaultDensity=0;

DefaultRestitution=1;

SimSet_Distance_Joint_Connections=0;

SimSet_Weld_Joint_Connections=0;

Vector_2D_Grid_Position=%x SPC %y;

Vector_2D_Origin=%Vector_2D_Position;

Vector_2D_Original_Size=%this.Vector_2D_Phyxel_Size;

Module_ID_Parent=%this;

FixedAngle=true;

LinearDamping=0;

};

%Sprite_Phyxel.SimSet_Distance_Joint_Connections=new SimSet();

%Sprite_Phyxel.SimSet_Weld_Joint_Connections=new SimSet();

%Sprite_Phyxel.setCollisionGroups(0,2);

%Int_Collision_Shape_Index=%Sprite_Phyxel.createPolygonBoxCollisionShape(%Sprite_Phyxel.Size);

//%Sprite_Phyxel.setCollisionShapeIsSensor(%Int_Collision_Shape_Index,true);

Scene_Phyxel_Tender.add(%Sprite_Phyxel);

%this.SimSet_Grid_Phyxels_Rogue_Tender.add(%Sprite_Phyxel);

}

}

//Random offset
for (%x=0;%x<%this.SimSet_Grid_Phyxels_Rogue_Tender.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Grid_Phyxels_Rogue_Tender.getObject(%x);

//For testing, need to make randomized positioning.
%Sprite_Phyxel.Position.X-=(%this.Vector_2D_Grid_Size.X*%this.Vector_2D_Phyxel_Size.X)*2;

%Sprite_Phyxel.Position.Y-=(%this.Vector_2D_Grid_Size.Y*%this.Vector_2D_Phyxel_Size.Y)*2;

}

/***********************************************************************************************************/
//Collision box for Rogue Tender

%Phyxel_Center=%this.SimSet_Grid_Phyxels_Rogue_Tender.getObject(%this.Int_Center_Phyxel_Index);

%SceneObject_Collision_Shape=new SceneObject()
{

Position=%Phyxel_Center.Position;

Size=Vector_2D_Vector_To_Camera_By_Resolution_Scale("32 32","800 480");

class="Class_Phyxel_Collision_Shape";

SceneGroup=1;

DefaultDensity=0;

DefaultRestitution=1;

Module_ID_Parent=%this;

SimSet_Parent_Phyxels=%this.SimSet_Grid_Phyxels_Rogue_Tender;

CollisionCallback="true";

Schedule_Reconstruct_Phyxels=0;

};

%SceneObject_Collision_Shape.setCollisionGroups(0,2);

%Int_Collision_Shape_Index=%SceneObject_Collision_Shape.createPolygonBoxCollisionShape(%SceneObject_Collision_Shape.Size);

%SceneObject_Collision_Shape.setCollisionShapeIsSensor(%Int_Collision_Shape_Index,true);

Scene_Phyxel_Tender.add(%SceneObject_Collision_Shape);

Scene_Phyxel_Tender.createDistanceJoint(%SceneObject_Collision_Shape,%Phyxel_Center,"0 0","0 0",
Vector2Distance(%SceneObject_Collision_Shape.Position,%Phyxel_Center.Position),
0,
1,
false);

/***********************************************************************************************************/
//Collision box for Tender

%Phyxel_Center=%this.SimSet_Grid_Phyxels_Tender.getObject(%this.Int_Center_Phyxel_Index);

%SceneObject_Collision_Shape=new SceneObject()
{

Position=%Phyxel_Center.Position;

Size=Vector_2D_Vector_To_Camera_By_Resolution_Scale("32 32","800 480");

class="Class_Phyxel_Collision_Shape";

SceneGroup=0;

DefaultDensity=0;

DefaultRestitution=1;

Module_ID_Parent=%this;

SimSet_Parent_Phyxels=%this.SimSet_Grid_Phyxels_Tender;

CollisionCallback="true";

Schedule_Reconstruct_Phyxels=0;

};

%SceneObject_Collision_Shape.setCollisionGroups(1,2);

%Int_Collision_Shape_Index=%SceneObject_Collision_Shape.createPolygonBoxCollisionShape(%SceneObject_Collision_Shape.Size);

%SceneObject_Collision_Shape.setCollisionShapeIsSensor(%Int_Collision_Shape_Index,true);

Scene_Phyxel_Tender.add(%SceneObject_Collision_Shape);

Scene_Phyxel_Tender.createDistanceJoint(%SceneObject_Collision_Shape,%Phyxel_Center,"0 0","0 0",
Vector2Distance(%SceneObject_Collision_Shape.Position,%Phyxel_Center.Position),
0,
1,
false);

}
