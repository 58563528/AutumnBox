﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/8/2 20:04:55 (UTC +8:00)
** desc： ...
*************************************************/
using AutumnBox.OpenFramework.Extension;
using System.Threading;

namespace AutumnBox.ExampleExtensions
{
    [ExtRequiredDeviceStates(Basic.Device.DeviceState.None)]
    [ExtName("重启测试器")]
    public class FuckExt : AutumnBoxExtension
    {
        public override int Main()
        {
            App.ShowLoadingWindow();
            Thread.Sleep(5000);
            App.CloseLoadingWindow();
            return 0;
        }
    }
}
