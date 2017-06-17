// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX41 
    {
        public class TestRequest : Message
        {
            public const string MsgType = "1";

            public TestRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("1"));
            }

            public TestRequest(TestRequest other) : base(other)
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("1"));
            }

            public new TestRequest Clone()
            {
                return (TestRequest)DoClone();
            }

            protected override QuickFix.Message DoClone()
            {
                return new TestRequest(this);
            }

            public TestRequest(
                    QuickFix.Fields.TestReqID aTestReqID
                ) : this()
            {
                this.TestReqID = aTestReqID;
            }

            public QuickFix.Fields.TestReqID TestReqID
            { 
                get 
                {
                    QuickFix.Fields.TestReqID val = new QuickFix.Fields.TestReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TestReqID val) 
            { 
                this.TestReqID = val;
            }
            
            public QuickFix.Fields.TestReqID Get(QuickFix.Fields.TestReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TestReqID val) 
            { 
                return IsSetTestReqID();
            }
            
            public bool IsSetTestReqID() 
            { 
                return IsSetField(Tags.TestReqID);
            }

        }
    }
}
