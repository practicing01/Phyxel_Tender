function Phyxel_Tender::create(%this)
{

/*Core Misc*/

exec("./scripts/Misc/Misc_Initialize.cs");

initializeCanvas("Phyxel_Tender");

Canvas.BackgroundColor="black";

Canvas.UseBackgroundColor=true;

initializeOpenAL();

/*Gui Init*/
exec("./gui/guiProfiles.cs");

/*Global Variables*/

exec("./scripts/Variables_Initialize.cs");

%this.Variables_Initialize();

/*Global Functions*/
exec("./scripts/Functions_Initialize/Functions_Initialize.cs");

/*Core Scene*/
exec("./scenes/Scene_Phyxel_Tender.cs");

/*Pause Menu*/
exec("./gui/Gui_Pause_Menu/Gui_Pause_Menu.cs");

Window_Create_Phyxel_Tender();

Scene_Create_Phyxel_Tender();

Phyxel_Tender.add(TamlRead("./gui/ConsoleDialog.gui.taml"));

GlobalActionMap.bind(keyboard,"tilde",toggleConsole);

new RenderProxy(CannotRenderProxy)
{

Image="Phyxel_Tender:CannotRender";

};

Phyxel_Tender.add(CannotRenderProxy);

Phyxel_Tender.Camera_Size=Window_Phyxel_Tender.getCameraSize();

%Local_Time=getLocalTime();

%Local_Time=stripChars(%Local_Time,":/");

%Local_Time=getWord(%Local_Time,0)+getWord(%Local_Time,1);

setRandomSeed(%Local_Time);

/*Load Play*/
exec("./scripts/Play_Load/Play_Load.cs");

%this.Play_Load();

}

function Phyxel_Tender::destroy(%this)
{
Window_Destroy_Phyxel_Tender();
}
