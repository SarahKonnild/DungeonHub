using Microsoft.AspNetCore.SignalR.Client;

namespace DungeonHub.Client.Bridge;

public partial class SignalRBridge
{
    private readonly HubConnection _hubConnection;

    public bool IsConnected => _hubConnection?.State == HubConnectionState.Connected;

    public SignalRBridge()
    {
        _hubConnection = new HubConnectionBuilder().WithUrl("").Build();
        _hubConnection.On("", () => { });

        _hubConnection.StartAsync();
    }
}