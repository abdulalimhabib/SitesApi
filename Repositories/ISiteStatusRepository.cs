using System.Collections.Generic;
using System.Threading.Tasks;
using SitesApi.Models;

public interface ISiteStatusModelRepository
{
    IEnumerable<SiteStatusModel> GetAll();

    Task<IEnumerable<SiteStatusModel>> GetAllAsync();

    SiteStatusModel GetById(int Id);

    int Add(SiteStatusModel entity);

    Task<int> AddAsync(SiteStatusModel entity);

    void Delete(int entity);

    void Update(SiteStatusModel entity);
}