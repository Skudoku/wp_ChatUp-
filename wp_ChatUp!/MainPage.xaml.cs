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
using Windows.UI.Popups;
using System.Net;

namespace wp_ChatUp_
{
    public sealed partial class MainPage : Page
    {
        private string un;
        private string autoscroll;
        private bool sendenter = false;
        WebView wv = new WebView();
        Message message = new Message();
        Language language = new Language();

        public MainPage()
        {
            this.InitializeComponent();
            abtn_addroom.Visibility = Visibility.Collapsed;
            MessageDialog msg = new MessageDialog(Message.GetMessage(1));
            lv_rooms.Visibility = Visibility.Collapsed;
            this.NavigationCacheMode = NavigationCacheMode.Required;
            sld_fontsize.Value = 1;
            lv_rooms.ItemsSource = Room.GetRooms();
            // Chat pvt disablen
            pvt_chat.IsEnabled = false;

            // Instellingen laden
            getsettings();
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            cb_languages.ItemsSource = language.GetLanguages();
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

                // Naar andere pivot sliden
                pvt.SelectedItem = pvt_chat;
            }
        }

        private void tb_message_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            // Kijken of er op de enter toets is gedrukt
            if (e.Key == Windows.System.VirtualKey.Enter && sendenter == true)
            {
                // Bericht versturen
                message.Send(un, tb_message.Text);
                tb_message.Text = "";
                pvt.Focus(FocusState.Programmatic);
            }
        }


        private void abtn_refresh_Click(object sender, RoutedEventArgs e)
        {
            // Webview refreshen
            //wv_chat.Refresh();
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
            //wv_chat.Navigate(new Uri("http://www.google.nl"));
            //System.Diagnostics.Debug.WriteLine(wv_chat.Source.ToString());
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

        private void abtn_send_Click(object sender, RoutedEventArgs e)
        {
            // Bericht versturen
            //sendmsg();
            message.Send(un, tb_message.Text);
            tb_message.Text = "";
            pvt.Focus(FocusState.Programmatic);
        }

        private void sld_fontsize_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            //small 12
            //medium 18
            //large 24
            //if (e.NewValue == 1)
            //{
            //    
            //}
            //if (e.NewValue == 2)
            //{
            //
            //}
            //if (e.NewValue == 3)
            //{
            //
            //}
        }

        private void pvt_PivotItemLoading(Pivot sender, PivotItemEventArgs args)
        {
            if (args.Item == pvt_rooms)
            {
                abtn_addroom.Visibility = Visibility.Visible;
            }
            else
            {
                abtn_addroom.Visibility = Visibility.Collapsed;
            }
        }

        private void cb_languages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lv_rooms.Visibility = Visibility.Visible;
        }

        private void abtn_addroom_Click(object sender, RoutedEventArgs e)
        {
            grd_rooms_default.Visibility = Visibility.Collapsed;
            grd_rooms_add.Visibility = Visibility.Visible;
        }

        private  void btn_addroom_Click(object sender, RoutedEventArgs e)
        {
            Room.AddRoom(tb_addroom.Text);
            lv_rooms.ItemsSource = Room.GetRooms();
            grd_rooms_add.Visibility = Visibility.Collapsed;
            grd_rooms_default.Visibility = Visibility.Visible;
        }
    }
}
