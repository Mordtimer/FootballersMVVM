   M S B A M L   `   `   `  ����J  FFootballersMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FootballersMVVMFootballersMVVM  5   	   E'clr-namespace:FootballersMVVM.ConverterFootballersMVVM.Converter  5   	   ;"clr-namespace:FootballersMVVM.ViewFootballersMVVM.View  5	   	        FootballersMVVM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   )localclr-namespace:FootballersMVVM  5   	   9converterNS'clr-namespace:FootballersMVVM.Converter  5   	   .myBox"clr-namespace:FootballersMVVM.View  5	   	     � Title$  
MainWindow��5      $	��450��6   $	��800��6(    � 	Resources 5      )  #FootballersMVVM.Converter.Converter   	converter��%   &	          5   
   6    5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Closed��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *Save+5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ StackPanelForm��5      $��0��6-   .+�5      �  � DataContext 6   �� *DisplayedPlayer+ 5      	 � RowDefinitions	 5!      �� 5"      $��1* �6$   �� 5#      $��1* �6$   �� 5$      $��1* �6$   �� 5%      $��1* �6$   �� 5&      $��1* �6$   �� 5'      $��1* �6$   �� 5(      $��1* �6$   �� 5)      $��1* �6$   �� 5*      $��1* �6$   �� 5+      $��1* �6$   �� 5,      $��1* �6$   �� 5-      $��1* �6$   .+�50      �� -   5        
 ��Name$
 TextBlockName��50      $��Imie:��63   $��19(�6@   $��	15,15,5,5q�6N   $��0��6a   3   -FootballersMVVM.View.TextBoxWithErrorProvider  51      -   5          Name$ TextBoxName��51   1   $
��30px��52      $	��200��6(   $
��Left=�64   $��15,5,5,5q�6O   $��19(�6a   ���	#FFCECECE$��1��6�      Text 51   F   �� *Name+ �� Mode$ TwoWay=�52   �   �� 53      -   5        $
 TextBlockSurname��53      $��	Nazwisko:��66   $��19(�6G   $��15,5,5,5q�6U   $��2��6g     54      -   5        $ TextBoxSurname��54   1   $
��30px��55      $	��200��6(   $
��Left=�64   $��15,5,5,5q�6P   $��19(�6b   ���	#FFCECECE$��3��6�    54   I   �� *	Surname+$ TwoWay=�55   �   �� 56      -   5        $
 TextBlockWiek��56      $��Wiek:��63   $��19(�6@   $��15,5,5,5q�6N   $��4��6`   �� 57      $
��Left=�6   $��	15,5,0,10q�68    �� Orientation$ Vertical=�6K   $��2��6b   $��5��6s   .+�58      �� -   5         ��Name$ 	SliderAge��58       � Minimum$ 16Q�60    � Maximum$ 90Q�6=   $	��200��6J    �� TickFrequency$ 1Q�6V   $��18��6h    �� IsSnapToTickEnabled$
 True��6t    � Value 6�   �� *Age+$ TwoWay=��� 59      -   5        $
 TextBlockActualAge��59       $��16��5:       $��Center=�6,   ��59   <   ��  �� ElementName$ 	SliderAge�� �� Path$ Value� �� StringFormat$ {0} lat��$ TwoWay=�5:   ,   5;      �� 5<      -	   5        $
 TextBlockWeight��5<      $
��Waga��65   $��19(�6A   $��15,5,5,5q�6O   $��7��6a   �� 5=      $
��Left=�6   $��	15,5,0,10q�68   $ Vertical=�6K   $��2��6b   $��8��6s   .+�5>      �� -
   5        $ SliderWeight��5>      $ 40Q�63   $	 120Q�6@   $	��200��6N   $ 1Q�6Z   $��18��6l   $
 True��6x    6�   �� *Weight+$ TwoWay=��� 5?      -   5        $
 TextBlockActualWeight��5?       $��16��5@       $��Center=�6,   ��5?   @   �� $ SliderWeight��$ Value�$ {0} kg��$ TwoWay=�5@   ,   5A      �� 5B      -   5         ��Name$ 
ButtonEdit��5B      $��Edytuj��5C      $��80��6+   $��30��66   $��15,5,5,5q�6B   $
��Left=�6T   $��10��6o   ��5B   -   �� $ DataContext.Modify� �� RelativeSource ��  �� AncestorType
 Window{�5D      `� 5E       `� 	Converter# [  6'   .1�5F      �� $ TextBoxName��6&   $ 
IsNotEmpty�6@   �� 5G      $ TextBoxSurname��6&   $ 
IsNotEmpty�6C   5H      5J      �� 5L      -   5        $ ButtonaAppend��5L      $��Dodaj��5M      $��80��6)   $��30��64   $��	135,5,5,5q�6@   $
��Left=�6S   $��10��6n   ��5L   0   �� $ DataContext.Add� �� 
 Window5M   n   �� 5N      -   5        $ ButtonaDelete��5N      $��Usuń��5O      $��80��6(   $��30��63   $��	135,5,5,5q�6?   $
��Left=�6R   $��11��6m   ��5N   0   �� $ DataContext.Delete� �� 
 Window5O   m   5P      5Q      �� 5R   
   -   5         ��Name$ listBoxPeople��5R      $��1��6)   $��5q�69   $��19(�6D   ��6R   �� *ListOfPlayers+ �� UpdateSourceTrigger$ Explicit=�$ TwoWay=� �� SelectedItem 6�   �� *SelectedPlayer+��5S      �� 5T      .R�5U      �� $ 
Horizontal=�6!   .+�5V      �� ��6$   �� *Description+5W      5X      5Z      5[      5\      