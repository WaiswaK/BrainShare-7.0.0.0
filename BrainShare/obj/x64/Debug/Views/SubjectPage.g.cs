﻿

#pragma checksum "C:\Users\Kenneth\Documents\Visual Studio 2013\Projects\BrainShare\BrainShare\Views\SubjectPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D88674FE216B89B4F34E2028D92FFA35"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrainShare.Views
{
    partial class SubjectPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 66 "..\..\..\Views\SubjectPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.itemGridView_SelectionChanged;
                 #line default
                 #line hidden
                #line 66 "..\..\..\Views\SubjectPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.Category_click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


