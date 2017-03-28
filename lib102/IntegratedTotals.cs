using System;

namespace lib102
{
    /// <summary>
    /// ���ˣ��Ʒѣ������ۼ���
    /// <para>������</para>
    /// <para>��Ϣ�����ַ+�����ۼ���+У��</para>
    /// <para>������Ϣ�����������һ��5�ֽ�ʱ��</para>
    /// </summary>
    public class IntegratedTotals : InformationObject
    {
        /// <summary>
        /// ���ͱ�ʶM_IT_TA_2��2�������˵����ۼ�����ÿ����ռ4�ֽڣ���ʾ��Χ��-99 999 999~+99 999 999
        /// </summary>
        override public TypeID Type
        {
            get
            {
                return TypeID.M_IT_TA_2;
            }
        }

        //��֧������
        override public bool SupportsSequence
        {
            get
            {
                return false;
            }
        }

        #region �����ۼ���IT
        //�����ۼ����ṹ��
        //---------------------------------
        //         ��λλ��1
        //---------------------------------
        //         ��λλ��2
        //---------------------------------
        //         ��λλ��3
        //---------------------------------
        //         ��λλ��4
        //---------------------------------
        //  IV | CA | CY | ˳��ţ�bit0-5��
        //---------------------------------


        /// <summary>
        /// �����ۼ������ݣ����̣�-99 999 999~  +99 999 999������λkWh
        /// </summary>
        public int Value;
        /// <summary>
        /// ��CY����λλ 
        /// <para>true��1�����ۼ�ʱ����ڼ��������</para>
        /// <para>false��0�����ۼ�ʱ����ڼ�����δ���</para>
        /// </summary>
        public bool Carry;
        /// <summary>
        /// ��CA������������λ
        /// <para>true��1�����ۼ�ʱ����ڼ�����������</para>
        /// <para>false��0�����ۼ�ʱ����ڼ�����δ������</para>
        /// </summary>
        public bool CounterAdjusted;
        /// <summary>
        /// ��IV����Чλ
        /// <para>true��1����������������Ч</para>
        /// <para>false��0����������������Ч</para>
        /// </summary>
        public bool Invalid;
        protected int serialNo;
        /// <summary>
        /// ˳���,ȡֵ��Χ0-31
        /// <para>�������ۼ��������ն��豸��λʱ��˳��Ÿ�λΪ0��һ���ۼ�ʱ�θı�ʱ��˳��ż�1</para>
        /// </summary>
        public int SerialNo
        {
            get
            {
                return serialNo;
            }
            set
            {
                if (value < 0) serialNo = 0;
                if (value > 31) serialNo = 31;
            }
        }
        #endregion

        /// <summary>
        /// �����ۼ�����У��(���������ͱ�ʶ2-7)
        /// </summary>
        protected byte checksum;

        /// <summary>
        /// ʹ�û�����Ϣ����
        /// </summary>
        /// <param name="ioa"></param>
        /// <param name="val"></param>
        /// <param name="carry"></param>
        /// <param name="counterAdj"></param>
        /// <param name="invalid"></param>
        /// <param name="sn"></param>
        public IntegratedTotals(int ioa, int val,bool carry,bool counterAdj,bool invalid,int sn)
            : base(ioa)
        {
            this.Value = val;
            this.Carry = carry;
            this.CounterAdjusted = counterAdj;
            this.Invalid = invalid;
            this.SerialNo = sn;
        }

        internal IntegratedTotals( byte[] msg, int startIndex, bool isSquence) :
            base( msg, startIndex, isSquence)
        {
            if (!isSquence)
                startIndex ++; /* skip IOA */
            
        }

        internal override void Encode(Frame frame,  bool isSequence)
        {
            base.Encode(frame, isSequence);

        }
    }
}
