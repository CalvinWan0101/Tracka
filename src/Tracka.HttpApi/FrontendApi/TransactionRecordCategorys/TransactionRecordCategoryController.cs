using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tracka.TransactionRecordCategorys;

namespace Tracka.FrontendApi.TransactionRecordCategorys;

public class TransactionRecordCategoryController : FrontendApiBaseController {
    private readonly ITransactionRecordCategoryService _transactionRecordCategoryService;

    public TransactionRecordCategoryController(ITransactionRecordCategoryService transactionRecordCategoryService) {
        _transactionRecordCategoryService = transactionRecordCategoryService;
    }

    [HttpGet("All")]
    public async Task<JsonResult> GetAllAsync() {
        var result = await _transactionRecordCategoryService.GetAllAsync();
        return new JsonResult(result);
    }

    [HttpPost("Create")]
    public async Task<JsonResult> CreateAsync([FromBody] CreateTransactionRecordCategoryDto dto) {
        var result = await _transactionRecordCategoryService.CreateAsync(dto);
        return new JsonResult(result);
    }
}
