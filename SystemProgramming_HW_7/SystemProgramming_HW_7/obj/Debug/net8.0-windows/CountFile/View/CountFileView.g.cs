﻿#pragma checksum "..\..\..\..\..\CountFile\View\CountFileView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9D706803054968AA9B7BDEB20B496CADF8DD2D70"
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
using SystemProgramming_HW_7.CountFile.View;


namespace SystemProgramming_HW_7.CountFile.View {
    
    
    /// <summary>
    /// CountFileView
    /// </summary>
    public partial class CountFileView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\CountFile\View\CountFileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label countFile;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\CountFile\View\CountFileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sizeFile;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\CountFile\View\CountFileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button countFileButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\CountFile\View\CountFileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label countFile1;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\CountFile\View\CountFileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sizeFile1;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\CountFile\View\CountFileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button countFileButton1;
        
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
            System.Uri resourceLocater = new System.Uri("/SystemProgramming_HW_7;component/countfile/view/countfileview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\CountFile\View\CountFileView.xaml"
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
            this.countFile = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.sizeFile = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.countFileButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\CountFile\View\CountFileView.xaml"
            this.countFileButton.Click += new System.Windows.RoutedEventHandler(this.countFileButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.countFile1 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.sizeFile1 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.countFileButton1 = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\CountFile\View\CountFileView.xaml"
            this.countFileButton1.Click += new System.Windows.RoutedEventHandler(this.countFileButton1_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

