﻿/***************************************************************************
 *   QueryPropertiesPacket.cs
 *   Copyright (c) 2009 UltimaXNA Development Team
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 3 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/
#region usings
using UltimaXNA.Core.Network.Packets;
#endregion

namespace UltimaXNA.Ultima.Network.Client
{
    public class QueryPropertiesPacket : SendPacket
    {
        public QueryPropertiesPacket(Serial serial)
            : base(0xD6, "Query Properties", 7)
        {
            Stream.Write((short)7);
            Stream.Write((int)serial);
        }
    }
}
