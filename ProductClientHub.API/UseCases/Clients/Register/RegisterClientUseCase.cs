using ProductClientHub.Communication.Responses;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Exceptions.ExceptionsBase;
using ProductClientHub.API.Infrastructure;
using ProductClientHub.API.Entities;

namespace ProductClientHub.API.UseCases.Clients.Register
{
	public class RegisterClientUseCase
	{
		public ResponseClientJson Execute(RequestClientJson request)
		{
			Validate(request);

			var dbContext = new ProductClientHubDbContext();

			var entity = new Client
			{
				Name = request.Name,
				Email = request.Email,

			};

			dbContext.Clients.Add(entity);

			dbContext.SaveChanges();
			
			return new ResponseClientJson();
		}

		private void Validate(RequestClientJson request)
		{
            var validator = new RegisterClientValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();

                throw new ErrorOnValidationException(errors);
            }
        }
	}
}

