using first;
using first.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace first.Interfaces
{
    /// <summary>
    ///IDALService
    /// </summary>
    public interface IDALService
    {
        Task<GetDALResponse> GetDALAsync(GetDALRequest request);
        Task<GetDALResponse> AddDALAsync(GetDALRequest request);
        Task<GetDALResponse> UpdateDALAsync(GetDALRequest request);
        Task<GetDALResponse> DeleteDALAsync(Guid id);
        Task<IEnumerable<DALModel>> SearchDALAsync(DALModel request);
    }
}
