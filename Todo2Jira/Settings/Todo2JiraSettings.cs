using JetBrains.Annotations;
using JetBrains.Application.Settings;
using JetBrains.DataFlow;
using JetBrains.ReSharper.Features.Common.Options;
using JetBrains.UI.Options;
using JetBrains.UI.Options.Helpers;

namespace Todo2Jira.Settings
{
    [OptionsPage(Pid, "TODO 2 JIRA", typeof(UnnamedThemedIcons.OptionsPageIcon), ParentId = ToolsPage.PID)]
    public class Todo2JiraSettings : AOptionsPage
    {
        public const string Pid = "Todo2JiraId";

        private readonly OptionsSettingsSmartContext _settings;

        private readonly Todo2JiraSettingsUI _optionsUI;

        public Todo2JiraSettings([NotNull] Lifetime lifetime, OptionsSettingsSmartContext settingsSmartContext)
            : base(lifetime, Pid)
        {
            _settings = settingsSmartContext;
            _optionsUI = new Todo2JiraSettingsUI();
            Control = _optionsUI;
            
            _settings.SetBinding(lifetime, (JiraSetting s) => s.BaseUrl, WinFormsProperty.Create(lifetime, _optionsUI.txtJiraBaseUrl, box => box.Text, true));
            _settings.SetBinding(lifetime, (JiraSetting s) => s.ProjectKey, WinFormsProperty.Create(lifetime, _optionsUI.txtProjectKey, box => box.Text, true));
            _settings.SetBinding(lifetime, (JiraSetting s) => s.Username, WinFormsProperty.Create(lifetime, _optionsUI.txtJiraUsername, box => box.Text, true));
            _settings.SetBinding(lifetime, (JiraSetting s) => s.Password, WinFormsProperty.Create(lifetime, _optionsUI.txtJiraPassword, box => box.Text, true));
        }
    }
}