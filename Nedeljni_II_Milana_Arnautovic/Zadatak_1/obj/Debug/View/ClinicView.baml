   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Zadatak_1.ViewZadatak_1.View  5   	       Zadatak_1.View.ClinicView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Zadatak_1.View     5   	     � Title$  
ClinicView��5   	   $	��450��6   $
��1100��6)   .��5	      � $��
0,0,-6.4,0q�6    � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��20 �6   .+�5   
   �� $��
Add clinic��6   $
��Left=�5      $��0.2,1,0,0.2q�6,   $��65��6A   $��2��6L   $��1��6]   ��5   &   �� *	AddClinic+5   ]   � 5   
   $��1��6   $��3��6   .+�5      &   System.Windows.Controls.DataGrid     
IsReadOnly .    HeadersVisibility$ Column=�5   #      AutoGenerateColumns .  ��5      �� *
ClinicList+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5      �� *Clinic+$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	Clinic ID��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6<   �� *
ClinicID+  5       $	 Clinic name��6)   
 6>   �� *
ClinicName+  5!      $	 DateConstruction��6)   
 6C   �� *DateConstruction+  5"      $	 ClinicOwner��6)   
 6>   �� *ClinicOwner+  5#      $	 Adress��6)   
 69   �� *Adress+  5$      $	 FloorNumber��6)   
 6>   �� *FloorNumber+  5%      $	 NumberRoomsPerFloor��6)   
 6F   �� *NumberRoomsPerFloor+  5&      $	 Balcony��6)   
 6:   �� *	Balcony+  5'      $	 Garden��6)   
 69   �� *Garden+  5(      $	 AmbulancesParking��6)   
 6D   �� *AmbulancesParking+  5)      $	 InvalidParking��6)   
 6A   �� *InvalidParking+4  .System.Windows.Controls.DataGridTemplateColumn  5+         CellTemplate 5,      �� 5-      .R�5.   "   �� $
��Edit��6)   ��68   ��  �� RelativeSource ��  �� AncestorType"   �� Path$ DataContext.EditClinic�5/      51      53      54      55      56      