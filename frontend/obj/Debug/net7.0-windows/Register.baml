   M S B A M L   `   `   `  ����C  ?frontend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:frontendfrontend  5   	       frontend.Register   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:frontend     5   	   [ WMahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  6.   -   5          � AllowsTransparency$
  True��5   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � Title$ Register��5
   	   $	��550��6   $	��380��6'   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #303030��6'    � Offset$	 0.0Q�67   � 5      $ Fuchsia��6'   $ 1Q�67   5      5      �� 5      $
��Left=�6   .+�5      �� -   5        $��50��5      $��50��6$   ��5      �� 5       .R�5!      .  (MahApps.Metro.IconPacks.PackIconMaterial  E AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowLeft=�69   $��Center=�5"   -   $��Center=�5#   -   
�������$��0,0,0,0q�5%   -   5'      5)      5*      �� 5,      $��Center=�6   .+�5-      �� $��/Images/cheers.png��5.      $��80��5/      �� 51      $��Event House��6   $��Light"�52      $��Forte)�53      $��36(�54      $��Center=�55      
�������56      57      �� 59      $��1��6   .+�5:      �� 	 �� Orientation$	 
Horizontal=�6   .+�5;      �� -   5        $��txtusername��5H      $��
helventica)�5;      $��Light"�5<      $��Usename��5=      $��20(�5>      $��Center=�5?      
�������
������ $��0q�5B      $	��235��5C      $
��Left=�5D      
 J� Opacity$	
 0.8Q�5E      $��25��5F      $��63,0,0,0q�5G      5H        5K      $ Account=�61   $��Center=�5L   1   $��Center=�5M   1   
�������5N   1   5O      �� 5Q      $	��250��5R      $��2��5S      
�������$	
 0.5Q�5U      5V      �� 5Z      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�5[      G� -   5        $��txtpassword��5h   "   $��
helventica)�5[   "   $��Light"�5\   "    G� Password$ Password��5]   "   $��20(�5^   "   $��Center=�5_   "   
�������
������ $��0q�5b   "   $	��235��5c   "   $
��Left=�5d   "   $	
 0.8Q�5e   "   $��25��5f   "   $��63,0,0,0q�5g   "   5h   "     5j      $ TextboxPassword=�61   $��Center=�5k   1   $��Center=�5l   1   
�������5m   1   5n      �� 5p      $	��250��5q      $��2��5r      
�������$	
 0.5Q�5t      5u      �� 5w      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�5x      �� -   5        $��txtfirstname��5�      $��
helventica)�5x      $��Light"�5y      $��	Firstname��5z      $��20(�5{      $��Center=�5|      
�������
������ $��0q�5      $	��235��5�      $
��Left=�5�      $	
 0.8Q�5�      $��25��5�      $��63,0,0,0q�5�      5�        5�      $ Account=�61   $��Center=�5�   1   $��Center=�5�   1   
�������5�   1   5�      �� 5�      $	��250��5�      $��2��5�      
�������$	
 0.5Q�5�      5�      �� 5�      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�5�      �� -   5        $��txtlastname��5�      $��
helventica)�5�      $��Light"�5�      $��Lastname��5�      $��20(�5�      $��Center=�5�      
�������
������ $��0q�5�      $	��235��5�      $
��Left=�5�      $	
 0.8Q�5�      $��25��5�      $��63,0,0,0q�5�      5�        5�      $ Account=�61   $��Center=�5�   1   $��Center=�5�   1   
�������5�   1   5�      �� 5�      $	��250��5�      $��2��5�      
�������$	
 0.5Q�5�      5�      �� 5�      $	 
Horizontal=�6   $��80,20,20,80q�5�      $��Center=�5�      .+�5�      �� -   5        $	��110��5�      $��40��5�      $��	0,20,45,0q�5�      $��CREATE ACCOUNT��5�      5�      5�      5�      5�      5�      5�      