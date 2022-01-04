using System.Linq;

namespace EfCorePopulateCollectionProblem;

internal class Program
{
    private static void Main(string[] args)
    {
        var ctx = new TestDbContext();

        var result = ctx.Set<EntityOne>()
            .Select(x =>
                new
                {
                    x.Id,
                    ListWithSubList = x.ListA.Select(b =>
                        b.ListB.Select(o => new
                        {
                            o.Id, o.Prop
                        }))
                })
            .ToList();
    }
}