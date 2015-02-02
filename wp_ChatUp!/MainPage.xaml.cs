using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Text;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using Windows.Storage;

namespace wp_ChatUp_
{
    public sealed partial class MainPage : Page
    {
        private string un;
        private string autoscroll;
        private bool sendenter = false;
        WebView wv = new WebView();

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            // Chat pvt disablen
            pvt_chat.IsEnabled = false;
            btn_setun.IsEnabled = true;

            // Instellingen laden
            getsettings();
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private void btn_setun_Click(object sender, RoutedEventArgs e)
        {
            // Kijken of er een UN is ingevuld
            if(tb_uname.Text != "")
            {
                // UN opslaan
                un = tb_uname.Text;
                
                // Doorgaan
                pvt_chat.IsEnabled = true;
                tb_uname.IsReadOnly = true;
                btn_setun.IsEnabled = false;

                // Naar andere pivot sliden
                pvt.SelectedItem = pvt_chat;
            }
        }

        private void btn_send_Click(object sender, RoutedEventArgs e)
        {
            // Bericht versturen
            sendmsg();
        }

        private void tb_message_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            // Kijken of er op de enter toets is gedrukt
            if (e.Key == Windows.System.VirtualKey.Enter && sendenter == true)
            {
                // Bericht versturen
                sendmsg();
            }
        }

        private void sendmsg()
        {
            // Kijken of de TB niet leeg is
            if(tb_message.Text != "")
            {
                // Bericht stringen
                string message = tb_message.Text;

                // UN en bericht doorsturen naar db knal pagina
                wv.Navigate(new Uri("http://apps.bartkessels.net/wp_chatup/send.php?uname=" + un + "&message=" + message));

                // Keyboard verbergen
                wv_chat.Focus(FocusState.Pointer);

                // TB legen
                tb_message.Text = "";
            }
        }

        private void abtn_refresh_Click(object sender, RoutedEventArgs e)
        {
            // Webview refreshen
            wv_chat.Refresh();
        }

        private void getsettings()
        {
            // AutoScroll
            if(ApplicationData.Current.LocalSettings.Values["as"] != null)
            {
                if (ApplicationData.Current.LocalSettings.Values["as"].ToString() == "true")
                {
                    // String op true zetten
                    autoscroll = "true";

                    // Bij instellingen op ON zetten
                    tbtn_autoscroll.IsOn = true;
                }
                else
                {
                    // String op false zetten
                    autoscroll = "false";

                    // Bij instellingen op OFF zetten
                    tbtn_autoscroll.IsOn = false;
                }
            }
            else
            {
                // String op true zetten
                autoscroll = "true";

                // Bij instellingen op ON zetten
                tbtn_autoscroll.IsOn = true;
            }

            // EnterSend
            if(ApplicationData.Current.LocalSettings.Values["se"] != null)
            {
                if(ApplicationData.Current.LocalSettings.Values["se"].ToString() == "true")
                {
                    // Bool op true zetten
                    sendenter = true;

                    // Bij instellingen op on zetten
                    tbtn_senderenter.IsOn = true;
                }
                else
                {
                    // Bool op false zetten
                    sendenter = false;

                    // Bij instellingen op off zetten
                    tbtn_senderenter.IsOn = false;
                }
            }
            else
            {
                // Bool op false zetten
                sendenter = false;

                // Bij instellingen op off zetten
                tbtn_senderenter.IsOn = false;
            }
            
            // Webpagina openen
            wv_chat.Navigate(new Uri("http://apps.bartkessels.net/wp_chatup/chat.html?as=" + autoscroll));
            System.Diagnostics.Debug.WriteLine(wv_chat.Source.ToString());
        }

        private void tbtn_autoscroll_Toggled(object sender, RoutedEventArgs e)
        {
            if(tbtn_autoscroll.IsOn)
            {
                // AutoScroll inschakelen
                ApplicationData.Current.LocalSettings.Values["as"] = "true";

                // Instellingen opnieuw inladen
                getsettings();
            }
            else
            {
                // AutoScroll uitschakelen
                ApplicationData.Current.LocalSettings.Values["as"] = "false";

                // Instellingen opnieuw inladen
                getsettings();
            }
        }
    }
}
