   M S B A M L   `   `   `  ����O  KMachineStatusTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MachineStatusTrackerMachineStatusTracker  5   	   %    MachineStatusTracker.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:MachineStatusTracker     5   	     � Title$  Machine Status Tracker��5	   	   $	��450��6(   $	��800��65   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Center=�6   $��Machine Status Tracker��62   $��36(�6P   $
��Bold"�6^   $��0��6p   ���#0078D7$
��0 20q�6�   �� 5   
   $��Center=�6   $'��!Monitor and Manage Machine Status��62   $��1��6[   $��20(�6h   $��Italic$�6v   $	��0 5q�6�   �� 5   
    �� Orientation$ Vertical=�6   $��Center=�6,   $��2��6I   $��10q�6V   .+�5      �� $��Filter by status:��6   $	��150��61   $��	10 10 0 0q�6=   �� 5      -   5         ��Name$ 	cmbStatus��5      $	��150��6*   $��Center=�67   .@�5      �� $	��All��6   �� 5      $��Running��6   �� 5      $
��Idle��6   �� 5      $��Offline��6   5       5!      � 5#   
   -   5        $��MachineCards��5#      $��3��6(   $��5q�65   �� 5%   
   -   5        $��Add Machine��5%      $��4��6'   $��50��6M   $	��120��6Y   
���   �$��3q�6y   $��Center=�6�   $��Bottom=�6�   $��10q�6�   ���#0078D7
����  �6�   5&      5'      