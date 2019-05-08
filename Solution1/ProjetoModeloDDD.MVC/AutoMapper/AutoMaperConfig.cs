using AutoMapper;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMaperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
                {
                    x.AddProfile<DomainToViewModelMappingProfile>();
                    x.AddProfile<ViewModelToDomainMappingProfile>();
                });
        }
    }
}