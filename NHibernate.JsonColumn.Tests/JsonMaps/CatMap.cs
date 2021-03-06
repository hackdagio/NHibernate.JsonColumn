using FluentJsonNet;
using NHibernate.JsonColumn.Tests.Models;

namespace NHibernate.JsonColumn.Tests.JsonMaps
{
    public class CatMap : JsonSubclassMap<Cat>
    {
        public CatMap()
        {
            this.Map(x => x.Cuteness, "cuteness");
        }
    }
}