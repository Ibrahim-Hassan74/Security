using Security.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Security.Service
{
    public class CipherFactory : ICipherFactory
    {
        private readonly Dictionary<string, ICipherService> _map;
        public CipherFactory(IEnumerable<ICipherService> services)
        {
            _map = services.ToDictionary(s => s.Id, s => s, StringComparer.OrdinalIgnoreCase);
        }
        public IEnumerable<ICipherService> Available => _map.Values;
        public ICipherService GetById(string id)
        {
            if (!_map.TryGetValue(id, out var svc))
                throw new KeyNotFoundException($"Cipher '{id}' not registered.");
            return svc;
        }
    }
}
