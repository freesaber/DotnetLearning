using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyBlog.Data
{
    /* This is used if database provider does't define
     * IMyBlogDbSchemaMigrator implementation.
     */
    public class NullMyBlogDbSchemaMigrator : IMyBlogDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}