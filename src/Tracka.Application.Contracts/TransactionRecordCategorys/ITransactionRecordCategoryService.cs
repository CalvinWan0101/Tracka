using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Tracka.TransactionRecordCategorys;

public interface ITransactionRecordCategoryService : IApplicationService {
    Task<List<TransactionRecordCategoryDto>> GetAllAsync();
    Task<TransactionRecordCategoryDto> CreateAsync(CreateTransactionRecordCategoryDto dto);
}
