   M S B A M L   `   `   `  ����T  PStudio Wave Transfer 2019, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Studio_Wave_Transfer_2019Studio_Wave_Transfer_2019  5   	   *    $Studio_Wave_Transfer_2019.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Studio_Wave_Transfer_2019     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $	��720��5      $
��1024��6'     � 
ResizeMode$  NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J    � WindowStyle$
 None=�6o   
�������$��0,0,5,0q�6�    � 	Resources 5
         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose  NavigationPage t� From	 g� DecelerationRatio	
 t� To g� Duration W� From	 W� To��%�  &	        &	 �     &	 �    �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.2��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.2��6'   $ 60Q�69   5      5      �� 5   
   .��5      t� $ Margin�6!   $ 200 200 -150 -150X�6D   $	 .8Q�6]   $
 50 50 50 50X�6t   $ 0:0:0.5D�6�   $ 	MainFrame��6�   W� 5      $ Opacity�6   $ 0X�6B   $ 1X�6K   $	 .1Q�6R   $ 0:0:0.5D�6i   $ 	MainFrame��6|   5      5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      Opacity$	 0.5Q�6    � Triggers 5       :� 5!   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ OpenMenuButton��66   .[�5"      �� #��[  6   5#      :� 5$   
   $ ButtonBase.Click��6   $ CloseMenuButton��66   .[�5%      �� #��[ 6   5&      :� 5'   
   $ GotFocus��6   $ AboutMenuButton��6.   .[�5(      �� #��[ 6   5)      :� 5*   
   $ GotFocus��6   $ MainMenuButton��6.   .[�5+      �� #��[ 6   5,      :� 5-   
   $ GotFocus��6   $ FoldersMenuButton��6.   .[�5.      �� #��[ 6   5/      :� 50   
   $ GotFocus��6   $ SettingMenuButton��6.   .[�51      �� #��[ 6   52      :� 53   
   $ GotFocus��6   $ DictionaryMenuButton��6.   .[�54      �� #��[ 6   55      .��59      �  J� RenderTransformOrigin$ 0.491,0.325&�6   ��5:   
   �� 5;       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5<      �  � Color$ Black��6    � Offset$ 0.993Q�6-   � 5=      $ 	#FF5D5D5D��6   5>      .+�5@   
   ]� .+�5B      � $��60��6   $	��Top=�6   ���	#FF252526$	��Top=�6N    5C        5D      .+�5F      �� $��Studio Wave Transfer 2019��6   ���	#FF13688D$��Center=�6T   $��Center=�6q   $��22(�6�   �� 5G      $��Center=�6    �� Orientation$ 
Horizontal=�68   $��Right=�6Q   .+�5H      '  !MaterialDesignThemes.Wpf.PopupBox  $��10q�6.      PlacementMode$ BottomAndAlignRightEdges=�6:      	StaysOpen .  ���	#FF13688D   PopupContent. 5I      �� 
�������$	��150��68   .+�5J      �� $��Minimize��6%   ���	#FF13688D68   �� 5K      -   5         ��Name$ LogoutPopUpButton��5K   %   ���	#FF13688D$��Close��6W   6g   5L      5M      5N      5O      �� 5P      $ 
Horizontal=�6   $
��Left=�62   $��	0,-60,0,0q�6H   .+�5Q      � -   5         �Name$ GridMenu��5Q      $��60��6)   $
��Left=�64   ���	#FF1F1F1F$��0,60,0,0q�6f   .+�5R      �� .+�5S      � $��60��6   ��6+   Z� .+�5T      �� -   5        $ CloseMenuButton��5T   %   $��60��6>   $��60��6I   $	��Top=�6�   $��Right=�6�   $y�	Collapsed=�6�   ��6U   Z� ��6k   Z� .��5U   "   '  !MaterialDesignThemes.Wpf.PackIcon  ���	#FF13688D�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowLeft=�6Q   $��25��6b   $��25��6m   5V      �� 5W      -   5        $ OpenMenuButton��5W   %   $��60��6=   $��60��6H   $	��Top=�6�   $��Right=�6�   ��6T   Z� ��6j   Z� .��5X   "     ���	#FF13688D$
 Menu=�6Q   $��25��6]   $��25��6h   5Y      5Z      �� 5[      ���	#FF13688D��. $��Disabled=�6�   $��Disabled=�6�   ��6#   Z� ��69   Z� .@�5\      �� -   5          ��Name$  MainMenuButton��5\   +   $��60��6f   .��5]   "   �� $ 
Horizontal=�6-   .+�5^   &     $
 Home=�6>   ���	#FF13688D$��25��6a   $��25��6l   $��10q�6x   $��Center=�6�   �� 5_   &   $��	Principal��60   ���	#FF13688D$��Center=�6X   $��20 10q�6s   5`   #   5a      �� 5b      -   5        $  FoldersMenuButton��5b   +   $��60��6l   .��5c   "   �� $ 
Horizontal=�6-   .+�5d   &     $ Settings=�6>   $��25��6N   $��25��6Y   $��10q�6e   $��Center=�6q   �� 5e   &   $��Configuração��60   $��Center=�6D   $��20 10q�6_   5f   #   5g      �� 5h      -   5        $  SettingMenuButton��5h   +   $��60��6l   .��5i   "   �� $ 
Horizontal=�6-   .+�5j   &     $ 
FolderOpen=�6>   $��25��6P   $��25��6[   $��10q�6g   $��Center=�6s   �� 5k   &   $��Verificação de arquivos��60   $��Center=�6O   $��20 10q�6j   5l   #   5m      �� 5n      -	   5        $  DictionaryMenuButton��5n   +   $��60��6r   .��5o   "   �� $ 
Horizontal=�6-   .+�5p   &     $ 
Dictionary=�6>   $��25��6P   $��25��6[   $��10q�6g   $��Center=�6s   �� 5q   &   $��Dicionário��60   $��Center=�6B   $��20 10q�6]   5r   #   5s      �� 5t      -
   5        $  AboutMenuButton��5t   ,   $��60��6i   .��5u   "   �� $ 
Horizontal=�6-   .+�5v   &     $ FileDocument=�6>   $��25��6R   $��25��6]   $��10q�6i   $��Center=�6u   �� 5w   &   $��Sobre��60   $��Center=�6=   $��20 10q�6X   5x   #   5y      5z      5{      5|      5}       � 5~      -   5        !  �Name$! 	MainFrame��5~      "  � Source$" 
Page2.xaml?�6'   $��50,50,50,50q�6;   #  � NavigationUIVisibility$# Hidden=�6P    5        5�      $   
BlurRadius$$ 3Q�6'   5�      5�      5�      5�      