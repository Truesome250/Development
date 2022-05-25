using BTS.Data;
using BTS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BTS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private DemoDbContext _dbContext;
        public UserController(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet("GetUsers")]
        public IActionResult Get()
        {
            try
            {
                var users = _dbContext.tblUsers.ToList();
                if (users.Count == 0)
                {
                    return StatusCode(404, "No user found");
                }
                return Ok(users);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occured");
            }
        }

        [HttpPost("CreateUser")]
        public IActionResult Create([FromBody] UserRequest request)
        {
            tbluser user = new tbluser();
            user.Id = request.Id();
            user.StaffName = request.StaffName();
            user.StaffNumber = request.StaffNumber();
            user.GuarantorName = request.GuarantorName();
            user.AddressofStaff = request.AddressofStaff();
            user.City = request.City();
            user.Country = request.Country();

            try
            {
                _dbContext.tblUsers.Add(user);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error has occured");
            }
            // get all users
            var users = _dbContext.tblUsers.ToList();
            return Ok(users);
        }


        [HttpPut("UpdateUser")]
        public IActionResult Update([FromBody] UserRequest request)
        {
            try
            {
                var user = _dbContext.tblUsers.FirstOrDefault(x => x.Id = request.Id);
                if (user == null)
                {
                    return StatusCode(404, "User not found");
                }

                user.Id = request.Id();
                user.StaffName = request.StaffName();
                user.StaffNumber = request.StaffNumber();
                user.GuarantorName = request.GuarantorName();
                user.AddressofStaff = request.AddressofStaff();
                user.City = request.City();
                user.Country = request.Country();

                _dbContext.Entry(user).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error has occured");
            }
            var users = _dbContext.tblUsers.ToList();
            return Ok(users);
        }

        [HttpDelete("DeleteUser/{Id}")]
        public IActionResult Delete([FromRoute] int Id)
        {
            try
            {
                var user = _dbContext.tblUsers.FirstOrDefault(x => x.Id = Id);
                if (user == null)
                {
                    return StatusCode(404, "User not found");
                }
                _dbContext.Entry(user).State = EntityState.Deleted;
                _dbContext.SaveChanges();
            }
            catch
            {
                return StatusCode(500, "An error has occured");
            }

            var users = _dbContext.tblUsers.ToList();
            return Ok(users);


            // I requested the rest api configuration

        }


    }
}

