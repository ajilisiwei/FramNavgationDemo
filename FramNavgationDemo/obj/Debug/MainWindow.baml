   M S B A M L   `   `   `  ����F  BControlLibs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null>.clr-namespace:ControlLibs;assembly=ControlLibsControlLibs  5   	   L HFramNavgationDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FramNavgationDemoFramNavgationDemo 5   	   "   FramNavgationDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Ccontrols.clr-namespace:ControlLibs;assembly=ControlLibs     5   	   6
convertersclr-namespace:FramNavgationDemo     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5      %  FramNavgationDemo.NaviConverter   MultiConverter   ControlLibs.NavButton �� 
TargetType �� Property �� Value `� 	Converter �� ElementName �� Path �� RelativeSource��%%  &	        '       7     5   
   6<   �� 5	   
   "  6   .�5
      ��  � �� 6(   �� *	NaviCmd+�� 5       � �� 5      `� 5      8   .1�5      �� $ _innerframe��6"   �� 5      $ NavId�6"    6/   �� *Self+5      5      5      5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $��30 �6   �� 5      .+�5   
   �� 
 �� Orientation$
 
Horizontal=�6   .+�5        -   5          Name$ FirstPageBtn��5   !      NavId$ P000001��67   .��6H   
1st Page6R     5      $ P000002��6!   .��62   	2d Page6;     5      $ P000003��6!   .��62   
3td Page6<     5      $ P000004��6!   .��62   
4th Page6<   5       � 5    
   -   5        $��_innerframe��5    8   $��2��6   $
��Auto��6   $
��Auto��6+     � NavigationUIVisibility$ Hidden=�6K   5!      5"      