using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Tracka.TransactionRecordCategorys;

public class TransactionRecordCategoryService : ApplicationService, ITransactionRecordCategoryService {
    private readonly IRepository<TransactionRecordCategory, Guid> _transactionRecordCategoryRepository;

    public TransactionRecordCategoryService(IRepository<TransactionRecordCategory, Guid> transactionRecordCategoryRepository) {
        _transactionRecordCategoryRepository = transactionRecordCategoryRepository;
    }

    public async Task<List<TransactionRecordCategoryDto>> GetAllAsync() {
        var query = await _transactionRecordCategoryRepository.GetQueryableAsync();
        return query.Select(ObjectMapper.Map<TransactionRecordCategory, TransactionRecordCategoryDto>).ToList();
    }

    public async Task<TransactionRecordCategoryDto> CreateAsync(CreateTransactionRecordCategoryDto dto) {
        var transactionRecordCategory = new TransactionRecordCategory {
            UserId = dto.UserId,
            Name = dto.Name,
            Description = dto.Description
        };
        await _transactionRecordCategoryRepository.InsertAsync(transactionRecordCategory);
        return ObjectMapper.Map<TransactionRecordCategory, TransactionRecordCategoryDto>(transactionRecordCategory);
    }
}
