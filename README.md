# Caliburn.Micro Tutorial

Most simple and basic use for MVVM Toolkit CaliburnMicro.
Showcasing how to associate two or more controls to the same method.

Example: method `IncrementCount` on your ViewModel:

```csharp
// Handling event
public void IncrementCount()
{
    Count++;
}
```

And your View has

```xaml
<Button Name="ButtonOne">
    <i:Interaction.Triggers>
        <i:EventTrigger EventName="Click">
            <cal:ActionMessage MethodName="IncrementCount" />
        </i:EventTrigger>
    </i:Interaction.Triggers>
</Button>

<Button Name="ButtonTwo">
    <i:Interaction.Triggers>
        <i:EventTrigger EventName="Click">
            <cal:ActionMessage MethodName="IncrementCount" />
        </i:EventTrigger>
    </i:Interaction.Triggers>
</Button>
```
