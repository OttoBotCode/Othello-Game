using System.Collections.Generic;

public class MoveInfo
{
    public Player Player { get; set; }
    public Position Position { get; set; }
    public List<Position> Outflanked { get; set; }
}
