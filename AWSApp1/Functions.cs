using Amazon.Lambda.Annotations;
using Amazon.Lambda.Annotations.APIGateway;
using Amazon.Lambda.Core;
using SharedLibrary;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSApp1;

public class Functions
{
    [LambdaFunction]
    [RestApi(LambdaHttpMethod.Get, "/eng")]
    public IHttpResult Get(ILambdaContext context)
    {
        context.Logger.LogInformation(Message.GetMessage("eng"));

        return HttpResults.Ok(Message.GetMessage("eng"));
    }
}
