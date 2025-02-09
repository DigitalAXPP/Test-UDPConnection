---
external help file: portlistenPS.dll-Help.xml
Module Name: portlistenPS
online version:
schema: 2.0.0
---

# Receive-TcpMessage

## SYNOPSIS
This command listens for TCP calls on the designated port.

## SYNTAX

```
Receive-TcpMessage -Port <Int32> [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

## DESCRIPTION
This command listens for TCP calls on the designated port.

## EXAMPLES

### Example 1
```powershell
PS C:\> Receive-TcpMessage -Port 1000
```

This commands listens for TCP messages on port 1000.

## PARAMETERS

### -Port
Enter the port you want to listen the message on.

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

## OUTPUTS

### System.Object
## NOTES

## RELATED LINKS
