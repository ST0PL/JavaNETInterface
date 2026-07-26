using JavaNETInterface.Jni;
using System.Runtime.InteropServices;

namespace JavaNETInterface.Jvmti;

public unsafe struct JRawMonitorID { public void* Handle; }

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiThreadInfo
{
    public byte* Name;
    public int Priority;
    public byte IsDaemon;
    public JObject* ThreadGroup;
    public JObject* ContextClassLoader;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiMonitorStackDepthInfo
{
    public JObject* Monitor;
    public int StackDepth;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiThreadGroupInfo
{
    public JObject* Parent;
    public byte* Name;
    public int MaxPriority;
    public byte IsDaemon;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiFrameInfo
{
    public JMethodID* Method;
    public long Location;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiStackInfo
{
    public JObject* Thread;
    public int State;
    public JvmtiFrameInfo* FrameBuffer;
    public int FrameCount;
}

[StructLayout(LayoutKind.Sequential)] public struct JvmtiHeapReferenceInfoField { public int Index; }
[StructLayout(LayoutKind.Sequential)] public struct JvmtiHeapReferenceInfoArray { public int Index; }
[StructLayout(LayoutKind.Sequential)] public struct JvmtiHeapReferenceInfoConstantPool { public int Index; }

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiHeapReferenceInfoStackLocal
{
    public long ThreadTag;
    public long ThreadId;
    public int Depth;
    public JMethodID* Method;
    public long Location;
    public int Slot;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiHeapReferenceInfoJniLocal
{
    public long ThreadTag;
    public long ThreadId;
    public int Depth;
    public JMethodID* Method;
}

[StructLayout(LayoutKind.Sequential)]
public struct JvmtiHeapReferenceInfoReserved
{
    public long Reserved1;
    public long Reserved2;
    public long Reserved3;
    public long Reserved4;
    public long Reserved5;
    public long Reserved6;
    public long Reserved7;
    public long Reserved8;
}

[StructLayout(LayoutKind.Explicit)]
public struct JvmtiHeapReferenceInfo
{
    [FieldOffset(0)] public JvmtiHeapReferenceInfoField Field;
    [FieldOffset(0)] public JvmtiHeapReferenceInfoArray Array;
    [FieldOffset(0)] public JvmtiHeapReferenceInfoConstantPool ConstantPool;
    [FieldOffset(0)] public JvmtiHeapReferenceInfoStackLocal StackLocal;
    [FieldOffset(0)] public JvmtiHeapReferenceInfoJniLocal JniLocal;
    [FieldOffset(0)] public JvmtiHeapReferenceInfoReserved Other;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiHeapCallbacks
{
    public delegate* unmanaged[Cdecl]<long, long, long*, int, void*, int> HeapIterationCallback;
    public delegate* unmanaged[Cdecl]<JvmtiHeapReferenceKind, JvmtiHeapReferenceInfo, long, long, long, long*, long*, int, void*, int> HeapReferenceCallback;
    public delegate* unmanaged[Cdecl]<JvmtiHeapReferenceKind, JvmtiHeapReferenceInfo, long, long*, JValue, JvmtiPrimitiveType, void*, int> PrimitiveFieldCallback;
    public delegate* unmanaged[Cdecl]<long, long, long*, int, JvmtiPrimitiveType, void*, void*, int> ArrayPrimitiveValueCallback;
    public delegate* unmanaged[Cdecl]<long, long, long*, ushort*, int, void*, int> StringPrimitiveValueCallback;
    public void* Reserved5;
    public void* Reserved6;
    public void* Reserved7;
    public void* Reserved8;
    public void* Reserved9;
    public void* Reserved10;
    public void* Reserved11;
    public void* Reserved12;
    public void* Reserved13;
    public void* Reserved14;
    public void* Reserved15;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiClassDefinition
{
    public JClass* Klass;
    public int ClassByteCount;
    public byte* ClassBytes;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiMonitorUsage
{
    public JObject* Owner;
    public int EntryCount;
    public int WaiterCount;
    public JObject** Waiters;
    public int NotifyWaiterCount;
    public JObject** NotifyWaiters;
}

[StructLayout(LayoutKind.Sequential)]
public struct JvmtiLineNumberEntry
{
    public long StartLocation;
    public int LineNumber;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiLocalVariableEntry
{
    public long StartLocation;
    public int Length;
    public byte* Name;
    public byte* Signature;
    public byte* GenericSignature;
    public int Slot;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiParamInfo
{
    public byte* Name;
    public JvmtiParamKind Kind;
    public JvmtiParamTypes BaseType;
    public byte NullOk;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiExtensionFunctionInfo
{
    public void* Func;
    public byte* Id;
    public byte* ShortDescription;
    public int ParamCount;
    public JvmtiParamInfo* Params;
    public int ErrorCount;
    public JvmtiError* Errors;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiExtensionEventInfo
{
    public int ExtensionEventIndex;
    public byte* Id;
    public byte* ShortDescription;
    public int ParamCount;
    public JvmtiParamInfo* Params;
}

[StructLayout(LayoutKind.Sequential)]
public struct JvmtiTimerInfo
{
    public long MaxValue;
    public byte MaySkipForward;
    public byte MaySkipBackward;
    public JvmtiTimerKind Kind;
    public long Reserved1;
    public long Reserved2;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiAddrLocationMap
{
    public void* StartAddress;
    public long Location;
}

[StructLayout(LayoutKind.Sequential)]
public struct JvmtiCapabilities
{
    public uint Word0;
    public uint Word1;
    public ushort Reserved1;
    public ushort Reserved2;
    public ushort Reserved3;
    public ushort Reserved4;
    public ushort Reserved5;

    public bool CanTagObjects { get => GetBit(0, 0); set => SetBit(0, 0, value); }
    public bool CanGenerateFieldModificationEvents { get => GetBit(0, 1); set => SetBit(0, 1, value); }
    public bool CanGenerateFieldAccessEvents { get => GetBit(0, 2); set => SetBit(0, 2, value); }
    public bool CanGetBytecodes { get => GetBit(0, 3); set => SetBit(0, 3, value); }
    public bool CanGetSyntheticAttribute { get => GetBit(0, 4); set => SetBit(0, 4, value); }
    public bool CanGetOwnedMonitorInfo { get => GetBit(0, 5); set => SetBit(0, 5, value); }
    public bool CanGetCurrentContendedMonitor { get => GetBit(0, 6); set => SetBit(0, 6, value); }
    public bool CanGetMonitorInfo { get => GetBit(0, 7); set => SetBit(0, 7, value); }
    public bool CanPopFrame { get => GetBit(0, 8); set => SetBit(0, 8, value); }
    public bool CanRedefineClasses { get => GetBit(0, 9); set => SetBit(0, 9, value); }
    public bool CanSignalThread { get => GetBit(0, 10); set => SetBit(0, 10, value); }
    public bool CanGetSourceFileName { get => GetBit(0, 11); set => SetBit(0, 11, value); }
    public bool CanGetLineNumbers { get => GetBit(0, 12); set => SetBit(0, 12, value); }
    public bool CanGetSourceDebugExtension { get => GetBit(0, 13); set => SetBit(0, 13, value); }
    public bool CanAccessLocalVariables { get => GetBit(0, 14); set => SetBit(0, 14, value); }
    public bool CanMaintainOriginalMethodOrder { get => GetBit(0, 15); set => SetBit(0, 15, value); }
    public bool CanGenerateSingleStepEvents { get => GetBit(0, 16); set => SetBit(0, 16, value); }
    public bool CanGenerateExceptionEvents { get => GetBit(0, 17); set => SetBit(0, 17, value); }
    public bool CanGenerateFramePopEvents { get => GetBit(0, 18); set => SetBit(0, 18, value); }
    public bool CanGenerateBreakpointEvents { get => GetBit(0, 19); set => SetBit(0, 19, value); }
    public bool CanSuspend { get => GetBit(0, 20); set => SetBit(0, 20, value); }
    public bool CanRedefineAnyClass { get => GetBit(0, 21); set => SetBit(0, 21, value); }
    public bool CanGetCurrentThreadCpuTime { get => GetBit(0, 22); set => SetBit(0, 22, value); }
    public bool CanGetThreadCpuTime { get => GetBit(0, 23); set => SetBit(0, 23, value); }
    public bool CanGenerateMethodEntryEvents { get => GetBit(0, 24); set => SetBit(0, 24, value); }
    public bool CanGenerateMethodExitEvents { get => GetBit(0, 25); set => SetBit(0, 25, value); }
    public bool CanGenerateAllClassHookEvents { get => GetBit(0, 26); set => SetBit(0, 26, value); }
    public bool CanGenerateCompiledMethodLoadEvents { get => GetBit(0, 27); set => SetBit(0, 27, value); }
    public bool CanGenerateMonitorEvents { get => GetBit(0, 28); set => SetBit(0, 28, value); }
    public bool CanGenerateVmObjectAllocEvents { get => GetBit(0, 29); set => SetBit(0, 29, value); }
    public bool CanGenerateNativeMethodBindEvents { get => GetBit(0, 30); set => SetBit(0, 30, value); }
    public bool CanGenerateGarbageCollectionEvents { get => GetBit(0, 31); set => SetBit(0, 31, value); }

    public bool CanGenerateObjectFreeEvents { get => GetBit(1, 0); set => SetBit(1, 0, value); }
    public bool CanForceEarlyReturn { get => GetBit(1, 1); set => SetBit(1, 1, value); }
    public bool CanGetOwnedMonitorStackDepthInfo { get => GetBit(1, 2); set => SetBit(1, 2, value); }
    public bool CanGetConstantPool { get => GetBit(1, 3); set => SetBit(1, 3, value); }
    public bool CanSetNativeMethodPrefix { get => GetBit(1, 4); set => SetBit(1, 4, value); }
    public bool CanRetransformClasses { get => GetBit(1, 5); set => SetBit(1, 5, value); }
    public bool CanRetransformAnyClass { get => GetBit(1, 6); set => SetBit(1, 6, value); }
    public bool CanGenerateResourceExhaustionHeapEvents { get => GetBit(1, 7); set => SetBit(1, 7, value); }
    public bool CanGenerateResourceExhaustionThreadsEvents { get => GetBit(1, 8); set => SetBit(1, 8, value); }
    public bool CanGenerateEarlyVmstart { get => GetBit(1, 9); set => SetBit(1, 9, value); }
    public bool CanGenerateEarlyClassHookEvents { get => GetBit(1, 10); set => SetBit(1, 10, value); }
    public bool CanGenerateSampledObjectAllocEvents { get => GetBit(1, 11); set => SetBit(1, 11, value); }
    public bool CanSupportVirtualThreads { get => GetBit(1, 12); set => SetBit(1, 12, value); }

    private readonly uint GetWord(int index) => index switch
    {
        0 => Word0,
        1 => Word1,
        _ => 0,
    };

    private bool GetBit(int wordIndex, int bit) => ((GetWord(wordIndex) >> bit) & 1u) != 0;

    private void SetBit(int wordIndex, int bit, bool value)
    {
        if (value)
        {
            if (wordIndex == 0) Word0 |= 1u << bit;
            else Word1 |= 1u << bit;
        }
        else
        {
            if (wordIndex == 0) Word0 &= ~(1u << bit);
            else Word1 &= ~(1u << bit);
        }
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiEventCallbacks
{
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, void> VMInit;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, void> VMDeath;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, void> ThreadStart;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, void> ThreadEnd;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JClass*, JObject*, byte*, JObject*, int, byte*, int*, byte**, void> ClassFileLoadHook;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JClass*, void> ClassLoad;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JClass*, void> ClassPrepare;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, void> VMStart;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JMethodID*, long, JObject*, JMethodID*, long, void> Exception;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JMethodID*, long, JObject*, void> ExceptionCatch;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JMethodID*, long, void> SingleStep;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JMethodID*, byte, void> FramePop;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JMethodID*, long, void> Breakpoint;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JMethodID*, long, JClass*, JObject*, JFieldID*, void> FieldAccess;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JMethodID*, long, JClass*, JObject*, JFieldID*, byte, JValue, void> FieldModification;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JMethodID*, void> MethodEntry;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JMethodID*, byte, JValue, void> MethodExit;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JMethodID*, void*, void**, void> NativeMethodBind;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JMethodID*, int, void*, int, JvmtiAddrLocationMap*, void*, void> CompiledMethodLoad;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JMethodID*, void*, void> CompiledMethodUnload;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, byte*, void*, int, void> DynamicCodeGenerated;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, void> DataDumpRequest;
    public void* Reserved72;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JObject*, long, void> MonitorWait;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JObject*, byte, void> MonitorWaited;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JObject*, void> MonitorContendedEnter;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JObject*, void> MonitorContendedEntered;
    public void* Reserved77;
    public void* Reserved78;
    public void* Reserved79;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, int, void*, byte*, void> ResourceExhausted;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, void> GarbageCollectionStart;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, void> GarbageCollectionFinish;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, long, void> ObjectFree;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JObject*, JClass*, long, void> VMObjectAlloc;
    public void* Reserved85;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, JObject*, JClass*, long, void> SampledObjectAlloc;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, void> VirtualThreadStart;
    public delegate* unmanaged[Cdecl]<JvmtiEnv*, JniEnv*, JObject*, void> VirtualThreadEnd;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct JvmtiEnv
{
    public JvmtiInterface1* Functions;
}