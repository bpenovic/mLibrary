   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      C ?mLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:mLibrary.ControlsmLibrary.Controls 5      /clr-namespace:mLibrary.PagesmLibrary.Pages 5      #   mLibrary.Pages.SearchForMovie   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      4controlsclr-namespace:mLibrary.Controls     5      .localclr-namespace:mLibrary.Pages     5      $	��500��5
      $
��1024��6     � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Resources/Icons.xaml?�6%   %    5      ��5      �� 5   
    �� ImageSource$&  ../Resources/Images/bg_arrow.png��6   .��5      � ���	#FF596173 � RowDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 	lblSearch��5      $��Search for movie...��6#   ���#eee$��21(�6S   $��Segoe UI Semilight)�6a   $��50��6�   $	��200��6�   $��0,0,550,300q�6�   �� 5    
   -   5         ��Name$ txbMovieName��5       *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Name of movie��6(   $��0,5,0,0q�6Y   $��40��6k   $	��350��6w      ClearTextButton . 
������ ���#eee$��0,0,0,1q�6�   $��	0,0,0,330q�6�   $��19(�6
  ���#eee6  �� 5!   
   -   5        	 ��Name$	 	btnSearch��5!      $��Search��6$   $��40��65   $	��150��6A   $��570,-30,0,301q�6M   ���#eee���	#FF596174$��Segoe UI Semilight)�6�   $��18(�6�   ���#eee$��2q�6�   +   %MahApps.Metro.Controls.ControlsHelper
   ContentCharacterCasing$
 Normal=�6�   63  �� 5"   
   -   5        $ lblList��5"      $��List of movies...��6!   ���#eee$��22(�6O   $��Segoe UI Semilight)�6]   $��50��6}   $	��900��6�   $��0,150,40,300q�6�   ���#eee$��0,0,0,1q�6�   �� 5'   
   -   5         ��Name$ viewer��5'      $��0��6'   $��Hidden=�64   $��Visible=�6Y   $��	30,0,30,0q�6�   $	��250��6�   $
��1024��6�   $��	0,200,0,0q�6�   
������ $��0,2,0,0q�6�    � Cursor$ ScrollWE��6  .��5(      �� -   5         ��Name$ MovieItemContainer��5(       �� Orientation$ 
Horizontal=�65   $	��230��6N   ��6[   �� *ActualWidth+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ WindowL�.+�5*      �� $	��250��6   $
��1024��6(   
������ 
������ ��6Q   �� *MovieInfoList+ �� " >���5,      �� 5-      .R�5.      $�  $� Orientation$ 
Horizontal=�65   
������ 6N   5/      ��52      �� 53      .R�54      !  mLibrary.Controls.MovieItem  $	��230��61   $	��230��6>   $��5,0,5,0q�6J   55      ��58      �� 59       �� Triggers 5:      P� 5;   "    P� Property �@J�IsMouseOver P� Value . . �5<   &   ��  �� Property � �� �� Value
 ���� 6K   5=   #   5?      5B      5C      5D      5F      5G      