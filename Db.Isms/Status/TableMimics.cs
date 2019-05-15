/*
 * CR Title         : Isms sprint-3
 * Start Date       : 21-Feb-2019
 * Version          : 1.0
 * Author/Developer : dipon
 * Purpose          : table mimic class
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Isms.Status
{

    /*todo: move this to the core project*/
    /// <summary>
    /// user groups
    /// </summary>
    public enum UserRole
    {
        Admin = 1000,
        /*usergroup id*/
        Creator = 1,    /*customer, people from differnt departments*/
        Hod = 4,        /*department head*/
        Ssm = 2,
        Clc = 5,
        Clg = 3

        //Clc = 3,
        //Clg = 5
    }
}
