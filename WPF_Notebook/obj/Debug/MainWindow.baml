   M S B A M L   `   `   `  ����� 5   	   \  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5      )SampleControlsSampleControls      5        � Title$+  %Acceleration and Deceleration Example��5      .��5      �� $��20q�6   .+�5   
   �� -   5        $*��$nonAcceleratedOrDeceleratedRectangle��5      ���#9933FF$��10��5      $��20��6   $
��Left=�6   �� 5
   
   -   5        $��acceleratedRectangle��5
      ���#3333FF$��10��5      $��20��6   $
��Left=�6   �� 5   
   -   5        $��deceleratedRectangle��5      ���#33FF66$��10��5      $��20��6   $
��Left=�6   �� 5   
   -   5        $(��"acceleratedAndDeceleratedRectangle��5      ���#CCFF33$��10��5      $��20��6   $
��Left=�6   �� 5   
   $��0,30,0,0q�6   $
��Left=�6#   $��Start Animations��5       � Triggers 5      :� 5       :� RoutedEvent$ Button.Click��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$* $nonAcceleratedOrDeceleratedRectangle��5       �� TargetProperty$ (Rectangle.Width)�5       g� Duration$ 0:0:10D�5       W� From$ 20X�6#   	 W� To$	 400X�6-   W� 5"      $ acceleratedRectangle��5#      $ (Rectangle.Width)�5$       g� AccelerationRatio$	 0.4Q�5%      $ 0:0:10D�6)   $ 20X�6;   $	 400X�6E   W� 5(      $ deceleratedRectangle��5)      $ (Rectangle.Width)�5*      	 g� DecelerationRatio$		 0.6Q�5+      $ 0:0:10D�6)   $ 20X�6;   $	 400X�6E   W� 5/      $( "acceleratedAndDeceleratedRectangle��50      $ (Rectangle.Width)�51      $	 0.4Q�52      $		 0.6Q�6)   $ 0:0:10D�6A   $ 20X�6S   $	 400X�6]   53      54      55      57      58      59      