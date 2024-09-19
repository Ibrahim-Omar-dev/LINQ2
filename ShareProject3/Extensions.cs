using System.Text;

namespace Extensionmethod
{
    public static class Extensions
    {
        private static Random random = new Random();
        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            if (source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in source)
            {
                if (typeof(T).IsValueType)
                    Console.Write($" {item} "); // 1, 2, 3
                else
                    Console.WriteLine(item);
            }
        }
        public static IEnumerable<TSource> Paginate<TSource>(this IEnumerable<TSource> source
            , int page = 0, int sizeofPage = 10)
        {
            if (source == null)
                throw new ArgumentNullException($"{nameof(source)}");

            if (page <= 0)
            {
                page = 1; // reset the value
            }


            if (sizeofPage <= 0)
            {
                // pagesize = 10; // reset the value
                throw new ArgumentException($"{nameof(sizeofPage)}");
            }
            if (!source.Any())
                return Enumerable.Empty<TSource>();
            return source.Skip((page - 1) * sizeofPage).Take(sizeofPage);
        }
        public static IEnumerable<TSource> Paginate2<TSource>(this IEnumerable<TSource>source
            ,int? page,int? pagesize)
        {
            if (source == null)
                throw new ArgumentNullException($"{nameof(source)}");
            if(!page.HasValue)
                page= 1;
            if(!pagesize.HasValue)
                pagesize= 10;
            if(source.Any())
                return Enumerable.Empty<TSource>();
            return source.Skip((page.Value - 1) * pagesize.Value).Take(pagesize.Value);
        }
        public static IEnumerable<TSource>whereWithPaginate<TSource>(this IEnumerable<TSource> source
            ,Func<TSource,bool> predicate,int page=1,int pagesize=10)
        {
            if(source == null)
                throw new ArgumentNullException($"{nameof(source)}");
            if(predicate == null)
                    throw new ArgumentNullException($"{nameof(predicate)}");

            var result = Enumerable.Where(source, predicate);

            return Paginate(result,page,pagesize);
        }
        public static TSource Random<TSource>(this IEnumerable<TSource>source
            , Func<TSource, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException($"{nameof(source)}");
            if (predicate == null)
                throw new ArgumentNullException($"{nameof(predicate)}");
            if (!source.Any())
                return default;
            var result = Enumerable.Where(source, predicate);
            return result.ElementAt(random.Next(0, result.Count()));
        }
    }
}
