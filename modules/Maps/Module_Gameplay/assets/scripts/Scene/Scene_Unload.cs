function Module_Gameplay::Scene_Unload(%this)
{

%this.SimSet_Grid_Phyxels_Tender.delete();

%this.SimSet_Grid_Phyxels_Rogue_Tender.delete();

%this.SimSet_Shrubbery.delete();

%this.SimSet_ID_Leafs.deleteObjects();

%this.SimSet_ID_Leafs.delete();

%this.SimSet_Sprite_Leafs.delete();

cancel(%this.Schedule_AI);

Window_Phyxel_Tender.removeInputListener(%this.Script_Object_Input_Controller);

%this.Bool_Is_Playing=false;

%this.Gui_Text_Score.delete();

Canvas.popDialog(Gui_Gameplay);

%this.Ass_Unload();

}
