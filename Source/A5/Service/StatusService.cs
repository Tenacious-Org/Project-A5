using A5.Models;
using A5.Service.Interfaces;
using System.ComponentModel.DataAnnotations;
using A5.Data.Validations;
using A5.Data.Repository.Interface;

namespace A5.Service
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _statusRepository;
        private readonly ILogger<StatusService> _logger;

        public StatusService(ILogger<StatusService> logger, IStatusRepository statusRepository)
        {
            _logger = logger;
            _statusRepository = statusRepository;
        }

        //gets status of particular id using status id.
        public Status? GetStatusById(int statusId)
        {
            if (statusId <= 0) throw new ValidationException("organisationId ");
            try
            {
                return _statusRepository.GetStatusById(statusId);
            }
             catch (ValidationException exception)
            {
                _logger.LogError("StatusService: GetStatusById(id : {id}) : (Error:{Message}", statusId,exception.Message);
                throw;
            }
            catch (Exception exception)
            {
                _logger.LogError("StatusService: GetStatusById(id : {id}) : (Error:{Message}",statusId, exception.Message);
                throw;
            }
        }
        //gets all status.
        public IEnumerable<Status> GetAllStatus()
        {

            try
            {
                return _statusRepository.GetAllStatus();
            }
            catch (Exception exception)
            {
                _logger.LogError("StatusService: GetAllStatus() : (Error:{Message}", exception.Message);
                throw;
            }
        }
    }
}



