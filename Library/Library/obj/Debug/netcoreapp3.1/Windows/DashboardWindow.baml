   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library.WindowsLibrary.Windows  5   	   %    Library.Windows.DashboardWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Library.Windows     5   	     � Title$  DashboardWindow��5   	   $	��450��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:   ���	#FF5FC37A.��5	      � .+�5
   
   �� -   5         ��Name$ BooksBtn��5
      $��Books��6#   $
��Left=�63   $��
73,352,0,0q�6N   $	��Top=�6b   6z   �� 5   
   -   5        $ ManagersBtn��5      $��Managers��6&   $
��Left=�69   $��188,352,0,0q�6T   $	��Top=�6i    J� RenderTransformOrigin$ -0.66,1.198&�6�   6�   �� 5   
   -   5        $ CustomersBtn��5      $��	Customers��6'   $
��Left=�6;   $��309,352,0,0q�6V   $	��Top=�6k   6�   �� 5   
   -   5        $ 
ReportsBtn��5      $��Reports��6%   $
��Left=�67   $��441,352,0,0q�6R   $	��Top=�6g   $ 
0.271,2.57&�6   �� 5   
   $��Customer��6   $
��Left=�6#   $��	55,10,0,0q�6>   $	��Top=�6Q   �� 5   
   $
��Book��6   $
��Left=�6   $��	55,84,0,0q�6:   $	��Top=�6M   �� 5   
   -   5         ��Name$ CmbCustomers��5      $
��Left=�6)   $��	55,41,0,0q�6D   $	��Top=�6W   $	��120��6o    �� DisplayMemberPath$
 Name��5       �� SelectedValuePath$ Id��5      ��5   |   ��  �� Path$ Customer� �� SelectedValue 5      �� $ Customer��� 5   
   -   5        $ CmbBooks��5      $
��Left=�6%   $��
55,114,0,0q�6@   $	��Top=�6T   $	��120��6l   $
 Name��5      $ Id��5      ��5   y   �� $
 Book� 5      �� $
 Book�(  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 DtpDeadLine��5      $
��Left=�6*   $��
55,173,0,0q�6E   $	��Top=�6Y   �� 5   
   $��DeadLine��6   $
��Left=�6#   $��
55,142,0,0q�6>   $	��Top=�6R   �� 5   
   -   5        $ OrderBtn��5      $��Order��6#   $
��Left=�63   $��
51,217,0,0q�6N   $	��Top=�6b   6z   �� 5   
   $��Customer Return��6   $
��Left=�6*   $��
285,10,0,0q�6E   $	��Top=�6Y   �� 5   
   -	   5        $ CustomerReturnBtn��5      $��	ReturnBtn��6,   $
��Left=�6@   $��
285,84,0,0q�6[   $	��Top=�6o   6�   �� 5   
   -
   5        $ CmbCustomerReturn��5      $
��Left=�6.   $��
285,47,0,0q�6I   $	��Top=�6]   $	��120��6u   $
 Name��5      $ Id��5       ��5   �   �� $ Customer� 5!      �� $ Customer��� 5"   
   -   5        
 ��Name$
 ListBox��5"      $��285,125,281,156q�6#   5$      5%      