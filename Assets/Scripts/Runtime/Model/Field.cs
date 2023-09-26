using System.Collections.Generic;

public class Field
{
    public List<EventCard> EventCards { get; set; } = new();
    public List<SituationCard> SituationCards { get; set; } = new();

    internal Field()
    {
        // TODO:EventCardをランダムに20枚決定する。
        
        // TODO:SituationCardsをランダムに8枚決定する。

    }
}
