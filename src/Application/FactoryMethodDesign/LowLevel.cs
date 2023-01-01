using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.FactoryMethodDesign;
public class LowLevel : ITaskPriority
{
    public PriorityLevel SetPriority()
    {
        return PriorityLevel.Low;
    }
}

