   M S B A M L   `   `   `  ����P  LDataGridColumnBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DataGridColumnBindingDataGridColumnBinding  5   	   &     DataGridColumnBinding.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   5local#clr-namespace:DataGridColumnBinding     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  
MainWindow��5   	   $	��525��5   	   $	��350��5	   	    � 	Resources 5          BooleanToVisibilityConverter��%   &	        �� 5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��12q�6    �� Orientation$ 
Horizontal=�6!   .+�5      �� $��VisibleDate��6    d� 	IsChecked 6-   �� *IsVisibleDate+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��VisibleTime��6    6-   �� *IsVisibleTime+$ TwoWay=�$ PropertyChanged=�5      �� 5   
   $��1��6   ._�5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .  ��63   �� *Times+$ OneWay=� 5      (   "DataGridColumnBinding.BindingProxy 	 Proxy   Data��%&   &	         5        67   �� 5!      	   Columns	 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Date��5$   )   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5#   )   �� *Today+$ OneWay=� �� StringFormat$ {0:d}��   
Visibility 5%   )   �� *Data.IsVisibleDate+ �� 	Converter# [  $ OneWay=� �� Source# [   5&      $

 Time��5'   )    5&   )   �� $ OneWay=�$ {0:hh:mm:ss}�� 5(   )   �� *Data.IsVisibleTime+# [  $ OneWay=�# [   5)      $
 DateTime��6_    6)   �� $ OneWay=�$ {0:G}��6_   5+      5,      5-      5.      