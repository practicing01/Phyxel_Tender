function Class_Phyxel_Collision_Shape::Reconstruct_Phyxels(%this)
{

if (!isObject(%this)){return;}

for (%x=0;%x<%this.SimSet_Parent_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Parent_Phyxels.getObject(%x);

%Sprite_Phyxel.Position=Vector2Add(%this.Position,%Sprite_Phyxel.Vector_2D_Origin);

}

}
