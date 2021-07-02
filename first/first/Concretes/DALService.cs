using first;
using first.Dtos;
using first.Entities;
using first.Interfaces;
using first.Repositories;
using first.Repositories;
using iFramework.Common.Extensions;
using iFramework.Common.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first.Concretes
{
    /// <summary>
    /// DALService
    /// </summary>
    /// <seealso cref="first.Interfaces.IDALService" />
    public class DALService : IDALService
    {
        private readonly IDALRepository _dALRepository;
        private readonly ILogger _logger;

        public DALService(IDALRepository dALRepository, ILogger<DALService> logger)
        {
            _dALRepository = dALRepository;
            _logger = logger;
        }

        /// <summary>
        /// Gets the DAL asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetDALResponse> GetDALAsync(GetDALRequest request)
        {
            var response = new GetDALResponse();
            try
            {
                _logger.LogDebug("Entering GetDALAsync");
                var data = await _dALRepository.GetAsync(request.Id);
                _logger.LogDebug("Leaving GetDALAsync");
                if (data != null)
                {
                    response.DAL = data.ToDALModel();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
            return response;
        }

        /// <summary>
        /// Gets the DAL asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<IEnumerable<DALModel>> SearchDALAsync(DALModel request)
        {
            IEnumerable<DALModel> response = null;
            try
            {
                var filter = PredicateBuilder.True<DALEntity>();
                if ((request.UId != Guid.Empty))
                    filter = filter.Or(x => x.UId == request.UId);

                filter = filter.And(filter => filter.TenantUId == _httpUserContextService.UserData.TenantUId);

                _logger.LogDebug("Entering GetDALAsync");
                var data = await _dALRepository.SearchAsync(filter);
                _logger.LogDebug("Leaving GetDALAsync");
                if (data != null)
                {
                    response = data.Select(x => x.ToDALModel());
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
            return response;
        }

        /// <summary>
        /// Update the DAL asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetDALResponse> UpdateDALAsync(GetDALRequest request)
        {
            var response = new GetDALResponse();
            try
            {
                _logger.LogDebug("Entering UpdateDALAsync");
                var data = await _dALRepository.UpdateAsync(request.DAL.ToDALEntity());
                _logger.LogDebug("Entering UpdateDALAsync");
                if (data != null)
                {
                    response.DAL = data.ToDALModel();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
            return response;
        }

        /// <summary>
        /// Add the DAL asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetDALResponse> AddDALAsync(GetDALRequest request)
        {
            var response = new GetDALResponse();
            try
            {
                _logger.LogDebug("Entering AddDALAsync");
                var data = await _dALRepository.AddAsync(request.DAL.ToDALEntity());
                _logger.LogDebug("Entering AddDALAsync");
                if (data != null)
                {
                    response.DAL = data.ToDALModel();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
            return response;
        }

        /// <summary>
        /// Delete the DAL asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetDALResponse> DeleteDALAsync(Guid id)
        {
            var response = new GetDALResponse();
            try
            {
                _logger.LogDebug("Entering DeleteDALAsync");
                var data = await _dALRepository.DeleteAsync(id);
                _logger.LogDebug("Entering DeleteDALAsync");
                if (data != null)
                {
                    response.DAL = data.ToDALModel();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
            return response;
        }
    }
    //TODO:// Move to extensions folder for better brevity
    public static class ModelExtensions
    {
        public static DALEntity ToDALEntity(this DALModel model)
        {
            return new DALEntity() { };
        }

        public static DALModel ToDALModel(this DALEntity model)
        {
            return new DALModel() { };
        }
    }
}
