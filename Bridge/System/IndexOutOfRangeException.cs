namespace System
{
    [Bridge.Convention(Member = Bridge.ConventionMember.Field | Bridge.ConventionMember.Method, Notation = Bridge.Notation.CamelCase)]
    [Bridge.External]
    [Bridge.Reflectable]
    public class IndexOutOfRangeException : SystemException, Bridge.IBridgeClass
    {
        public extern IndexOutOfRangeException();

        public extern IndexOutOfRangeException(string message);

        public extern IndexOutOfRangeException(string message, Exception innerException);
    }
}