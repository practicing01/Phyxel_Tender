function Module_Gameplay::AI_Process(%this)
{

%Phyxel_Target=%this.SimSet_Grid_Phyxels_Rogue_Tender.getObject(%this.Int_Center_Phyxel_Index);

%Phyxel_Center=%this.SimSet_Grid_Phyxels_Tender.getObject(%this.Int_Center_Phyxel_Index);

%Float_Angle=Vector2AngleToPoint(%Phyxel_Center.Position,%Phyxel_Target.Position);

%Float_Distance=Vector2Distance(%Phyxel_Center.Position,%Phyxel_Target.Position);

%Vector_2D_Normalized_Projected_Position=Vector2Direction(%Float_Angle,%Float_Distance);

for (%x=0;%x<%this.SimSet_Grid_Phyxels_Tender.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Grid_Phyxels_Tender.getObject(%x);

%Sprite_Phyxel.setLinearVelocityPolar(%Float_Angle,%this.Float_Tender_Speed);

//%Vector_2D_Projected_Position=Vector2Add(%Sprite_Phyxel.Position,%Vector_2D_Normalized_Projected_Position);

//%Sprite_Phyxel.moveTo(%Vector_2D_Projected_Position,%this.Float_Tender_Speed,true,false);

}

/*****************************************************************************/
//Shoot projectile.

%Sprite_Projectile=new Sprite()
{

Position=%Phyxel_Center.Position;

Size=%this.Vector_2D_Projectile_Size;

Image="Module_Gameplay:Image_Flame";

Animation="Module_Gameplay:Animation_Flame";

class="Class_Projectile";

SceneLayer=14;

SceneGroup=0;

DefaultDensity=0;

DefaultRestitution=1;

Module_ID_Parent=%this;

Angle=%Float_Angle;

CollisionCallback="true";

};

%Sprite_Projectile.setCollisionGroups(1,2);

%Int_Collision_Shape_Index=%Sprite_Projectile.createPolygonBoxCollisionShape(%Sprite_Projectile.Size);

%Sprite_Projectile.setCollisionShapeIsSensor(%Int_Collision_Shape_Index,true);

Scene_Phyxel_Tender.add(%Sprite_Projectile);

%Sprite_Projectile.setLinearVelocityPolar(%Float_Angle,%this.Float_Projectile_Speed);

/*****************************************************************************/

%this.Schedule_AI=schedule(1000,0,"Module_Gameplay::AI_Process",%this);

}

function Module_Gameplay::AI_Initialize(%this)
{

%this.AI_Process();

}
