// Updated by XamlIntelliSenseFileGenerator 12/04/2022 00:22:06
#pragma checksum "..\..\CutList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "819EE1B1D6E2A9C0B53BCD4C06598ACAC711E8E561C3CB4224004F7B1CD94877"
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
using WpfApp5;


namespace WpfApp5
{


    /// <summary>
    /// CutList
    /// </summary>
    public partial class CutList : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 17 "..\..\CutList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox width;

#line default
#line hidden


#line 22 "..\..\CutList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fullHeight;

#line default
#line hidden


#line 27 "..\..\CutList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox kicker;

#line default
#line hidden


#line 32 "..\..\CutList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lowSideHeight;

#line default
#line hidden


#line 37 "..\..\CutList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox flatTopWidth;

#line default
#line hidden


#line 42 "..\..\CutList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox angle;

#line default
#line hidden


#line 49 "..\..\CutList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox depth;

#line default
#line hidden


#line 54 "..\..\CutList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cabinetWidth;

#line default
#line hidden


#line 59 "..\..\CutList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox drawerNumber;

#line default
#line hidden


#line 67 "..\..\CutList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn1;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp5;component/cutlist.xaml", System.UriKind.Relative);

#line 1 "..\..\CutList.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.width = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.fullHeight = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.kicker = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.lowSideHeight = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.flatTopWidth = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.angle = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.depth = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.cabinetWidth = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 9:
                    this.drawerNumber = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 10:
                    this.btn1 = ((System.Windows.Controls.Button)(target));

#line 69 "..\..\CutList.xaml"
                    this.btn1.Click += new System.Windows.RoutedEventHandler(this.cuttingList_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.CheckBox hasTallUnit;
    }
}

