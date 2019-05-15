/*
 * CR Title         : Isms sprint-3
 * Start Date       : 21-Feb-2019
 * Version          : 1.0
 * Author/Developer : dipon
 * Purpose          : db structures
*/

using System;

namespace Db.Isms.Contract
{
    /// <summary>
    /// create log
    /// </summary>
    interface ICreateLog
    {
        string CreatedBy { get; set; }
        DateTime? CreatedDateTime { get; set; }
    }

    /// <summary>
    /// update log
    /// </summary>
    interface IUpdateLog
    {
        string UpdatedBy { get; set; }
        DateTime? UpdatedDateTime { get; set; }
    }

    /// <summary>
    /// table primary key
    /// </summary>
    interface IPrimaryKey
    {
        long Id { get; set; }
    }

    /// <summary>
    /// row owner
    /// </summary>
    public interface IOwn
    {
        string OwnBy { get; set; }
    }

    /*
    public long Id { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? CreatedDateTime { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedDateTime { get; set; }
     */

    /// <summary>
    /// table
    /// </summary>
    interface ITable : IPrimaryKey, ICreateLog, IUpdateLog
    {
    }


}
