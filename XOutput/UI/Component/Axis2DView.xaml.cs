﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using XOutput.Input;
using XOutput.UI.Component;

namespace XOutput.UI.Component
{
    /// <summary>
    /// Interaction logic for AxisView.xaml
    /// </summary>
    public partial class Axis2DView : UserControl, IUpdatableView
    {
        protected readonly Axis2DViewModel viewModel;

        public Axis2DView(Enum typex, Enum typey)
        {
            viewModel = new Axis2DViewModel(typex, typey, 42, 42);
            DataContext = viewModel;
            InitializeComponent();
        }

        public void updateValues(IDevice device)
        {
            viewModel.updateValues(device);
        }
    }
}