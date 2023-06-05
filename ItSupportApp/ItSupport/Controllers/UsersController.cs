﻿using ItSupport.Data;
using ItSupport.Entites;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItSupport.Controllers
{
	[Authorize]
	public class UsersController : BaseApiController
	{
		private readonly DataContext _dataContext;
		public UsersController(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
		{
			var users = await _dataContext.Users.ToListAsync();
			return users;
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<AppUser>> GetUser(int id) 
		{
			return await _dataContext.Users.FindAsync(id);
		}
	}
}
