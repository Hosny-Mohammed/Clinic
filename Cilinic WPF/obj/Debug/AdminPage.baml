   M S B A M L   `   `   `  ����F  BCilinic WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Cilinic_WPFCilinic_WPF  5          Cilinic_WPF.AdminPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Cilinic_WPF     5        N� Title$  	AdminPage��5	      .��5      � 
��� �|� � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	Data_Grid��5   %   
��� ���$��0��68   $��1��6H   �� 5   
   -   5         ��Name$ 
Refrsh_btn��5   %   
��� ���$��Refresh��69   $
��Left=�6K   $��	74,26,0,0q�6f   $	��Top=�6y   $��39��6�   $	��104��6�   6�   �� 5   
   -   5        $ 
Update_btn��5   %   
��� ���$��Update��6:   $
��Left=�6K   $��
74,145,0,0q�6f   $	��Top=�6z   $��40��6�   $	��104��6�   6�   �� 5   
   -   5        $ 
Delete_btn��5   (   
��� E��$��Delete��6=   $
��Left=�6N   $��553,145,0,0q�6i   $	��Top=�6~   $��40��6�   $��89��6�   6�   �� 5   
   -   5         ��Name$ ID_txt��5      $
��Left=�6#   $��
280,37,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��120��6~   $��28��6�   �� 5   
   -   5        $ Date_txt��5      $
��Left=�6$   $��	XXX-YY-NN��6?   $��
522,37,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   $��28��6�   �� 5   
   -   5        $ DocName_txt��5      $
��Left=�6'   $��
522,84,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   $��28��6�   �� 5   
   $��ID��6   $
��Left=�6   $��
249,38,0,0q�68   $	��Top=�6L   �� 5   
   $
��Date��6   $
��Left=�6   $��
481,35,0,0q�6:   $	��Top=�6N   �� 5   
   $��Doctor Name��6   $
��Left=�6&   $��
433,84,0,0q�6A   $	��Top=�6U   �� 5   
   -   5        $ 
Search_btn��5   %   
���� ��$��Search��6:   $
��Left=�6K   $��302,145,0,0q�6f   $	��Top=�6{   $��98��6�   $��40��6�   6�   5      5      