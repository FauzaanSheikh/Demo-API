using System;
using Demo_API.Models;

namespace Demo_API.Interfaces
{
	public interface IUserService
	{
		Task<User> Register(RegisterModel model);
		Task<LoginResponse> Authenticate(LoginModel model);
	}
}