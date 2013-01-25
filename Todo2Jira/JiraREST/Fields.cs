namespace Todo2Jira.JiraREST
{
    public class Fields
    {
        public Project project { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        public IssueType issuetype { get; set; }
    }
}