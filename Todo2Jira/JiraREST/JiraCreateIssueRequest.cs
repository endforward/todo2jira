using RestSharp;

namespace Todo2Jira.JiraREST
{
    public class JiraCreateIssueRequest
    {
        public Fields fields { get; set; }

        public void Send(string jiraRestApiUrl, string jiraUsername, string jiraPassword)
        {
            jiraRestApiUrl = jiraRestApiUrl.TrimEnd("/".ToCharArray()) + "/rest/api/2/";
            var restClient = new RestClient(jiraRestApiUrl)
                                 {
                                     Authenticator =
                                         new HttpBasicAuthenticator(jiraUsername,
                                                                    jiraPassword)
                                 };

            var request = new RestRequest("issue", Method.POST);
            //request.AddBody(this);
            //request.RequestFormat = DataFormat.Json;
            
            //request.AddHeader("Content-Type", "application/json");
            
            string json = request.JsonSerializer.Serialize(this);
            
            request.Method = Method.POST;
            request.AddHeader("Accept", "application/json");
            request.Parameters.Clear();
            request.AddParameter("application/json", json, ParameterType.RequestBody);

            restClient.Post(request);
        }
    }
}