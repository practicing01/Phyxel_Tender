function Module_Gui_Instructions_Menu::Scene_Initialize(%this)
{

%Text="Instructions";
%Text=%Text NL "Flee from the shadow.";
%Text=%Text NL "Free the carcasses from their torment.";
%Text=%Text NL "The harvest holds clues.";
%Text=%Text NL "";
%Text=%Text NL "Credits for code and graphics to their respective authors.";
%Text=%Text NL "";
%Text=%Text NL "Thank you for playing. ~ practicing01";

%this.Gui_Text_ML=new GuiMLTextCtrl()
{
Position="0 0";
HorizSizing="relative";
VertSizing="relative";
Text=%Text; 
Extent=Phyxel_Tender.Resolution;
isContainer="1";
Profile="Gui_Profile_Modalless_Text";
hovertime="1000";
MaxLength="512";
};

Gui_Instructions_Menu.addGuiControl(%this.Gui_Text_ML);

}
