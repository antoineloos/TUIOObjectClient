   M S B A M L   `   `   `  ���� J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2      WpfApplication2.TObject   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:WpfApplication2     P LPrism.Wpf, Version=6.2.0.0, Culture=neutral, PublicKeyToken=91a96d2a154366d8$prismhttp://prismlibrary.com/  c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  .��� -     �Name$  mainGr��$	��250��$	��250��
������  � 	Resources  �� 
TargetType �� Property �� Value��%m   '��       '�� 7     �� " ��.���  � �� �� *Capsule.Couleur+�� " ��.���  � ��$ 0q�z��� -   
transf�� �� CenterX$	 125Q� �� CenterY$	 125Q�.+��� $��4��	 �� X1$	 -26��	 �� X2$ 40��		 �� Y1$	 -8��	
 �� Y2$
 40���� $��4��$	 227��$	 215��$	 33��$
 45������  �� Path$ Capsule.Couleur��� $��-6,37,6,-37q�$��4��$	 -36��$ 10��$	 48��$
 80��A� $��Stretch=�$��Stretch=�$��5������ $ Capsule.Couleur�A� $��80��$��80��$��0,-32,-47,0q�$��Right=�$	��Top=�$��3������ $ Capsule.Couleur�A� $��60��$��60��$��
0,48,-82,0q�$��Right=�$	��Top=�
�������$��3���� $��228,-10,-228,10q�
�������$��4��$ 50��$ 59��$	 50��$
 63���� $��220,80,-220,-80q� J� RenderTransformOrigin$ 0.5,0.5&�
�������$��4��$ 50��$ 59��$	 50��$
 63��z�V� .~��� �� ��  �� Angle$ 23.161Q�T� �� $��60��$��60��$��0,-23,-36,0q�$��Right=�$	��Top=�
������ .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ 	TouchDown��.  (System.Windows.Interactivity.TriggerBase   Actions. -  'Prism.Interactivity.InvokeCommandAction     Command �� *
AddCommand+.���� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     -    ��Name$ appbar_cart��$��76��$��76�� J� Clip4 ��        � ��    � �� ���     ���        .+�F�  �� Left$ 10��
 �� Top$ 16.167��$��38��$��31.666�������L������$����������0��Ԍ2$�|�ML��|�M��Z�|�M0P�Ԍ20P��0�0P�����Z����L������x��������҇@@�����������0Ӕ�Ԍ2���҇@@|�Mx�|�M�µ|�M\��Ԍ2\���0�\�����µ���x�����4�����4��l'tѬ<R ����! ����!pej�\��pej�\�� ��@�e �ѐE���4�����s�l't�H��l't�(��Z���u��Z�Ѥs�l't
������� �� Stretch$
 Fill=��� $	��400��$��-429,-52,279,254q�$��Right=�$��Bottom=� K� ZIndex$ 10��$��RightToLeft=�$
��Lato)�$��40(����� *Capsule.Couleur+���� *Capsule.Nom+�� $��-121,50,0,0q�$
��Left=�$	��Top=�$
��Lato)�$��25(�
����������� *Capsule.Prix+�� $��-121,85,121,-85q�$��4��$ 0��$ 80��$	 0��$
 0���� $��-77,-111,77,111q�$ 0.5,0.5&�$��4��$	 -36��$ 10��$	 48��$
 80��z�V� .~��� �� �� $	 -90Q�T� �� $��-121,175,121,-175q�$��4��$ 0��$ 93��$	 0��$
 0���� $��-121,140,0,0q�$
��Left=�$	��Top=�$
��Lato)�$��25(�
����������� *Capsule.Contenance+�� $��	4,7,-4,-7q�$ 0.5,0.5&�$��4��$	 -26��$ 40��$	 -8��$
 40��z�V� .~��� �� �� $	 -90Q�T� �� $��-121,282,121,-282q�$��4��$ 0��$	 118��$	 0��$
 0���� $��-121,247,0,-27q�$
��Left=�$	��Top=�$
��Lato)�$��25(�
����������� *Capsule.Intensite+�� $��-121,222,0,-2q�$
��Left=�$	��Top=�$��
Sans Serif)�$��20(�$��Light"�
�������$��Intensité :��A� $��60��$��60��$��0,121,-91,0q�$��Right=�$	��Top=�
�������$��3��A� $��60��$��60��$��0,186,-54,0q�$��Right=�$	��Top=�
�������$��3���� $��139,153,-139,-153q�$ 0.5,0.5&�
�������$��4��$ 50��$ 59��$	 50��$
 63��z�V� .~��� �� �� $ 63.104Q�T� �� $��28��$��48��$��300,122,-78,80q�$��Center=�$��Center=�$��40(�
����������� *	NbProduit+�� $��50��$��50��$��
0,53,-77,0q�$��Right=�$	��Top=�
������    $ 	TouchDown��.    �� *PlusCommand+���� $��34��$��76��$��Center=�$��Center=�$��50(�
�������$��+���� $��50��$��50��$��0,190,-49,0q�$��Right=�$	��Top=�
������    $ 	TouchDown��.    �� *MoinCommand+.���� $��20��$��76��$��Center=�$��Center=�$��50(�
�������$��-��