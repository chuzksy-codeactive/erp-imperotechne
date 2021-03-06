using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class OpenIddictScopes
    {
        public string Id { get; set; }
        public string ConcurrencyToken { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string Properties { get; set; }
        public string Resources { get; set; }
    }
}
