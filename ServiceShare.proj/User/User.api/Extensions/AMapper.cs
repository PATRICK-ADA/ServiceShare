
using UserModel;
using AutoMapper;
using Login;


namespace AMapper
{
	public class MapperClass : Profile
	{
		public MapperClass()
		{

			CreateMap<User, UserDTO>().ReverseMap();
			
		}
	}
}

