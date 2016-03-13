using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace WS
{
    public class OnStageChara
    {
        public int deckNo;
        public Chara chara;
        public int Soul;
        public int Power;
        public Position position;

        public FrontBack FrontBack()
        {
            if (position == Position.FrontCenter || position == Position.FrontLeft || position == Position.FrontRight)
            {
                return WS.FrontBack.Front;
            }
            else if (position == Position.BackLeft || position == Position.BackRight)
            {
                return WS.FrontBack.Back;
            }
            else if (position == Position.Memory)
            {
                return WS.FrontBack.Memory;
            }
            else
            {
                //残りはマーカーだけのはず
                return WS.FrontBack.Marker;
            }
        }
    }

    public enum Status
    {
        Stand,
        Reverse,
        Rest,
        Marker,
        Memory,
    }

    public enum Position
    {
        FrontCenter,
        FrontLeft,
        FrontRight,
        BackLeft,
        BackRight,
        Memory,
        MarkerFrontCenter,
        MarkerFrontLeft,
        MarkerFrontRight,
        MarkerBackLeft,
        MarkerBackRight,

    }

    public enum FrontBack
    {
        Front,
        Back,
        Memory,
        Marker,
    }
}