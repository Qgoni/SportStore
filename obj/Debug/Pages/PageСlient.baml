   M S B A M L   `   `   `  ����E  ASportStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SportStore.PagesSportStore.Pages  5      "    SportStore.Pages.PageСlient   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:SportStore.Pages     5        N� Title$  PageСlient��5	      .��5      � .+�5   
   �� -   5         ��Name$ NameFullUserText��5      $��Right=�6*   $	��Top=�6F   $	��360��6^   $��31��6j   $��0,17,0,0q�6v   �� 5   
   -   5        $��
Назад��5      $
��Left=�6!   $��22,0,0,9q�6<   $��Bottom=�6N   $��51��6~   �� 5   
   -   5        $��productListView��5      $��	0,48,0,34q�6*    �� View 5      �� 5      .P�5      �� $��
Номер��6%    �� Width$	 150��64    �� DisplayMemberBinding 6@   �� *	ProductID+�� 5      $��Фото��6%   $	 100��63    �� CellTemplate 5      �� 5      .R�5   "   �� $��80��6A   $��80��6L   ��6(   �� *Image+6L   5      5      �� 5      $#��Название товара��6%   $	 150��6>    6J   �� *Description+�� 5      $��Тип товара��6%   $	 150��69    6E   �� *
Category+�� 5      $&�� Наличие на складе��6%   $	 150��6@    6L   �� *StockQuantity+5      ��5       �� 5!       �� 
TargetType" ��6   .�5"      ��  �� Property � �� �� Value 63   �� *
Background+5#      5%      �� 5&   
   -   5        	 ��Name$	 SearchTextbox��5&      $
��Left=�6)   $��	58,25,0,0q�6D   
 �� TextWrapping$

 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��190��6�   
���   �6�   �� 5'   
   $��
Поиск��6   $
��Left=�6    $��5,19,0,0q�6;   $	��Top=�6M   $
��Bold"�6e   $��14(�6w   5(      5)      