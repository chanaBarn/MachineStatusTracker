   M S B A M L   `   `   `  ����O  KMachineStatusTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MachineStatusTrackerMachineStatusTracker  5      (    "MachineStatusTracker.MachineCardUC   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .local"clr-namespace:MachineStatusTracker  5        � DataContext  5	   7   ��  � 	Resources 5
      0   *MachineStatusTracker.StatusToIconConverter   StatusToIconConverter  	IconStyle �� 
TargetType'  !MaterialDesignThemes.Wpf.PackIcon �� Property �� Value �� Triggers �� Binding �� Value��%�  &	        &	        5   
   6&   �� 5   
   "  6"   .�5      ��  � ��
 �����6+    5      �� 5       6   �� *Status+ Running69   .a�5      ��  � ��
 � � �63   5      �� 5       6   �� *Status+ Idle69   .a�5      ��  � ��
 � ���63   5      �� 5       6   �� *Status+ Offline69   .a�5      ��  � ��
 �  ��63   5      5      5      .��5      �� 
���   �$��1q�6!   $��5q�65   ._�5   
   � $��5q�6    � RowDefinitions 5       �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    .+�5%      � $��0��6   	 � ColumnDefinitions	 5&      �� 5'      $
��Auto �6'   �� 5(      $��* �6'   .+�5+      �� $
��Bold"�69   $��16(�6K   $��Center=�6Y   ��6   �� *MachineName+6Y     5,      $��1��6*   $��Center=�6�   $��5q�6�   #��[ 6�   
   Kind
 6:   �� *Status+ �� 	Converter# [  6�   5-      �� 5/      $��1��6   $��0,10,0,0q�6&   .+�50      �� $��0,5,0,0q�6Z   ��6   �� *Description+ �� StringFormat$ Description: {0}��6Z   �� 51      $��0,5,0,0q�6P   ��6   �� *Status+$ Status: {0}��6P   �� 52      $��0,5,0,0q�6N   ��6   �� *Notes+$ 
Notes: {0}��6N   � 53       � 
ItemHeight$ 25��6    � 	ItemWidth$ 60��6,   $��0,10,0,0q�6;   .+�54      �� -   5        $
��Edit��54      $��0,0,10,0q�6?   ���#0078D7
����  �6f   �� 55      -   5        $��Delete��55      ���#0078D7
����  �6X   56      57      58      59      5:      