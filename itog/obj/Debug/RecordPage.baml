   M S B A M L   `   `   `  ����?  ;itog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:itogitog  5          itog.RecordPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:itog     5      -   5          N� Title$  
RecordPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��7* �6   �� 5      $��1* �6   .+�5   
   �� $��-118,-156,-122,-230q�6   $��pngwing.com (1).png��6-   $
��Fill=�6J   $��2��6Y   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridRecord��5         AutoGenerateColumns .     
IsReadOnly . $��
168,2,10,0q�6Y   $	��348��6�   $	��Top=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Дата занятия��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Date+6`     5      $ Время начала��6%   $
 Auto 6Z    6;   �� *
Time_Start+6i     5      $ Кабинет��6%   $ * 6_    66   �� *Cabinet.Cabinet_Name+6k     5      $ Сотрудник��6%   $ * 6Y    68   �� *User.Surname+6e     5      $ Ребенок��6%   $ * 6V    66   �� *Kid.Surname+6b   5      �� 5!   
   -   5        ���#171717���#F0F0F0$��
Назад��5!   ;   $
��Left=�6K   $��	27,10,0,0q�6f   $��1��6y   $	��Top=�6�   $	��106��6�   $��36��6�   6�   �� 5"   
   -   5        	 ��Name$	 	filterBox��5"      $
��Left=�6%   $��23��6@   $��	27,30,0,0q�6L   
 �� TextWrapping$

 Wrap=�6_   $	��Top=�6s   $	��106��6�   6�   �� 5#   
   $��Введите дату��6   $
��Left=�6'   $��41,4,0,0q�6B   $	��Top=�6T    J� RenderTransformOrigin$ 0.926,0.654&�6l   5%      5&      