   M S B A M L   `   `   `  ���� E  AFileFinder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:FileFinder
FileFinder      FileFinder.ShowFiles   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:FileFinder     -     � Title$  	ShowFiles��$	��450��$	��800�� � 	Resources  �� 
TargetType �� Property �� Value&   System.Windows.Controls.DataGrid��%   '��       '  T     '�� w     �� " ��.���  � ��$ 30(���  � ��$ Calibri)���  � ��$ 50���� "  .���  � ��$ 20(��� " ��.���  � ��$ 50����  � ��$	 200����  � ��$ 30(���  � ��$ Calibri)�.���  � RowDefinitions �� $
��auto ��� �� $
��auto �.+��� -   $��	lblAmount��  -   $��dgFiles��$��1��   AutoGenerateColumns .     
IsReadOnly . $ �� IsSynchronizedWithCurrentItem$
 TrueY����� ���� )  #System.Windows.Controls.DataGridRow"  .�-   	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Dateiname��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+  $

 Pfad�� �� *
FullName+�� -   $��btnClose��$��2��.��	Schliesen