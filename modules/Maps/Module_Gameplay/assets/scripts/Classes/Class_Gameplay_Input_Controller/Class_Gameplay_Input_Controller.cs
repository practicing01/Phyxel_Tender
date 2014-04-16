function Class_Gameplay_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

%Phyxel_Center=%this.Module_ID_Parent.SimSet_Grid_Phyxels_Rogue_Tender.getObject(%this.Module_ID_Parent.Int_Center_Phyxel_Index);

%Float_Angle=Vector2AngleToPoint(%Phyxel_Center.Position,%Vector_2D_World_Position);

%Float_Distance=Vector2Distance(%Phyxel_Center.Position,%Vector_2D_World_Position);

%Vector_2D_Normalized_Projected_Position=Vector2Direction(%Float_Angle,%Float_Distance);

for (%x=0;%x<%this.Module_ID_Parent.SimSet_Grid_Phyxels_Rogue_Tender.getCount();%x++)
{

%Sprite_Phyxel=%this.Module_ID_Parent.SimSet_Grid_Phyxels_Rogue_Tender.getObject(%x);

%Sprite_Phyxel.setLinearVelocityPolar(%Float_Angle,%this.Module_ID_Parent.Float_Rogue_Tender_Speed);

//%Vector_2D_Projected_Position=Vector2Add(%Sprite_Phyxel.Position,%Vector_2D_Normalized_Projected_Position);

//%Sprite_Phyxel.moveTo(%Vector_2D_Projected_Position,%this.Module_ID_Parent.Float_Rogue_Tender_Speed,true,false);

}

%this.Module_ID_Parent.Scroller_Fog.setScrollPolar(%Float_Angle,%this.Module_ID_Parent.Float_Scroller_Speed);

}

/*function Class_Gameplay_Input_Controller::onTouchUp(%this,%touchID,%Vector_2D_World_Position)
{

return;

}

function Class_Gameplay_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{

return;

}*/
