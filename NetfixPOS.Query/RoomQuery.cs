﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class RoomQuery
    {
        string query = "";
        public string Insert()
        {
            query = "INSERT tbl_Room VALUES(@RoomNo, @RoomName, @CompanyId, @ModifiedDate, 0, 1, @IsDefault)";
            return query;
        }
        public string Update()
        {
            query = "UPDATE tbl_Room SET RoomName = @RoomNo, RoomName = @RoomName, CompanyId = @CompanyId," +
                " ModifiedDate = @ModifiedDate, IsDefault = @IsDefault WHERE RoomId = @RoomId";
            return query;
        }
        public string Delete()
        {
            query = "UPDATE tbl_Room SET IsDeleted = 1 WHERE RoomId = @RoomId";
            return query;
        }
        public string Select(int id)
        {
            if (id == 0)
            {
                query = "SELECT * FROM dbo.tbl_Room ORDER BY RoomId";
            }
            else
            {
                query = "SELECT * FROM   dbo.tbl_Room WHERE (RoomId = @RoomId) ORDER BY RoomId";
            }
            return query;
        }
    }
}