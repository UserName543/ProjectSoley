﻿#pragma checksum "C:\Users\Sascha\Documents\GitHub\ProjectSoley\Project Soley\Project Soley\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3D186908D0F3045612C3FEB5F2EAAF1C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Soley
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.GpioStatus = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.LED = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 3:
                {
                    this.Time = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.Seconds = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.optionButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.optionButton).PointerEntered += this.optionButton_PointerEntered;
                    #line 35 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.optionButton).PointerExited += this.optionButton_PointerExited;
                    #line default
                }
                break;
            case 6:
                {
                    this.testbox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.one_time_alarm = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 45 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.one_time_alarm).Tapped += this.one_time_alarm_Tapped;
                    #line default
                }
                break;
            case 8:
                {
                    this.weekly_alarm = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 46 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.weekly_alarm).Tapped += this.weekly_alarm_Tapped;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

