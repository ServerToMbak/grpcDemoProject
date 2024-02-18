using Grpc.Core;
using Grpc.Net.Client;
using grpcMessageClient;

internal class Program
{
    private static async Task Main(string[] args)
    {

        var channel = GrpcChannel.ForAddress("https://localhost:5038");
        var messageClient = new Message.MessageClient(channel);
        #region unary
       
        
            //MessageResponse response =  await messageClient.SendMessageAsync(new MessageRequest
            //{
            //    Message = "Merhaba",
            //    Name = "server"
            //});
        #endregion
        
        
        #region Server streaming
            //var response = messageClient.SendMessage(new MessageRequest 
            //{
            //    Message = "Merhaba",
            //    Name = "server"
            //});

            //CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            //while (await response.ResponseStream.MoveNext(cancellationTokenSource.Token)) 
            //{
            //    Console.WriteLine(response.ResponseStream.Current.Message);
            //},

        #endregion

        #region  Client Streaming
            // var request = messageClient.SendMessage();


            // for (int i = 0; i < 10; i++)
            // {

            //     await Task.Delay(1000);
            //     await request.RequestStream.WriteAsync(new MessageRequest
            //     {
            //         Message = "Mesaj " + i,
            //         Name = "Server"
            //     });

            // }

            // await request.RequestStream.CompleteAsync(); // stream datanın sonlandığını ifade eder

            // Console.WriteLine((await request.ResponseAsync).Message);
        #endregion 
    
        #region bidirectional Streaming

        
        #endregion
    
    }
}

interface interface11{
    int a();
    
    public int MyProperty { get; set; }

    public int b{get; set;}

     public int d{set;}
      int P { get;}
}