
using Model;
using AutoMapper;
using Register;

namespace AMapper
{
	public class MapperClass : Profile
	{
		public MapperClass()
		{
			CreateMap<User, RegisterDTO>().ReverseMap();
			CreateMap<User, LoginDTO>().ReverseMap();
			
		}
	}
}

