   M S B A M L   `   `   `  ????J  FRecuperacionWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:RecuperacionWPFRecuperacionWPF  5   	   !    RecuperacionWPF.buscarLibro   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:RecuperacionWPF     5   	     ? Title$  buscarLibro??5   	   $	??450??6   $	??800??6*   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6   .+?5   
   ?? $??2??6   $??25(?6(   $??Center=?66   $??5q?6S   $
??Bold"?6^   Busqueda de libros6?   ?? 5   
   $??images/lupa.png??6   $??1??6)   $??15q?66   ?? 5   
   $??1??6   $??1??6"   $??Center=?62   .+?5      ??  ?? Orientation$ 
Horizontal=?6   $??10q?62   .+?5      ?? $F??@http://cdn1.iconfinder.com/data/icons/fatcow/16/bullet_green.png??6   ?? 5      $??Titulo??6   5      ?? 5      -   5        $??titulo??5   "   $	??300??6   62   ?? 5      $ 
Horizontal=?6   $??10q?62   .+?5      ?? $F??@http://cdn1.iconfinder.com/data/icons/fatcow/16/bullet_green.png??6   ?? 5      $??Titulo??6   5      ?? 5      -   5        $
??ISBN??5   "   $	??300??6   60   5       ?? 5!   
   $??1??6   $?? 1??6"   $ 
Horizontal=?63   $??	0,150,0,0q?6L   .+?5"      ?? -   5        $??80??5"      $??30??6    $??
20,0,150,0q?6A   .??6U   buscar6]   ?? 5#      $??80??6   $??30??6     ?? IsCancel . .??6=   
cancelar6G   5$      5%      5&      