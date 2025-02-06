namespace UDP_Connection

open System.Management.Automation
open UDP

[<Cmdlet("Send", "UdpMessage")>]
type SendUdpMessage () =
    inherit PSCmdlet ()
    [<Parameter(
        HelpMessage="Enter the message you want to send.",
        Mandatory=true,
        ValueFromPipelineByPropertyName=true)>]
    [<ValidateNotNullOrEmpty>]
    member val Message : string = System.String.Empty with get, set

    [<Parameter(
        HelpMessage="Enter the IP address of your target machine.",
        Mandatory=true,
        ValueFromPipelineByPropertyName=true)>]
    [<ValidateNotNullOrEmpty>]
    member val IP : string = System.String.Empty with get, set

    [<Parameter(
        HelpMessage="Enter the port you want to send the message on.",
        Mandatory=true,
        ValueFromPipelineByPropertyName=true)>]
    [<ValidateNotNullOrEmpty>]
    member val Port : int = 0 with get, set

    override x.BeginProcessing () =
        base.BeginProcessing ()

    override x.ProcessRecord () =
        sendUdpMessage x.Message x.IP x.Port
        x.WriteVerbose ($"Message: {x.Message} send to {x.IP} on port {x.Port}") 
        base.ProcessRecord ()

    override x.EndProcessing () =
        base.EndProcessing ()

[<Cmdlet("Receive", "UdpMessage")>]
type ReceiveUdpMessage () =
    inherit PSCmdlet ()
    [<Parameter(
        HelpMessage="Enter the port you want to send the message on.",
        Mandatory=true,
        ValueFromPipelineByPropertyName=true)>]
    [<ValidateNotNullOrEmpty>]
    member val Port : int = 0 with get, set

    [<Parameter(
        HelpMessage="Enter the port you want to send the message on.",
        Mandatory=true,
        ValueFromPipelineByPropertyName=true)>]
    [<ValidateNotNullOrEmpty>]
    member val Path : string = System.String.Empty with get, set

    override x.BeginProcessing () =
        base.BeginProcessing ()

    override x.ProcessRecord () =
        receiveUdpMessage x.Port x.Path
        base.ProcessRecord ()

    override x.EndProcessing () =
        base.EndProcessing ()