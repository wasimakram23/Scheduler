/*
 * CR Title         : Isms sprint-3
 * Start Date       : 21-Feb-2019
 * Version          : 1.0
 * Author/Developer : dipon
 * Purpose          : db structures from log tables
*/
using System;
using System.Collections.Generic;

namespace Db.Isms.Contract
{
    /// <summary>
    /// log table
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    interface ILogTable<TSource>
    {
        /// <summary>
        /// log primary key
        /// </summary>
        long LogId { get; set; }
        DateTime? LogDateTime { get; set; }
        TSource LogFor { get; set; }
    }

    /// <summary>
    /// table logs
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    interface IHasLog<TSource>
    {
        ICollection<TSource> Logs { get; set; }
    }
}
