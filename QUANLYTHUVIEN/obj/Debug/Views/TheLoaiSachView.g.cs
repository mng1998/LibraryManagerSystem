﻿#pragma checksum "..\..\..\Views\TheLoaiSachView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E8D3A5C6EFED81C0895762069A2EE5D6A1D68AFE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QUANLYTHUVIEN.Views;
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


namespace QUANLYTHUVIEN.Views {
    
    
    /// <summary>
    /// TheLoaiSachView
    /// </summary>
    public partial class TheLoaiSachView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 98 "..\..\..\Views\TheLoaiSachView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaTL;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Views\TheLoaiSachView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTenTL;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Views\TheLoaiSachView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGhiChu;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\Views\TheLoaiSachView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TheLoaiList;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\Views\TheLoaiSachView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btThemTL;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Views\TheLoaiSachView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btXoaTL;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Views\TheLoaiSachView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCapNhatTL;
        
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
            System.Uri resourceLocater = new System.Uri("/QUANLYTHUVIEN;component/views/theloaisachview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\TheLoaiSachView.xaml"
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
            this.txtMaTL = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtTenTL = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtGhiChu = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TheLoaiList = ((System.Windows.Controls.DataGrid)(target));
            
            #line 116 "..\..\..\Views\TheLoaiSachView.xaml"
            this.TheLoaiList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TheLoaiList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btThemTL = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\..\Views\TheLoaiSachView.xaml"
            this.btThemTL.Click += new System.Windows.RoutedEventHandler(this.btThemTL_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btXoaTL = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\..\Views\TheLoaiSachView.xaml"
            this.btXoaTL.Click += new System.Windows.RoutedEventHandler(this.btXoaTL_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btCapNhatTL = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\Views\TheLoaiSachView.xaml"
            this.btCapNhatTL.Click += new System.Windows.RoutedEventHandler(this.btCapNhatTL_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

