function Class_Wall::onMoveToComplete(%this)
{

%this.Position=%this.Vector_2D_Wall_Move_Start;

%this.moveTo(%this.Vector_2D_Wall_Move_End,%this.Module_ID_Parent.Float_Wall_Speed,true,true);

}
