using Microsoft.Extensions.Logging;
using OpenMod.Unturned.Plugins;
using Cysharp.Threading.Tasks;
using OpenMod.API.Plugins;
using System;

[assembly: PluginMetadata("WilDev.AutoSave", DisplayName = "WilDev Studios' Automatic Saving Plugin", Author = "WilDev Studios", Description = "Unturned plugin to add automatic saving through the OpenMod API", Website = "https://discord.gg/4Ggybyy87d")]
namespace AutoSave
{
    public class AutoSavePlugin : OpenModUnturnedPlugin
    {
        private readonly ILogger<AutoSavePlugin> m_Logger;

        public AutoSavePlugin(
            ILogger<AutoSavePlugin> logger,
            IServiceProvider serviceProvider) : base(serviceProvider)
        {
            m_Logger = logger;
        }

        protected override UniTask OnLoadAsync()
        {
            m_Logger.LogInformation("+==========================================================+");
            m_Logger.LogInformation("| WILDEV.AUTOSAVE plugin has been loaded!                  |");
            m_Logger.LogInformation("| Made with <3 by WildKadeGaming @ WilDev Studios          |");
            m_Logger.LogInformation("| WilDev Discord: https://discord.com/invite/4Ggybyy87d    |");
            m_Logger.LogInformation("+==========================================================+");
            return UniTask.CompletedTask;
        }

        protected override UniTask OnUnloadAsync()
        {
            m_Logger.LogInformation("+==========================================================+");
            m_Logger.LogInformation("| WILDEV.AUTOSAVE plugin has been unloaded!                |");
            m_Logger.LogInformation("| Made with <3 by WildKadeGaming @ WilDev Studios          |");
            m_Logger.LogInformation("| WilDev Discord: https://discord.com/invite/4Ggybyy87d    |");
            m_Logger.LogInformation("+==========================================================+");
            return UniTask.CompletedTask;
        }
    }
}
