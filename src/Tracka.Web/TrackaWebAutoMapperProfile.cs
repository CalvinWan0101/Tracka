using AutoMapper;
using Tracka.Books;

namespace Tracka.Web;

public class TrackaWebAutoMapperProfile : Profile
{
    public TrackaWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your object mappings here, for the Web project
    }
}
