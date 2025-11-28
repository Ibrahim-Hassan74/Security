using System.Collections.Generic;

namespace Security.ServiceContract
{
    public interface ICipherFactory
    {
        IEnumerable<ICipherService> Available { get; }
        ICipherService GetById(string id);
    }
}
