function Class_Phyxel::Squiggle(%this,%Float_Force)
{

if (!isObject(%this)){return;}

%this.setLinearVelocityPolar(getRandom(0,360),%Float_Force);

%this.Schedule_Squiggle=schedule(62,0,"Class_Phyxel::Squiggle",%this,%Float_Force);

}
