   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   C ?mLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:mLibrary.ControlsmLibrary.Controls 5   	   #clr-namespace:mLibrarymLibrary 5   	      mLibrary.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   4controlsclr-namespace:mLibrary.Controls     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:mLibrary     5   	     � Title$  mLibrary��5   	   $	��500��6   $
��1024��6'      AccentColorBrush(   "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�6.      TitleCharacterCasing$ Normal=�6D      TitlebarHeight$ 35��6b      	TitleCaps .  $��15(�6�    � 	Resources 5       �� MergedDictionaries	 �� Source�� 5   
    5      �� 5      $	 /Resources/Icons.xaml?�6%   %    5      
   RightWindowCommands
 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� -   5         ��Name$ btnSearchForMovie��5      .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��20��6    $��20��6+   ��67   ��  �� RelativeSource ��  �� AncestorType$ ButtonL� �� Path$ 
Foreground� J� OpacityMask 5      !� 5        j� Stretch$
 Fill=�6*     appbar_movie_clapper !� Visual# [ 69   5"      �� 5#      $��4 0 0 0q�6    $��Center=�5$      $��Search for movie��5%      5&      5'      5(      ��5,      �� 5-   
    �� ImageSource$ Resources/Images/bg1.png��6   .��50      �  � RowDefinitions 51   
   �� 52      $��* �6   6)    � ColumnDefinitions 55   
   �� 56      $
��405* �6   6.   �� 57      $
��104* �6   .+�5;   
    � -   5          �Name$ MainContainer��5;      $��0��6'   $��0��64     � NavigationUIVisibility$ Hidden=�6D   $��2��6d   �� 5>   
   -   5         ��Name$ panelAboutApp��5>      $��2��6,   .+�5?      �� -   5         ��Name$ lblTitle��5?      $��0��6&   $��0��66   $��Movie library��6C   $��336,70,408,301q�6[   $��42(�6s   $��Segoe UI Semibold)�6�   
������ ���	#FF596173+   %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Lower=�6�   �� 5@      -   5         ��Name$ lblIntro��5@      $��0��6*   $��0��6:   $_��YSearch for movie that you like, create list of your favorites movies and preview it later��6G   $��260,-300,270,100q�6�   $��22(�6�   $��Segoe UI Semilight)�6�   
������ ���	#FF596173$
��Wrap=�6   �� 5A      -   5        $ btnFindMovie��5A      $��Search for movie��6+   $��50��6F   $	��200��6R   $��320,-220,408,301q�6^   
����������	#FF596174$��Segoe UI Semilight)�6�   $��18(�6�   ���	#FF596174$ Normal=�6�   6<  5B      5D      5I      