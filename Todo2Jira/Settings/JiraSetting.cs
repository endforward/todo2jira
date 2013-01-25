using JetBrains.Application.Communication;
using JetBrains.Application.Settings;

namespace Todo2Jira.Settings
{
    [SettingsKey(typeof(InternetSettings), "Jira settings")]
    public class JiraSetting
    {
        [SettingsEntry("", "The base URL for your jira installation")]
        public string BaseUrl { get; set; }


        [SettingsEntry("", "Jira Project KEY")]
        public string ProjectKey { get; set; }

        [SettingsEntry("", "Jira username")]
        public string Username { get; set; }

        [SettingsEntry("", "Jira password")]
        public string Password { get; set; }
    }
}