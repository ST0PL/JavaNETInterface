using JavaNETInterface.Jni;
using System.Collections;

namespace JavaNETInterface.Wrappers
{

    public unsafe class JList : JniObject, IEnumerable<JObjectPtr>
    {
        public unsafe class JListEnum(JniEnv* env, JObject* obj) : IEnumerator<JObjectPtr>
        {
            private readonly JObject* _object = obj;
            private readonly JniEnv* _env = env;

            public JObject* Get(int index)
            {
                JValue args = default;
                args.I = index;
                return _env->CallObjectMethodA(_object, getMethodId, &args);
            }

            public int GetSize()
                => _env->CallIntMethod(_object, sizeMethodId);

            // IEnumerable implementations

            private JObjectPtr _current;
            public JObjectPtr Current => _current;
            object IEnumerator.Current => Current;

            private int position = -1;

            public bool MoveNext()
            {
                if (position + 1 < GetSize())
                {
                    position++;
                    var jobj = Get(position);
                    _current = new JObjectPtr((nint)jobj);
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                position = -1;
                _current = default;
            }

            public void Dispose()
            { }
        }
        public static JClass* Class { get; private set; }

        private static readonly Lock lockObject = new();
        private static JMethodID* getMethodId;
        private static JMethodID* sizeMethodId;

        private static bool initialized;
        public JList(JniEnv* env, JObject* obj) : base(env, obj)
            => Initialize(env);

        public static void Initialize(JniEnv* env)
        {
            using (lockObject.EnterScope())
            {
                if (initialized)
                    return;

                Class = env->FindClassGlobalRef("java/util/List");
                getMethodId = env->GetMethodID(Class, "get", "(I)Ljava/lang/Object;");
                sizeMethodId = env->GetMethodID(Class, "size", "()I");
                initialized = true;
            }
        }
        public JObject* Get(int index)
        {
            JValue args = default;
            args.I = index;
            return _env->CallObjectMethodA(Object, getMethodId, &args);
        }

        public int GetSize()
            => _env->CallIntMethod(Object, sizeMethodId);

        public IEnumerator<JObjectPtr> GetEnumerator()
            => new JListEnum(_env, Object);

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
