﻿#pragma checksum "..\..\..\..\..\MVVM\View\RegisterPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D073B2F2F5870F8A4E9534E9AAF2A7396A9D101A2A05C37569DDAD2EEFC11E00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BodyPosition.MVVM.View;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace BodyPosition.MVVM.View {
    
    
    /// <summary>
    /// RegisterPage
    /// </summary>
    public partial class RegisterPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\..\MVVM\View\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\MVVM\View\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastName;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\MVVM\View\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox gender;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\MVVM\View\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phone;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\MVVM\View\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox weight;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\..\MVVM\View\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox height;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\..\MVVM\View\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\..\MVVM\View\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox age;
        
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
            System.Uri resourceLocater = new System.Uri("/BodyPosition;component/mvvm/view/registerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\View\RegisterPage.xaml"
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
            this.firstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.lastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.gender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.phone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.weight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.height = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.date = ((System.Windows.Controls.DatePicker)(target));
            
            #line 83 "..\..\..\..\..\MVVM\View\RegisterPage.xaml"
            this.date.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.date_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.age = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 106 "..\..\..\..\..\MVVM\View\RegisterPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 113 "..\..\..\..\..\MVVM\View\RegisterPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

