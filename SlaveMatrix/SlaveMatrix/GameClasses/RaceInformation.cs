using System;
using _2DGAMELIB;

namespace SlaveMatrix.GameClasses
{
    [Serializable]
    public struct RaceInformation
    {
        public int 希少;

        public int 需要;

        public int 危険;

        public int 一般;

        public int 娼婦;

        public RaceInformation(int 希少, int 需要, int 危険, int 一般, int 娼婦)
        {
            this.希少 = 希少;
            this.需要 = 需要;
            this.危険 = 危険;
            this.一般 = 一般;
            this.娼婦 = 娼婦;
        }

        public double GetPriceWeight()
        {
            return 需要 / (10.0 - (希少 + 危険) * 0.5);
        }

        public void 一般成長(int 一般最大加算)
        {
            if (0.05.Lot())
            {
                一般 = (一般 + 1).Clamp(0, 9 + 一般最大加算);
            }
        }

        public void 娼婦成長(int 娼婦最大加算)
        {
            if (0.05.Lot())
            {
                娼婦 = (娼婦 + 1).Clamp(0, 9 + 娼婦最大加算);
            }
        }
    }
}
