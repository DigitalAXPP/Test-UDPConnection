---
external help file: UDP_Connection.dll-Help.xml
Module Name: UDP_Connection
online version:
schema: 2.0.0
---

# Receive-UdpMessage

## SYNOPSIS
This function listens for UDP messages and the port you entered. The messages are printed in the console, plus appended to the file of the path provided.

## SYNTAX

```
Receive-UdpMessage -Port <Int32> -Path <String> [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

## DESCRIPTION
This function listens for UDP messages and the port you entered. The messages are printed in the console, plus appended to the file of the path provided.

## EXAMPLES

### Example 1
```powershell
PS C:\> Receive-UdpMessage -Port 123 -Path .\udp_messages.log
```

This command listens on port 123 and creates the log file 'udp_messages.log' in the current directory.

## PARAMETERS

### -Path
Enter the port you want to send the message on.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Port
Enter the port you want to send the message on.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ProgressAction
{{ Fill ProgressAction Description }}

```yaml
Type: ActionPreference
Parameter Sets: (All)
Aliases: proga

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### System.Object
## NOTES

## RELATED LINKS
