using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace JavaNETInterface.Jni
{
    public struct JObject { }
    public struct JClass { }
    public struct JThrowable { }
    public struct JString { }
    public struct JArray { }
    public struct JBooleanArray { }
    public struct JByteArray { }
    public struct JCharArray { }
    public struct JShortArray { }
    public struct JIntArray { }
    public struct JLongArray { }
    public struct JFloatArray { }
    public struct JDoubleArray { }
    public struct JObjectArray { }
    public struct JFieldID { }
    public struct JMethodID { }
    public struct JWeak { }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct JValue
    {
        [FieldOffset(0)] public byte Z;
        [FieldOffset(0)] public sbyte B;
        [FieldOffset(0)] public ushort C;
        [FieldOffset(0)] public short S;
        [FieldOffset(0)] public int I;
        [FieldOffset(0)] public long J;
        [FieldOffset(0)] public float F;
        [FieldOffset(0)] public double D;
        [FieldOffset(0)] public JObject* L;
    }

    public enum JObjectRefType
    {
        JNIInvalidRefType = 0,
        JNILocalRefType = 1,
        JNIGlobalRefType = 2,
        JNIWeakGlobalRefType = 3,
    }

    public unsafe struct JniNativeMethod
    {
        public byte* Name;
        public byte* Signature;
        public void* FnPtr;
    }

    public unsafe struct JniInvokeInterface
    {
        public void* Reserved0;
        public void* Reserved1;
        public void* Reserved2;

        public delegate* unmanaged[Cdecl]<JavaVM*, int> DestroyJavaVM;
        public delegate* unmanaged[Cdecl]<JavaVM*, void**, JavaVMAttachArgs*, int> AttachCurrentThread;
        public delegate* unmanaged[Cdecl]<JavaVM*, int> DetachCurrentThread;
        public delegate* unmanaged[Cdecl]<JavaVM*, void**, int, int> GetEnv;
        public delegate* unmanaged[Cdecl]<JavaVM*, void**, JavaVMAttachArgs*, int> AttachCurrentThreadAsDaemon;
    }

    public unsafe struct JniNativeInterface
    {
        public void* Reserved0;
        public void* Reserved1;
        public void* Reserved2;
        public void* Reserved3;

        public delegate* unmanaged[Cdecl]<JniEnv*, int> GetVersion;
        public delegate* unmanaged[Cdecl]<JniEnv*, byte*, JObject*, sbyte*, int, JClass*> DefineClass;
        public delegate* unmanaged[Cdecl]<JniEnv*, byte*, JClass*> FindClass;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*> FromReflectedMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*> FromReflectedField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, byte, JObject*> ToReflectedMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JClass*> GetSuperclass;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JClass*, byte> IsAssignableFrom;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, byte, JObject*> ToReflectedField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JThrowable*, int> Throw;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, byte*, int> ThrowNew;
        public delegate* unmanaged[Cdecl]<JniEnv*, JThrowable*> ExceptionOccurred;
        public delegate* unmanaged[Cdecl]<JniEnv*, void> ExceptionDescribe;
        public delegate* unmanaged[Cdecl]<JniEnv*, void> ExceptionClear;
        public delegate* unmanaged[Cdecl]<JniEnv*, byte*, void> FatalError;
        public delegate* unmanaged[Cdecl]<JniEnv*, int, int> PushLocalFrame;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JObject*> PopLocalFrame;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JObject*> NewGlobalRef;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, void> DeleteGlobalRef;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, void> DeleteLocalRef;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JObject*, byte> IsSameObject;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JObject*> NewLocalRef;
        public delegate* unmanaged[Cdecl]<JniEnv*, int, int> EnsureLocalCapacity;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JObject*> AllocObject;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JObject*> NewObject;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, IntPtr, JObject*> NewObjectV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JValue*, JObject*> NewObjectA;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*> GetObjectClass;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, byte> IsInstanceOf;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, byte*, byte*, JMethodID*> GetMethodID;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, JObject*> CallObjectMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, IntPtr, JObject*> CallObjectMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, JValue*, JObject*> CallObjectMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, byte> CallBooleanMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, IntPtr, byte> CallBooleanMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, JValue*, byte> CallBooleanMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, sbyte> CallByteMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, IntPtr, sbyte> CallByteMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, JValue*, sbyte> CallByteMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, ushort> CallCharMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, IntPtr, ushort> CallCharMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, JValue*, ushort> CallCharMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, short> CallShortMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, IntPtr, short> CallShortMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, JValue*, short> CallShortMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, int> CallIntMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, IntPtr, int> CallIntMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, JValue*, int> CallIntMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, long> CallLongMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, IntPtr, long> CallLongMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, JValue*, long> CallLongMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, float> CallFloatMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, IntPtr, float> CallFloatMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, JValue*, float> CallFloatMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, double> CallDoubleMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, IntPtr, double> CallDoubleMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, JValue*, double> CallDoubleMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, void> CallVoidMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, IntPtr, void> CallVoidMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JMethodID*, JValue*, void> CallVoidMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, JObject*> CallNonvirtualObjectMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, IntPtr, JObject*> CallNonvirtualObjectMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, JValue*, JObject*> CallNonvirtualObjectMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, byte> CallNonvirtualBooleanMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, IntPtr, byte> CallNonvirtualBooleanMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, JValue*, byte> CallNonvirtualBooleanMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, sbyte> CallNonvirtualByteMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, IntPtr, sbyte> CallNonvirtualByteMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, JValue*, sbyte> CallNonvirtualByteMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, ushort> CallNonvirtualCharMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, IntPtr, ushort> CallNonvirtualCharMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, JValue*, ushort> CallNonvirtualCharMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, short> CallNonvirtualShortMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, IntPtr, short> CallNonvirtualShortMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, JValue*, short> CallNonvirtualShortMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, int> CallNonvirtualIntMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, IntPtr, int> CallNonvirtualIntMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, JValue*, int> CallNonvirtualIntMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, long> CallNonvirtualLongMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, IntPtr, long> CallNonvirtualLongMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, JValue*, long> CallNonvirtualLongMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, float> CallNonvirtualFloatMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, IntPtr, float> CallNonvirtualFloatMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, JValue*, float> CallNonvirtualFloatMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, double> CallNonvirtualDoubleMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, IntPtr, double> CallNonvirtualDoubleMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, JValue*, double> CallNonvirtualDoubleMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, void> CallNonvirtualVoidMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, IntPtr, void> CallNonvirtualVoidMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JClass*, JMethodID*, JValue*, void> CallNonvirtualVoidMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, byte*, byte*, JFieldID*> GetFieldID;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, JObject*> GetObjectField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, byte> GetBooleanField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, sbyte> GetByteField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, ushort> GetCharField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, short> GetShortField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, int> GetIntField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, long> GetLongField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, float> GetFloatField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, double> GetDoubleField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, JObject*, void> SetObjectField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, byte, void> SetBooleanField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, sbyte, void> SetByteField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, ushort, void> SetCharField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, short, void> SetShortField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, int, void> SetIntField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, long, void> SetLongField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, float, void> SetFloatField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JFieldID*, double, void> SetDoubleField;

        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, byte*, byte*, JMethodID*> GetStaticMethodID;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JObject*> CallStaticObjectMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, IntPtr, JObject*> CallStaticObjectMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JValue*, JObject*> CallStaticObjectMethodA;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, byte> CallStaticBooleanMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, IntPtr, byte> CallStaticBooleanMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JValue*, byte> CallStaticBooleanMethodA;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, sbyte> CallStaticByteMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, IntPtr, sbyte> CallStaticByteMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JValue*, sbyte> CallStaticByteMethodA;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, ushort> CallStaticCharMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, IntPtr, ushort> CallStaticCharMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JValue*, ushort> CallStaticCharMethodA;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, short> CallStaticShortMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, IntPtr, short> CallStaticShortMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JValue*, short> CallStaticShortMethodA;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, int> CallStaticIntMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, IntPtr, int> CallStaticIntMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JValue*, int> CallStaticIntMethodA;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, long> CallStaticLongMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, IntPtr, long> CallStaticLongMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JValue*, long> CallStaticLongMethodA;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, float> CallStaticFloatMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, IntPtr, float> CallStaticFloatMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JValue*, float> CallStaticFloatMethodA;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, double> CallStaticDoubleMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, IntPtr, double> CallStaticDoubleMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JValue*, double> CallStaticDoubleMethodA;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, void> CallStaticVoidMethod;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, IntPtr, void> CallStaticVoidMethodV;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JMethodID*, JValue*, void> CallStaticVoidMethodA;

        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, byte*, byte*, JFieldID*> GetStaticFieldID;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, JObject*> GetStaticObjectField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, byte> GetStaticBooleanField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, sbyte> GetStaticByteField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, ushort> GetStaticCharField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, short> GetStaticShortField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, int> GetStaticIntField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, long> GetStaticLongField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, float> GetStaticFloatField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, double> GetStaticDoubleField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, JObject*, void> SetStaticObjectField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, byte, void> SetStaticBooleanField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, sbyte, void> SetStaticByteField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, ushort, void> SetStaticCharField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, short, void> SetStaticShortField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, int, void> SetStaticIntField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, long, void> SetStaticLongField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, float, void> SetStaticFloatField;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JFieldID*, double, void> SetStaticDoubleField;

        public delegate* unmanaged[Cdecl]<JniEnv*, ushort*, int, JString*> NewString;
        public delegate* unmanaged[Cdecl]<JniEnv*, JString*, int> GetStringLength;
        public delegate* unmanaged[Cdecl]<JniEnv*, JString*, byte*, ushort*> GetStringChars;
        public delegate* unmanaged[Cdecl]<JniEnv*, JString*, ushort*, void> ReleaseStringChars;
        public delegate* unmanaged[Cdecl]<JniEnv*, byte*, JString*> NewStringUTF;
        public delegate* unmanaged[Cdecl]<JniEnv*, JString*, int> GetStringUTFLength;
        public delegate* unmanaged[Cdecl]<JniEnv*, JString*, byte*, byte*> GetStringUTFChars;
        public delegate* unmanaged[Cdecl]<JniEnv*, JString*, byte*, void> ReleaseStringUTFChars;
        public delegate* unmanaged[Cdecl]<JniEnv*, JString*, long> GetStringUTFLengthAsLong;

        public delegate* unmanaged[Cdecl]<JniEnv*, JArray*, int> GetArrayLength;
        public delegate* unmanaged[Cdecl]<JniEnv*, int, JClass*, JObject*, JObjectArray*> NewObjectArray;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObjectArray*, int, JObject*> GetObjectArrayElement;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObjectArray*, int, JObject*, void> SetObjectArrayElement;
        public delegate* unmanaged[Cdecl]<JniEnv*, int, JBooleanArray*> NewBooleanArray;
        public delegate* unmanaged[Cdecl]<JniEnv*, int, JByteArray*> NewByteArray;
        public delegate* unmanaged[Cdecl]<JniEnv*, int, JCharArray*> NewCharArray;
        public delegate* unmanaged[Cdecl]<JniEnv*, int, JShortArray*> NewShortArray;
        public delegate* unmanaged[Cdecl]<JniEnv*, int, JIntArray*> NewIntArray;
        public delegate* unmanaged[Cdecl]<JniEnv*, int, JLongArray*> NewLongArray;
        public delegate* unmanaged[Cdecl]<JniEnv*, int, JFloatArray*> NewFloatArray;
        public delegate* unmanaged[Cdecl]<JniEnv*, int, JDoubleArray*> NewDoubleArray;

        public delegate* unmanaged[Cdecl]<JniEnv*, JBooleanArray*, byte*, byte*> GetBooleanArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JByteArray*, byte*, sbyte*> GetByteArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JCharArray*, byte*, ushort*> GetCharArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JShortArray*, byte*, short*> GetShortArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JIntArray*, byte*, int*> GetIntArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JLongArray*, byte*, long*> GetLongArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JFloatArray*, byte*, float*> GetFloatArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JDoubleArray*, byte*, double*> GetDoubleArrayElements;

        public delegate* unmanaged[Cdecl]<JniEnv*, JBooleanArray*, byte*, int, void> ReleaseBooleanArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JByteArray*, sbyte*, int, void> ReleaseByteArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JCharArray*, ushort*, int, void> ReleaseCharArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JShortArray*, short*, int, void> ReleaseShortArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JIntArray*, int*, int, void> ReleaseIntArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JLongArray*, long*, int, void> ReleaseLongArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JFloatArray*, float*, int, void> ReleaseFloatArrayElements;
        public delegate* unmanaged[Cdecl]<JniEnv*, JDoubleArray*, double*, int, void> ReleaseDoubleArrayElements;

        public delegate* unmanaged[Cdecl]<JniEnv*, JBooleanArray*, int, int, byte*, void> GetBooleanArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JByteArray*, int, int, sbyte*, void> GetByteArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JCharArray*, int, int, ushort*, void> GetCharArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JShortArray*, int, int, short*, void> GetShortArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JIntArray*, int, int, int*, void> GetIntArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JLongArray*, int, int, long*, void> GetLongArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JFloatArray*, int, int, float*, void> GetFloatArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JDoubleArray*, int, int, double*, void> GetDoubleArrayRegion;

        public delegate* unmanaged[Cdecl]<JniEnv*, JBooleanArray*, int, int, byte*, void> SetBooleanArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JByteArray*, int, int, sbyte*, void> SetByteArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JCharArray*, int, int, ushort*, void> SetCharArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JShortArray*, int, int, short*, void> SetShortArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JIntArray*, int, int, int*, void> SetIntArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JLongArray*, int, int, long*, void> SetLongArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JFloatArray*, int, int, float*, void> SetFloatArrayRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JDoubleArray*, int, int, double*, void> SetDoubleArrayRegion;

        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JniNativeMethod*, int, int> RegisterNatives;
        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, int> UnregisterNatives;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, int> MonitorEnter;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, int> MonitorExit;
        public delegate* unmanaged[Cdecl]<JniEnv*, JavaVM**, int> GetJavaVM;

        public delegate* unmanaged[Cdecl]<JniEnv*, JString*, int, int, ushort*, void> GetStringRegion;
        public delegate* unmanaged[Cdecl]<JniEnv*, JString*, int, int, byte*, void> GetStringUTFRegion;

        public delegate* unmanaged[Cdecl]<JniEnv*, JArray*, byte*, void*> GetPrimitiveArrayCritical;
        public delegate* unmanaged[Cdecl]<JniEnv*, JArray*, void*, int, void> ReleasePrimitiveArrayCritical;
        public delegate* unmanaged[Cdecl]<JniEnv*, JString*, byte*, ushort*> GetStringCritical;
        public delegate* unmanaged[Cdecl]<JniEnv*, JString*, ushort*, void> ReleaseStringCritical;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JWeak*> NewWeakGlobalRef;
        public delegate* unmanaged[Cdecl]<JniEnv*, JWeak*, void> DeleteWeakGlobalRef;

        public delegate* unmanaged[Cdecl]<JniEnv*, byte> ExceptionCheck;

        public delegate* unmanaged[Cdecl]<JniEnv*, void*, long, JObject*> NewDirectByteBuffer;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, void*> GetDirectBufferAddress;
        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, long> GetDirectBufferCapacity;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, JObjectRefType> GetObjectRefType;

        public delegate* unmanaged[Cdecl]<JniEnv*, JClass*, JObject*> GetModule;

        public delegate* unmanaged[Cdecl]<JniEnv*, JObject*, byte> IsVirtualThread;
    }


    // JNI окружение
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JniEnv
    {
        public JniNativeInterface* Functions;
    }

    // Java VM
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JavaVM
    {
        public JniInvokeInterface* Functions;
    }

    public unsafe struct JavaVMOption
    {
        public byte* OptionString;
        public void* ExtraInfo;
    }

    public unsafe struct JavaVMInitArgs
    {
        public int Version;
        public int NOptions;
        public JavaVMOption* Options;
        public byte IgnoreUnrecognized;
    }

    public unsafe struct JavaVMAttachArgs
    {
        public int Version;
        public byte* Name;
        public JObject* Group;
    }

    public static unsafe partial class JniNative
    {
        [LibraryImport("jvm.dll", EntryPoint = "JNI_GetDefaultJavaVMInitArgs")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial int JNI_GetDefaultJavaVMInitArgs(void* args);

        [LibraryImport("jvm.dll", EntryPoint = "JNI_CreateJavaVM")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial int JNI_CreateJavaVM(JavaVM** pvm, void** penv, void* args);

        [LibraryImport("jvm.dll", EntryPoint = "JNI_GetCreatedJavaVMs")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial int JNI_GetCreatedJavaVMs(JavaVM** pvm, int buffSize, int* count);

        [LibraryImport("jvm.dll", EntryPoint = "JNI_OnLoad")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial int JNI_OnLoad(JavaVM* vm, void* reserved);

        [LibraryImport("jvm.dll", EntryPoint = "JNI_OnUnload")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void JNI_OnUnload(JavaVM* vm, void* reserved);
    }
}