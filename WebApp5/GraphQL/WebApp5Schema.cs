using GraphQL;
using GraphQL.Types;

namespace WebApp5.GraphQL
{
    public class WebApp5Schema : Schema
    {
        public WebApp5Schema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<PersonQuery>();
        }
    }
}
