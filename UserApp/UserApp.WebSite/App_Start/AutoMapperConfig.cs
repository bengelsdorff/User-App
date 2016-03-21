using AutoMapper;
using UserApp.Maps;

namespace UserApp
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<UserMap>();
            });
        }
    }
}