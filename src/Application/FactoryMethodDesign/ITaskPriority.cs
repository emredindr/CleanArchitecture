using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.FactoryMethodDesign;
public interface ITaskPriority
{
    public PriorityLevel SetPriority();
}
