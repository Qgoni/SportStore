﻿#pragma checksum "..\..\..\Pages\PageAutorisation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D2525799C0AC2C4804E8A13A651AC1BF9713E8133DD99CC31494374C33B00A36"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SportStore.Pages;
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


namespace SportStore.Pages {
    
    
    /// <summary>
    /// PageAutorisation
    /// </summary>
    public partial class PageAutorisation : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Pages\PageAutorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnInputUser;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\PageAutorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassTBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\PageAutorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginTBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\PageAutorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCheckProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/SportStore;component/pages/pageautorisation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageAutorisation.xaml"
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
            this.BtnInputUser = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\PageAutorisation.xaml"
            this.BtnInputUser.Click += new System.Windows.RoutedEventHandler(this.BtnInputUser_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PassTBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.LoginTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtnCheckProduct = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Pages\PageAutorisation.xaml"
            this.BtnCheckProduct.Click += new System.Windows.RoutedEventHandler(this.BtnCheckProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

