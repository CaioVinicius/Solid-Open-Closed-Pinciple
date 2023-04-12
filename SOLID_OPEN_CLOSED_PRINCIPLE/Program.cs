// See https://aka.ms/new-console-template for more information
using SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Entities;
using SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Proccess.CreateClientSubscription;
using SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Proccess.CreateClientSubscription.Base;

Console.WriteLine("# - SOLID CONCEPTS - OCP - OPEN CLOSED PRINCIPLE - #\n\n");

//CREATE CLIENT FREE SUBSCRIPTION

var clientFree = new Client("John Doe Free");
ExecuteService(SubscriptionTypeEnum.Free, clientFree);

var clientMontly = new Client("John Doe Montly");
ExecuteService(SubscriptionTypeEnum.Montly, clientMontly);

var clientAnnual = new Client("John Doe Annual");
ExecuteService(SubscriptionTypeEnum.Annual, clientAnnual);

void ExecuteService(SubscriptionTypeEnum typeEnum, Client client)
{
    var service = GetCreateSubscriptionServiceFactory(typeEnum);
    var response = service.Execute(client);
    Console.WriteLine(response);
}

ICreateClientSubscriptionProccess GetCreateSubscriptionServiceFactory(SubscriptionTypeEnum type)
{
    return type switch
    {
        SubscriptionTypeEnum.Free => new CreateClientFreeSubscription(),
        SubscriptionTypeEnum.Montly => new CreateClientMontlySubscriptionProccess(),
        SubscriptionTypeEnum.Annual => new CreateClientAnnualSubscriptionProccess(),
        _ => throw new ArgumentException(),
    };
}