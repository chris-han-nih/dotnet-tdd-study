namespace Orders;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum OrderStatus
{
    Pending,
    AwaitingPayment,
    AwaitingShipment,
    Completed,
}