using Dapper;
using PizzaOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PizzaOnline.DAL.Services.SQLServices
{
    public class JoinService
    {
        string connectionString = "server=KING;Initial Catalog=Pizzeria_online;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<OrderJoin> GetInfo()
        {


            List<OrderJoin> info = new List<OrderJoin>();

            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                info = connection.Query<OrderJoin>("readOrderbyAll").ToList();
            }
            return info;

        }
    }
}

