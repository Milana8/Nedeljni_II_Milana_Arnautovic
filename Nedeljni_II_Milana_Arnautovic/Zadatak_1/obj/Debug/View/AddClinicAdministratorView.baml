   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Zadatak_1.ViewZadatak_1.View  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   /    )Zadatak_1.View.AddClinicAdministratorView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Zadatak_1.View     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$   AddClinicAdministratorView��5	   	   $	��450��6,   $	��800��69    � 	Resources 5
      �� 5   
    �� Type" ��6      Key
Gender  .s�5      ��M��6   ��5      F��6   ��5      O��6   ��5      X��6   5      .��5      � .+�5   
   �� -   5        $��lblFirstName��5      $��
FirstName:��5      $
��Left=�5      $	��Top=�5      $��	50,10,0,0q�5      $��88��5      �� 5   
   -   5        $��
lblSurname��5      $��Surname:��5      $
��Left=�5      $	��Top=�5      $��	50,41,0,0q�5      $��88��5      �� 5    
   -   5        $��	lblIdCard��5!      $��IdCard:��5       $
��Left=�5"      $	��Top=�5#      $��	50,72,0,0q�5$      $��88��5%      �� 5&   
   -   5        $��	lblGender��5'      $��Gender:��5&      $
��Left=�5(      $	��Top=�5)      $��
50,103,0,0q�5*      $��88��5+      �� 5,   
   -   5        $��lblDateOfBirth��5-      $��DateOfBirth:��5,      $
��Left=�5.      $	��Top=�5/      $��
50,134,0,0q�50      $��88��51      �� 52   
   -   5        $��lblCitizenship��53      $��Citizenship:��52      $
��Left=�54      $	��Top=�55      $��
50,165,0,0q�56      $	��103��57      �� 58   
   -   5        $��lblUsername��59      $��	Username:��58      $
��Left=�5:      $	��Top=�5;      $��
50,196,0,0q�5<      $��88��5=       J� RenderTransformOrigin$ 0.518,3.875&�6   �� 5>   
   -   5        $��
lblPasword��5?      $��Pasword:��5>      $
��Left=�5@      $	��Top=�5A      $��
50,227,0,0q�5B      $��88��5C      �� 5F   
   $
��Left=�6   $��23��5G       �� TextWrapping$
 Wrap=�5H      $	��Top=�5I      $	��120��5J      $��
205,13,0,0q�5K      ��5L      �� *Administrator.FirstName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5M   
   $
��Left=�6   $��23��5N      $
 Wrap=�5O      $	��Top=�5P      $	��120��5Q      $��
205,44,0,0q�5R      ��5S      �� *Administrator.Surname+$ PropertyChanged=��� 5T   
   $
��Left=�6   $��23��5U      $
 Wrap=�5V      $	��Top=�5W      $	��120��5X      $��
205,75,0,0q�5Y      ��5Z      �� *Administrator.IdCard+$ PropertyChanged=��� 5[   
   $
��Left=�6   $��23��5\      $	��Top=�5]      $	��120��5^      $��205,106,0,0q�5_       
 Gender#��[ 5`       �� SelectedItem 5a      �� *Administrator.Gender+$ PropertyChanged=�5b      (  "System.Windows.Controls.DatePicker  5c   
   $��23��6   $	��Top=�5d      $	��120��5e      $��205,137,468.6,0q�5f         SelectedDate 5h   
   �� *Administrator.DateOfBirth+$ PropertyChanged=��� 5l   
   $
��Left=�6   $��23��5m      $
 Wrap=�5n      $	��Top=�5o      $	��120��5p      $��205,168,0,0q�5q      ��5r      �� *Administrator.Citizenship+$ PropertyChanged=��� 5u   
   $
��Left=�6   $��23��5v      $
 Wrap=�5w      $	��Top=�5x      $	��120��5y      $��205,199,0,0q�5z      ��5{      �� *Administrator.Username+$ PropertyChanged=��� 5|   
   $
��Left=�6   $��23��5}      $
 Wrap=�5~      $	��Top=�5      $	��120��5�      $��205,230,0,0q�5�      ��5�      �� *Administrator.Pasword+$ PropertyChanged=��� 5�   
   $
��Save��6   $��86,288,614.6,104q�5�   O   ���#545d6a
�������$��12(�6�    �� 	IsDefault . ��6   �� *Save+$ PropertyChanged=�6�   �� 5�   
   -	   5        $��btnClose��5�      $��Close��6"   $��298,288,402.6,104q�5�   Q   ���#545d6a
�������$��12(�6�    . ��6   �� *Close+$ PropertyChanged=�6�   5�      5�      