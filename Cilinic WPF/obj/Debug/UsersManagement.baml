   M S B A M L   `   `   `  ����F  BCilinic WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Cilinic_WPFCilinic_WPF  5      !    Cilinic_WPF.UsersManagement   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Cilinic_WPF     5        N� Title$  UsersManagement��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      $	��250 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid_Admin��5      $��1��6+   $��1��6;     5   
   -   5        $ DataGrid_User��5      $��0��6,   $��1��6<   �� 5   
   $��	User Name��6   $
��Left=�6$   $��	46,62,0,0q�6?   $	��Top=�6R   $��15(�6j   �� 5   
   -   5         ��Name$ ID_txt��5      $��Center=�6#   $��0,68,0,0q�6@    �� TextWrapping$
 Wrap=�6R   $	��Top=�6g   $	��132��6   $��27��6�   .��6�   z�5      V� 5      .~�5      �� �� 5      �� 5      T� 5      5      .��5   )   5       �� 5!   
   -   5        $��Delete��5!      $��Center=�6"   $��	0,140,0,0q�6?   $	��Top=�6R   $��26��6j   $��72��6v   6�   �� 5"   
   -   5         ��Name$ Combo��5"      $��80��6"   $��40��6-   $��1��69   $��10,52,310,108q�6I   .@�5#      �� $��Admin��6   �� 5$      $
��User��6   5%      �� 5&   
   $��Users��6   $��Center=�6    $��Bottom=�6=   �� 5'   
   $��Admins��6   $��Center=�6!   $��Bottom=�6>   $��1��6Y   5(      5)      