﻿#pragma checksum "..\..\..\..\..\DoubleReadFile\View\DoubleRead.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3B3C8EF825123EF19C094927E7A70BE1B31BE526"
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
using SystemProgramming_HW_6.DoubleReadFile.Control;
using SystemProgramming_HW_6.DoubleReadFile.View;


namespace SystemProgramming_HW_6.DoubleReadFile.View {
    
    
    /// <summary>
    /// DoubleRead
    /// </summary>
    public partial class DoubleRead : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\DoubleReadFile\View\DoubleRead.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountNumber;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\DoubleReadFile\View\DoubleRead.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startSaveButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\DoubleReadFile\View\DoubleRead.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startReadButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\DoubleReadFile\View\DoubleRead.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView firstList;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\DoubleReadFile\View\DoubleRead.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SecondList;
        
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
            System.Uri resourceLocater = new System.Uri("/SystemProgramming_HW_6;component/doublereadfile/view/doubleread.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\DoubleReadFile\View\DoubleRead.xaml"
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
            this.CountNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\..\..\DoubleReadFile\View\DoubleRead.xaml"
            this.CountNumber.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CountNumber_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.startSaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\DoubleReadFile\View\DoubleRead.xaml"
            this.startSaveButton.Click += new System.Windows.RoutedEventHandler(this.startSaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.startReadButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\..\DoubleReadFile\View\DoubleRead.xaml"
            this.startReadButton.Click += new System.Windows.RoutedEventHandler(this.startReadButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.firstList = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.SecondList = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

