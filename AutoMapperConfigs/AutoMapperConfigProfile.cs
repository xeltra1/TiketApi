using AutoMapper;
using TiketApi.DataModels;
using TiketApi.Models;

namespace TiketApi.AutoMapperConfigs
{
    public class AutoMapperConfigProfile :Profile
    {
        public AutoMapperConfigProfile()
        {
            CreateMap<BuatTiket,TiketModel>();
            CreateMap<TiketModel, AllDataTiket>();
            CreateMap<UpdateTiket,TiketModel>();
        }
    }
}
