   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   P LPrism.Wpf, Version=6.2.0.0, Culture=neutral, PublicKeyToken=91a96d2a154366d8$prismhttp://prismlibrary.com/  5   	   -   5          � Title$  
MainWindow��5   	   $
��1920��5   	   $
��1080��5   	    � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�5   	   .��5      � 
���   � � 	Resources 5   
    �� 
TargetType �� Property �� Value��%Q   '��       �� 5      " ��6   .�5      ��  � ��$ 0q�64   5      5      .+�5   
   �� $��Stretch=�6   $��Stretch=�5       K� ZIndex$ 1��5      $��Background.jpg��5      �� 5   
   -   5         ��Name$ 
MainCanvas��5      $��Stretch=�5       $��Stretch=�5!      $ 50��5"      �� 5#   
   $��Right=�6   $	��Top=�5$      $ 40��5%      
�������	 �� Orientation$	 
Horizontal=�5'      .+�5(      �� $��60��6   $��60��5)      
������ .  (System.Windows.Interactivity.Interaction
   Triggers
 5+      /  )System.Windows.Interactivity.EventTrigger  5,         	EventName$ 	TouchDown��6%   5.      .��51      �� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6   :x,http://schemas.microsoft.com/winfx/2006/xaml     52      -   5        $ appbar_cart��53      $��76��54      $��76��55       J� Clip4 ��        � ��    � �� ���     ���        .+�57      F�  �� Left$ 10��6   
 �� Top$ 16.167��58      $��38��59      $��31.666��5:      �����L������$����������0��Ԍ2$�|�ML��|�M��Z�|�M0P�Ԍ20P��0�0P�����Z����L������x��������҇@@�����������0Ӕ�Ԍ2���҇@@|�Mx�|�M�µ|�M\��Ԍ2\���0�\�����µ���x�����4�����4��l'tѬ<R ����! ����!pej�\��pej�\�� ��@�e �ѐE���4�����s�l't�H��l't�(��Z���u��Z�Ѥs�l't
���   � �� Stretch$
 Fill=�5=      5>      5?      �� 5@      $��Center=�6   $��	Helvetica)�5A      $��40(�5B      
���������5D      �� *	NbTotal+5E      5G      5H      