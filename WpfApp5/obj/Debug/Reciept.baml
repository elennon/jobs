   M S B A M L   `   `   `  ����B  >WpfApp5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp5WpfApp5  5   	       WpfApp5.Reciept   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp5     5   	     � Title$  Reciept��5   	   $	��800��6   $	��800��6&   .��5	      � .+�5
   
   ]� .+�5      ]� $	��Top=�6   .+�5      �� $��Add Reciept��6   $��20(�6/   $��30q�6=   6L   5      ]� 5      
�������.+�5      �� $
��Left=�6   .+�5      �� $
��Bold"�6    $��10,10,10,10q�62   
supplier6Q   �� 5      -   5        $��supplier��5   \   $��10,10,10,10q�6    $	��200��65   $
��Left=�6A   .@�5      ��  �� 
IsSelected . .��6=   Noyaks6E   �� 5      .��6,   	Barrets65   �� 5      .��6+   
Strahans65   �� 5      .��6+   	Clearys64   �� 5      .��6+   Deisel63   5      �� 5      $
��Bold"�6    $��10,10,10,10q�62   spent6N   �� 5      -   5         ��Name$ spent��5   9   $
��Left=�6   $
��30px��5      $��200px��5      $��10,10,10,10q�5      6(   �� 5       $
��Bold"�6    $��10,10,10,10q�62   date bought6T   (  "System.Windows.Controls.DatePicker  5!      -   5        $��
dateBought��5!   U      SelectedDateFormat$
 Long=�6!      IsTodayHighlighted .    DisplayDateStart$ 1/01/22X�5"         DisplayDateEnd$ 12/31/22X�6.   $	��200��6H   $��10,10,10,10q�6T   $
��Left=�6i      FirstDayOfWeek$ Monday=�5#      �� 5%      -   5        $
��btn1��5%      
�������$
��Left=�6@   $��10,10,10,10q�6[   
�������$��1q�5&   .   $	��200��6B   $��35��6N   $��17(�6Z   .��5'   /   add receipt5)      5*      5+      5,      5-      5.      