/*
 * CR Title         : Isms sprint-3
 * Start Date       : 21-Feb-2019
 * Version          : 1.0
 * Author/Developer : dipon
 * Purpose          : db structures from sim tables
*/

using Db.Isms.Contract;
using Isms.Entity.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Db.Isms.Contract
{

    public interface ISim : ITimeLimit, ICreditLimit, IOwn //: ISmsSim
    {
    }

    public interface ITimeLimit
    {
        DateTime? TimeLimitFrom { get; set; }
        DateTime? TimeLimitTo { get; set; }
    }

    public interface ICreditLimit
    {
        double? CreditLimit { get; set; }
    }

}
