using JavaNETInterface.Jni;

namespace JavaNETInterface.Wrappers
{
    public abstract unsafe class JniObject : IDisposable
    {
        private bool _isGlobal;

        protected JniEnv* _env;

        public JObject* Object { get; protected set; }

        public JniObject(JniEnv* env, JObject* obj)
        {
            _env = env;
            Object = obj;
        }

        public void ChangeEnvironment(JniEnv* newEnv)
            => _env = newEnv;

        public void Dispose()
        {
            if (Object == null)
                return;

            if (_isGlobal)
                _env->DeleteGlobalRef(Object);
            else
                _env->DeleteLocalRef(Object);

            Object = null;

            GC.SuppressFinalize(this);
        }

        public T ToGlobal<T>() where T : JniObject
        {
            if (_isGlobal || Object == null)
                return (T)this;

            var local = Object;
            Object = _env->NewGlobalRef(local);
            _env->DeleteLocalRef(local);

            _isGlobal = true;
            
            return (T)this;
        }
    }
}
