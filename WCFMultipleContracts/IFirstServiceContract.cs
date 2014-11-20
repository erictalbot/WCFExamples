using System.ServiceModel;

namespace WCFMultipleContracts
{
    [ServiceContract]
    public interface IFirstServiceContract
    {
        [OperationContract]
        string GetWhileAnonymous();
    }
}
