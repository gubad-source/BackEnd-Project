   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library.WindowsLibrary.Windows  5   	   !    Library.Windows.BooksWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Library.Windows     5   	     � Title$  BooksWindow��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66   ���	#FF5FC37A.��5	      � .+�5
   
   �� -   5         ��Name$ 	CreateBtn��5
      $y�Visible=�6$   $��Button��69   $
��Left=�6J   $��
46,368,0,0q�6e   $	��Top=�6y    J� RenderTransformOrigin$ 
0.38,12.99&�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgbBooks��5      $��	271,0,0,0q�6%      AutoGenerateColumns$ False��68      CanUserAddRows$ False��6T      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *Id+  5      $ Ad��6%   	 61   �� *Name+  5      $ Qiymet��6%   	 65   �� *Price+  5      $	 Ref��6%   	 62   �� *Shelf+  5      $
 Skaf��6%   	 63   �� *
Bookcase+5      �� 5   
   -   5        
 ��Name$
 TxtName��5      $
��Left=�6#   $��	48,68,0,0q�6>   $�� ��6Q    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   �� 5   
   -   5        $
 TxtPrice��5      $
��Left=�6$   $��
46,147,0,0q�6?   $�� ��6S   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5   
   $��Kitabin Adi��6   $
��Left=�6&   $��	46,10,0,0q�6A   $	��Top=�6T   �� 5   
   $��Kitabin Qiymeti��6   $
��Left=�6*   $��	48,91,0,0q�6E   $	��Top=�6X   �� 5   
   $��Saxlandigi Ref��6   $
��Left=�6)   $��
48,170,0,0q�6D   $	��Top=�6X   �� 5   
   $��Saxlandigi Skaf��6   $
��Left=�6*   $��
48,258,0,0q�6E   $	��Top=�6Y   �� 5   
   -   5         ��Name$ CmbShelf��5      $
��Left=�6%   $��
48,217,0,0q�6@   $	��Top=�6T   $	��120��6l    �� DisplayMemberPath$
 Name��5       �� SelectedValuePath$ Id��5      ��5   x   ��  �� Path$ Shelf� �� SelectedValue 5      �� $ Shelf��� 5    
   -   5        $ CmbBookcase��5       $
��Left=�6(   $��
46,289,0,0q�6C   $	��Top=�6W   $	��120��6o   $
 Name��5!      $ Id��5"      ��5    {   �� $ Bookcase� 5#      �� $ Bookcase��� 5$   
   -   5        $ 	DeleteBtn��5$   %   $y�Hidden=�6   $��Delete��68   $
��Left=�6I   $��108,368,0,0q�6d   $	��Top=�6y   6�   �� 5%   
   -   5        $ 	UpdateBtn��5%   %   $y�Hidden=�6   $��Update��68   $
��Left=�6I   $��185,368,0,0q�6d   $	��Top=�6y   6�   5'      5(      