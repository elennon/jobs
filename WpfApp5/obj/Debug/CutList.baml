   M S B A M L   `   `   `  ����B  >WpfApp5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp5WpfApp5  5   	       WpfApp5.CutList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp5     5   	     � Title$  CutList��5   	   $	��800��6   $	��800��6&   .��5	      � .+�5
   
   ]� .+�5      ]� $	��Top=�6   .+�5      �� $��Cutting List��6   $��20(�60   $��30q�6>   6M   5      ]� 5      
�������.+�5      �� $
��Left=�6   .+�5      �� 
full width6,   �� 5      -   5         ��Name$ width��5   9   $
��Left=�6   $
��30px��5      $��100px��5      $��10,10,10,10q�5      .��6&   19256,   �� 5      full height6-   �� 5      -   5        $ 
fullHeight��5   9   $
��Left=�6   $
��30px��5      $��100px��5      $��10,10,10,10q�5      .��6&   18806,   �� 5      Kicker height6/   �� 5      -   5        $ kicker��5   9   $
��Left=�6   $
��30px��5      $��100px��5      $��10,10,10,10q�5      .��6&   606*   �� 5      Low side height61   �� 5       -   5        $ lowSideHeight��5    9   $
��Left=�6   $
��30px��5!      $��100px��5"      $��10,10,10,10q�5#      .��6&   1836+   �� 5$      Flat top width60   �� 5%      -   5        $ flatTopWidth��5%   9   $
��Left=�6   $
��30px��5&      $��100px��5'      $��10,10,10,10q�5(      .��6&   06)   �� 5)      Angle6'   �� 5*      -   5        $ angle��5*   9   $
��Left=�6   $
��30px��5+      $��100px��5,      $��10,10,10,10q�5-      .��6&   486*   �� 5.      -   5        $
��btn1��5.      $
��Left=�6)   $��10,10,10,10q�5/      
�������
�������$��1q�50   .   $	��200��6B   $��35��6N   $��17(�6Z   .��51   0   get cut list53      54      �� 55      $��Right=�6   .+�56      �� 
unit depth6,   �� 57      -   5        $ depth��57   9   $
��Left=�6   $
��30px��58      $��100px��59      $��10,10,10,10q�5:      .��6&   8006+   �� 5;      tall cabinet6.   �� 5<      -	   5        $ cabinetWidth��5<   9   $
��Left=�6   $
��30px��5=      $��100px��5>      $��10,10,10,10q�5?      .��6&   6006+   �� 5@      drawer number6/   �� 5A      -
   5        $ drawerNumber��5A   9   $
��Left=�6   $
��30px��5B      $��100px��5C      $��10,10,10,10q�5D      .��6&   36)   �� 5E      	unit type6+   �� 5F      -   5        $��unitTypeCmb��5F      $
��30px��62   $
��Left=�6@   $��100px��5G      $��10,10,10,10q�5H      .@�5I      ��  �� 
IsSelected . .��69   
3dr/tall6C   �� 5J      .��6(   
6dr/tall62   �� 5K      .��6'   3dr6,   �� 5L      .��6'   6dr6,   5M      �� 5O      $
��Bold"�6   .��6*   Has a tall unit6;   �� 5P      -   5         ��Name$ hasTallUnit��5P      $
��30px��64   $
��Left=�6B   $��100px��5Q      $��10,10,10,10q�5R       d� 	IsChecked$
 TrueY�6&   .��67   has a tall unit6H   �� 5S      -   5        $��costList��5S   3   $��
10,10,0,13q�6   $
��Left=�6C   $	��Top=�6^   $	��300��5T      $	��200��6+   5U      5V      5W      5X      5Y      5Z      