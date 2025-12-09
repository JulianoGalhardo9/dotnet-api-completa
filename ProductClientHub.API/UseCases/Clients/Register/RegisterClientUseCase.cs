using ProductClientHub.Communication.Responses;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Clients.Register
{
	public class RegisterClientUseCase
	{
		public ResponseClientJson Execute(RequestClientJson request)
		{
			var validator = new RegisterClientValidator();

			var result = validator.Validate(request);

			if (result.IsValid == false)
			{
				throw new ArgumentException("Erro nos dados recebidos");
			}
			
			return new ResponseClientJson();
		}
	}
}

