   M S B A M L   `   `   `  ????J  FRecuperacionWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:RecuperacionWPFRecuperacionWPF  5   	       RecuperacionWPF.altaLibro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:RecuperacionWPF     5   	     ? Title$  	altaLibro??5   	   $	??450??6   $	??800??6(   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6   .+?5   
   ?? $??2??6   $??25(?6(   $??Center=?66   $??5q?6S   $
??Bold"?6^   Alta de libro6   ?? 5   
   $??images/library.png??6   $??20q?6,   $??1??68   ?? 5   
   $??1??6   $??1??6"   $??Center=?62   .+?5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? $F??@http://cdn1.iconfinder.com/data/icons/fatcow/16/bullet_green.png??6   ?? 5      $??Titulo??6   5      ?? 5      -   5        $??titulo??5   "   $	??300??6   62   ?? 5      $ 
Horizontal=?6   .+?5      ?? $F??@http://cdn1.iconfinder.com/data/icons/fatcow/16/bullet_green.png??6   ?? 5      $??	Editorial??6   5      ?? 5      -   5        $??	editorial??5   "   $	??300??6   65   ?? 5      $ 
Horizontal=?6   .+?5       ?? $F??@http://cdn1.iconfinder.com/data/icons/fatcow/16/bullet_green.png??6   ?? 5!      $??Numero de Paginas??6   5"      ?? 5#      -   5        $??paginas??5#   "   $	??300??6   63   ?? 5$      $ 
Horizontal=?6   .+?5%      ?? $F??@http://cdn1.iconfinder.com/data/icons/fatcow/16/bullet_green.png??6   ?? 5&      $??Precio??6   5'      ?? 5(      -   5        $??precio??5(   "   $	??300??6   62   ?? 5)      $ 
Horizontal=?6   .+?5*      ?? $F??@http://cdn1.iconfinder.com/data/icons/fatcow/16/bullet_green.png??6   ?? 5+      $
??ISBN??6   5,      ?? 5-      -   5        $
??ISBN??5-   "   $	??300??6   60   ?? 5.      $ 
Horizontal=?6   .+?5/      ?? $F??@http://cdn1.iconfinder.com/data/icons/fatcow/16/bullet_green.png??6   ?? 50      $??Stock??6   51      ?? 52      -   5        $??stock??52   "   $	??300??6   61   ?? 53      -   5        $	??100??53      $??30??6!   $??	0,50,0,15q?6-   .??6U   Dar de alta6b   ?? 54      $	??100??6   $??30??6!    ?? IsCancel . .??6>   
cancelar6H   55      57      58      