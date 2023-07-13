using E_COMM.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;

namespace E_COMM.Repository
{
    public class Registration : IRegistration
    {
        private readonly IConfiguration _configuration;
        public Registration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        

        public bool UserRegistration(SellerRegistration userdata)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection(_configuration.GetConnectionString("dbc"));
                NpgsqlCommand cmd = new NpgsqlCommand($"select fun_usermasterq('{userdata.name}','{userdata.email}',{userdata.number},'{userdata.password}','{userdata.conformpassword}')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
