using System;
using System.Collections.Generic;

namespace EfCorePopulateCollectionProblem;

public class EntityOne
{
    public Guid Id { get; set; }

    public List<EntityTwo> ListA { get; set; }
}

public class EntityTwo
{
    public Guid Id { get; set; }

    public List<EntityThree> ListB { get; set; }
}

public class EntityThree
{
    public Guid Id { get; set; }

    public string Prop { get; set; }
}