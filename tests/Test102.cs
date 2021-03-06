﻿using NUnit.Framework;
using lib102;
using System;

namespace tests
{
    [TestFixture()]
    class Test102
    {
        [Test()]

        public void TestFrame()
        {
            ConnectionParameters para = new ConnectionParameters();
            para.LinkAddress = 1;
            para.SizeOfCA = 2;

            LinkControlUp lc = new LinkControlUp();
            lc.ACD = true;
            lc.DFC = false;
            lc.FuncCode = LinkFunctionCodeUp.UserData;

            T102Frame frame = new T102Frame(lc, para);

            ASDU asdu = new ASDU(TypeID.M_SP_TA_2, CauseOfTransmission.SPONTANEOUS, false, false, 1, RecordAddress.Total, false);
            SinglePointInformation sp = new SinglePointInformation(0, true, 0, new CP56Time2b(new DateTime(2007, 8, 18, 6, 21, 1, 520)));
            asdu.AddInformationObject(sp);

            asdu.Encode(frame, para);

            frame.PrepareToSend();

            byte[] aa= frame.GetBuffer();


        }
       
    }
}
