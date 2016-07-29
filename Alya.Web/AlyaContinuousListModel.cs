using Alya.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alya.Web
{
    public class AlyaPagedItem<TEntity> where TEntity : EntityBase
    {
        public TEntity Entity { get; set; }
        public int IdOfNextItem { get; set; }
    }



    public class AlyaContinuousListModel<TEntity> : List<TEntity> where TEntity : EntityBase
    {
        public int IdOfNextItem { get; set; }
        public int InitialItemCount { get; set; } = 12;
    }
}
