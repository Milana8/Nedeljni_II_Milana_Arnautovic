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
using Zadatak_1.ViewModel;

namespace Zadatak_1.View
{
    /// <summary>
    /// Interaction logic for AddClinicView.xaml
    /// </summary>
    public partial class AddClinicView : Window
    {
        public AddClinicView()
        {
            InitializeComponent();
            this.DataContext = new AddClinicViewModel(this);
        }
    }
}
