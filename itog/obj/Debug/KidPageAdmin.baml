   M S B A M L   `   `   `  ����?  ;itog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:itogitog  5          itog.KidPageAdmin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:itog     5      -   5          N� Title$  KidPageAdmin��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��7* �6   �� 5      $��1* �6   .+�5   
   �� $��-118,-156,-122,-230q�6   $��pngwing.com (1).png��6-   $
��Fill=�6J   $��2��6Y   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridKid��5         AutoGenerateColumns .     
IsReadOnly . $��
168,2,10,0q�6V   $	��348��6�   $	��Top=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	Surname+6^     5      $ Имя��6%   $ * 6K    62   �� *Name+6W     5      $ Отчество��6%   $ * 6V    67   �� *
Middlename+6b     5      $ День рождения��6%   $
 Auto 6Y    6<   �� *
Birthday+6h     5      $% Город проживания��6%   $ * 6c    6?   �� *City1.City_Name+6o   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   	   CellTemplate	 5      �� 5      .R�5      �� $��BtnEdit��64   -   5        $��Ред.��5   %   6[   5      5      5$      �� 5%   
   -   5        $��Добавить��5%      $
��Left=�6$   $��	27,88,0,0q�6?   $	��Top=�6R   $	��106��6j   6v   �� 5&   
   -   5        $��Удалить��5&      $
��Left=�6#   $��
27,131,0,0q�6>   $	��Top=�6R   $	��106��6j   6v   �� 5'   
   -   5        
 ��Name$
 	filterBox��5'      $
��Left=�6%   $��23��6@   $��	27,30,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��106��6�   6�   �� 5(   
   -   5        ���#171717���#F0F0F0$��
Назад��5(   ;   $
��Left=�6K   $��	27,10,0,0q�6f   $��1��6y   $	��Top=�6�   $	��106��6�   $��36��6�   6�   �� 5)   
   $#��Введите фамилию��6   $
��Left=�6*   $��25,4,0,0q�6E   $	��Top=�6W    J� RenderTransformOrigin$ 0.926,0.654&�6o   5+      5,      