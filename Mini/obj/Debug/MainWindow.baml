   M S B A M L   `   `   `  ����?  ;Mini, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MiniMini  5   	       Mini.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Mini     5   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ 	CanResize=�5	   	   $	��320��5
   	   $	��530��5   	   $	��483��5   	   $	��800��5   	   
������  � Title$ 
MainWindow��5   	   $	��530��6   $	��320��6)   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�6      ResizeBorderThickness$ 5q�5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��2* �6#   �� 5      $��* �6#   �� 5      $��2* �6#   .+�5!      �� -   5        $��0��5!      
���   �$��30��66   $��3��6B   5"      �� 5#      $��1��6   $��Stretch=�6$   $��Stretch=�6@   $��Center=�5$      $��Stretch=�68   $
��Mini��6V   
�������6e   �� 5%      $��0,0,10,0q�6   $��2��6+    �� Orientation$ 
Horizontal=�6;   $��Right=�6T   .+�5&      �� -   5        $��minimize_Btn��5&      $��20��6-   $��20��68   $��_��6D   6P   �� 5'      -   5        $��maximize_Btn��5'      $��20��6-   $��20��68   $��O��6D   6P   �� 5(      -   5        $��	close_Btn��5(      $��20��6*   $��20��65   $��X��6A   6M   5)      5*      �� 5-   
   $��1��6   
�������$	��Top=�65   ._�5.      (� 	 (� Stretch$	 Uniform=�6   .��5/       � -   5        $��	mainFrame��5/      
  � NavigationUIVisibility$
 Hidden=�50      51      52      53      54      