﻿#pragma checksum "..\..\..\..\..\Loader\View\LoaderView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AE7AC1FCFA26D54C479477AEDB34FA5EA37A844D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using SystemProgramming_HW_6.Loader.View;


namespace SystemProgramming_HW_6.Loader.View {
    
    
    /// <summary>
    /// LoaderView
    /// </summary>
    public partial class LoaderView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\Loader\View\LoaderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sourceTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Loader\View\LoaderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox destinationTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Loader\View\LoaderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sourceButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Loader\View\LoaderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button destinationButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Loader\View\LoaderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startCopyButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\Loader\View\LoaderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressBar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SystemProgramming_HW_6;component/loader/view/loaderview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Loader\View\LoaderView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.sourceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.destinationTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.sourceButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\Loader\View\LoaderView.xaml"
            this.sourceButton.Click += new System.Windows.RoutedEventHandler(this.sourceButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.destinationButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\Loader\View\LoaderView.xaml"
            this.destinationButton.Click += new System.Windows.RoutedEventHandler(this.destinationButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.startCopyButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\..\Loader\View\LoaderView.xaml"
            this.startCopyButton.Click += new System.Windows.RoutedEventHandler(this.startCopyButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.progressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

