﻿#pragma checksum "..\..\..\userControls\RecentBuyingUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "22D4A51CEAF44B2E7A12CE4D594E78738632912F2A8091B8E5A840CBFFD500AD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// RecentBuyingUC
    /// </summary>
    public partial class RecentBuyingUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\userControls\RecentBuyingUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addData;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\userControls\RecentBuyingUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ConfirmCheckBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\userControls\RecentBuyingUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid recentBuyingsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\userControls\RecentBuyingUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn ProductColumn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\userControls\RecentBuyingUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn StoreColumn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\userControls\RecentBuyingUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn dateColumn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\userControls\RecentBuyingUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn UserColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/PL;component/usercontrols/recentbuyinguc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\userControls\RecentBuyingUC.xaml"
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
            this.addData = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\userControls\RecentBuyingUC.xaml"
            this.addData.Click += new System.Windows.RoutedEventHandler(this.AddData_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ConfirmCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.recentBuyingsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.ProductColumn = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 5:
            this.StoreColumn = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 6:
            this.dateColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 7:
            this.UserColumn = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

