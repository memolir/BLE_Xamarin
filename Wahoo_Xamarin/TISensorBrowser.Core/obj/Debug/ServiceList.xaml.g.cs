// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace TISensorBrowser {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class ServiceList : ContentPage {
        
        private ToolbarItem DisconnectButton;
        
        private Label hr_label;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(ServiceList));
            DisconnectButton = this.FindByName <ToolbarItem>("DisconnectButton");
            hr_label = this.FindByName <Label>("hr_label");
        }
    }
}