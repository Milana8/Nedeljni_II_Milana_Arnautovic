   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Zadatak_1.ViewZadatak_1.View  5   	   #    Zadatak_1.View.EditClinicView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Zadatak_1.View     5   	     � Title$  EditClinicView��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5   
   �� -   5        $��lblClinicOwner��5      $��ClinicOwner:��5      $
��Left=�5      $	��Top=�5      $��	50,72,0,0q�5      $��88��5      �� 5   
   -   5        $��lblAmbulancesParking��5      $��AmbulancesParking:��5      $
��Left=�5      $	��Top=�5      $��
50,103,0,0q�5      $	��123��5      �� 5   
   -   5        $��lblInvalidParking��5      $��InvalidParking:��5      $
��Left=�5      $	��Top=�5      $��
50,134,0,0q�5      $	��102��5      �� 5"   
   $
��Left=�6   $��23��5#       �� TextWrapping$
 Wrap=�5$      $	��Top=�5%      $	��120��5&      $��
205,75,0,0q�5'      ��5(      �� *Clinic.ClinicOwner+ �� UpdateSourceTrigger$ PropertyChanged=��� 5*   
   $
��Left=�6   $��23��5+      $
 Wrap=�5,      $	��Top=�5-      $	��120��5.      $��205,105,0,0q�5/      ��50      �� *Clinic.AmbulancesParking+$ PropertyChanged=��� 51   
   $
��Left=�6   $��23��52      $
 Wrap=�53      $	��Top=�54      $	��120��55      $��205,137,0,0q�56      ��57      �� *Clinic.InvalidParking+$ PropertyChanged=��� 59   
   $
��Save��6   $��80,349,620.6,43q�5:   O   ���#545d6a
�������$��12(�6�    �� 	IsDefault . ��6   �� *Save+$ PropertyChanged=�6�   �� 5;   
   -   5        $��btnClose��5<      $��Close��6"   $��293,349,407.6,43q�5=   Q   ���#545d6a
�������$��12(�6�    . ��6   �� *Close+$ PropertyChanged=�6�   5?      5@      