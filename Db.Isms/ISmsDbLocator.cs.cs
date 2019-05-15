/*
 * CR Title         : Isms sprint-3
 * Start Date       : 21-Feb-2019
 * Version          : 1.0
 * Author/Developer : dipon
 * Purpose          : Isms db locator
*/

using Ef.Helper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Isms
{
    /// <summary>
    /// Isms db locator structure
    /// </summary>
    public interface IISmsDbLocator : IDbContextLocator<IISmsDbContext>
    {

    }

    /// <summary>
    /// Isms db locator
    /// </summary>
    /// <typeparam name="TSourceDbContext">Isms db</typeparam>
    public class ISmsDbLocator<TSourceDbContext> : IISmsDbLocator where TSourceDbContext : DbContext, IISmsDbContext, new()
    {
        private DbContextLocator<TSourceDbContext> _locator;

        public ISmsDbLocator()
        {
            _locator = new DbContextLocator<TSourceDbContext>();
        }

        public IISmsDbContext Current
        {
            get
            {
                return _locator.Current;
            }
        }

        public void Dispose()
        {
            _locator.Dispose();
        }

        public void Reset()
        {
            _locator.Reset();
        }
    }
}
