   M S B A M L   `   `   `  ����B  >MyRobot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MyRobotMyRobot  5   	   7 clr-namespace:MyRobot.DataModelsMyRobot.DataModels  5   	       MyRobot.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   'localclr-namespace:MyRobot     5   	   .l clr-namespace:MyRobot.DataModels     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5      !   MyRobot.MainWindowViewModel  5	   
    � 	Resources 5      '   !MyRobot.PlaceDataTemplateSelector   placeDataTemplateSelector   RobotWithNeck �� Left
 �� Top	 �� X1	 �� Y1	 �� X2		 �� Y2
   RobotWithoutNeck��%�
  &	          5   
    5      �� 5      .R�5      � .+�5      �� .+�5      �� 
���   � 6(   �� *RobotHead.X+ 6L   �� *RobotHead.Y+��5      �� *RobotHead.Width+��6?   �� *RobotHead.Height+6c   5      �� 5      
���  ��$��4��5   ,    5      �� *RobotNeck.StartX+ 6?   �� *RobotNeck.StartY+ 6_   �� *RobotNeck.EndX+	 6}   �� *RobotNeck.EndY+5   ,   �� 5      .+�5      �� 
���   � 6(   �� *RobotStomach.X+ 6O   �� *RobotStomach.Y+��6u   �� *RobotStomach.Width+��5   $   �� *RobotStomach.Height+6K   5      �� 5      
���  ��$��4��5   N    5      �� *RobotLeftHand.StartX+ 6C   �� *RobotLeftHand.StartY+ 6g   �� *RobotLeftHand.EndX+	 5      �� *RobotLeftHand.EndY+6N   �� 5      
���  ��$��4��5    O    5      �� *RobotRightHand.StartX+ 6D   �� *RobotRightHand.StartY+ 6i   �� *RobotRightHand.EndX+	 5       �� *RobotRightHand.EndY+6O   �� 5"      
���  ��$��4��5#   M    5"      �� *RobotLeftLeg.StartX+ 6B   �� *RobotLeftLeg.StartY+ 6e   �� *RobotLeftLeg.EndX+	 5#      �� *RobotLeftLeg.EndY+6M   �� 5$      
���  ��$��4��5%   N    5$      �� *RobotRightLeg.StartX+ 6C   �� *RobotRightLeg.StartY+ 6g   �� *RobotRightLeg.EndX+	 5%      �� *RobotRightLeg.EndY+6N   5&      5'      
 5*      �� 5+      .R�5,      � .+�5-      �� .+�5.      �� 
���   � 6(   �� *RobotHead.X+ 6L   �� *RobotHead.Y+��5/      �� *RobotHead.Width+��6?   �� *RobotHead.Height+6c   50      �� 54      .+�55      �� 
���   � 6(   �� *RobotStomach.X+ 6O   �� *RobotStomach.Y+��6u   �� *RobotStomach.Width+��56   $   �� *RobotStomach.Height+6K   57      �� 59      
���  ��$��4��5:   N    59      �� *RobotLeftHand.StartX+ 6C   �� *RobotLeftHand.StartY+ 6g   �� *RobotLeftHand.EndX+	 5:      �� *RobotLeftHand.EndY+6N   �� 5;      
���  ��$��4��5<   O    5;      �� *RobotRightHand.StartX+ 6D   �� *RobotRightHand.StartY+ 6i   �� *RobotRightHand.EndX+	 5<      �� *RobotRightHand.EndY+6O   �� 5>      
���  ��$��4��5?   M    5>      �� *RobotLeftLeg.StartX+ 6B   �� *RobotLeftLeg.StartY+ 6e   �� *RobotLeftLeg.EndX+	 5?      �� *RobotLeftLeg.EndY+6M   �� 5@      
���  ��$��4��5A   N    5@      �� *RobotRightLeg.StartX+ 6C   �� *RobotRightLeg.StartY+ 6g   �� *RobotRightLeg.EndX+	 5A      �� *RobotRightLeg.EndY+6N   5B      5C      5E      5F      .��5G      � .+�5V   
   �� $��Move Forward��6   $��	0,0,200,0q�6O   $��Right=�6b   $	��Top=�6~   ��6(   �� *MoveForwardCommand+6~   �� 5W   
   $��Move Backward��6   $��	0,0,100,0q�6Q   $��Right=�6d   $	��Top=�6�   ��6)   �� *MoveBackwardCommand+6�   �� 5X   
   $��Rajnikant Mode��6   $��Right=�6N   $	��Top=�6j   ��6*   �� *MultiplyCommand+6j   �� 5Z   
   $��0,30,0,0q�6   #��[  5[      ��5Z   )   �� *Robots+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5\      �� 5]      .R�5^      �� |�.  $��Hidden=�65   $��Visible=�6Z   .��5_      ��  J� SnapsToDevicePixels# z 6)   5`      5a      ��5c      �� 5d      .R�5e      �� $
��Left=�6   $	��Top=�68   $	��320��5f   L   ��6.   �� *CanvasWidth+6L   5g      5m      5o      5p      