using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.FactoryMethodDesign;
public class Creater
{
    //Factory işlemini yapacak method
    public ITaskPriority FactoryMethod(PriorityLevel PriorityLevel)
    {
        ITaskPriority taskPriority = null;
        switch (PriorityLevel)
        {
            case PriorityLevel.None:
                taskPriority = new NoneLevel();
                break;
            case PriorityLevel.Low:
                taskPriority = new LowLevel();
                break;
            case PriorityLevel.Medium:
                taskPriority = new MediumLevel(); 
                break;
                case PriorityLevel.High:
                taskPriority = new HighLevel();
                break;
        }
        return taskPriority;
    }
}
