   M S B A M L   `   `   `  ����L  HConverterCurrency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ConverterCurrencyConverterCurrency  5   	   "    ConverterCurrency.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ConverterCurrency     5   	     � Title$#  Конвертер валют��5   	   $��340.841��6!   $��386.757��62   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��5* �6   �� 5      $	��17* �6   .+�5   
   �� -   5        $��
txtbResult��5   N   $
��Left=�6   $	��119��6-   $��
22,105,0,0q�6:    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $��Arial )�6|   $��14(�6�   $��Italic$�6�   $	��Top=�6�   $	��336��6�   $��2��6�   �� 5   
   -   5         ��Name$ 
btnConvert��5      $"��Конвертировать��6%   $
��Left=�6>   $��
44,241,0,0q�6Y   $	��Top=�6m   $	��266��6�   $��30��6�   $��2��6�   �� 5   
   $��ВАЛЮТА:��6   $
��Left=�6"   $��	22,24,0,0q�6=   $	��Top=�6P   $��14(�6h   $��2��6v   �� 5   
   -   5         ��Name$ cmbCurrency��5      $
��Left=�6(   $��	12,28,0,0q�6C   $	��Top=�6V   $	��187��6n   $��1��6z   .@�5      �� /-Австралийский доллар (AUD)64   �� 5      1/Азербайджанский манат (AZN)65   �� 5      USФунт стерлингов Соединенного королевства (GBP)6H   �� 5      Доллар США (USD)6*   �� 5      Евро (EUR)6$   �� 5      #!Китайский юань (CNY)6.   �� 5      +)Гонконгский доллар (HKD)62   5      �� 5   
   $8��2Результат конвертирования:��6   $
��Left=�65   $��	22,71,0,0q�6P   $	��Top=�6c   $��14(�6{   $��2��6�   5      5      