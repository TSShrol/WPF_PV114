   M S B A M L   `   `   `  ????P  L04_2_Binding_Template, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:_04_2_Binding_Template_04_2_Binding_Template  5   	   '    !_04_2_Binding_Template.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:_04_2_Binding_Template     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??350??6)    ? 	Resources 5	         listTamplate ?? ImageSource ??Name ?? Path ?? Triggers ?? Value ?? Binding ?? 
TargetName	 ?? Property
 ?? Value??%?  &	        ?? 5
   
   .R?5      ?? $??5q?6   .+?5      A? $??30??6   $??30??6&   $??5q?61   ??5      ?? 5      $ /91.jpg??6%   5      ?? 5      $ userLastName??6   $??18(?62   ??6@   ?? $ LastName??? 5      $ userFirstName??6   $??18(?63   ??6A   ?? $ 	FirstName?5       5      ?? 5      $ Sokil??6;    6   ?? *
LastName+.a?5      ?? $ userLastName??6   	 ? ??$

 Bold"?6M   6\   5      5      5      .??5      ]? .+?5   
   ?? $	??Top=?6   .+?5       ?? .??6   Input FirstName:6&   ?? 5!      -   5         ??Name$ inputFirstName??5!      60   ?? 5"      .??6   Input LastName:6%   ?? 5#      -   5        $ inputLastName??5#      6/   ?? 5$       ?? Orientation$ 
Horizontal=?6   $??Center=?62   .+?5%      ?? -   5         ??Name$ AddUser??5%      $??60??6@   $
??10 0q?6K   .??6Y   Add6^   ?? 5&      -   5        $ 
DeleteUser??5&      $??60??6F   $
??10 0q?6Q   .??6_   Delete6g   ?? 5'      -   5        $ 
ChangeUser??5'      $??60??6F   $
??10 0q?6Q   .??6_   Change6g   5(      5)      ?? 5*      -   5         ??Name$ 	listUsers??5*      #??[  6&   5,      5/      50      