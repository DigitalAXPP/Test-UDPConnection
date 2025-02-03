module UDP
    open System
    open System.Net
    open System.Net.Sockets
    open System.Text

    let sendUdpMessage (message: string) (ip: string) (port: int) =
        use udpClient = new UdpClient()
        let bytes = Encoding.UTF8.GetBytes(message)
        let remoteEndPoint = IPEndPoint(IPAddress.Parse(ip), port)
        udpClient.Send(bytes, bytes.Length, remoteEndPoint) |> ignore

    // Example Usage
    //sendUdpMessage "Hello, UDP!" "127.0.0.1" 8080


    let receiveUdpMessage (port: int) =
            use udpListener = new UdpClient(port)
            let remoteEndPoint = IPEndPoint(IPAddress.Any, port)
            while true do
                let bytes = udpListener.Receive(ref remoteEndPoint)
                let message = Encoding.UTF8.GetString(bytes)
                printf "%s\r\n" message

    // Example Usage
    //receiveUdpMessage 8080  // This will run indefinitely