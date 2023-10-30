using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GetAllProductsQuery : IRequest<List<GetProductViewModel>>
    {

        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<GetProductViewModel>>
        {
            public Task<List<GetProductViewModel>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var viewModel = new GetProductViewModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Book"
                };

                var viewModel2 = new GetProductViewModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Monitor"
                };

                return Task.FromResult(new List<GetProductViewModel> { viewModel, viewModel2 });
            }
        }
    }
}
