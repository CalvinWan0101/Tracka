using AutoMapper;

namespace Tracka.TransactionRecordCategorys;
public class TransactionRecordCategoryMapperProfile : Profile {
    public TransactionRecordCategoryMapperProfile() {
        CreateMap<TransactionRecordCategory, TransactionRecordCategoryDto>();
    }
}

