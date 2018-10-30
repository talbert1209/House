﻿namespace House
{
    public class Outside : Location
    {
        private bool _hot;
        public Outside(string name, bool hot) : base(name)
        {
            _hot = hot;
        }

        public override string Description
        {
            get
            {
                if (_hot)
                {
                    return base.Description + "It's very hot here.";
                }

                return base.Description;
            }
        }
    }
}