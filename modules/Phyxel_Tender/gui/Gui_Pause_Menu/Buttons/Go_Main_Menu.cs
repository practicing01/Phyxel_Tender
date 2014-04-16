function Gui_Pause_Menu::Go_Main_Menu(%this)
{

$Module_ID_Map_Loaded.Scene_Unload();

$Module_ID_Map_Loaded=0;

/***********************************************/
/************ Delete Gui's **********************/

for (%x=0;%x<Gui_Phyxel_Tender_Overlay.getCount();%x++)
{

%Gui_Child=Gui_Phyxel_Tender_Overlay.getObject(%x);

if (%Gui_Child.Bool_Delete_Me==true)
{

Gui_Phyxel_Tender_Overlay.remove(%Gui_Child);

%Gui_Child.deleteObjects();

%Gui_Child.delete();

%x=-1;//Restart loop because we just modified the count.

}

}

/***********************************************/

$Bool_Is_Playing=false;

Module_Gui_Chat_Box.Scene_Unload();

Canvas.popDialog(Gui_Pause_Menu);

Module_Gui_Main_Menu.Scene_Load();

}
