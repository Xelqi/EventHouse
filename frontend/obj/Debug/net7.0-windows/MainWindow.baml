   M S B A M L   `   `   `  ����C  ?frontend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:frontendfrontend  5   	       frontend.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:frontend     5   	   [ WMahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  6.   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��380��6)    � AllowsTransparency$
 True��5   	   
������  � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #303030��6'    � Offset$	 0.0Q�67   � 5      $ Fuchsia��6'   $ 1Q�67   5      5      �� 5      $
��Left=�6   .+�5      �� -   5        $��50��5      $��50��6$   ��5      �� 5       .R�5!      .  (MahApps.Metro.IconPacks.PackIconMaterial  E AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowLeft=�69   $��Center=�5"   -   $��Center=�5#   -   
�������$��0,0,0,0q�5%   -   5'      5)      5*      �� 5-      $��Center=�6   .+�5.      �� $��/Images/cheers.png��5/      $��80��50      �� 52      $��Event House��6   $��Light"�53      $��Forte)�54      $��36(�55      $��Center=�56      
�������57      58      �� 5:      $��1��6   .+�5;      �� 	 �� Orientation$	 
Horizontal=�6   .+�5<      �� -   5        $��username��5I      $��
helventica)�5<      $��Light"�5=      $��Usename��5>      $��20(�5?      $��Center=�5@      
�������
������ $��0q�5C      $	��235��5D      $
��Left=�5E      
 J� Opacity$	
 0.8Q�5F      $��25��5G      $��63,0,0,0q�5H      5I        5K      $ Account=�61   $��Center=�5L   1   $��Center=�5M   1   
�������5N   1   5O      �� 5Q      $	��250��5R      $��2��5S      
�������$	
 0.5Q�5U      5V      �� 5Y      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�5Z      G� -   5        $��password��5g   "   $��
helventica)�5Z   "   $��Light"�5[   "    G� Password$ Password��5\   "   $��20(�5]   "   $��Center=�5^   "   
�������
������ $��0q�5a   "   $	��235��5b   "   $
��Left=�5c   "   $	
 0.8Q�5d   "   $��25��5e   "   $��63,0,0,0q�5f   "   5g   "     5i      $ TextboxPassword=�61   $��Center=�5j   1   $��Center=�5k   1   
�������5l   1   5m      �� 5o      $	��250��5p      $��2��5q      
�������$	
 0.5Q�5s      5t      �� 5v      $	 
Horizontal=�6   $��0,50,0,0q�66   .+�5w      �� -   5        $	��100��5w      $��40��5x      $��LOGIN��5y      $��	60,0,60,0q�5z      5{      �� 5}      -   5        $	��100��5}      $��40��5~      $��REGISTER��5      5�      5�      �� 5�      .+�5�      �� -   5        $��
resultTest��5�      $��RESULT��5�      $��Center=�5�      $��Center=�5�      $	��100��5�      $��Center=�5�      
�������$��
Helventica)�5�      $��Light"�5�      $��0,20,0,0q�5�      5�      5�      5�      5�      5�      