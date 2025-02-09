module Tcp_Commands

    open System.Net
    open System.Net.Sockets

    let receiveTcpMessage port =
        let listener = TcpListener.Create(port)
        listener.Start()
        let data = listener.AcceptTcpClient()
        let stream = data.GetStream()
        listener.Start()
        stream.Close()
        stream


