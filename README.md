# portlistenPS
This repository is a PowerShell module to run and receive Udp calls, plus listen to Tcp calls.

## Introduction
This module is written in F# and contains three functions: `Send-UdpMessage`, `Receive-UdpMessage` and `Receive-TcpMessage`.
Because it's written in F#, it requires PowerShell version 6 or above.
I didn't write a function to send Tcp calls because `Test-NetConnection` does a fine job already.

## Test Udp ports
To send a message you simply run `Send-UdpMessage` to a target server and check afterwards in your Firewall or SIEM solution which actions these calls triggered.
```PowerShell
Send-UdpMessage -Message "This is a test call" -IP "1.1.1.1" -Port 123
```

If you also have access to the target server, you can listen to the target port and receive the messages.
The command will run continuously until you forcibly stop the session.
The messages are displayed in the session, plus all messages are appended to a file declared in `-Path`.
```PowerShell
Receive-UdpMessage -Path .\Filder\file.log -Port 123
```

## Test Tcp ports
To send Tcp messages you can simply use `Test-Netconnection`.
However, if you want to listen on a port for Tcp messages, you can run `Receive-TcpMessages`.
```PowerShell
Receive-TcpMessage -Port 123
```