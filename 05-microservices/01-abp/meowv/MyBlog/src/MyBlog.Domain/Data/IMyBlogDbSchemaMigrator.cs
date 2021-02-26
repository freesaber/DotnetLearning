using System.Threading.Tasks;

namespace MyBlog.Data
{
    public interface IMyBlogDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
