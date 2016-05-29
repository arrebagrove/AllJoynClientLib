﻿using AllJoynClientLib.Devices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AllJoynSampleApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public ViewModels.MainViewModel VM { get; } = new ViewModels.MainViewModel();

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem as DeviceClient;
            if(item is AllJoynClientLib.Devices.LSF.LightClient)
            {
                Frame.Navigate(typeof(DeviceViews.LightClientView), item);
            }
            else if (item is AllJoynClientLib.Devices.AllPlay.PlayerClient)
            {
                Frame.Navigate(typeof(DeviceViews.AllPlayClientView), item);
            }
            else if (item is AllJoynClientLib.Devices.Switch.SwitchClient)
            {
                Frame.Navigate(typeof(DeviceViews.SwitchClientView), item);
            }
        }
    }
}
