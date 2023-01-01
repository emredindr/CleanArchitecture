using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.FactoryMethodDesign;
public class HighLevel : ITaskPriority
{
    public PriorityLevel SetPriority()
    {
        return PriorityLevel.High;
    }
}
