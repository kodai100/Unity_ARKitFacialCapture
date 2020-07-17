[unity-osc by nobnak](https://github.com/nobnak/unity-osc)

### this is original readme

unity-osc
=========
OSC Client & Server MonoBehaviours for Unity

[Unity Package](Osc.unitypackage)

# Usage
## Set Up a Server
 - Add OscServer (MonoBehaviour) Component
 - Set Listening Port Number
 - Listen OnReceive Event

## Set Up a Client
 - Add OscClient (MonoBehaviour) Component
 - Set Server Name & Port Number
 - Listen OnReceive Event

## Send a Message
```C#
var oscEnc = new MessageEncoder("/path");
oscEnc.Add(3.14f);
oscEnc.Add(12345);
var dest = new IPEndPoint("Client IP Address", "Client Port Number");
_server.Send(oscEnc.Encode(), dest);
```
