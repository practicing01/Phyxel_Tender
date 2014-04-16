function Class_Carcass::onCollision(%this,%Colliding_Object,%Collision_Details)
{

%this.Module_ID_Parent.Int_Score++;

%this.Module_ID_Parent.Gui_Text_Score.setText("Score:" SPC %this.Module_ID_Parent.Int_Score);

%Vector_2D_Position=%this.Module_ID_Parent.SimSet_Shrubbery.getObject(getRandom(0,%this.Module_ID_Parent.SimSet_Shrubbery.getCount()-1)).Position;

%this.Position=%Vector_2D_Position;

for (%x=0;%x<%this.Module_ID_Parent.SimSet_Sprite_Leafs.getCount();%x++)
{

%Sprite_Leaf=%this.Module_ID_Parent.SimSet_Sprite_Leafs.getObject(%x);

%Sprite_Leaf.Angle=Vector2AngleToPoint(%Sprite_Leaf.Position,%Vector_2D_Position);

}

return;

for (%x=0;%x<%this.Module_ID_Parent.SimSet_ID_Leafs.getCount();%x++)
{

%Sprite_ID=%this.Module_ID_Parent.SimSet_ID_Leafs.getObject(%x);

%Sprite_Leaf=%this.Module_ID_Parent.CompositeSprite_Leaves.selectSpriteId(%Sprite_ID.Sprite_ID);

%Float_Angle=Vector2AngleToPoint(%this.Module_ID_Parent.CompositeSprite_Leaves.getSpriteLocalPosition(),%Vector_2D_Position);

%this.Module_ID_Parent.CompositeSprite_Leaves.setSpriteAngle(%Float_Angle);

}

}
