﻿

#pragma checksum "C:\Users\Ties\Desktop\SMW21\AO\wp_ChatUp!\wp_ChatUp!\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "701AFC443691ABCC0F653CEFA5840A97"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wp_ChatUp_
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.CommandBar cb_chat; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton abtn_setun; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton abtn_refresh; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton abtn_send; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton abtn_addroom; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Pivot pvt; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.PivotItem pvt_main; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.PivotItem pvt_rooms; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.PivotItem pvt_chat; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ToggleSwitch tbtn_autoscroll; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ToggleSwitch tbtn_senderenter; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Slider sld_fontsize; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.WebView wv_chat; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox tb_message; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ComboBox cb_languages; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView lv_rooms; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox tb_uname; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///MainPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            cb_chat = (global::Windows.UI.Xaml.Controls.CommandBar)this.FindName("cb_chat");
            abtn_setun = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("abtn_setun");
            abtn_refresh = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("abtn_refresh");
            abtn_send = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("abtn_send");
            abtn_addroom = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("abtn_addroom");
            pvt = (global::Windows.UI.Xaml.Controls.Pivot)this.FindName("pvt");
            pvt_main = (global::Windows.UI.Xaml.Controls.PivotItem)this.FindName("pvt_main");
            pvt_rooms = (global::Windows.UI.Xaml.Controls.PivotItem)this.FindName("pvt_rooms");
            pvt_chat = (global::Windows.UI.Xaml.Controls.PivotItem)this.FindName("pvt_chat");
            tbtn_autoscroll = (global::Windows.UI.Xaml.Controls.ToggleSwitch)this.FindName("tbtn_autoscroll");
            tbtn_senderenter = (global::Windows.UI.Xaml.Controls.ToggleSwitch)this.FindName("tbtn_senderenter");
            sld_fontsize = (global::Windows.UI.Xaml.Controls.Slider)this.FindName("sld_fontsize");
            wv_chat = (global::Windows.UI.Xaml.Controls.WebView)this.FindName("wv_chat");
            tb_message = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("tb_message");
            cb_languages = (global::Windows.UI.Xaml.Controls.ComboBox)this.FindName("cb_languages");
            lv_rooms = (global::Windows.UI.Xaml.Controls.ListView)this.FindName("lv_rooms");
            tb_uname = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("tb_uname");
        }
    }
}



