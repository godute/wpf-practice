   M S B A M L   `   `   `  ���� I  EWPF_MakeButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPF_MakeButtonWPF_MakeButton      WPF_MakeButton.App   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     .localclr-namespace:WPF_MakeButton       �� 	Resources      MyGlassGradientStopsResource � Color � Offset  MyGlassBrushResource �� 
StartPoint �� EndPoint �� Opacity  GrayBlueGradientBrush �� 
TargetType �� Property �� Value	 �� 
TargetType
 ��Name �� RadiusX �� RadiusY J� Opacity J� RenderTransformOrigin J� BitmapEffect ��Name �� Triggers P� Property P� Value �� 
TargetName �� Radius :� RoutedEvent ��Name �� 
TargetName �� TargetProperty	 W� By g� Duration �� BeginStoryboardName��%�  &	        &	 �     7   &	 �     '�� c    7  7  � � $ 
WhiteSmoke��$	 0.2Q�� $ Transparent��$	 0.4Q�� $ 
WhiteSmoke��$	 0.5Q�� $ Transparent��$
 0.75Q�� $ 
WhiteSmoke��$	 0.9Q�� $ Transparent��$ 1Q��� $	 0,0&�$	 1,1&�$
 0.75Q�8��  �� $
 0, 0&�$
 1, 1&�.��� $ DarkGray��$ 0Q�� $ #CCCCFF��$	 0.5Q�� $ DarkGray��$ 1Q��� " ��.���  � ��8   ��  � ��$ 80����  � ��$ 10q���  � �� �� "	 ��.R�� #��z��#��z��}�. .+��� $
 outerRectangle��$��Stretch=�$��Stretch=�#��z��$ 20��$ 20��$��5��
������ �� $
 innerRectangle��$��Stretch=�$��Stretch=�
������ $��20��#��z��$ 20��$ 20���� $
 	glassCube��$��Stretch=�$��Stretch=�$��2��$ 10��$ 10��$ 0Q�8�� $ 0.5, 0.5&����� $ 0.5, 0&�$ 0.5, 1&���� $	 0.0Q�$ 	LightBlue��� $	 1.0Q�$
 Gray��z�V� .~��� ��  �� ]� $!��myContentPresenterDockPanel��.+��� $ myContentPresenter��$��20q�#��z��
���   � P�  �@J�IsMouseOver . . ��� $ outerRectangle��# � �� � ���� $ 	glassCube�� �@J�Opacity$ 1Q��� $ myContentPresenter�� �@J�BitmapEffect �� $ 1Q�P�  �@J�	IsFocused . . ��� $ 	glassCube�� �@J�Opacity$ 1Q��� $ outerRectangle��# � �� � ���� $ 	glassCube�� �@J�Opacity$ 1Q�:� $ Mouse.MouseEnter��[��� $ mouseEnterBeginStoryBoard��.���� .��W� $ 	glassCube��$V P(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$
 -0.5X�$ 0:0:2.5D�W� $ 	glassCube��$V P(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$
 -0.5X�$ 0:0:2.5D�:� $ Mouse.MouseLeave��[��� $ mouseEnterBeginStoryBoard��:� $ Button.Click��[��� .���� .��W� $ 	glassCube��$V P(Rectangle.RenderTransform).(TransformGroup.Children)[1].(RotateTransform.Angle)�$	 360X�$ 0:0:2.0D�