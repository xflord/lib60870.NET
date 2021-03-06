/*
 *  ConnectionParameters.cs
 *
 *  Copyright 2016 MZ Automation GmbH
 *
 *  This file is part of lib60870.NET
 *
 *  lib60870.NET is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  lib60870.NET is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with lib60870.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *  See COPYING file for the complete license text.
 */

using System;

namespace lib60870
{
    /// <summary>
    /// 这里主要是104规约中用到的应用参数
    /// </summary>
	public class ConnectionParameters
    {
        /// <summary>
        /// 发送方未被确认的I格式的APDU最大数目 -- 默认12
        /// </summary>
		private int k = 12; /* number of unconfirmed APDUs in I format
		                (range: 1 .. 32767 (2^15 - 1) - sender will
		                stop transmission after k unconfirmed I messages */

        /// <summary>
        /// 接收方最多收到的未确认的I格式APDU数目，收到这么多必须确认了。。 --默认8
        /// </summary>
		private int w = 8; /* number of unconfirmed APDUs in I format 
						      (range: 1 .. 32767 (2^15 - 1) - receiver
						      will confirm latest after w messages */

        /// <summary>
        /// 网络建立连接超时时间--默认30
        /// </summary>
		private int t0 = 30; /* connection establishment (in s) */

        /// <summary>
        /// 发送或者测试APDU的超时时间--默认20
        /// </summary>
		private int t1 = 20; /* timeout for transmitted APDUs in I/U format (in s)
		                   when timeout elapsed without confirmation the connection
		                   will be closed */

        /// <summary>
        /// 接收方无数据报文时的确认超时时间--默认15
        /// </summary>
		private int t2 = 15; /* timeout to confirm messages (in s) */

        /// <summary>
        /// 通道长期空闲时，发送确认镇的超时时间--默认25
        /// </summary>
        private int t3 = 25; /* time until test telegrams in case of idle connection */

        /// <summary>
        /// 类型标识长度，默认1
        /// </summary>
        private int sizeOfTypeId = 1;

        /// <summary>
        /// 可变结构限定词的长度，默认1
        /// </summary>
        private int sizeOfVSQ = 1; /* VSQ = variable sturcture qualifier */

        /// <summary>
        /// 传送原因的字节数，默认2
        /// </summary>
        private int sizeOfCOT = 2; /* (parameter b) COT = cause of transmission (1/2) */

        /// <summary>
        /// 原发地址：用来标明响应来自哪个主站的召唤，一般不用，置零
        /// </summary>
        private int originatorAddress = 0;

        /// <summary>
        /// 应用服务数据单元公共地址的字节数（ASDU 的 Address），默认2
        /// </summary>
        private int sizeOfCA = 2; /* (parameter a) CA = common address of ASDUs (1/2) */

        /// <summary>
        /// 信息体对象地址的字节数，默认是3
        /// </summary>
        private int sizeOfIOA = 3; /* (parameter c) IOA = information object address (1/2/3) */

        public ConnectionParameters()
        {
        }

        /// <summary>
        /// 复制一份，深度复制
        /// </summary>
        /// <returns></returns>
        public ConnectionParameters clone()
        {
            ConnectionParameters copy = new ConnectionParameters();

            copy.k = k;
            copy.w = w;
            copy.t0 = t0;
            copy.t1 = t1;
            copy.t2 = t2;
            copy.t3 = t3;
            copy.sizeOfTypeId = sizeOfTypeId;
            copy.sizeOfVSQ = sizeOfVSQ;
            copy.sizeOfCOT = sizeOfCOT;
            copy.originatorAddress = originatorAddress;
            copy.sizeOfCA = sizeOfCA;
            copy.sizeOfIOA = sizeOfIOA;

            return copy;
        }

        /// <summary>
        /// 发送方未被确认的I格式的APDU最大数目
        /// </summary>
        public int K
        {
            get
            {
                return this.k;
            }
            set
            {
                k = value;
            }
        }

        /// <summary>
        /// 接收方最多收到的未确认的I格式APDU数目，收到这么多必须确认了。。 -- 默认8
        /// </summary>
        public int W
        {
            get
            {
                return this.w;
            }
            set
            {
                w = value;
            }
        }

        /// <summary>
        /// 网络建立连接超时时间--默认30
        /// </summary>
        public int T0
        {
            get
            {
                return this.t0;
            }
            set
            {
                t0 = value;
            }
        }

        /// <summary>
        /// 发送或者测试APDU的超时时间--默认20
        /// </summary>
        public int T1
        {
            get
            {
                return this.t1;
            }
            set
            {
                t1 = value;
            }
        }

        /// <summary>
        /// 接收方无数据报文时的确认超时时间--默认15
        /// </summary>
        public int T2
        {
            get
            {
                return this.t2;
            }
            set
            {
                t2 = value;
            }
        }

        /// <summary>
        /// 通道长期空闲时，发送确认镇的超时时间--默认25
        /// </summary>
        public int T3
        {
            get
            {
                return this.t3;
            }
            set
            {
                t3 = value;
            }
        }


        /// <summary>
        /// 传送原因的字节数，默认2
        /// </summary>
        public int SizeOfCOT
        {
            get
            {
                return this.sizeOfCOT;
            }
            set
            {
                sizeOfCOT = value;
            }
        }

        /// <summary>
        /// 原发地址：用来标明响应来自哪个主站的召唤，一般不用，置零
        /// </summary>
        public int OriginatorAddress
        {
            get
            {
                return this.originatorAddress;
            }
            set
            {
                originatorAddress = value;
            }
        }

        /// <summary>
        /// 应用服务数据单元公共地址的字节数（ASDU 的 Address），默认2
        /// </summary>
        public int SizeOfCA
        {
            get
            {
                return this.sizeOfCA;
            }
            set
            {
                sizeOfCA = value;
            }
        }

        /// <summary>
        /// 信息体对象地址的字节数，默认是3
        /// </summary>
        public int SizeOfIOA
        {
            get
            {
                return this.sizeOfIOA;
            }
            set
            {
                sizeOfIOA = value;
            }
        }


        /// <summary>
        /// 类型标识长度，默认1
        /// </summary> 
        public int SizeOfTypeId
        {
            get
            {
                return this.sizeOfTypeId;
            }
        }

        /// <summary>
        /// 可变结构限定词的长度，默认1
        /// </summary>
        public int SizeOfVSQ
        {
            get
            {
                return this.sizeOfVSQ;
            }
        }
    }
}

