using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.FactoryMethodDesign;
public class MediumLevel : ITaskPriority
{
    public PriorityLevel SetPriority()
    {
        return PriorityLevel.Medium;
    }
}
