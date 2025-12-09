namespace ProductClientHub.Communication.Responses
{
	public class ResponsesErrorMessagesJson
	{
		public List<string> Errors { get; private set; }

		public ResponsesErrorMessagesJson(string message)
		{
            Errors = new List<string> { message };
		}
		
	}
}

