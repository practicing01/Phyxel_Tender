function Window_Create_Phyxel_Tender()
{

if (!isObject(Window_Phyxel_Tender))
{

new SceneWindow(Window_Phyxel_Tender);   

Window_Phyxel_Tender.Profile=Gui_Profile_Window_Phyxel_Tender;

Canvas.setContent(Window_Phyxel_Tender);                     

}

Window_Phyxel_Tender.stopCameraMove();
Window_Phyxel_Tender.dismount();
Window_Phyxel_Tender.setViewLimitOff();
Window_Phyxel_Tender.setRenderGroups(Phyxel_Tender.All_Bits);
Window_Phyxel_Tender.setRenderLayers(Phyxel_Tender.All_Bits);
Window_Phyxel_Tender.setObjectInputEventGroupFilter(Phyxel_Tender.All_Bits);
Window_Phyxel_Tender.setObjectInputEventLayerFilter(Phyxel_Tender.All_Bits);
Window_Phyxel_Tender.setLockMouse(true);
Window_Phyxel_Tender.setCameraPosition(0,0);
Window_Phyxel_Tender.setCameraZoom(1);
Window_Phyxel_Tender.setCameraAngle(0);

Phyxel_Tender.Resolution=getRes();
%Y_Times_100=100*Phyxel_Tender.Resolution.Y;
%Cam_Y=%Y_Times_100/Phyxel_Tender.Resolution.X;

Window_Phyxel_Tender.setCameraSize(100,%Cam_Y);

if (!isObject(Gui_Phyxel_Tender_Overlay))
{

new GuiControl(Gui_Phyxel_Tender_Overlay)
{

Position="0 0";
Extent=Phyxel_Tender.Resolution;
Profile=gui_profile_modalless;

};   

Window_Phyxel_Tender.addGuiControl(Gui_Phyxel_Tender_Overlay);

Gui_Phyxel_Tender_Overlay.setActive(true);

}

}

//-----------------------------------------------------------------------------

function Window_Destroy_Phyxel_Tender()
{
    
if (isObject(Window_Phyxel_Tender))
{

Window_Phyxel_Tender.delete();

}

}

//-----------------------------------------------------------------------------

function Scene_Destroy_Phyxel_Tender()
{

if (isObject(Scene_Phyxel_Tender))
{

Scene_Phyxel_Tender.delete();

}

}

function Scene_Set_To_Window()
{

if (!isObject(Scene_Phyxel_Tender))
{

error("Cannot set Phyxel_Tender Scene to Window as the Scene is invalid.");
return;

}
    
Window_Phyxel_Tender.setScene(Scene_Phyxel_Tender);

Window_Phyxel_Tender.stopCameraMove();
Window_Phyxel_Tender.dismount();
Window_Phyxel_Tender.setViewLimitOff();
Window_Phyxel_Tender.setRenderGroups(Phyxel_Tender.All_Bits);
Window_Phyxel_Tender.setRenderLayers(Phyxel_Tender.All_Bits);
Window_Phyxel_Tender.setObjectInputEventGroupFilter(Phyxel_Tender.All_Bits);
Window_Phyxel_Tender.setObjectInputEventLayerFilter(Phyxel_Tender.All_Bits);
Window_Phyxel_Tender.setLockMouse(true);
Window_Phyxel_Tender.setCameraPosition(0,0);
Window_Phyxel_Tender.setCameraZoom(1);
Window_Phyxel_Tender.setCameraAngle(0);

Phyxel_Tender.Resolution=getRes();
%Y_Times_100=100*Phyxel_Tender.Resolution.Y;
%Cam_Y=%Y_Times_100/Phyxel_Tender.Resolution.X;

Window_Phyxel_Tender.setCameraSize(100,%Cam_Y);

}

function Scene_Create_Phyxel_Tender()
{

Scene_Destroy_Phyxel_Tender();

new Scene(Scene_Phyxel_Tender);

if (!isObject(Window_Phyxel_Tender))
{

error("Phyxel_Tender: Created scene but no window available.");
return;

}

Scene_Set_To_Window();    
}

function Scene_Set_Custom(%Scene)
{

if (!isObject(%Scene))
{

error("Cannot set Phyxel_Tender to use an invalid Scene.");
return;

}
   
Scene_Destroy_Phyxel_Tender();

%Scene.setName("Scene_Phyxel_Tender");

//%Scene.class="Class_Scene_Phyxel_Tender";

Scene_Set_To_Window();

//%Scene.setDebugOn("joints");
//%Scene.setDebugOn("metrics");
//%Scene.setDebugOn("fps");
//%Scene.setDebugOn("wireframe");
//%Scene.setDebugOn("aabb");
//%Scene.setDebugOn("oobb");
//%Scene.setDebugOn("sleep");
//%Scene.setDebugOn("collision");
//%Scene.setDebugOn("position");
//%Scene.setDebugOn("sort");
//%Scene.setDebugOn("controllers");

}

//-----------------------------------------------------------------------------

/*function Class_Scene_Phyxel_Tender::onSceneCollision(%this,%Scene_Object_0,%Scene_Object_1,%Collision_Details)
{

echo(%Scene_Object_0.class);

echo(%Scene_Object_1.class);

}*/
