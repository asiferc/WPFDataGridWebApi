   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid1��5         AutoGenerateColumns$ False��6&      CanUserSortColumns$
 True��5   	      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Employee ID��5   !   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *
EmployeeID+   HeaderTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� ��6,   �� *	Content+	 �� RelativeSource	 �� 
 �� Mode$
 TemplatedParent=��� 5   "    ��Name$ id��6*   -   5        $	��100��5   6   6B   5      5      5         5!      $ Employee Name��5"   !    5!   %   �� *EmployeeName+ 5#      �� 5$      .R�5%      �� $ 
Horizontal=�6)   .+�5&   "   �� ��6,   �� *	Content+	 �� $
 TemplatedParent=��� 5(   "   $
 name��6*   -   5        $	��100��5(   8   6D   5)      5*      5,        5-      $ Location��5.   !    5-   %   �� *
Location+ 5/      �� 50      .R�51      �� $ 
Horizontal=�6)   .+�52   "   �� ��6,   �� *	Content+	 �� $
 TemplatedParent=��� 54   "   $ location��6*   -   5        $	��100��54   <   6H   55      56      58        5:      $ Reporting Manager��5;   !    5:   %   �� *ReportingManager+ 5<      �� 5=      .R�5>      �� $ 
Horizontal=�6)   .+�5?   "   �� ��6,   �� *	Content+	 �� $
 TemplatedParent=��� 5A   "   $ txtReportingManager��6*   -   5        $	��100��5A   G   6S   5B      5C      5E      5G      5I      5J      