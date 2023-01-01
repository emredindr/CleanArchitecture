using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.FactoryMethodDesign;
public class NoneLevel : ITaskPriority
{
    public PriorityLevel SetPriority()
    {
        return PriorityLevel.None;
    }
}
