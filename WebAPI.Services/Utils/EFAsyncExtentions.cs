using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ERP.WebAPI.Services.Utils
{
    public static class EFAsyncExtentions
    {

        public static IQueryable<TSource> AsNoTrackingEF<TSource>(this IQueryable<TSource> source) where TSource : class => source.AsNoTracking();
        public static Task<TSource> FirstOrDefaultAsyncEF<TSource>(this IQueryable<TSource> source) => source.FirstOrDefaultAsync();
        public static Task<bool> AnyAsyncEF<TSource>(this IQueryable<TSource> source) => source.AnyAsync();
        public static Task<TSource> MaxAsyncEF<TSource>(this IQueryable<TSource> source) => source.MaxAsync();
        public static Task<List<TSource>> ToListAsyncEF<TSource>(this IQueryable<TSource> source) => source.ToListAsync();
        public static Task<TResult> MaxAsyncEF<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector) => source.MaxAsync(selector);

    }
}
