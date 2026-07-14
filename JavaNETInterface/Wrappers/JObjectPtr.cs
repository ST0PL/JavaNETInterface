using JavaNETInterface.Jni;

namespace JavaNETInterface.Wrappers
{
    public unsafe readonly struct JObjectPtr(nint v)
    {
        public readonly JObject* Value => (JObject*)v;
    }
}
