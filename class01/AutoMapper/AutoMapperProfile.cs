using AutoMapper;
using class01.Models.ModelData;

namespace class01.AutoMapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            //classes/objs mapeados
            CreateMap<ClientModel, ClientViewModel>().ReverseMap();
        }
    }
}
