﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Zadatak_1.Model;
using Zadatak_1.ViewModel;

namespace Zadatak_1.View
{
    /// <summary>
    /// Interaction logic for EditClinicView.xaml
    /// </summary>
    public partial class EditClinicView : Window
    {
        public EditClinicView(tblClinic clinicToEdit)
        {
            InitializeComponent();
            this.DataContext = new EditClinicViewModel(this, clinicToEdit);
        }
    }
}
