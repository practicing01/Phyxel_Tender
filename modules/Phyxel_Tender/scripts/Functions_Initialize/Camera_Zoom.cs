function Class_Phyxel_Tender_Input_Controller::onMouseWheelUp(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Phyxel_Tender.setCameraZoom(Window_Phyxel_Tender.getCameraZoom()+$pref::Phyxel_Tender::cameraMouseZoomRate);

}

function Class_Phyxel_Tender_Input_Controller::onMouseWheelDown(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Phyxel_Tender.setCameraZoom(Window_Phyxel_Tender.getCameraZoom()-$pref::Phyxel_Tender::cameraMouseZoomRate);

}
