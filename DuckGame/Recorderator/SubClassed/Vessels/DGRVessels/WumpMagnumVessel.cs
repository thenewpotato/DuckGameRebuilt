﻿namespace DuckGame
{
    public class WumpMagnumVessel : GunVessel
    {
        public WumpMagnumVessel(Thing th) : base(th)
        {
            IndexPriority = 1;
            tatchedTo.Add(typeof(WumpMagnum));
        }
        public override SomethingSomethingVessel RecDeserialize(BitBuffer b)
        {
            WumpMagnumVessel v = new WumpMagnumVessel(new WumpMagnum(0, -2000));
            return v;
        }
        public override BitBuffer RecSerialize(BitBuffer prevBuffer)
        {
            return prevBuffer;
        }
        public override void DoUpdateThing()
        {
            Gun g = (Gun)t;
            if (g.kick > 0) g.kick -= 0.2f;
            else g.kick = 0;
            if (g._flareAlpha > 0f) g._flareAlpha -= 0.5f;
            else g._flareAlpha = 0f;
        }
    }
}
