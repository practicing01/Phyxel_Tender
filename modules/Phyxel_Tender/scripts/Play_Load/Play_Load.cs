function Phyxel_Tender::Play_Load(%this)
{

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Phyxel_Tender_Input_Controller";

};

Window_Phyxel_Tender.addInputListener(%this.Script_Object_Input_Controller);

/*Load splashes*/

ModuleDatabase.LoadExplicit("Splashes");

Splashes.Scene_Load();

}
