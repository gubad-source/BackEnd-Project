   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library.WindowsLibrary.Windows  5   	   %    Library.Windows.CustomersWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Library.Windows     5   	     � Title$  CustomersWindow��5   	   $	��450��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:   ���	#FF5FC37A.��5	      � $��10,0,0,0q�6   .+�5
   
   �� $
��Name��6   $
��Left=�6   $��	32,10,0,0q�6:   $	��Top=�6M   �� 5   
   $��Surname��6   $
��Left=�6"   $��	32,83,0,0q�6=   $	��Top=�6P   �� 5   
   -   5         ��Name$ TxtName��5      $
��Left=�6#   $��	32,41,0,0q�6>   $�� ��6Q    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   �� 5   
   -   5        $ 
TxtSurname��5      $
��Left=�6&   $��
32,114,0,0q�6A   $�� ��6U   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   -   5         ��Name$ 	CreateBtn��5   &   $y�Visible=�6   $��Button��69   $
��Left=�6J   $��
32,165,0,0q�6e   $	��Top=�6y   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgbCustomers��5      $��	279,0,0,0q�6)      CanUserAddRows$ False��6<      AutoGenerateColumns$ False��6S      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Id+  5      $
	 Name��6%   
 63   �� *Name+  5      $	 Surname��6%   
 66   �� *	Surname+5      �� 5   
   -   5        $ 	BtnUpdate��5      $��Update��6$   $
��Left=�65   $��
32,217,0,0q�6P   $	��Top=�6d   $y�Hidden=�6|   6�   �� 5   
   -   5        $ 	BtnDelete��5      $��Delete��6$   $
��Left=�65   $��112,217,0,0q�6P   $	��Top=�6e   $y�Hidden=�6}   6�   5      5      