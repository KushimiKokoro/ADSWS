using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace WS
{
    public class CardManager
    {
        public CardManager opponentDeck;

        Card[] cardList;
        public Card this[int i]
        {
            get { return cardList[i]; }
            set { cardList[i] = value; }
        }

        /// <summary>
        /// 前列中央
        /// </summary>
        public int frontCenter;
        /// <summary>
        /// 前列右
        /// </summary>
        public int frontRight;
        /// <summary>
        /// 前列左
        /// </summary>
        public int frontLeft;
        /// <summary>
        /// 後列右
        /// </summary>
        public int backRight;
        /// <summary>
        /// 後列左
        /// </summary>
        public int backLeft;
        /// <summary>
        /// 思い出
        /// </summary>
        public List<int> memories = new List<int>();
        /// <summary>
        /// 山札
        /// </summary>
        private List<int> deck = new List<int>();
        /// <summary>
        /// 手札
        /// </summary>
        private List<int> hand = new List<int>();
        /// <summary>
        /// 処理中のカード
        /// </summary>
        public int active;
        /// <summary>
        /// 解決領域
        /// </summary>
        public List<int> solution;
        /// <summary>
        /// 控え室
        /// </summary>
        public List<int> waiting;
        /// <summary>
        /// 前列中央のマーカー
        /// </summary>
        private List<int> markerFrontCenter = new List<int>();
        /// <summary>
        /// 前列右のマーカー
        /// </summary>
        private List<int> markerFrontRight = new List<int>();
        /// <summary>
        /// 前列左のマーカー
        /// </summary>
        private List<int> markerFrontLeft = new List<int>();
        /// <summary>
        /// 後列右のマーカー
        /// </summary>
        private List<int> markerBackRight = new List<int>();
        /// <summary>
        /// 後列左のマーカー
        /// </summary>
        private List<int> markerBackLeft = new List<int>();

        bool refleshTrigger = false;

        public void 手札を1枚選び控え室に置く(int listNo)
        {
            hand.Remove(listNo);
            waiting.Add(listNo);
            CardCheck();
        }

        public void 手札から舞台に置く(int listNo, Stage stage)
        {
            hand.Remove(listNo);
            switch (stage)
            {
                case Stage.FrontCenter:
                    break;
                case Stage.FrontRight:
                    break;
                case Stage.FrontLeft:
                    break;
                case Stage.BackRight:
                    break;
                case Stage.BackLeft:
                    break;
            }
        }


        public void CardCheck()
        {
            bool[] checkList = new bool[cardList.Length];

            for (int i = 0; i < checkList.Length; i++)
            {
                checkList[i] = true;
            }

            if (frontCenter != -1)
            {
                if (!checkList[frontCenter])
                {
                    throw new SameCardExistException("frontCenter");
                }
                checkList[frontCenter] = false;
            }

            if (frontRight != -1)
            {
                if (!checkList[frontRight])
                {
                    throw new SameCardExistException("frontRight");
                }
                checkList[frontRight] = false;
            }

            if (frontLeft != -1)
            {
                if (!checkList[frontLeft])
                {
                    throw new SameCardExistException("frontLeft");
                }
                checkList[frontLeft] = false;
            }

            if (backRight != -1)
            {
                if (!checkList[backRight])
                {
                    throw new SameCardExistException("backRight");
                }
                checkList[backRight] = false;
            }

            if (backLeft != -1)
            {
                if (!checkList[backLeft])
                {
                    throw new SameCardExistException("backLeft");
                }
                checkList[backLeft] = false;
            }

            for (int i = 0; i < memories.Count; i++)
            {
                if (!checkList[memories[i]])
                {
                    throw new SameCardExistException("memories[" + i + "]");
                }
                checkList[memories[i]] = false;
            }

            for (int i = 0; i < deck.Count; i++)
            {
                if (!checkList[deck[i]])
                {
                    throw new SameCardExistException("deck[" + i + "]");
                }
                checkList[deck[i]] = false;
            }

            for (int i = 0; i < hand.Count; i++)
            {
                if (!checkList[hand[i]])
                {
                    throw new SameCardExistException("hand[" + i + "]");
                }
                checkList[hand[i]] = false;
            }

            for (int i = 0; i < solution.Count; i++)
            {
                if (!checkList[solution[i]])
                {
                    throw new SameCardExistException("solution[" + i + "]");
                }
                checkList[solution[i]] = false;
            }

            for (int i = 0; i < waiting.Count; i++)
            {
                if (!checkList[waiting[i]])
                {
                    throw new SameCardExistException("waiting[" + i + "]");
                }
                checkList[waiting[i]] = false;
            }

            for (int i = 0; i < markerFrontCenter.Count; i++)
            {
                if (!checkList[markerFrontCenter[i]])
                {
                    throw new SameCardExistException("markerFrontCenter[" + i + "]");
                }
                checkList[markerFrontCenter[i]] = false;
            }

            for (int i = 0; i < markerFrontRight.Count; i++)
            {
                if (!checkList[markerFrontRight[i]])
                {
                    throw new SameCardExistException("markerFrontRight[" + i + "]");
                }
                checkList[markerFrontRight[i]] = false;
            }

            for (int i = 0; i < markerFrontLeft.Count; i++)
            {
                if (!checkList[markerFrontLeft[i]])
                {
                    throw new SameCardExistException("markerFrontLeft[" + i + "]");
                }
                checkList[markerFrontLeft[i]] = false;
            }

            for (int i = 0; i < markerBackRight.Count; i++)
            {
                if (!checkList[markerBackRight[i]])
                {
                    throw new SameCardExistException("markerBackRight[" + i + "]");
                }
                checkList[markerBackRight[i]] = false;
            }

            for (int i = 0; i < markerBackLeft.Count; i++)
            {
                if (!checkList[markerBackLeft[i]])
                {
                    throw new SameCardExistException("markerBackLeft[" + i + "]");
                }
                checkList[markerBackLeft[i]] = false;
            }

            for (int i = 0; i < checkList.Length; i++)
            {
                if (checkList[i])
                {
                    throw new LostCardException();
                }
            }

        }


    }
    public enum Stage
    {
        FrontCenter,
        FrontRight,
        FrontLeft,
        BackRight,
        BackLeft,
    }

    [Serializable()]
    public class SameCardExistException : System.Exception
    {
        public SameCardExistException() : base() { }
        public SameCardExistException(string message) : base(message) { }
        public SameCardExistException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected SameCardExistException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }

    [Serializable()]
    public class LostCardException : System.Exception
    {
        public LostCardException() : base() { }
        public LostCardException(string message) : base(message) { }
        public LostCardException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected LostCardException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}