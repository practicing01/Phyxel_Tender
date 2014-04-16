function Module_Gameplay::Scene_Initialize(%this)
{

exec("./Initialize/Initialize.cs");

%this.Score_Initialize();

%this.Phyxels_Initialize();

%this.Background_Initialize();

%this.Fog_Initialize();

%this.Input_Initialize();

%this.Shrubbery_Initialize();

%this.Carcass_Initialize();

%this.Leaf_Initialize();

%this.AI_Initialize();

%this.Walls_Initialize();

}
