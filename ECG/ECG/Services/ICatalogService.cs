using ECG.Models;
using System;
using System.Collections.Generic;

namespace ECG.Services
{
    public interface ICatalogService
    {
        List<Catalog> GetCatalogs();
        Catalog GetCatalogById(Guid Id);
    }
}
