   M S B A M L   `   `   `  ����E  AFileFinder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:FileFinder
FileFinder  5   	       FileFinder.ShowFiles   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:FileFinder     5   	   -   5          � Title$  	ShowFiles��5   	   $	��450��6   $	��800��6(    � 	Resources 5	       �� 
TargetType �� Property �� Value&   System.Windows.Controls.DataGrid��%�  '��       '  �     '�� �     �� 5
   
   " ��6   .�5      ��  � ��$ 30(�6)   66   �� 5       � ��$ Calibri)�6+   6=   �� 5       � ��$ 50��6'   64   5      �� 5   
   "  6   .�5      ��  � ��$ 20(�6)   66   5      �� 5   
   " ��6   .�5      ��  � ��$ 50��6'   64   �� 5       � ��$	 200��6&   64   �� 5       � ��$ 30(�6)   66   �� 5       � ��$ Calibri)�6+   6=   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   �� 5      $
��auto �6   6,   .+�5   
   �� -   5        $��	lblAmount��5      6#     5    
   -   5        $��dgFiles��5    �   $��1��6      AutoGenerateColumns .     
IsReadOnly . $ �� IsSynchronizedWithCurrentItem$
 TrueY�6f   ��6<   �� ��5!      �� 5"      )  #System.Windows.Controls.DataGridRow"  6   .�5#      -   5        5$      	   Columns	 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Dateiname��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Name+6S     5(      $

 Pfad��6%    63   �� *
FullName+6R   5*      �� 5,   
   -   5        $��btnClose��5,      $��2��6   .��6E   	Schliesen6P   5.      5/      