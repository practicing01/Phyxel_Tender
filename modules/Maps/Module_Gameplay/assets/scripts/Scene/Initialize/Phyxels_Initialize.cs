function Module_Gameplay::Phyxels_Initialize(%this)
{

%FileObject_File=new FileStreamObject();

/*************************************************************/
/*Load Tender Phyxels*/

%FileObject_File.open("./../../../Phyxels/Tender.txt","Read");

for (%x=0;%x<%this.SimSet_Grid_Phyxels_Tender.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Grid_Phyxels_Tender.getObject(%x);

//%Sprite_Phyxel.Size=%FileObject_File.readLine();
%Size=%FileObject_File.readLine();//Not used.

%Sprite_Phyxel.BlendColor=%FileObject_File.readLine();

//%Sprite_Phyxel.Vector_2D_Origin=%FileObject_File.readLine();
%Vector_2D_Origin=%FileObject_File.readLine();//Not used.

//%Sprite_Phyxel.Vector_2D_Original_Size=%FileObject_File.readLine();
%Vector_2D_Original_Size=%FileObject_File.readLine();//Not used.

%Sprite_Phyxel.SceneLayer=%FileObject_File.readLine();

%Sprite_Phyxel.Bool_Is_Phyxel=%FileObject_File.readLine();

%Sprite_Phyxel.Bool_Is_Squiggler=%FileObject_File.readLine();

%Sprite_Phyxel.DefaultDensity=%FileObject_File.readLine();

%Sprite_Phyxel.DefaultRestitution=%FileObject_File.readLine();

%Sprite_Phyxel.Vector_2D_Grid_Position=%FileObject_File.readLine();

%Int_Distance_Joint_Connection_Count=%FileObject_File.readLine();

for (%y=0;%y<%Int_Distance_Joint_Connection_Count;%y++)
{

%ScriptObject_Connected_Phyxel_Grid_Position=new ScriptObject()
{

Vector_2D_Grid_Position=%FileObject_File.readLine();

};

%Sprite_Phyxel.SimSet_Distance_Joint_Connections.add(%ScriptObject_Connected_Phyxel_Grid_Position);

}

%Int_Weld_Joint_Connection_Count=%FileObject_File.readLine();

for (%y=0;%y<%Int_Weld_Joint_Connection_Count;%y++)
{

%ScriptObject_Connected_Phyxel_Grid_Position=new ScriptObject()
{

Vector_2D_Grid_Position=%FileObject_File.readLine();

};

%Sprite_Phyxel.SimSet_Weld_Joint_Connections.add(%ScriptObject_Connected_Phyxel_Grid_Position);

}

}

%FileObject_File.close();

/*Make joint connections*/

for (%x=0;%x<%this.SimSet_Grid_Phyxels_Tender.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Grid_Phyxels_Tender.getObject(%x);

for (%y=0;%y<%Sprite_Phyxel.SimSet_Distance_Joint_Connections.getCount();%y++)
{

%ScriptObject_Connected_Phyxel_Grid_Position=%Sprite_Phyxel.SimSet_Distance_Joint_Connections.getObject(%y);

%Sprite_Connected_Phyxel=%this.SimSet_Grid_Phyxels_Tender.getObject(%ScriptObject_Connected_Phyxel_Grid_Position.Vector_2D_Grid_Position.X+
(%ScriptObject_Connected_Phyxel_Grid_Position.Vector_2D_Grid_Position.Y*%this.Vector_2D_Grid_Size.X));

Scene_Phyxel_Tender.createDistanceJoint(%Sprite_Phyxel,%Sprite_Connected_Phyxel,"0 0","0 0",
Vector2Distance(%Sprite_Phyxel.Position,%Sprite_Connected_Phyxel.Position),
0,//%this.Joint_Distance_Frequency,
1,//%this.Joint_Distance_Damping_Ratio,
false);

}

for (%y=0;%y<%Sprite_Phyxel.SimSet_Weld_Joint_Connections.getCount();%y++)
{

%ScriptObject_Connected_Phyxel_Grid_Position=%Sprite_Phyxel.SimSet_Weld_Joint_Connections.getObject(%y);

%Sprite_Connected_Phyxel=%this.SimSet_Grid_Phyxels_Tender.getObject(%ScriptObject_Connected_Phyxel_Grid_Position.Vector_2D_Grid_Position.X+
(%ScriptObject_Connected_Phyxel_Grid_Position.Vector_2D_Grid_Position.Y*%this.Vector_2D_Grid_Size.X));

/*Scene_Phyxel_Tender.createWeldJoint(%Sprite_Phyxel,%Sprite_Connected_Phyxel,
%Sprite_Phyxel.getLocalVector(%Sprite_Connected_Phyxel.Position),
%Sprite_Connected_Phyxel.getLocalVector(%Sprite_Phyxel.Position),
0,//%this.Module_ID_Parent.Joint_Distance_Frequency,
1,//%this.Module_ID_Parent.Joint_Distance_Damping_Ratio,
false);*/

Scene_Phyxel_Tender.createDistanceJoint(%Sprite_Phyxel,%Sprite_Connected_Phyxel,"0 0","0 0",
Vector2Distance(%Sprite_Phyxel.Position,%Sprite_Connected_Phyxel.Position),
0,//%this.Joint_Distance_Frequency,
1,//%this.Joint_Distance_Damping_Ratio,
true);

}

}

/**********************************************/

for (%x=0;%x<%this.SimSet_Grid_Phyxels_Tender.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Grid_Phyxels_Tender.getObject(%x);

if (%Sprite_Phyxel.Bool_Is_Squiggler)
{

%Sprite_Phyxel.Schedule_Squiggle=schedule(62,0,"Class_Phyxel::Squiggle",%Sprite_Phyxel,2);

}
else if (!%Sprite_Phyxel.Bool_Is_Phyxel)
{

%Sprite_Phyxel.Visible=false;

%Sprite_Phyxel.Active=false;

}

}

/*************************************************************/
/*Load Rogue Tender Phyxels*/

%FileObject_File.open("./../../../Phyxels/Rogue_Tender.txt","Read");

for (%x=0;%x<%this.SimSet_Grid_Phyxels_Rogue_Tender.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Grid_Phyxels_Rogue_Tender.getObject(%x);

//%Sprite_Phyxel.Size=%FileObject_File.readLine();
%Size=%FileObject_File.readLine();//Not used.

%Sprite_Phyxel.BlendColor=%FileObject_File.readLine();

//%Sprite_Phyxel.Vector_2D_Origin=%FileObject_File.readLine();
%Vector_2D_Origin=%FileObject_File.readLine();//Not used.

//%Sprite_Phyxel.Vector_2D_Original_Size=%FileObject_File.readLine();
%Vector_2D_Original_Size=%FileObject_File.readLine();//Not used.

%Sprite_Phyxel.SceneLayer=%FileObject_File.readLine();

%Sprite_Phyxel.Bool_Is_Phyxel=%FileObject_File.readLine();

%Sprite_Phyxel.Bool_Is_Squiggler=%FileObject_File.readLine();

%Sprite_Phyxel.DefaultDensity=%FileObject_File.readLine();

%Sprite_Phyxel.DefaultRestitution=%FileObject_File.readLine();

%Sprite_Phyxel.Vector_2D_Grid_Position=%FileObject_File.readLine();

%Int_Distance_Joint_Connection_Count=%FileObject_File.readLine();

for (%y=0;%y<%Int_Distance_Joint_Connection_Count;%y++)
{

%ScriptObject_Connected_Phyxel_Grid_Position=new ScriptObject()
{

Vector_2D_Grid_Position=%FileObject_File.readLine();

};

%Sprite_Phyxel.SimSet_Distance_Joint_Connections.add(%ScriptObject_Connected_Phyxel_Grid_Position);

}

%Int_Weld_Joint_Connection_Count=%FileObject_File.readLine();

for (%y=0;%y<%Int_Weld_Joint_Connection_Count;%y++)
{

%ScriptObject_Connected_Phyxel_Grid_Position=new ScriptObject()
{

Vector_2D_Grid_Position=%FileObject_File.readLine();

};

%Sprite_Phyxel.SimSet_Weld_Joint_Connections.add(%ScriptObject_Connected_Phyxel_Grid_Position);

}

}

%FileObject_File.close();

/*Make joint connections*/

for (%x=0;%x<%this.SimSet_Grid_Phyxels_Rogue_Tender.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Grid_Phyxels_Rogue_Tender.getObject(%x);

for (%y=0;%y<%Sprite_Phyxel.SimSet_Distance_Joint_Connections.getCount();%y++)
{

%ScriptObject_Connected_Phyxel_Grid_Position=%Sprite_Phyxel.SimSet_Distance_Joint_Connections.getObject(%y);

%Sprite_Connected_Phyxel=%this.SimSet_Grid_Phyxels_Rogue_Tender.getObject(%ScriptObject_Connected_Phyxel_Grid_Position.Vector_2D_Grid_Position.X+
(%ScriptObject_Connected_Phyxel_Grid_Position.Vector_2D_Grid_Position.Y*%this.Vector_2D_Grid_Size.X));

Scene_Phyxel_Tender.createDistanceJoint(%Sprite_Phyxel,%Sprite_Connected_Phyxel,"0 0","0 0",
Vector2Distance(%Sprite_Phyxel.Position,%Sprite_Connected_Phyxel.Position),
0,//%this.Joint_Distance_Frequency,
1,//%this.Joint_Distance_Damping_Ratio,
false);

}

for (%y=0;%y<%Sprite_Phyxel.SimSet_Weld_Joint_Connections.getCount();%y++)
{

%ScriptObject_Connected_Phyxel_Grid_Position=%Sprite_Phyxel.SimSet_Weld_Joint_Connections.getObject(%y);

%Sprite_Connected_Phyxel=%this.SimSet_Grid_Phyxels_Rogue_Tender.getObject(%ScriptObject_Connected_Phyxel_Grid_Position.Vector_2D_Grid_Position.X+
(%ScriptObject_Connected_Phyxel_Grid_Position.Vector_2D_Grid_Position.Y*%this.Vector_2D_Grid_Size.X));

/*Scene_Phyxel_Tender.createWeldJoint(%Sprite_Phyxel,%Sprite_Connected_Phyxel,
%Sprite_Phyxel.getLocalVector(%Sprite_Connected_Phyxel.Position),
%Sprite_Connected_Phyxel.getLocalVector(%Sprite_Phyxel.Position),
0,//%this.Module_ID_Parent.Joint_Distance_Frequency,
1,//%this.Module_ID_Parent.Joint_Distance_Damping_Ratio,
false);*/

Scene_Phyxel_Tender.createDistanceJoint(%Sprite_Phyxel,%Sprite_Connected_Phyxel,"0 0","0 0",
Vector2Distance(%Sprite_Phyxel.Position,%Sprite_Connected_Phyxel.Position),
0,//%this.Joint_Distance_Frequency,
1,//%this.Joint_Distance_Damping_Ratio,
true);

}

}

/**********************************************/

for (%x=0;%x<%this.SimSet_Grid_Phyxels_Rogue_Tender.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Grid_Phyxels_Rogue_Tender.getObject(%x);

if (%Sprite_Phyxel.Bool_Is_Squiggler)
{

%Sprite_Phyxel.Schedule_Squiggle=schedule(62,0,"Class_Phyxel::Squiggle",%Sprite_Phyxel,0.25);

}
else if (!%Sprite_Phyxel.Bool_Is_Phyxel)
{

%Sprite_Phyxel.Visible=false;

%Sprite_Phyxel.Active=false;

}

}

%Phyxel_Center=%this.SimSet_Grid_Phyxels_Rogue_Tender.getObject(%this.Int_Center_Phyxel_Index);

Window_Phyxel_Tender.mount(%Phyxel_Center,"0 0",0,true,false);

}
