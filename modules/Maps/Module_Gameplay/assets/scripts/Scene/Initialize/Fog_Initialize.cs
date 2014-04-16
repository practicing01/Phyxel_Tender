function Module_Gameplay::Fog_Initialize(%this)
{

%Phyxel_Center=%this.SimSet_Grid_Phyxels_Rogue_Tender.getObject(
(%this.Vector_2D_Grid_Size.X*0.5)+((%this.Vector_2D_Grid_Size.Y*0.5)*%this.Vector_2D_Grid_Size.X));

%Scroller_Fog=new Scroller()
{

Position=%Phyxel_Center.Position;
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Fog);
Image="Module_Gameplay:Image_Fog";
class="Class_Fog";
BodyType="dynamic";
SceneLayer=0;

BlendColor="1 1 1 0.25";

DefaultDensity=0;

DefaultRestitution=0;

SceneGroup=3;

};

Scene_Phyxel_Tender.add(%Scroller_Fog);

%Phyxel_Center=%this.SimSet_Grid_Phyxels_Rogue_Tender.getObject(%this.Int_Center_Phyxel_Index);

Scene_Phyxel_Tender.createDistanceJoint(%Scroller_Fog,%Phyxel_Center,"0 0","0 0",
0,
0,
1,
false);

%this.Scroller_Fog=%Scroller_Fog;

%Scroller_Fog.setScroll(-1,0);

}
