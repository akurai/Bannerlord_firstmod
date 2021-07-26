using System;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;
using TaleWorlds.DotNet;

namespace ExampleMod{
    class ExampleMod : MBSubModuleBase
    {
        protected override void OnSubModuleLoad(){
            Module.CurrentModule.AddInitialStateOption(new InitialStateOption(
                "Message", 
                new TextObject("Click me!", null), 
                9990, 
                () => {InformationManager.DisplayMessage(new InformationMessage("Hello world!"));}, 
                () => {return (false, null);
                }));
        }
    }
}