function Class_Projectile::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

%Sprite_Explosion=new Sprite()
{

Position=%this.Position;

Size=%this.Module_ID_Parent.Vector_2D_Explosion_Size;

Image="Module_Gameplay:Image_Explosion";

Animation="Module_Gameplay:Animation_Explosion";

class="Class_Explosion";

SceneLayer=14;

SceneGroup=0;

DefaultDensity=0;

DefaultRestitution=1;

Module_ID_Parent=%this.Module_ID_Parent;

BodyType="static";

};

Scene_Phyxel_Tender.add(%Sprite_Explosion);

if (%Colliding_Object.class$="Class_Phyxel")
{

if (%this.Module_ID_Parent.Main_Menu_Schedule==0)
{

%this.Module_ID_Parent.Main_Menu_Schedule=schedule(1000,0,"Gui_Gameplay::Go_Main_Menu",Gui_Gameplay);

}

}

%this.safeDelete();

}
