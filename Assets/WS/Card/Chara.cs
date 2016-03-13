namespace WS
{
    public class Chara : Card
    {
        public Attribute[] attributes;
        public int power;
        public Effect[] effects;
    }

    public enum Attribute
    {
        魔法,
        音楽,
        武器,
    }
}