﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lib102
{
    /// <summary>
    /// 运行电能累计量 4字节量
    /// <para>非连续</para>
    /// <para>信息对象地址+电能累计量+校核</para>
    /// <para>所有信息对象最后，增加一个5字节时标</para>
    /// <para>不含校核</para>
    /// </summary>
    public class OperationalIT : IntegratedTotals
    {
        /// <summary>
        /// 类型标识M_IT_TG_2（8），运行电能累计量，每个量占4字节，表示范围：-99 999 999~+99 999 999
        /// </summary>
        override public TypeID Type
        {
            get
            {
                return TypeID.M_IT_TG_2;
            }
        }

        //不支持连续
        override public bool SupportsSequence
        {
            get
            {
                return false;
            }
        }

        //不含校核
        protected override void UpdateHasCheckSum()
        {
            HasCheckSum = false;
        }

        /// <summary>
        /// 使用基本信息创建
        /// </summary>
        /// <param name="ioa"></param>
        /// <param name="val"></param>
        /// <param name="carry"></param>
        /// <param name="counterAdj"></param>
        /// <param name="invalid"></param>
        /// <param name="sn"></param>
        public OperationalIT(int ioa, int val, bool carry, bool counterAdj, bool invalid, int sn)
            : base(ioa, val, carry, counterAdj, invalid, sn)
        {
        }

        /// <summary>
        /// 使用接收到的数据解析出来一个对象
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="startIndex"></param>
        /// <param name="isSquence"></param>
        internal OperationalIT(byte[] msg, int startIndex, bool isSquence)
           : base(msg, startIndex, isSquence)
        {
        }
    }

    /// <summary>
    /// 运行电能累计量 3字节量
    /// <para>非连续</para>
    /// <para>信息对象地址+电能累计量+校核</para>
    /// <para>所有信息对象最后，增加一个5字节时标</para>
    /// <para>不含校核</para>
    /// </summary>
    public class OperationalITWith3Byte : IntegratedTotalsWith3Byte
    {
        /// <summary>
        /// 类型标识M_IT_TG_2（9），运行电能累计量，每个量占3字节，表示范围：- 999 999~+ 999 999
        /// </summary>
        override public TypeID Type
        {
            get
            {
                return TypeID.M_IT_TH_2;
            }
        }

        //不支持连续
        override public bool SupportsSequence
        {
            get
            {
                return false;
            }
        }

        //不含校核
        protected override void UpdateHasCheckSum()
        {
            HasCheckSum = false;
        }

        /// <summary>
        /// 使用基本信息创建
        /// </summary>
        /// <param name="ioa"></param>
        /// <param name="val"></param>
        /// <param name="carry"></param>
        /// <param name="counterAdj"></param>
        /// <param name="invalid"></param>
        /// <param name="sn"></param>
        public OperationalITWith3Byte(int ioa, int val, bool carry, bool counterAdj, bool invalid, int sn)
            : base(ioa, val, carry, counterAdj, invalid, sn)
        {
        }

        /// <summary>
        /// 使用接收到的数据解析出来一个对象
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="startIndex"></param>
        /// <param name="isSquence"></param>
        internal OperationalITWith3Byte(byte[] msg, int startIndex, bool isSquence)
           : base(msg, startIndex, isSquence)
        {
        }
    }

    /// <summary>
    /// 运行电能累计量 2字节量
    /// <para>非连续</para>
    /// <para>信息对象地址+电能累计量+校核</para>
    /// <para>所有信息对象最后，增加一个5字节时标</para>
    /// <para>不含校核</para>
    /// </summary>
    public class OperationalITWith2Byte : IntegratedTotalsWith2Byte
    {
        /// <summary>
        /// 类型标识M_IT_TG_I（10），运行电能累计量，每个量占2字节，表示范围：-999~+ 999
        /// </summary>
        override public TypeID Type
        {
            get
            {
                return TypeID.M_IT_TI_2;
            }
        }

        //不支持连续
        override public bool SupportsSequence
        {
            get
            {
                return false;
            }
        }

        //不含校核
        protected override void UpdateHasCheckSum()
        {
            HasCheckSum = false;
        }

        /// <summary>
        /// 使用基本信息创建
        /// </summary>
        /// <param name="ioa"></param>
        /// <param name="val"></param>
        /// <param name="carry"></param>
        /// <param name="counterAdj"></param>
        /// <param name="invalid"></param>
        /// <param name="sn"></param>
        public OperationalITWith2Byte(int ioa, int val, bool carry, bool counterAdj, bool invalid, int sn)
            : base(ioa, val, carry, counterAdj, invalid, sn)
        {
        }

        /// <summary>
        /// 使用接收到的数据解析出来一个对象
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="startIndex"></param>
        /// <param name="isSquence"></param>
        internal OperationalITWith2Byte(byte[] msg, int startIndex, bool isSquence)
           : base(msg, startIndex, isSquence)
        {
        }
    }


}
