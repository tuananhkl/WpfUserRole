   M S B A M L   `   `   `  ????B  >WpfUser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfUserWpfUser  5      -clr-namespace:WpfUser.ViewsWpfUser.Views  5      U QSystem.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 5          WpfUser.App   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      'localclr-namespace:WpfUser     5      -viewsclr-namespace:WpfUser.Views     5      ^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	 cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag
 cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Coolicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Fontisto, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah  dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai! eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj" fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag# cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af$ bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj% fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak& gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah' dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a}	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks!   	 
                        ! " # $ % & ' 5      ysystem,clr-namespace:System;assembly=System.Runtime!   	 
                        ! " # $ % & ' 5        ?? 	Resources  5	         PrimaryDarkBrush ?? Color  PrimaryLightBrush  NavigationListBoxStyle ?? 
TargetType ?? Property ?? Value ?? 
TargetType ?? Padding J? SnapsToDevicePixels  NavigationListBoxItemStyle ?? RelativeSource	 ?? AncestorType
 ??Name ?? Triggers P? Property P? Value ?? 
TargetName ]? 
Conditions ?? Property ?? Value  NavigationDataTemplate4  .MahApps.Metro.IconPacks.PackIconMaterialDesign  Name ?? Triggers ?? Value ?? Binding  NavigationMenuItems ?? Type  HomeViewTemplate   WpfUser.Views.HomeView  UserViewTemplate   WpfUser.Views.UserView  RoleViewTemplate   WpfUser.Views.RoleView??%
  &	        &	 #     &	 F     7   &	 ?    7  7  7  &	 ?    &	 ?    &	 8	    &	 `	    &	 ?	    ?? 5
   
   $ 	#FF0D2738??63   ?? 5   
   $ 	#FF1F90FF??64   ?? 5   
   " ??6/   .?5   
   ??  ? ??8   6'   ?? 5   
    ? ??$ Disabled=?6G   ?? 5   
    ? ??$ Disabled=?6E   ?? 5   
    ? ??$ Center=?65   ?? 5   
    ? ??$ Center=?67   ?? 5   
    ?@??SelectedIndex$ 0??6*   ?? 5   
    ? ??$
 Auto??6"   ?? 5   
    ? ?? 5      ?? 5      " ??6"   .R?5      ?? #??z??6   $??0q?5   !   $ 0q?5   !   $
 true??5   !   ._?5      ?? #??z??6'   $|?false??5   +   .??5      ?? # z 6-   5      5       5!      5#      5$      ?? 5&      " ??6/   .?5'   
   ??  ? ??
 ???? 6'   ?? 5(   
    ? ??8   6'   ?? 5)   
    ? ??$ -1q?6#   ?? 5*   
    ?@?ToolTip 6$   ?? ?? 5+   
    ? ?? 5,      ?? *HorizontalContentAlignment+ ?? "	 ???? 5-   
    ? ?? 5.      ?? *VerticalContentAlignment+ ?? "	 ???? 5/   
    ? ?? 50      ?? 51      " ??6"   .R?52      ?? $
 Bd??6   #??z??53   !   #??z??54   !   #??z??55   !   # z??56   !   $
 true??57   !   ._?58      ?? #??z??6+   #??z??59   /   # z 5:   /   5;       5<      P? 5=       ?@??
IsSelected$
 true??68   . ?5>      ?? $ Bd??6%   8   ? ??6K   ?? 5?       ? ??
 ?????6;   5@      ]? 5A       5B      ?? 5C   "    ?@??
IsSelected$
 true??6B   ?? 5D   "    ?@??IsSelectionActive$ false??6R   ./?5F      ?? $ Bd??6;   8   ? ??6K   ?? 5G       ? ??
 ?????6;   5H      P? 5I       ? {?$ false??67   . ?5J      ?? # ? ??6;    ? ??5K      5M      5O      5P      ?? 5R      .R?5S   
     $ MenuItemIcon??6+   $??Center=?6A   $??Center=?5T   /   $??12q?6L    5U   
   ?? 5V      $
 Home??6.    6   ?? .a?5W      ?? $ MenuItemIcon??6    ?@ Kind$
 Home=?6C   5X      ?? 5Y      $ Email??6.    6   ?? .a?5Z      ?? $ MenuItemIcon??6    ?@ Kind$ Email=?6C   5[      ?? 5\      $ Cloud??6.    6   ?? .a?5]      ?? $ MenuItemIcon??6    ?@ Kind$ Cloud=?6C   5^      5`      ?? 5b      " ??6*   .s?5c   
   ??Home??6   ??5d   
   	Email??6   ??5e   
   	Cloud??6   5f      ?? 5h   
   .R?5i        5j      ?? 5k   
   .R?5l        5m      ?? 5n   
   .R?5o        5p      5q      5r      