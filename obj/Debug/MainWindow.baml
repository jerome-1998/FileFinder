   M S B A M L   `   `   `  ����E  AFileFinder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:FileFinder
FileFinder  5   	       FileFinder.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:FileFinder     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�65    � 	Resources 5	       �� 
TargetType �� Property �� Value��%8  '��       '�� {     '�� L    �� 5
   
   " ��6   .�5      ��  � ��$ Calibri)�6+   6=   �� 5       � ��$ 30(�6)   66   5      �� 5   
   " ��6   .�5      ��  � ��$ Calibri)�6+   6=   �� 5       � ��$ 30(�6)   66   �� 5       � ��$ Center=�69   6J   �� 5       � ��$ 50��6'   64   5      �� 5   
   " ��6   .�5      ��  � ��$ 50��6'   64   �� 5       � ��$	 150��6&   64   �� 5       � ��$ Calibri)�6+   6=   �� 5       � ��$ 30(�6)   66   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   �� 5      6   �� 5       6   �� 5!      6    � ColumnDefinitions 5#   
   �� 5$      $��* �6   6+   �� 5%      $
��auto �6   6.   .+�5(   
   �� $��Bottom=�6   .��6+   Datei Suchen:6:   �� 5)   
   -   5         ��Name$ btnPath��5)   �   $��Bottom=�6   $��1��6,   $��Pfad auswählen��6<   	 � ToolTip$f	 `wenn kein Pfad ausgewählt wurde werden Alle Laufwerke ausgewählt, dies kann sehr lange dauern!��6U   6�   � 5+   
   $��0��6   $��1��6    5,      �� 5-      6%   �� 5.      6%   .+�50      �� $��Bottom=�6   $��0��6/   $��Ausgewählter Pfad:��6@   6_   �� 51      -   5        
 ��Name$
 lblSelectedPath��51   a   $��Bottom=�6   $��1��6/   ��6?   ��  �� Path$ ShowPath�6|   52      � 54   
   $��1��6   $��1��6    55      �� 56      6"   �� 57      6"   .+�59      �� -   5        $ btnClearPath��59   +   $��Pfad leeren��6   6^   �� 5:      -   5        $��	lblStatus��5:      $��1��6%   64   5;      �� 5>   
   -   5        $��tbxFileName��5>   /   $��0��6   $��2��6"   6D   �� 5?   
   -   5        $��btnFindFile��5?   .   $��1��6   $��2��6!   .��6[   Suchen6c   �� 5A   
   -   5        $��	lblResult��5A   Y   $��0��6   $��3��6    $��2��6-   $	��Top=�6A   .��6j   Noch nichts gesucht6   �� 5C   
   -   5        $��btnShow��5C   B   $��0��6   $��4��6!   $��2��6.   {�6g   �� $ 
ShowResult�.��6�   
Anzeigen6�   5D      5E      