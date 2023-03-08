using Ardalis.Specification;
using Core.Entities;

namespace Application.Specifications
{
    public class PagedUserSpecification : Specification<User>
    {
        public PagedUserSpecification(int pageSize, int pageNumber, string name)
        {
            Query.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);

            if (!string.IsNullOrEmpty(name))
                Query.Search(x => x.Name, "%" + name + "%");
            //TODO: checar como seria buscar por booleanos
            //if (state == true)
            //    Query.Search(x => x.State);
        }
    }
}
