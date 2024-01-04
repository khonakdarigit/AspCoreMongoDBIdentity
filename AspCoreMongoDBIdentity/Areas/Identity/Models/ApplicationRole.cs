using AspNetCore.Identity.MongoDbCore.Models;

namespace AspCoreMongoDBIdentity.Areas.Identity.Models
{
    public class ApplicationRole : MongoIdentityRole<string>
    {
        public ApplicationRole() : base()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }
    }
}
