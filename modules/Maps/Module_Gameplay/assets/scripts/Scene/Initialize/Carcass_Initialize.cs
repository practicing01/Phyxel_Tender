function Module_Gameplay::Carcass_Initialize(%this)
{

%Vector_2D_Position=%this.SimSet_Shrubbery.getObject(getRandom(0,%this.SimSet_Shrubbery.getCount()-1)).Position;

%Sprite_Carcass=new Sprite()
{

Position=%Vector_2D_Position;

Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Carcass);

Image="Module_Gameplay:Image_Carcass";

class="Class_Carcass";

SceneLayer=14;

SceneGroup=2;

DefaultDensity=0;

DefaultRestitution=1;

Module_ID_Parent=%this;

BodyType="static";

};

%Sprite_Carcass.setCollisionGroups(1);

%Int_Collision_Shape_Index=%Sprite_Carcass.createPolygonBoxCollisionShape(%Sprite_Carcass.Size);

%Sprite_Carcass.setCollisionShapeIsSensor(%Int_Collision_Shape_Index,true);

Scene_Phyxel_Tender.add(%Sprite_Carcass);

%this.Sprite_Carcass=%Sprite_Carcass;

}
