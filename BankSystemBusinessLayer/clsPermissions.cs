using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBusinessLayer
{
    public class clsPermissions
    {
        public static bool HasPermission(int userPermissions, int requiredPermission)
        {
            // Check if user has the required permission using bitwise AND operator
            return (userPermissions & requiredPermission) == requiredPermission;
        }

        public enum enPermission { People = 1, Clients = 2, Users = 4, Deposits = 8, Withdrawls = 16, Transfer = 32, All = -1 };


    }
}
