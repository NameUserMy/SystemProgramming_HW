﻿#pragma checksum "..\..\..\..\..\OneReadOneView\View\OneToOne.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7832B50839C1DB1C62B00DCA8E43CD32ACCE97D0"
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
using SystemProgramming_HW_6.OneReadOneView.View;


namespace SystemProgramming_HW_6.OneReadOneView.View {
    
    
    /// <summary>
    /// OneToOne
    /// </summary>
    public partial class OneToOne : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\OneReadOneView\View\OneToOne.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountNumber;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\OneReadOneView\View\OneToOne.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startSaveButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\OneReadOneView\View\OneToOne.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startReadButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\OneReadOneView\View\OneToOne.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView firstList;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\OneReadOneView\View\OneToOne.xaml"
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
            System.Uri resourceLocater = new System.Uri("/SystemProgramming_HW_6;V1.0.0.0;component/onereadoneview/view/onetoone.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\OneReadOneView\View\OneToOne.xaml"
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
            
            #line 21 "..\..\..\..\..\OneReadOneView\View\OneToOne.xaml"
            this.CountNumber.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CountNumber_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.startSaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\..\OneReadOneView\View\OneToOne.xaml"
            this.startSaveButton.Click += new System.Windows.RoutedEventHandler(this.startSaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.startReadButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\OneReadOneView\View\OneToOne.xaml"
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

