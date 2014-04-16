function Class_Phyxel_Collision_Shape::onCollision(%this,%Colliding_Object,%Collision_Details)
{

cancel(%this.Schedule_Reconstruct_Phyxels);

if ((%this.SceneGroup==1&&%Colliding_Object.SceneGroup==0)||(%this.SceneGroup==0&&%Colliding_Object.SceneGroup==1))
{

if (%Colliding_Object.class$="Class_Projectile"){return;}

if (%this.Module_ID_Parent.Main_Menu_Schedule==0)
{

%this.Module_ID_Parent.Main_Menu_Schedule=schedule(1000,0,"Gui_Gameplay::Go_Main_Menu",Gui_Gameplay);

}

}

}
