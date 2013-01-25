using System;
using JetBrains.Application;
using JetBrains.Application.Progress;
using JetBrains.Application.Settings;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.Bulbs;
using JetBrains.ReSharper.Feature.Services.CSharp.Bulbs;
using JetBrains.ReSharper.Intentions.Extensibility;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.TextControl;
using JetBrains.Util;
using Todo2Jira.JiraREST;
using Todo2Jira.Settings;

namespace Todo2Jira
{
    [ContextAction(Name = "ConvertTODO2JIRA", Description = "Creates a jira issue based on a todo comment", Group = "C#")]
    public class ConvertTodo2JiraAction : ContextActionBase
    {
        private readonly ICSharpContextActionDataProvider _provider;

        public ConvertTodo2JiraAction(ICSharpContextActionDataProvider provider )
        {
            _provider = provider;
        }

        protected override Action<ITextControl> ExecutePsiTransaction(ISolution solution, IProgressIndicator progress)
        {
            var factory = CSharpElementFactory.GetInstance(_provider.PsiModule);
            
            var oldComment = _provider.TokenAfterCaret as ICommentNode;
            if (oldComment != null)
            {
                CreateJiraIssue(oldComment.CommentText);
                var newComment = factory.CreateComment("// JIRA: ");
                ModificationUtil.ReplaceChild(oldComment, newComment);
            }

            return null;
        }

        public void CreateJiraIssue(string summary)
        {
            var settingsStore = Shell.Instance.GetComponent<ISettingsStore>();
            var settings = settingsStore.GetKey<JiraSetting>((lt, d) => d.Empty, SettingsOptimization.OptimizeDefault);

            var jiraCreateIssueRequest = new JiraCreateIssueRequest
            {
                fields = new Fields
                           {
                               summary = summary,
                               project = new Project() { key = settings.ProjectKey },
                               issuetype = new IssueType() { name = "Task" },
                               description = ""
                           }
            };

            jiraCreateIssueRequest.Send(settings.BaseUrl, settings.Username, settings.Password);
        }

        public override bool IsAvailable(IUserDataHolder cache)
        {
            return _provider.TokenAfterCaret is ICommentNode;
        }

        public override string Text
        {
            get { return "Convert to JIRA issue"; }
        }
    }
}
