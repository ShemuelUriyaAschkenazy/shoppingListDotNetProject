﻿#pragma checksum "..\..\..\userControls\DataSectionsUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4981658A2DC545E56FFDF9599BBEF079521D126BBFDE51237FE2CAFB483900B6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
using PL.userControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PL.userControls {
    
    
    /// <summary>
    /// DataSectionsUC
    /// </summary>
    public partial class DataSectionsUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\userControls\DataSectionsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart chart;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\userControls\DataSectionsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.Axis chartAxisX;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\userControls\DataSectionsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox parameterCB;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\userControls\DataSectionsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox scalingCB;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\userControls\DataSectionsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label timeFirstLabel;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\userControls\DataSectionsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox timeFirstCB;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\userControls\DataSectionsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label timeSecondLabel;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\userControls\DataSectionsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox timeSecondCB;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PL;component/usercontrols/datasectionsuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\userControls\DataSectionsUC.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.chart = ((LiveCharts.Wpf.CartesianChart)(target));
            return;
            case 2:
            this.chartAxisX = ((LiveCharts.Wpf.Axis)(target));
            return;
            case 3:
            this.parameterCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.scalingCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\..\userControls\DataSectionsUC.xaml"
            this.scalingCB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.scalingCB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.timeFirstLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.timeFirstCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.timeSecondLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.timeSecondCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

