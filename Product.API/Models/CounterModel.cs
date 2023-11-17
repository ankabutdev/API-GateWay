using MongoDB.Bson.Serialization.Attributes;

namespace Product.API.Models;

public class CounterModel
{
    [BsonId]
    public string Id { get; set; }

    public int Value { get; set; }
}
