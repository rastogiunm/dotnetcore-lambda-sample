using System;
using Amazon.Lambda.Core;

[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace MyNamespace
{
    public class MyClass
    {
    	public object MyFunction()
    	{
    		return new { message = "Hello from Lambda - now using dotnet lambda CLI!", automated_build = true, time = DateTime.UtcNow };
    	}
    }
}
