﻿using ProtoBuf;
using System;

namespace Trinity
{
    [Serializable, ProtoContract(Name = @"CSHeartBeat")]
    public partial class CSHeartBeat : CSPacketBase
    {
        public CSHeartBeat()
        {

        }

        public override int Id
        {
            get
            {
                return 1;
            }
        }

        public override void Clear()
        {

        }
    }
}
