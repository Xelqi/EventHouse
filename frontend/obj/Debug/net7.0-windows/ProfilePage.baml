   M S B A M L   `   `   `  ����C  ?frontend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:frontendfrontend  5   	       frontend.ProfilePage   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:frontend     5   	   [ WMahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  6.   -   5          � Title$  ProfilePage��5   	   $	��550��6   $	��380��6*    � AllowsTransparency$
 True��5   	   
������  � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��1��6'   ��5      �� 5      .��5      �  � Color$ #303030��6'    � Offset$	 0.0Q�67   � 5      $ Fuchsia��6'   $ 1Q�67   5      5      �� 5      $
��Left=�6   .+�5      �� -   5        $��50��5      $��50��6$   ��5      �� 5      .R�5      .  (MahApps.Metro.IconPacks.PackIconMaterial  E AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowLeft=�69   $��Center=�5    -   $��Center=�5!   -   
�������$��0,0,0,0q�5#   -   5%      5'      5(      �� 5+      $	��Top=�6   $��0,50,0,0q�5,      .+�5-      �� $��/Images/cheers.png��5.      $��80��5/      �� 51      $��Event House��6   $��Light"�52      $��Forte)�53      $��36(�54      $��Center=�55      
�������56      �� 58      	 �� Orientation$	 
Horizontal=�6   .+�59      �� -   5        $��username��5F      $��
helventica)�59      $��Light"�5:      $��20(�5<      $��Center=�5=      
�������
������ $��0q�5@      $	��235��5A      $
��Left=�5B      
 J� Opacity$	
 0.8Q�5C      $��25��5D      $��63,0,0,0q�5E      ��5;      ��  �� Path$ Username�5F        5H      $ Account=�61   $��Center=�5I   1   $��Center=�5J   1   
�������5K   1   5L      �� 5N      $	��250��5O      $��2��5P      
�������$	
 0.5Q�5R      5S      �� 5T      $	 
Horizontal=�6   $��0,10,0,0q�5U      .+�5V      �� -   5        $��Password��5c      $��
helventica)�5V      $��Light"�5W      $��20(�5Y      $��Center=�5Z      
�������
������ $��0q�5]      $	��235��5^      $
��Left=�5_      $	
 0.8Q�5`      $��25��5a      $��63,0,0,0q�5b      ��5X      �� $ Password�5c        5e      $ TextboxPassword=�61   $��Center=�5f   1   $��Center=�5g   1   
�������5h   1   5i      �� 5k      $	��250��5l      $��2��5m      
�������$	
 0.5Q�5o      5p      �� 5r      $	 
Horizontal=�6   $��0,10,0,0q�5s      .+�5t      �� -   5        $��	Firstname��5�      $��
helventica)�5t      $��Light"�5u      $��20(�5w      $��Center=�5x      
�������
������ $��0q�5{      $	��235��5|      $
��Left=�5}      $	
 0.8Q�5~      $��25��5      $��63,0,0,0q�5�      ��5v      �� $ Fname�5�        5�      $ Feather=�61   $��Center=�5�   1   $��Center=�5�   1   
�������5�   1   5�      �� 5�      $	��250��5�      $��2��5�      
�������$	
 0.5Q�5�      5�      �� 5�      $	 
Horizontal=�6   $��0,10,0,0q�5�      .+�5�      �� -   5        $��Lastname��5�      $��
helventica)�5�      $��Light"�5�      $��20(�5�      $��Center=�5�      
�������
������ $��0q�5�      $	��235��5�      $
��Left=�5�      $	
 0.8Q�5�      $��25��5�      $��63,0,0,0q�5�      ��5�      �� $ Lname�5�        5�      $ Feather=�61   $��Center=�5�   1   $��Center=�5�   1   
�������5�   1   5�      �� 5�      $	��250��5�      $��2��5�      
�������$	
 0.5Q�5�      5�      �� 5�      $	 
Horizontal=�6   .+�5�      �� $��Your Events��6    $��Light"�5�      $��Forte)�5�      $��15(�5�      $��Center=�5�      
�������$��
160,10,0,5q�5�      $��Center=�5�      �� 5�      -   5        $��20��5�      $��20��5�      $��Right=�5�      $��
100,0,20,5q�5�      ��5�      �� 5�      .R�5�   "     $ Delete=�6=   $��Center=�5�   -   $��Right=�5�   -   
�������$��0,0,0,0q�5�   -   5�      5�      5�      �� 5�      $��20, 0, 20, 20q�6   .+�5�      �� $��Hidden=�6#   .��5�      �� $	��100��6#   .@�5�      �� $��hi��6+   �� 5�      $��hi��6+   �� 5�      $��hi��6+   �� 5�      $��hi��6+   �� 5�      $��hi��6+   5�      5�      �� 5�      $	 
Horizontal=�6!   $��0,30,0,0q�5�   !   .+�5�      �� -   5        $	��100��5�   !   $��40��5�      $��Update��5�      $��	40,0,60,0q�5�      5�      �� 5�      -	   5        $	��100��5�   !   $��40��5�      $��Delete��5�      5�      5�      5�      5�      5�      5�      5�      