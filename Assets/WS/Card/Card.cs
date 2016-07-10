using System.Collections.Generic;
namespace WS
{
    public class Card
    {
        public Side side;
        public string neoStandard;
        public string no;
        public Rarity rarity;

        public string name;
        public Color color;
        public int lv;
        public int cost;
        public Trigger trigger;

        public Card(Side side, string neoStandard, string no, Rarity reality, string name, Color color, int lv, int cost, Trigger trigger)
        {

        }

    }

    public enum Trigger
    {
        None,
        ComeBack,
        Book,
        Treasure,
        Pool,
        GateSoul,
        WindSoul,
        ShotSoul,
        Soul,
        SoulSoul,
    }

    public enum Color
    {
        Yellow,
        Green,
        Red,
        Blue,
    }

    public enum Side
    {
        White,
        Black,
    }

    public enum Rarity
    {
        PR,
        C,
        U,
        R,
        RR,
        RRR,
        SR,
        SP,
        CX,
        CR,
    }
}