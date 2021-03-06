using JPSAGE_ERP.Application.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPSAGE_ERP.Application.Helpers
{
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public bool HasPrevious => (CurrentPage > 1);
        public bool HasNext => (CurrentPage < TotalPages);

        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            AddRange(items);
        }

        public static async Task<PagedList<T>> Create(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();

            if (pageSize == 0)
            {
                pageSize = count;
            }

            var items = await source.Skip(((pageNumber - 1) * pageSize)).Take(pageSize).ToListAsync();

            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }

    public enum ResourceUriType
    {
        PreviousPage,
        NextPage,
        CurrentPage
    }

    public class ResourceParameters
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

    public class AuthListParameters : ResourceParameters
    {
        public string Search { get; set; }
    }

    public class CtqParameters : ResourceParameters
    {
        public string Search { get; set; }
        public int? CompanyId { get; set; }
    }

    public class MtoParameters : ResourceParameters
    {
        public string Search { get; set; }
        public int? DisciplineId { get; set; }
        public bool ThisWeek { get; set; }
        public bool ThisMonth { get; set; }
        public bool LastMonth { get; set; }
        public bool ThisYear { get; set; }
    }
}
