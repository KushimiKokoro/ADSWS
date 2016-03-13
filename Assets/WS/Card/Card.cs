using System.Collections.Generic;
namespace WS
{
    public class Card
    {
        public Side side;
        public string NeoStandard;
        public string No;
        public Reality reality;

        public string Name;
        public Color color;
        public int Lv;
        public int Cost;
        public Trigger trigger;
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

    public enum Reality
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