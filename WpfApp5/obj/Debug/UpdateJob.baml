   M S B A M L   `   `   `  ����B  >WpfApp5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp5WpfApp5  5   	       WpfApp5.UpdateJob   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp5     5   	     � Title$  	UpdateJob��5   	   $	��900��6   $	��900��6(   .��5	      � .+�5
   
   ]� .+�5      ]� $	��Top=�6   .+�5      �� $��
Update job��6   $��20(�6.   $��30q�6<   6K   5      ]� 5      
�������.+�5      �� .+�5      �� -   5        $��jobsDone��5   3   $��
10,10,0,13q�6   $
��Left=�6C   $	��Top=�6^   $	��400��5      $	��300��6+   5      �� 5      $��10,10,10,10q�6    
customer6?   �� 5      -   5         ��Name$ customerName��5   9   $
��Left=�6   $
��30px��6P   $��10,10,10,10q�6^   $��200px��6s   .��6�   5      �� 5      -   5        $
��btn1��5      
�������$
��Left=�6@   $��10,10,10,10q�6[   
�������$	��200��5      $��35��6%   $��17(�61   .��6@   
update job5      5      5      ]� 5      $��Bottom=�6   
�������.+�5      �� $
��Left=�6   .+�5      �� $
��Bold"�6    $��10,10,10,10q�62   date agreed price6Z   (  "System.Windows.Controls.DatePicker  5      -   5        $��
dateAgreed��5   Q      SelectedDateFormat$
 Long=�6      IsTodayHighlighted .    DisplayDateStart$ 1/01/22X�5          DisplayDateEnd$ 12/31/22X�6.   $	��200��6H   $��10,10,10,10q�6T   $
��Left=�6i      FirstDayOfWeek$ Monday=�5!      �� 5"      $��10q�6   .+�5#      �� $
��Bold"�6    .��63   state6:   	� 5$      -   5        $��agreedRd��5$   "   .��63   Agreed6;   	� 5%      -   5        $��
finishedRd��5%   "   .��65   
Finished6?   5&      5(      �� 5)      $��Right=�6   .+�5*      �� $
��Bold"�6    $��10,10,10,10q�62   date finished6V     5+      -   5        $��
finishDate��5+   U   $
 Long=�6!    . $ 1/01/22X�5,      $ 12/31/22X�64   $	��200��6N   $��10,10,10,10q�6Z   $
��Left=�6o   $ Monday=�5-      �� 5.      $��10q�6!   .+�5/      �� $
��Bold"�6    .��62   	paid by6;   	� 50      -   5        $��
paidByCash��50   &   .��69   cash6?   	� 51      -	   5        $��paidByTransfer��51   &   .��6=   
Transfer6G   52      �� 53      $
��Bold"�6    $��10,10,10,10q�62   
time spent6S   �� 54      -
   5        $ 	timeSpent��54   9   $
��Left=�6   $
��30px��55      $��200px��56      $��10,10,10,10q�57      60   58      5:      5;      5<      5=      