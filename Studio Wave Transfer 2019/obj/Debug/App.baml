   M S B A M L   `   `   `  ����T  PStudio Wave Transfer 2019, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Studio_Wave_Transfer_2019Studio_Wave_Transfer_2019  5      #    Studio_Wave_Transfer_2019.App   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      9local'clr-namespace:Studio_Wave_Transfer_2019     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6K     �� 	Resources  5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType �� 
TargetType ��Name'  !System.Windows.VisualStateManager	   VisualStateGroups%  System.Windows.VisualStateGroup
   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value ��Name �� Triggers P� Property P� Value �� 
TargetName��%	  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 �� 5   
   .�5	      ��  � �� 5
      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5        � ��$ Center=�6;   �� 5!       � ��$ Center=�69   �� 5"       � ��$ 1q�6(   �� 5#       � �� 5$      �� 5%      " ��6&   .R�5&      �� $ border��6!   ���	#FF3E3E40#��z��6I   ���	#FF3E3E40 . 	 5'        5(   "   CommonStates��.
 5)   &     
Normal��62     5*   &   	MouseOver��. 5+   *   �� .��5,   .   �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�6K   $ border��6�   .g�5-   2     $ 0��6F   $ 	#FF13688D��6R   5.   /   5/   +   50   '     51   &   Pressed��. 52   *   �� .��53   .   �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�6K   $ border��6�   .g�54   2     $ 0��6F   $ 	#FF3E3E40��6R   55   /   �� 56   .   $0 *(Panel.Background).(SolidColorBrush.Color)�6K   $ border��6�   .g�57   2     $ 0��6F   $ 	#FF333333��6R   58   /   59   +   5:   '     5;   &   Disabled��62   5<   #   ._�5>      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5?       5@      P� 5A       �@��IsDefaulted . . �5B   "   �� $ border��6@   # � ��6T    � ��5C      P� 5D       �@J�IsMouseOver . 6=   P� 5E       � �� . 6;   P� 5F       � {� .  . �5G   "   �� $ border��6?   8   � ��6S   �� 5H   "   $ border��6@   8   � ��6T   �� 5I   "   $ contentPresenter��6K   8   � ��6i   5J      5L      5N      5O      5P      5S      