using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdQueyHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };

            return Task.FromResult(viewModel);

            //Get product from repository
        }
    }
}
