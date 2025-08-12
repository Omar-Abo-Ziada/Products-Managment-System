﻿

namespace ProductsMangementSystem.Common.Helpers
{
    public static class MapperHelper
    {

        public static IMapper Mapper { get; set; }

        public static IQueryable<TResult> Map<TResult>(this IQueryable source)
        {
            return source.ProjectTo<TResult>(Mapper.ConfigurationProvider);
        }
        public static IEnumerable<TResult> Map<TResult>(this IEnumerable source)
        {
            return source.AsQueryable().ProjectTo<TResult>(Mapper.ConfigurationProvider);
        }

        public static TResult MapOne<TResult>(this object source)
        {
            return Mapper.Map<TResult>(source);
        }
    }
}
