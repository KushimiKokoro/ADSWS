using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WS
{
    public class Effect
    {
        Kind kind;
        Keyword[] keyword;

        //システムが進んだら発動タイミング
        
        //効果のシステムどう組もうかな
    }

    public enum Kind
    {
        Automatic,
        Activated,
        Continuous,
    }

    public enum Keyword
    {
        無し,
        アラーム,
        アンコール,
        応援,
        絆,
        助太刀,
        大活躍,
        集中,
        チェンジ,
        記憶,
        経験,
        シフト,
        加速,
        共鳴,
    }
}