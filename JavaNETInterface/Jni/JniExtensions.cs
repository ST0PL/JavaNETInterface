using JavaNETInterface.Utils;
using System.Runtime.InteropServices;

namespace JavaNETInterface.Jni
{
    public static unsafe class JniExtensions
    {
        extension(ref JniEnv env)
        {
            public string? JStringToString(JString* jstring)
            {
                fixed(JniEnv* envPtr = &env)
                {
                    if (jstring == null)
                        return null;

                    byte* utfChars = env.Functions->GetStringUTFChars(envPtr, jstring, null);

                    if (utfChars == null)
                        return null;

                    try
                    {
                        int len = env.Functions->GetStringUTFLength(envPtr, jstring);
                        return Marshal.PtrToStringUTF8((nint)utfChars, len);
                    }
                    finally { env.Functions->ReleaseStringUTFChars(envPtr, jstring, utfChars); }
                }
            }

            public int GetJavaVM(JavaVM** vm)
            {
                fixed(JniEnv* envPtr = &env)
                {
                    return env.Functions->GetJavaVM(envPtr, vm);
                }
            }

            public void GetStringRegion(JString* str, int start, int len, ushort* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->GetStringRegion(envPtr, str, start, len, buf);
                }
            }

            public void GetStringUTFRegion(JString* str, int start, int len, byte* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->GetStringUTFRegion(envPtr, str, start, len, buf);
                }
            }

            public void* GetPrimitiveArrayCritical(JArray* array, byte* isCopy)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetPrimitiveArrayCritical(envPtr, array, isCopy);
                }
            }

            public void ReleasePrimitiveArrayCritical(JArray* array, void* carray, int mode)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ReleasePrimitiveArrayCritical(envPtr, array, carray, mode);
                }
            }

            public ushort* GetStringCritical(JString* str, byte* isCopy)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStringCritical(envPtr, str, isCopy);
                }
            }

            public void ReleaseStringCritical(JString* str, ushort* chars)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ReleaseStringCritical(envPtr, str, chars);
                }
            }

            public JWeak* NewWeakGlobalRef(JObject* obj)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewWeakGlobalRef(envPtr, obj);
                }
            }

            public void DeleteWeakGlobalRef(JWeak* obj)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->DeleteWeakGlobalRef(envPtr, obj);
                }
            }

            public bool ExceptionCheck()
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->ExceptionCheck(envPtr) != 0;
                }
            }

            public JObject* NewDirectByteBuffer(void* address, long capacity)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewDirectByteBuffer(envPtr, address, capacity);
                }
            }

            public void* GetDirectBufferAddress(JObject* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetDirectBufferAddress(envPtr, buf);
                }
            }

            public long GetDirectBufferCapacity(JObject* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetDirectBufferCapacity(envPtr, buf);
                }
            }

            public JObjectRefType GetObjectRefType(JObject* obj)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetObjectRefType(envPtr, obj);
                }
            }

            public JObject* GetModule(JClass* klass)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetModule(envPtr, klass);
                }
            }

            public bool IsVirtualThread(JObject* thread)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->IsVirtualThread(envPtr, thread) != 0;
                }
            }

            public JFieldID* GetStaticFieldID(JClass* klass, string name, string sig)
            {
                fixed (JniEnv* envPtr = &env)
                fixed (byte* nPtr = JniHelper.GetUtf8Bytes(name))
                fixed (byte* sPtr = JniHelper.GetUtf8Bytes(sig))
                {
                    return env.Functions->GetStaticFieldID(envPtr, klass, nPtr, sPtr);
                }
            }

            public JObject* GetStaticObjectField(JClass* klass, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStaticObjectField(envPtr, klass, fieldID);
                }
            }

            public bool GetStaticBooleanField(JClass* klass, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStaticBooleanField(envPtr, klass, fieldID) != 0;
                }
            }

            public sbyte GetStaticByteField(JClass* klass, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStaticByteField(envPtr, klass, fieldID);
                }
            }

            public ushort GetStaticCharField(JClass* klass, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStaticCharField(envPtr, klass, fieldID);
                }
            }

            public short GetStaticShortField(JClass* klass, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStaticShortField(envPtr, klass, fieldID);
                }
            }

            public int GetStaticIntField(JClass* klass, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStaticIntField(envPtr, klass, fieldID);
                }
            }

            public long GetStaticLongField(JClass* klass, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStaticLongField(envPtr, klass, fieldID);
                }
            }

            public float GetStaticFloatField(JClass* klass, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStaticFloatField(envPtr, klass, fieldID);
                }
            }

            public double GetStaticDoubleField(JClass* klass, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStaticDoubleField(envPtr, klass, fieldID);
                }
            }

            public void SetStaticObjectField(JClass* klass, JFieldID* fieldID, JObject* value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetStaticObjectField(envPtr, klass, fieldID, value);
                }
            }

            public void SetStaticBooleanField(JClass* klass, JFieldID* fieldID, bool value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetStaticBooleanField(envPtr, klass, fieldID, value ? (byte)1 : (byte)0);
                }
            }

            public void SetStaticByteField(JClass* klass, JFieldID* fieldID, sbyte value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetStaticByteField(envPtr, klass, fieldID, value);
                }
            }

            public void SetStaticCharField(JClass* klass, JFieldID* fieldID, ushort value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetStaticCharField(envPtr, klass, fieldID, value);
                }
            }

            public void SetStaticShortField(JClass* klass, JFieldID* fieldID, short value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetStaticShortField(envPtr, klass, fieldID, value);
                }
            }

            public void SetStaticIntField(JClass* klass, JFieldID* fieldID, int value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetStaticIntField(envPtr, klass, fieldID, value);
                }
            }

            public void SetStaticLongField(JClass* klass, JFieldID* fieldID, long value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetStaticLongField(envPtr, klass, fieldID, value);
                }
            }

            public void SetStaticFloatField(JClass* klass, JFieldID* fieldID, float value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetStaticFloatField(envPtr, klass, fieldID, value);
                }
            }

            public void SetStaticDoubleField(JClass* klass, JFieldID* fieldID, double value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetStaticDoubleField(envPtr, klass, fieldID, value);
                }
            }

            public JFieldID* GetFieldID(JClass* klass, string name, string sig)
            {
                fixed (JniEnv* envPtr = &env)
                fixed (byte* nPtr = JniHelper.GetUtf8Bytes(name))
                fixed (byte* sPtr = JniHelper.GetUtf8Bytes(sig))
                {
                    return env.Functions->GetFieldID(envPtr, klass, nPtr, sPtr);
                }
            }

            public JObject* GetObjectField(JObject* obj, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetObjectField(envPtr, obj, fieldID);
                }
            }

            public bool GetBooleanField(JObject* obj, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetBooleanField(envPtr, obj, fieldID) != 0;
                }
            }

            public sbyte GetByteField(JObject* obj, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetByteField(envPtr, obj, fieldID);
                }
            }

            public ushort GetCharField(JObject* obj, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetCharField(envPtr, obj, fieldID);
                }
            }

            public short GetShortField(JObject* obj, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetShortField(envPtr, obj, fieldID);
                }
            }

            public int GetIntField(JObject* obj, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetIntField(envPtr, obj, fieldID);
                }
            }

            public long GetLongField(JObject* obj, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetLongField(envPtr, obj, fieldID);
                }
            }

            public float GetFloatField(JObject* obj, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetFloatField(envPtr, obj, fieldID);
                }
            }

            public double GetDoubleField(JObject* obj, JFieldID* fieldID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetDoubleField(envPtr, obj, fieldID);
                }
            }

            public void SetObjectField(JObject* obj, JFieldID* fieldID, JObject* value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetObjectField(envPtr, obj, fieldID, value);
                }
            }

            public void SetBooleanField(JObject* obj, JFieldID* fieldID, bool value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetBooleanField(envPtr, obj, fieldID, value ? (byte)1 : (byte)0);
                }
            }

            public void SetByteField(JObject* obj, JFieldID* fieldID, sbyte value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetByteField(envPtr, obj, fieldID, value);
                }
            }

            public void SetCharField(JObject* obj, JFieldID* fieldID, ushort value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetCharField(envPtr, obj, fieldID, value);
                }
            }

            public void SetShortField(JObject* obj, JFieldID* fieldID, short value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetShortField(envPtr, obj, fieldID, value);
                }
            }

            public void SetIntField(JObject* obj, JFieldID* fieldID, int value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetIntField(envPtr, obj, fieldID, value);
                }
            }

            public void SetLongField(JObject* obj, JFieldID* fieldID, long value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetLongField(envPtr, obj, fieldID, value);
                }
            }

            public void SetFloatField(JObject* obj, JFieldID* fieldID, float value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetFloatField(envPtr, obj, fieldID, value);
                }
            }

            public void SetDoubleField(JObject* obj, JFieldID* fieldID, double value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetDoubleField(envPtr, obj, fieldID, value);
                }
            }

            public int GetVersion()
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetVersion(envPtr);
                }
            }

            public JClass* DefineClass(byte* name, JObject* loader, sbyte* buf, int bufLen)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->DefineClass(envPtr, name, loader, buf, bufLen);
                }
            }

            public JClass* FindClass(byte* name)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->FindClass(envPtr, name);
                }
            }

            public JMethodID* FromReflectedMethod(JObject* method)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->FromReflectedMethod(envPtr, method);
                }
            }

            public JFieldID* FromReflectedField(JObject* field)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->FromReflectedField(envPtr, field);
                }
            }

            public JObject* ToReflectedMethod(JClass* klass, JMethodID* methodID, byte isStatic)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->ToReflectedMethod(envPtr, klass, methodID, isStatic);
                }
            }

            public JClass* GetSuperclass(JClass* klass)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetSuperclass(envPtr, klass);
                }
            }

            public bool IsAssignableFrom(JClass* klass1, JClass* klass2)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->IsAssignableFrom(envPtr, klass1, klass2) != 0;
                }
            }

            public JObject* ToReflectedField(JClass* klass, JFieldID* fieldID, byte isStatic)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->ToReflectedField(envPtr, klass, fieldID, isStatic);
                }
            }

            public int Throw(JThrowable* throwable)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->Throw(envPtr, throwable);
                }
            }

            public int ThrowNew(JClass* klass, byte* message)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->ThrowNew(envPtr, klass, message);
                }
            }

            public JThrowable* ExceptionOccurred()
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->ExceptionOccurred(envPtr);
                }
            }

            public void ExceptionDescribe()
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ExceptionDescribe(envPtr);
                }
            }

            public void ExceptionClear()
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ExceptionClear(envPtr);
                }
            }

            public void FatalError(byte* msg)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->FatalError(envPtr, msg);
                }
            }

            public int PushLocalFrame(int capacity)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->PushLocalFrame(envPtr, capacity);
                }
            }

            public JObject* PopLocalFrame(JObject* result)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->PopLocalFrame(envPtr, result);
                }
            }

            public JObject* NewGlobalRef(JObject* obj)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewGlobalRef(envPtr, obj);
                }
            }

            public void DeleteGlobalRef(JObject* obj)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->DeleteGlobalRef(envPtr, obj);
                }
            }

            public void DeleteLocalRef(JObject* obj)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->DeleteLocalRef(envPtr, obj);
                }
            }

            public bool IsSameObject(JObject* obj1, JObject* obj2)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->IsSameObject(envPtr, obj1, obj2) != 0;
                }
            }

            public JObject* NewLocalRef(JObject* obj)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewLocalRef(envPtr, obj);
                }
            }

            public int EnsureLocalCapacity(int capacity)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->EnsureLocalCapacity(envPtr, capacity);
                }
            }

            public JObject* AllocObject(JClass* klass)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->AllocObject(envPtr, klass);
                }
            }

            public JObject* NewObject(JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewObject(envPtr, klass, methodID);
                }
            }

            public JObject* NewObjectA(JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewObjectA(envPtr, klass, methodID, args);
                }
            }

            public JClass* GetObjectClass(JObject* obj)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetObjectClass(envPtr, obj);
                }
            }

            public bool IsInstanceOf(JObject* obj, JClass* klass)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->IsInstanceOf(envPtr, obj, klass) != 0;
                }
            }

            public JMethodID* GetMethodID(JClass* klass,string name, string sig)
            {
                fixed(byte* nP = JniHelper.GetUtf8Bytes(name))
                fixed (byte* sP = JniHelper.GetUtf8Bytes(sig))
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetMethodID(envPtr, klass, nP, sP);
                }
            }

            public JClass* FindClass(string className)
            {
                fixed(JniEnv* envPtr = &env)
                fixed(byte* nameBytes = JniHelper.GetUtf8Bytes(className))
                {
                    return env.Functions->FindClass(envPtr, nameBytes);
                }
            }

            public JClass* FindClassGlobalRef(string className)
            {
                fixed (JniEnv* envPtr = &env)
                fixed (byte* nameBytes = JniHelper.GetUtf8Bytes(className))
                {
                    var localRef = env.Functions->FindClass(envPtr, nameBytes);
                    var globalRef = env.Functions->NewGlobalRef(envPtr, (JObject*)localRef);
                    env.Functions->DeleteLocalRef(envPtr, (JObject*)localRef);
                    
                    return (JClass*)globalRef;
                }
            }
            public JMethodID* GetStaticMethodID(JClass* klass, string name, string sig)
            {
                fixed (JniEnv* envPtr = &env)
                fixed (byte* nameBytes = JniHelper.GetUtf8Bytes(name))
                fixed (byte* sigBytes = JniHelper.GetUtf8Bytes(sig))
                {
                    return env.Functions->GetStaticMethodID(envPtr, klass, nameBytes, sigBytes);
                }
            }

            public JObject* CallStaticObjectMethod(JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticObjectMethod(envPtr, klass, methodID);
                }
            }

            public JObject* CallStaticObjectMethodA(JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticObjectMethodA(envPtr, klass, methodID, args);
                }
            }

            public bool CallStaticBooleanMethod(JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticBooleanMethod(envPtr, klass, methodID) != 0;
                }
            }

            public bool CallStaticBooleanMethodA(JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticBooleanMethodA(envPtr, klass, methodID, args) != 0;
                }
            }

            public sbyte CallStaticByteMethod(JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticByteMethod(envPtr, klass, methodID);
                }
            }

            public sbyte CallStaticByteMethodA(JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticByteMethodA(envPtr, klass, methodID, args);
                }
            }

            public ushort CallStaticCharMethod(JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticCharMethod(envPtr, klass, methodID);
                }
            }

            public ushort CallStaticCharMethodA(JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticCharMethodA(envPtr, klass, methodID, args);
                }
            }

            public short CallStaticShortMethod(JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticShortMethod(envPtr, klass, methodID);
                }
            }

            public short CallStaticShortMethodA(JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticShortMethodA(envPtr, klass, methodID, args);
                }
            }

            public int CallStaticIntMethod(JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticIntMethod(envPtr, klass, methodID);
                }
            }

            public int CallStaticIntMethodA(JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticIntMethodA(envPtr, klass, methodID, args);
                }
            }

            public long CallStaticLongMethod(JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticLongMethod(envPtr, klass, methodID);
                }
            }

            public long CallStaticLongMethodA(JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticLongMethodA(envPtr, klass, methodID, args);
                }
            }

            public float CallStaticFloatMethod(JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticFloatMethod(envPtr, klass, methodID);
                }
            }

            public float CallStaticFloatMethodA(JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticFloatMethodA(envPtr, klass, methodID, args);
                }
            }

            public double CallStaticDoubleMethod(JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticDoubleMethod(envPtr, klass, methodID);
                }
            }

            public double CallStaticDoubleMethodA(JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallStaticDoubleMethodA(envPtr, klass, methodID, args);
                }
            }

            public void CallStaticVoidMethod(JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->CallStaticVoidMethod(envPtr, klass, methodID);
                }
            }

            public void CallStaticVoidMethodA(JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->CallStaticVoidMethodA(envPtr, klass, methodID, args);
                }
            }

            public JObject* CallObjectMethod(JObject* obj, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallObjectMethod(envPtr, obj, methodID);
                }
            }

            public JObject* CallObjectMethodA(JObject* obj, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallObjectMethodA(envPtr, obj, methodID, args);
                }
            }

            public bool CallBooleanMethod(JObject* obj, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallBooleanMethod(envPtr, obj, methodID) != 0;
                }
            }

            public bool CallBooleanMethodA(JObject* obj, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallBooleanMethodA(envPtr, obj, methodID, args) != 0;
                }
            }

            public sbyte CallByteMethod(JObject* obj, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallByteMethod(envPtr, obj, methodID);
                }
            }

            public sbyte CallByteMethodA(JObject* obj, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallByteMethodA(envPtr, obj, methodID, args);
                }
            }

            public ushort CallCharMethod(JObject* obj, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallCharMethod(envPtr, obj, methodID);
                }
            }

            public ushort CallCharMethodA(JObject* obj, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallCharMethodA(envPtr, obj, methodID, args);
                }
            }

            public short CallShortMethod(JObject* obj, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallShortMethod(envPtr, obj, methodID);
                }
            }

            public short CallShortMethodA(JObject* obj, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallShortMethodA(envPtr, obj, methodID, args);
                }
            }

            public int CallIntMethod(JObject* obj, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallIntMethod(envPtr, obj, methodID);
                }
            }

            public int CallIntMethodA(JObject* obj, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallIntMethodA(envPtr, obj, methodID, args);
                }
            }

            public long CallLongMethod(JObject* obj, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallLongMethod(envPtr, obj, methodID);
                }
            }

            public long CallLongMethodA(JObject* obj, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallLongMethodA(envPtr, obj, methodID, args);
                }
            }

            public float CallFloatMethod(JObject* obj, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallFloatMethod(envPtr, obj, methodID);
                }
            }

            public float CallFloatMethodA(JObject* obj, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallFloatMethodA(envPtr, obj, methodID, args);
                }
            }

            public double CallDoubleMethod(JObject* obj, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallDoubleMethod(envPtr, obj, methodID);
                }
            }

            public double CallDoubleMethodA(JObject* obj, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallDoubleMethodA(envPtr, obj, methodID, args);
                }
            }

            public void CallVoidMethod(JObject* obj, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->CallVoidMethod(envPtr, obj, methodID);
                }
            }

            public void CallVoidMethodA(JObject* obj, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->CallVoidMethodA(envPtr, obj, methodID, args);
                }
            }

            public JObject* CallNonvirtualObjectMethod(JObject* obj, JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualObjectMethod(envPtr, obj, klass, methodID);
                }
            }

            public JObject* CallNonvirtualObjectMethodA(JObject* obj, JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualObjectMethodA(envPtr, obj, klass, methodID, args);
                }
            }

            public bool CallNonvirtualBooleanMethod(JObject* obj, JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualBooleanMethod(envPtr, obj, klass, methodID) != 0;
                }
            }

            public bool CallNonvirtualBooleanMethodA(JObject* obj, JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualBooleanMethodA(envPtr, obj, klass, methodID, args) != 0;
                }
            }

            public sbyte CallNonvirtualByteMethod(JObject* obj, JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualByteMethod(envPtr, obj, klass, methodID);
                }
            }

            public sbyte CallNonvirtualByteMethodA(JObject* obj, JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualByteMethodA(envPtr, obj, klass, methodID, args);
                }
            }

            public ushort CallNonvirtualCharMethod(JObject* obj, JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualCharMethod(envPtr, obj, klass, methodID);
                }
            }

            public ushort CallNonvirtualCharMethodA(JObject* obj, JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualCharMethodA(envPtr, obj, klass, methodID, args);
                }
            }

            public short CallNonvirtualShortMethod(JObject* obj, JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualShortMethod(envPtr, obj, klass, methodID);
                }
            }

            public short CallNonvirtualShortMethodA(JObject* obj, JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualShortMethodA(envPtr, obj, klass, methodID, args);
                }
            }

            public int CallNonvirtualIntMethod(JObject* obj, JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualIntMethod(envPtr, obj, klass, methodID);
                }
            }

            public int CallNonvirtualIntMethodA(JObject* obj, JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualIntMethodA(envPtr, obj, klass, methodID, args);
                }
            }

            public long CallNonvirtualLongMethod(JObject* obj, JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualLongMethod(envPtr, obj, klass, methodID);
                }
            }

            public long CallNonvirtualLongMethodA(JObject* obj, JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualLongMethodA(envPtr, obj, klass, methodID, args);
                }
            }

            public float CallNonvirtualFloatMethod(JObject* obj, JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualFloatMethod(envPtr, obj, klass, methodID);
                }
            }

            public float CallNonvirtualFloatMethodA(JObject* obj, JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualFloatMethodA(envPtr, obj, klass, methodID, args);
                }
            }

            public double CallNonvirtualDoubleMethod(JObject* obj, JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualDoubleMethod(envPtr, obj, klass, methodID);
                }
            }

            public double CallNonvirtualDoubleMethodA(JObject* obj, JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->CallNonvirtualDoubleMethodA(envPtr, obj, klass, methodID, args);
                }
            }

            public void CallNonvirtualVoidMethod(JObject* obj, JClass* klass, JMethodID* methodID)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->CallNonvirtualVoidMethod(envPtr, obj, klass, methodID);
                }
            }

            public void CallNonvirtualVoidMethodA(JObject* obj, JClass* klass, JMethodID* methodID, JValue* args)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->CallNonvirtualVoidMethodA(envPtr, obj, klass, methodID, args);
                }
            }

            public JString* NewString(ushort* unicode, int len)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewString(envPtr, unicode, len);
                }
            }

            public int GetStringLength(JString* str)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStringLength(envPtr, str);
                }
            }

            public ushort* GetStringChars(JString* str, byte* isCopy)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStringChars(envPtr, str, isCopy);
                }
            }

            public void ReleaseStringChars(JString* str, ushort* chars)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ReleaseStringChars(envPtr, str, chars);
                }
            }

            public JString* NewStringUTF(string str)
            {
                fixed (JniEnv* envPtr = &env)
                fixed (byte* utfChars = JniHelper.GetUtf8Bytes(str))
                {
                    return env.Functions->NewStringUTF(envPtr, utfChars);
                }
            }

            public int GetStringUTFLength(JString* str)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStringUTFLength(envPtr, str);
                }
            }

            public byte* GetStringUTFChars(JString* str, byte* isCopy)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStringUTFChars(envPtr, str, isCopy);
                }
            }

            public void ReleaseStringUTFChars(JString* str, byte* chars)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ReleaseStringUTFChars(envPtr, str, chars);
                }
            }
            public long GetStringUTFLengthAsLong(JString* str)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetStringUTFLengthAsLong(envPtr, str);
                }
            }

            public int GetArrayLength(JArray* array)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetArrayLength(envPtr, array);
                }
            }

            public JObjectArray* NewObjectArray(int length, JClass* elementClass, JObject* initialElement)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewObjectArray(envPtr, length, elementClass, initialElement);
                }
            }

            public JObject* GetObjectArrayElement(JObjectArray* array, int index)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetObjectArrayElement(envPtr, array, index);
                }
            }

            public void SetObjectArrayElement(JObjectArray* array, int index, JObject* value)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetObjectArrayElement(envPtr, array, index, value);
                }
            }

            public JBooleanArray* NewBooleanArray(int length)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewBooleanArray(envPtr, length);
                }
            }

            public JByteArray* NewByteArray(int length)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewByteArray(envPtr, length);
                }
            }

            public JCharArray* NewCharArray(int length)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewCharArray(envPtr, length);
                }
            }

            public JShortArray* NewShortArray(int length)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewShortArray(envPtr, length);
                }
            }

            public JIntArray* NewIntArray(int length)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewIntArray(envPtr, length);
                }
            }

            public JLongArray* NewLongArray(int length)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewLongArray(envPtr, length);
                }
            }

            public JFloatArray* NewFloatArray(int length)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewFloatArray(envPtr, length);
                }
            }

            public JDoubleArray* NewDoubleArray(int length)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->NewDoubleArray(envPtr, length);
                }
            }

            public byte* GetBooleanArrayElements(JBooleanArray* array, byte* isCopy)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetBooleanArrayElements(envPtr, array, isCopy);
                }
            }

            public sbyte* GetByteArrayElements(JByteArray* array, byte* isCopy)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetByteArrayElements(envPtr, array, isCopy);
                }
            }

            public ushort* GetCharArrayElements(JCharArray* array, byte* isCopy)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetCharArrayElements(envPtr, array, isCopy);
                }
            }

            public short* GetShortArrayElements(JShortArray* array, byte* isCopy)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetShortArrayElements(envPtr, array, isCopy);
                }
            }

            public int* GetIntArrayElements(JIntArray* array, byte* isCopy)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetIntArrayElements(envPtr, array, isCopy);
                }
            }

            public long* GetLongArrayElements(JLongArray* array, byte* isCopy)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetLongArrayElements(envPtr, array, isCopy);
                }
            }

            public float* GetFloatArrayElements(JFloatArray* array, byte* isCopy)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetFloatArrayElements(envPtr, array, isCopy);
                }
            }

            public double* GetDoubleArrayElements(JDoubleArray* array, byte* isCopy)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetDoubleArrayElements(envPtr, array, isCopy);
                }
            }

            public void ReleaseBooleanArrayElements(JBooleanArray* array, byte* elems, int mode)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ReleaseBooleanArrayElements(envPtr, array, elems, mode);
                }
            }

            public void ReleaseByteArrayElements(JByteArray* array, sbyte* elems, int mode)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ReleaseByteArrayElements(envPtr, array, elems, mode);
                }
            }

            public void ReleaseCharArrayElements(JCharArray* array, ushort* elems, int mode)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ReleaseCharArrayElements(envPtr, array, elems, mode);
                }
            }

            public void ReleaseShortArrayElements(JShortArray* array, short* elems, int mode)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ReleaseShortArrayElements(envPtr, array, elems, mode);
                }
            }

            public void ReleaseIntArrayElements(JIntArray* array, int* elems, int mode)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ReleaseIntArrayElements(envPtr, array, elems, mode);
                }
            }

            public void ReleaseLongArrayElements(JLongArray* array, long* elems, int mode)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ReleaseLongArrayElements(envPtr, array, elems, mode);
                }
            }

            public void ReleaseFloatArrayElements(JFloatArray* array, float* elems, int mode)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ReleaseFloatArrayElements(envPtr, array, elems, mode);
                }
            }

            public void ReleaseDoubleArrayElements(JDoubleArray* array, double* elems, int mode)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->ReleaseDoubleArrayElements(envPtr, array, elems, mode);
                }
            }

            public void GetBooleanArrayRegion(JBooleanArray* array, int start, int length, byte* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->GetBooleanArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void GetByteArrayRegion(JByteArray* array, int start, int length, sbyte* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->GetByteArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void GetCharArrayRegion(JCharArray* array, int start, int length, ushort* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->GetCharArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void GetShortArrayRegion(JShortArray* array, int start, int length, short* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->GetShortArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void GetIntArrayRegion(JIntArray* array, int start, int length, int* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->GetIntArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void GetLongArrayRegion(JLongArray* array, int start, int length, long* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->GetLongArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void GetFloatArrayRegion(JFloatArray* array, int start, int length, float* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->GetFloatArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void GetDoubleArrayRegion(JDoubleArray* array, int start, int length, double* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->GetDoubleArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void SetBooleanArrayRegion(JBooleanArray* array, int start, int length, byte* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetBooleanArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void SetByteArrayRegion(JByteArray* array, int start, int length, sbyte* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetByteArrayRegion(envPtr, array, start, length, buf);
                }
            }
            public void SetCharArrayRegion(JCharArray* array, int start, int length, ushort* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetCharArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void SetShortArrayRegion(JShortArray* array, int start, int length, short* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetShortArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void SetIntArrayRegion(JIntArray* array, int start, int length, int* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetIntArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void SetLongArrayRegion(JLongArray* array, int start, int length, long* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetLongArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void SetFloatArrayRegion(JFloatArray* array, int start, int length, float* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetFloatArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public void SetDoubleArrayRegion(JDoubleArray* array, int start, int length, double* buf)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    env.Functions->SetDoubleArrayRegion(envPtr, array, start, length, buf);
                }
            }

            public JObject* ToReflectedMethod(JClass* klass, JMethodID* methodID, bool isStatic)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->ToReflectedMethod(envPtr, klass, methodID, isStatic ? (byte)1 : (byte)0);
                }
            }

            public JObject* ToReflectedField(JClass* klass, JFieldID* fieldID, bool isStatic)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->ToReflectedField(envPtr, klass, fieldID, isStatic ? (byte)1 : (byte)0);
                }
            }

            public JMethodID* GetMethodID(JClass* klass, byte* name, byte* sig)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->GetMethodID(envPtr, klass, name, sig);
                }
            }

            public int RegisterNatives(JClass* klass, JniNativeMethod* methods, int methodsCount)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->RegisterNatives(envPtr, klass, methods, methodsCount);
                }
            }

            public int UnregisterNatives(JClass* klass)
            {
                fixed (JniEnv* envPtr = &env)
                {
                    return env.Functions->UnregisterNatives(envPtr, klass);
                }
            }
        }

        extension(ref JavaVM vm)
        {
            public int DestroyJavaVM()
            {
                fixed(JavaVM* jvmPtr = &vm)
                {
                    return vm.Functions->DestroyJavaVM(jvmPtr);
                }
            }
            public int AttachCurrentThread(void** env, JavaVMAttachArgs* attachArgs)
            {
                fixed (JavaVM* jvmPtr = &vm)
                {
                    return vm.Functions->AttachCurrentThread(jvmPtr, env, attachArgs);
                }
            }
            public int DetachCurrentThread()
            {
                fixed (JavaVM* vmPtr = &vm)
                {
                    return vm.Functions->DetachCurrentThread(vmPtr);
                }
            }

            public int GetEnv(void** env, int version)
            {
                fixed (JavaVM* vmPtr = &vm)
                {
                    return vm.Functions->GetEnv(vmPtr, env, version);
                }
            }

            public int AttachCurrentThreadAsDaemon(void** env, JavaVMAttachArgs* args)
            {
                fixed (JavaVM* vmPtr = &vm)
                {
                    return vm.Functions->AttachCurrentThreadAsDaemon(vmPtr, env, args);
                }
            }
        }
    }
}
