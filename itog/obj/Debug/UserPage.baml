   M S B A M L   `   `   `  ����?  ;itog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:itogitog  5          itog.UserPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:itog     5      -   5          N� Title$  UserPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��7* �6   �� 5      $��1* �6   .+�5      �� $��-118,-156,-122,-230q�6   $��pngwing.com (1).png��6%   $
��Fill=�6B   $��2��6Q   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridUser��5         AutoGenerateColumns .     
IsReadOnly . $��
168,2,10,0q�6W   $	��348��6�   $	��Top=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	Surname+6^     5      $ Имя��6%   $ * 6K    62   �� *Name+6W     5      $ Отчество��6%   $ * 6V    67   �� *
Middlename+6b     5      $ Стаж (лет)��6%   $ * 6X    69   �� *
Experience+6d     5      $ Образование��6%   $ * 6h    6:   �� *Education1.Education_Name+6t     5      $  Классификация��6%   $ * 6t    6<   �� *%#Classification1.Classification_Name+6�   5      �� 5   
   -   5        	 ��Name$	 	filterBox��5      $
��Left=�6%   $��23��6@   $��	27,30,0,0q�6L   
 �� TextWrapping$

 Wrap=�6_   $	��Top=�6s   $	��106��6�   6�   �� 5   
   -   5        ���#171717���#F0F0F0$��
Назад��5   ;   $
��Left=�6K   $��	27,10,0,0q�6f   $��1��6y   $	��Top=�6�   $	��106��6�   $��36��6�   6�   �� 5    
   $#��Введите фамилию��6   $
��Left=�6*   $��25,4,0,0q�6E   $	��Top=�6W    J� RenderTransformOrigin$ 0.926,0.654&�6o   5"      5#      