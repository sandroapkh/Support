﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ItSupport.Extensions
{
	public static class IdentityServiceExtansions
	{


		public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
		{
			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
			{
				opt.TokenValidationParameters = new TokenValidationParameters
					{
						ValidateIssuerSigningKey = true,
						IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"])),
						ValidateIssuer = false,
						ValidateAudience = false
					};
			});
			return services;
		}
	}
}
