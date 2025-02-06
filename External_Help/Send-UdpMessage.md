---
external help file: UDP_Connection.dll-Help.xml
Module Name: UDP_Connection
online version:
schema: 2.0.0
---

# Send-UdpMessage

## SYNOPSIS
This function sends a UDP message to a target IP address on the selected port.

## SYNTAX

```
Send-UdpMessage -Message <String> -IP <String> -Port <Int32> [-ProgressAction <ActionPreference>]
 [<CommonParameters>]
```

## DESCRIPTION
This function sends a UDP message to a target IP address on the selected port.

## EXAMPLES

### Example 1
```powershell
PS C:\> Send-UdpMessage -Message "Test Message" -IP 10.198.12.12 -Port 123
```

The command sends "Test Message" to the IP address "10.198.12.12" on port 123.

## PARAMETERS

### -IP
Enter the IP address of your target machine.

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

### -Message
Enter the message you want to send.

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

### System.String

### System.Int32

## OUTPUTS

### System.Object
## NOTES

## RELATED LINKS
