using first.DataContext;
using first.Entities;
using first.Repositories;
using iFramework.Core.Concretes.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace first.Repositories.EfCore
{
    public class DALEfRepository : Repository<DALEntity, CoreDataContext>, IDALRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DALEfRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public DALEfRepository(CoreDataContext context) : base(context)
        {

        }
    }
}
