   M S B A M L   `   `   `  ����@  <Filmy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FilmyFilmy  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Filmy.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Filmy     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	     � Title$  Informator filmowy��5	   	   $	��450��6$   $	��800��61   .��5      �� $
��Auto=�6   .��5   
   �� -   5         ��Name$ items��5      $��10q�6&   ��5      �� ��5   
   �� 5      .R�5      � 5      ��5   
   �� 5       � 	Resources 5       �� 
TargetType �� Property �� Value��%x   '��       �� 5      " ��6   .�5      ��  � ��$ 14(�65   �� 5       � ��$
 Left=�6@   5      5       .R�5!      �  �Name$ testgrid��6    � RowDefinitions 5"      �� 5#      $��2* �6(   �� 5$      $��2* �6(   .+�5&      �� -   5        $
��Left=�5&   <   $	��140��6W   $	��200��6c   
 � Tag 6!   �� 	 �� Path$	 Tytul�.��5'      �� $
��Left=�6%   $	��200��6@   $	��150��6M   ��6Y   �� $	 LinkDoPlakatu�6�   5(      �� 5*      $��2��6&   $
��Left=�63   .+�5+      �� $
��Bold"�6$   $
��Wrap=�66   $��3,3,3,0q�6J   ��5,      �� $	 Tytul��� 5.      $
��Wrap=�6$   $��3,0,3,7q�68   ��5/      �� $	 Rezyser��� 51      $
��Wrap=�6$   $��3,0,3,7q�68   ��52      �� $	 RokProdukcji�53      54      55      ��58   
   �� 59      .�5:      ��  � ��$	 200��62   �� 5;       � ��$ 40q�63   
 �� Triggers
 5<      P� 5>       P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5?      ��  �@�ToolTip 5@      �� $	 Tytul�5A      5E      5G      5I      5L      