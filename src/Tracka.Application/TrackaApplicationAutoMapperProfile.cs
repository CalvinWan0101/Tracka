using AutoMapper;
using Tracka.Books;

namespace Tracka;

public class TrackaApplicationAutoMapperProfile : Profile
{
    public TrackaApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
