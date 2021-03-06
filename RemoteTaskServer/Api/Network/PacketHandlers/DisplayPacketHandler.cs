﻿#region

using UlteriusServer.Api.Network.Messages;
using UlteriusServer.Api.Win32;
using UlteriusServer.WebSocketAPI.Authentication;
using vtortola.WebSockets;

#endregion

namespace UlteriusServer.Api.Network.PacketHandlers
{
    public class DisplayPacketHandler : PacketHandler
    {
        private MessageBuilder _builder;
        private AuthClient _authClient;
        private Packet _packet;
        private WebSocket _client;


 
        public override void HandlePacket(Packet packet)
        {
            _client = packet.Client;
            _authClient = packet.AuthClient;
            _packet = packet;
            _builder = new MessageBuilder(_authClient, _client, _packet.EndPointName, _packet.SyncKey);
            switch (_packet.EndPoint)
            {
                case PacketManager.EndPoints.ChangeDisplayResolution:
                    ChangeScreenResolution();
                    break;
                case PacketManager.EndPoints.RotateDisplay:
                    RotateDisplay();
                    break;
                case PacketManager.EndPoints.SetPrimaryDisplay:
                    SetPrimaryDisplay();
                    break;
                case PacketManager.EndPoints.GetEventLogs:
                    // GetEventLogs();
                    break;
            }
        }

        private void SetPrimaryDisplay()
        {
           /* var device = _packet.Args[0].ToString();
            var message =  Display.SetPrimary(device);
            var formThread = new
            {
                message
            };
            _builder.WriteMessage(formThread);*/
        }

        private void RotateDisplay()
        {
            /*var width = int.Parse(_packet.Args[0].ToString());
            var height = int.Parse(_packet.Args[1].ToString());
            var angle = int.Parse(_packet.Args[2].ToString());
            var device = _packet.Args[3].ToString();
           var message = Display.Rotate(angle, width, height, device);
            var formThread = new
            {
                message
            };
            _builder.WriteMessage(formThread);*/
        }

        private void ChangeScreenResolution()
        {

            /*var width = int.Parse(_packet.Args[0].ToString());
            var height = int.Parse(_packet.Args[1].ToString());
            var bbp = int.Parse(_packet.Args[2].ToString());
            var freq = int.Parse(_packet.Args[3].ToString());
            var device = _packet.Args[4].ToString();
            var message = Display.ChangeResolution(device, width, height, bbp, freq);
            var formThread = new
            {
                message
            };
            _builder.WriteMessage(formThread);*/
        }
    }
}