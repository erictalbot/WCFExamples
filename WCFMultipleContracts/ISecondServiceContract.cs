using System.ServiceModel;

namespace WCFMultipleContracts
{
    [ServiceContract]
    public interface ISecondServiceContract
    {
        [OperationContract]
        string GetWhileAuthenticated();
    }
}