﻿#pragma checksum "..\..\ClassificationPage01.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "207779E0E07811C359025BC71FD2D4FC3CE770F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TagDocx;


namespace TagDocx {
    
    
    /// <summary>
    /// ClassificationPage01
    /// </summary>
    public partial class ClassificationPage01 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\ClassificationPage01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox 태그검색어;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ClassificationPage01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button 태그검색버튼;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ClassificationPage01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox 태그목록리스트;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ClassificationPage01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl 묶음박스;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ClassificationPage01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox 묶음태그리스트0;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ClassificationPage01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox 묶음태그리스트1;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\ClassificationPage01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox 묶음태그리스트2;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\ClassificationPage01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button 묶음에추가;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\ClassificationPage01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button 묶음에서삭제;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\ClassificationPage01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button gotoMain;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\ClassificationPage01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button strartTag;
        
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
            System.Uri resourceLocater = new System.Uri("/TagDocx;component/classificationpage01.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClassificationPage01.xaml"
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
            this.태그검색어 = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\ClassificationPage01.xaml"
            this.태그검색어.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.TextBox_GotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 2:
            this.태그검색버튼 = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\ClassificationPage01.xaml"
            this.태그검색버튼.Click += new System.Windows.RoutedEventHandler(this.click_search);
            
            #line default
            #line hidden
            return;
            case 3:
            this.태그목록리스트 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.묶음박스 = ((System.Windows.Controls.TabControl)(target));
            
            #line 41 "..\..\ClassificationPage01.xaml"
            this.묶음박스.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TabControl_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.묶음태그리스트0 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.묶음태그리스트1 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.묶음태그리스트2 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.묶음에추가 = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\ClassificationPage01.xaml"
            this.묶음에추가.Click += new System.Windows.RoutedEventHandler(this.묶음에추가_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.묶음에서삭제 = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\ClassificationPage01.xaml"
            this.묶음에서삭제.Click += new System.Windows.RoutedEventHandler(this.묶음비우기_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.gotoMain = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\ClassificationPage01.xaml"
            this.gotoMain.Click += new System.Windows.RoutedEventHandler(this.BtnPreStep);
            
            #line default
            #line hidden
            return;
            case 11:
            this.strartTag = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\ClassificationPage01.xaml"
            this.strartTag.Click += new System.Windows.RoutedEventHandler(this.BtnNextStep);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
