using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    internal class VerkoopfacturenOperations : CrudOperationsBase<VerkoopFactuurModel>, IVerkoopfacturenOperations
    {
        public VerkoopfacturenOperations(ClientState clientState) : base(clientState, VerkoopFactuurModel.ResourceName)
        {
        }

        public Task<Response<VerkoopFactuurModel[]>> GetAsync(string queryString) => GetAsync(queryString, CancellationToken.None);
        public Task<Response<VerkoopFactuurModel[]>> GetAsync(string queryString, CancellationToken cancellationToken) => ClientState.ExecuteGetAsync<VerkoopFactuurModel>(ResourceName, queryString, cancellationToken);
    }
}