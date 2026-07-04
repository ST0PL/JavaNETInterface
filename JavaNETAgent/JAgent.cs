using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JavaNETInterface.Jni;
using JavaNETInterface.Jvmti;

namespace JavaNETAgent;

public static unsafe class JAgent
{
    static JvmtiEventCallbacks callbacks = default;
    [UnmanagedCallersOnly(EntryPoint = "Agent_OnLoad")]
    public static int Agent_OnLoad(JavaVM* vm, byte* options, void* reserved)
        => Initialize(vm, options);

    [UnmanagedCallersOnly(EntryPoint = "Agent_OnAttach")]
    public static int Agent_OnAttach(JavaVM* vm, byte* options, void* reserved)
        => Initialize(vm, options);

    [UnmanagedCallersOnly(EntryPoint = "Agent_OnUnload")]
    public static void Agent_OnUnload(JavaVM* vm) { }

    private static int Initialize(JavaVM* vm, byte* options)
    {
        JvmtiEnv* jvmti = null;
        int res = vm->GetEnv((void**)&jvmti, JvmtiConstants.JVMTI_VERSION);
        if (res != JniConstants.JNI_OK || jvmti == null)
            return -1;

        JvmtiCapabilities caps = default;
        jvmti->GetPotentialCapabilities(&caps);

        caps.CanTagObjects = true;
        caps.CanSuspend = true;
        caps.CanRetransformClasses = true;
        caps.CanGenerateAllClassHookEvents = true;
        caps.CanGenerateBreakpointEvents = true;
        caps.CanGenerateSingleStepEvents = true;
        caps.CanAccessLocalVariables = true;

        jvmti->AddCapabilities(&caps);
        

        callbacks.ClassFileLoadHook = &OnClassLoaded;

        fixed(JvmtiEventCallbacks* cptr = &callbacks)
            jvmti->SetEventCallbacks(cptr, sizeof(JvmtiEventCallbacks));

        jvmti->SetEventNotificationMode(JvmtiEventMode.ENABLE, JvmtiEvent.CLASS_FILE_LOAD_HOOK, null);

        return 0;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static void OnClassLoaded(
        JvmtiEnv* jvmti,
        JniEnv* jni,
        JClass* redefinedClass,
        JObject* loader,
        byte* name,
        JObject* protectionDomain,
        int classDataLen,
        byte* classData,
        int* newClassDataLen,
        byte** newClassData) => File.AppendAllText("JClasses.txt", Marshal.PtrToStringAnsi((nint)name) + '\n');
}