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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PL.userControls
{
    /// <summary>
    /// Interaction logic for WatchPanelLeftMenuUC.xaml
    /// </summary>
    public partial class WatchPanelLeftMenuUC : UserControl
    {
        public event Action HistoryButtonClickedEvent;
        public WatchPanelLeftMenuUC()
        {
            InitializeComponent();
        }

        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (HistoryButtonClickedEvent != null)
                HistoryButtonClickedEvent();
        }
    }
}
