using ECG.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECG.Services
{
    public class CatalogService : ICatalogService
    {
        private CatalogRepository _catalogRepository = new CatalogRepository();

        public List<Catalog> GetCatalogs()
        {
            return _catalogRepository.Catalogs;
        }

        public Catalog GetCatalogById(Guid Id)
        {
            return _catalogRepository.Catalogs.Find(c => c.Id == Id);
        }
    }
}
