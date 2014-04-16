function Class_Phyxel_Collision_Shape::onEndCollision(%this,%Colliding_Object,%Collision_Details)
{

if (!isObject(%this)){return;}

cancel(%this.Schedule_Reconstruct_Phyxels);

%this.Schedule_Reconstruct_Phyxels=schedule(1000,0,"Class_Phyxel_Collision_Shape::Reconstruct_Phyxels",%this);

}
