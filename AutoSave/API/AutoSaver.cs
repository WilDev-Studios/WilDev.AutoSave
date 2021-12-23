using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using SDG.Unturned;

namespace AutoSave.API
{
    public class AutoSaver
    {
        private readonly IConfiguration m_Configuration;
        private readonly IStringLocalizer m_StringLocalizer;

        public AutoSaver(
            IConfiguration configuration,
            IStringLocalizer stringLocalizer
            )
        {
            m_Configuration = configuration;
            m_StringLocalizer = stringLocalizer;
        }

        public async Task Save()
        {
            while (m_Configuration.GetSection("Save-Server").Get<bool>())
            {
                await Task.Delay(m_Configuration.GetSection("Save-Interval").Get<int>() * 1000);

                SaveManager.save();

                if (m_Configuration.GetSection("Announce-Saves").Get<bool>())
                {
                    ChatManager.serverSendMessage(m_StringLocalizer["Saving"], UnityEngine.Color.green, null, null, EChatMode.GLOBAL, m_Configuration.GetSection("Announce-URL").Get<string>(), true);
                }
            }
        }
    }
}
