   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Zadatak_1.ViewZadatak_1.View  5   	   "    Zadatak_1.View.AddClinicView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Zadatak_1.View     5   	     � Title$  AddClinicView��5   	   $	��450��6   $	��800��6,   .��5
      � .+�5   
   �� -   5        $��lblClinicName��5      $��ClinicName:��5      $
��Left=�5      $	��Top=�5      $��	50,10,0,0q�5      $��88��5      �� 5   
   -   5        $��lblDateConstruction��5      $��DateConstruction:��5      $
��Left=�5      $	��Top=�5      $��	50,41,0,0q�5      $	��123��5      �� 5   
   -   5        $��lblClinicOwner��5      $��ClinicOwner:��5      $
��Left=�5      $	��Top=�5      $��	50,72,0,0q�5      $��88��5      �� 5   
   -   5        $��	lblAdress��5      $��Adress:��5      $
��Left=�5      $	��Top=�5       $��
50,103,0,0q�5!      $��88��5"      �� 5#   
   -   5        $��lblFloorNumber��5$      $��FloorNumber:��5#      $
��Left=�5%      $	��Top=�5&      $��
50,134,0,0q�5'      $��88��5(      �� 5)   
   -   5        $��lblNumberRoomsPerFloor��5*      $��NumberRoomsPerFloor:��5)      $
��Left=�5+      $	��Top=�5,      $��
50,165,0,0q�5-      $	��139��5.      �� 5/   
   -   5        $��
lblBalcony��50      $��Balcony:��5/      $
��Left=�51      $	��Top=�52      $��
50,196,0,0q�53      $��88��54       J� RenderTransformOrigin$ 0.518,3.875&�6   �� 55   
   -   5        $��	lblGarden��56      $��Garden:��55      $
��Left=�57      $	��Top=�58      $��
50,227,0,0q�59      $��88��5:      �� 5;   
   -	   5        $��lblAmbulancesParking��5<      $��AmbulancesParking:��5;      $
��Left=�5=      $	��Top=�5>      $��
50,253,0,0q�5?      $	��123��5@      �� 5A   
   -
   5        $��lblInvalidParking��5B      $��InvalidParking:��5A      $
��Left=�5C      $	��Top=�5D      $��
50,279,0,0q�5E      $	��102��5F      �� 5J   
   $
��Left=�6   $��23��5K       �� TextWrapping$
 Wrap=�5L      $	��Top=�5M      $	��120��5N      $��
205,13,0,0q�5O      ��5P      �� *Clinic.ClinicName+ �� UpdateSourceTrigger$ PropertyChanged=�(  "System.Windows.Controls.DatePicker  5Q   
   $��23��6   $	��Top=�5R      $	��120��5S      $��205,44,468.6,0q�5T         SelectedDate 5V   
   �� *Clinic.DateConstruction+$ PropertyChanged=��� 5W   
   $
��Left=�6   $��23��5X      $
 Wrap=�5Y      $	��Top=�5Z      $	��120��5[      $��
205,75,0,0q�5\      ��5]      �� *Clinic.ClinicOwner+$ PropertyChanged=��� 5^   
   $
��Left=�6   $��23��5_      $	��Top=�5`      $	��120��5a      $��205,106,0,0q�5b      ��5c      �� *Clinic.Adress+$ PropertyChanged=��� 5d   
   $
��Left=�6   $��23��5e      $	��Top=�5f      $	��120��5g      $��205,134,0,0q�5h      ��5i      �� *Clinic.FloorNumber+$ PropertyChanged=��� 5l   
   $
��Left=�6   $��23��5m      $
 Wrap=�5n      $	��Top=�5o      $	��120��5p      $��205,168,0,0q�5q      ��5r      �� *Clinic.NumberRoomsPerFloor+$ PropertyChanged=��� 5u   
   -   5        $��	cbBalcony��5u      $	��130��6   $��205,202,458.6,-202q�6z    d� 	IsChecked 61   �� *Clinic.Balcony+$ PropertyChanged=�5v      �� 5x   
   -   5        $��cbGarden��5x      $	��130��6   $��205,227,458.6,-227q�6x    60   �� *Clinic.Garden+$ PropertyChanged=�5y      �� 5z   
   $
��Left=�6   $��23��5{      $
 Wrap=�5|      $	��Top=�5}      $	��120��5~      $��205,250,0,0q�5      ��5�      �� *Clinic.AmbulancesParking+$ PropertyChanged=��� 5�   
   $
��Left=�6   $��23��5�      $
 Wrap=�5�      $	��Top=�5�      $	��120��5�      $��205,278,0,0q�5�      ��5�      �� *Clinic.InvalidParking+$ PropertyChanged=��� 5�   
   $
��Save��6   $��80,349,620.6,43q�5�   O   ���#545d6a
�������$��12(�6�    �� 	IsDefault . ��6   �� *Save+$ PropertyChanged=�6�   �� 5�   
   -   5        $��btnClose��5�      $��Close��6"   $��293,349,407.6,43q�5�   Q   ���#545d6a
�������$��12(�6�    . ��6   �� *Close+$ PropertyChanged=�6�   5�      5�      