   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library.WindowsLibrary.Windows  5   	   $    Library.Windows.ManagersWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Library.Windows     5   	   ���	#FF5FC37A  � Title$  ManagersWindow��5   	   $	��450��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69   .��5	      � $��10,0,0,0q�6   .+�5
   
   �� -   5         ��Name$ LblName��5
      $��Name *��6!   $
��Left=�62   $��	51,10,0,0q�6M   $	��Top=�6`   $��30��6x   $��78��6�    J� RenderTransformOrigin$ 0.431,0.186&�6�   �� 5   
   -   5         ��Name$ TxtName��5      $
��Left=�6#   $��	51,55,0,0q�6>   $�� ��6Q    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   �� 5   
   -   5        $ 
LblSurname��5      $��	Surname *��6$   $
��Left=�68   $��	51,78,0,0q�6S   $	��Top=�6f   $��32��6~   $��94��6�   �� 5   
   -   5        $ 
TxtSurname��5      $
��Left=�6&   $��
51,115,0,0q�6A   $�� ��6U   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   -   5         ��Name$ 	BtnCreate��5      $��Create��6$   $
��Left=�65   $��
51,170,0,0q�6P   $	��Top=�6d   $��23��6|   $��94��6�   $ 0.448,-1.857&�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgbManagers��5   Y   $��	320,0,0,0q�6      AutoGenerateColumns$ False��6&   	   CanUserAddRows$	 False��6B   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $ Ad��6%    61   �� *Name+  5      $ Soyad��6%    64   �� *	Surname+5      �� 5   
   -   5        $ 	BtnDelete��5      $��Delete��6$   $
��Left=�65   $��
51,217,0,0q�6P   $	��Top=�6d   $��27��6|   $��94��6�   $y�Hidden=�6�   6�   �� 5   
   -   5        $ 	BtnUpdate��5      $��Update��6$   $
��Left=�65   $��
51,270,0,0q�6P   $	��Top=�6d   $��24��6|   $��94��6�   $y�Hidden=�6�   6�   5      5      