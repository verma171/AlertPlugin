using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;
namespace Cordova.Extension.Commands
{
    class Alert : BaseCommand
    {
        public void showAlert(string value)
        {
            string optVal = null;
            try
            {
                 optVal = JsonHelper.Deserialize<string[]>(value)[0];
            }
            catch(Exception)
            {
                DispatchCommandResult(new PluginResult(PluginResult.Status.JSON_EXCEPTION));
            }

            Deployment.Current.Dispatcher.BeginInvoke(() =>
                {
                   MessageBoxResult result =  MessageBox.Show(optVal);
                   if(result == MessageBoxResult.OK)
                   {
                       DispatchCommandResult(new PluginResult(PluginResult.Status.OK, "success"));
                   }
                });
        }
    }
}
