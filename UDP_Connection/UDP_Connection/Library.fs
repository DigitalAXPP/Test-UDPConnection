namespace UDP_Connection

open System.Management.Automation

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

    override x.BeinProcessing () =