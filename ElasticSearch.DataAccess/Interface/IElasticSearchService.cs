using ElasticSearch.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearch.Data.Interface
{
    public interface IElasticSearchService
    {

        Task ChekIndex(string indexName);
        Task InsertDocument(string indexName, Cities cities);
        Task DeleteIndex(string indexName);
        Task DeleteByIdDocument(string indexName, Cities cities);
        Task InsertBulkDocuments(string indexName, List<Cities> cities);
        Task<Cities> GetDocument(string indexName, string id);
        Task<List<Cities>> GetDocuments(string indexName);

    }
}
