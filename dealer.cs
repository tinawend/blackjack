using System;
using System.Collections.Generic;

namespace examination_3
{

public class Dealer : Player
{
    private int _limit;
    public Dealer(int limit, string name) : base (limit, name)
    {
        _limit = limit;

    }


}

}