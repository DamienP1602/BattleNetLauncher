﻿using BattleNet.ViewModel;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BattleNet.View
{
    /// <summary>
    /// Interaction logic for CustomTitleBar.xaml
    /// </summary>
    public partial class CustomTitleBar : UserControl
    {
        public CustomTitleBar()
        {
            InitializeComponent();
            CustomTitleBarViewModel _vm = new CustomTitleBarViewModel();
            DataContext = _vm;
        }
    }
}