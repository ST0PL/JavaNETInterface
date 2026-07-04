namespace JavaNETInterface.Jvmti;

public static class JvmtiConstants
{
    public const int JVMTI_VERSION_1 = 0x30010000;
    public const int JVMTI_VERSION_1_0 = 0x30010000;
    public const int JVMTI_VERSION_1_1 = 0x30010100;
    public const int JVMTI_VERSION_1_2 = 0x30010200;
    public const int JVMTI_VERSION_9 = 0x30090000;
    public const int JVMTI_VERSION_11 = 0x300B0000;
    public const int JVMTI_VERSION_19 = 0x30130000;
    public const int JVMTI_VERSION_21 = 0x30150000;
    public const int JVMTI_VERSION = 0x30000000 + (25 * 0x10000) + (0 * 0x100) + 0; // 25 версия

    public const int INTERFACE_JNI = 0x00000000;
    public const int INTERFACE_JVMTI = 0x30000000;

    public const int MASK_INTERFACE_TYPE = 0x70000000;
    public const int MASK_MAJOR = 0x0FFF0000;
    public const int MASK_MINOR = 0x0000FF00;
    public const int MASK_MICRO = 0x000000FF;

    public const int SHIFT_MAJOR = 16;
    public const int SHIFT_MINOR = 8;
    public const int SHIFT_MICRO = 0;
}

public static class JvmtiThreadStateFlags
{
    public const int ALIVE = 0x0001;
    public const int TERMINATED = 0x0002;
    public const int RUNNABLE = 0x0004;
    public const int BLOCKED_ON_MONITOR_ENTER = 0x0400;
    public const int WAITING = 0x0080;
    public const int WAITING_INDEFINITELY = 0x0010;
    public const int WAITING_WITH_TIMEOUT = 0x0020;
    public const int SLEEPING = 0x0040;
    public const int IN_OBJECT_WAIT = 0x0100;
    public const int PARKED = 0x0200;
    public const int SUSPENDED = 0x100000;
    public const int INTERRUPTED = 0x200000;
    public const int IN_NATIVE = 0x400000;
    public const int VENDOR_1 = 0x10000000;
    public const int VENDOR_2 = 0x20000000;
    public const int VENDOR_3 = 0x40000000;

    public const int JAVA_LANG_THREAD_STATE_MASK =
        TERMINATED | ALIVE | RUNNABLE | BLOCKED_ON_MONITOR_ENTER |
        WAITING | WAITING_INDEFINITELY | WAITING_WITH_TIMEOUT;
    public const int JAVA_LANG_THREAD_STATE_NEW = 0;
    public const int JAVA_LANG_THREAD_STATE_TERMINATED = TERMINATED;
    public const int JAVA_LANG_THREAD_STATE_RUNNABLE = ALIVE | RUNNABLE;
    public const int JAVA_LANG_THREAD_STATE_BLOCKED = ALIVE | BLOCKED_ON_MONITOR_ENTER;
    public const int JAVA_LANG_THREAD_STATE_WAITING = ALIVE | WAITING | WAITING_INDEFINITELY;
    public const int JAVA_LANG_THREAD_STATE_TIMED_WAITING = ALIVE | WAITING | WAITING_WITH_TIMEOUT;
}

public static class JvmtiThreadPriority
{
    public const int MIN = 1;
    public const int NORM = 5;
    public const int MAX = 10;
}

public static class JvmtiHeapFilter
{
    public const int TAGGED = 0x4;
    public const int UNTAGGED = 0x8;
    public const int CLASS_TAGGED = 0x10;
    public const int CLASS_UNTAGGED = 0x20;
}

public static class JvmtiVisit
{
    public const int OBJECTS = 0x100;
    public const int ABORT = 0x8000;
}

public enum JvmtiHeapReferenceKind
{
    CLASS = 1,
    FIELD = 2,
    ARRAY_ELEMENT = 3,
    CLASS_LOADER = 4,
    SIGNERS = 5,
    PROTECTION_DOMAIN = 6,
    INTERFACE = 7,
    STATIC_FIELD = 8,
    CONSTANT_POOL = 9,
    SUPERCLASS = 10,
    JNI_GLOBAL = 21,
    SYSTEM_CLASS = 22,
    MONITOR = 23,
    STACK_LOCAL = 24,
    JNI_LOCAL = 25,
    THREAD = 26,
    OTHER = 27,
}

public enum JvmtiPrimitiveType
{
    BOOLEAN = 90,
    BYTE = 66,
    CHAR = 67,
    SHORT = 83,
    INT = 73,
    LONG = 74,
    FLOAT = 70,
    DOUBLE = 68,
}

public enum JvmtiHeapObjectFilter
{
    TAGGED = 1,
    UNTAGGED = 2,
    EITHER = 3,
}

public enum JvmtiHeapRootKind
{
    JNI_GLOBAL = 1,
    SYSTEM_CLASS = 2,
    MONITOR = 3,
    STACK_LOCAL = 4,
    JNI_LOCAL = 5,
    THREAD = 6,
    OTHER = 7,
}

public enum JvmtiObjectReferenceKind
{
    CLASS = 1,
    FIELD = 2,
    ARRAY_ELEMENT = 3,
    CLASS_LOADER = 4,
    SIGNERS = 5,
    PROTECTION_DOMAIN = 6,
    INTERFACE = 7,
    STATIC_FIELD = 8,
    CONSTANT_POOL = 9,
}

public enum JvmtiIterationControl
{
    CONTINUE = 1,
    IGNORE = 2,
    ABORT = 0,
}

public static class JvmtiClassStatus
{
    public const int VERIFIED = 1;
    public const int PREPARED = 2;
    public const int INITIALIZED = 4;
    public const int ERROR = 8;
    public const int ARRAY = 16;
    public const int PRIMITIVE = 32;
}

public enum JvmtiEventMode
{
    ENABLE = 1,
    DISABLE = 0,
}

public enum JvmtiParamTypes
{
    JBYTE = 101,
    JCHAR = 102,
    JSHORT = 103,
    JINT = 104,
    JLONG = 105,
    JFLOAT = 106,
    JDOUBLE = 107,
    JBOOLEAN = 108,
    JOBJECT = 109,
    JTHREAD = 110,
    JCLASS = 111,
    JVALUE = 112,
    JFIELDID = 113,
    JMETHODID = 114,
    CCHAR = 115,
    CVOID = 116,
    JNIENV = 117,
}

public enum JvmtiParamKind
{
    IN = 91,
    IN_PTR = 92,
    IN_BUF = 93,
    ALLOC_BUF = 94,
    ALLOC_ALLOC_BUF = 95,
    OUT = 96,
    OUT_BUF = 97,
}

public enum JvmtiTimerKind
{
    USER_CPU = 30,
    TOTAL_CPU = 31,
    ELAPSED = 32,
}

public enum JvmtiPhase
{
    ONLOAD = 1,
    PRIMORDIAL = 2,
    START = 6,
    LIVE = 4,
    DEAD = 8,
}

public enum JvmtiVerboseFlag
{
    OTHER = 0,
    GC = 1,
    CLASS = 2,
    JNI = 4,
}

public enum JvmtiJlocationFormat
{
    JVMBCI = 1,
    MACHINEPC = 2,
    OTHER = 0,
}

public static class JvmtiResourceExhaustedFlags
{
    public const int OOM_ERROR = 0x0001;
    public const int JAVA_HEAP = 0x0002;
    public const int THREADS = 0x0004;
}

public enum JvmtiError
{
    NONE = 0,
    INVALID_THREAD = 10,
    INVALID_THREAD_GROUP = 11,
    INVALID_PRIORITY = 12,
    THREAD_NOT_SUSPENDED = 13,
    THREAD_SUSPENDED = 14,
    THREAD_NOT_ALIVE = 15,
    INVALID_OBJECT = 20,
    INVALID_CLASS = 21,
    CLASS_NOT_PREPARED = 22,
    INVALID_METHODID = 23,
    INVALID_LOCATION = 24,
    INVALID_FIELDID = 25,
    INVALID_MODULE = 26,
    NO_MORE_FRAMES = 31,
    OPAQUE_FRAME = 32,
    TYPE_MISMATCH = 34,
    INVALID_SLOT = 35,
    DUPLICATE = 40,
    NOT_FOUND = 41,
    INVALID_MONITOR = 50,
    NOT_MONITOR_OWNER = 51,
    INTERRUPT = 52,
    INVALID_CLASS_FORMAT = 60,
    CIRCULAR_CLASS_DEFINITION = 61,
    FAILS_VERIFICATION = 62,
    UNSUPPORTED_REDEFINITION_METHOD_ADDED = 63,
    UNSUPPORTED_REDEFINITION_SCHEMA_CHANGED = 64,
    INVALID_TYPESTATE = 65,
    UNSUPPORTED_REDEFINITION_HIERARCHY_CHANGED = 66,
    UNSUPPORTED_REDEFINITION_METHOD_DELETED = 67,
    UNSUPPORTED_VERSION = 68,
    NAMES_DONT_MATCH = 69,
    UNSUPPORTED_REDEFINITION_CLASS_MODIFIERS_CHANGED = 70,
    UNSUPPORTED_REDEFINITION_METHOD_MODIFIERS_CHANGED = 71,
    UNSUPPORTED_REDEFINITION_CLASS_ATTRIBUTE_CHANGED = 72,
    UNSUPPORTED_OPERATION = 73,
    UNMODIFIABLE_CLASS = 79,
    UNMODIFIABLE_MODULE = 80,
    NOT_AVAILABLE = 98,
    MUST_POSSESS_CAPABILITY = 99,
    NULL_POINTER = 100,
    ABSENT_INFORMATION = 101,
    INVALID_EVENT_TYPE = 102,
    ILLEGAL_ARGUMENT = 103,
    NATIVE_METHOD = 104,
    CLASS_LOADER_UNSUPPORTED = 106,
    OUT_OF_MEMORY = 110,
    ACCESS_DENIED = 111,
    WRONG_PHASE = 112,
    INTERNAL = 113,
    UNATTACHED_THREAD = 115,
    INVALID_ENVIRONMENT = 116,
    MAX = 116,
}

public enum JvmtiEvent
{
    MIN_EVENT_TYPE_VAL = 50,
    VM_INIT = 50,
    VM_DEATH = 51,
    THREAD_START = 52,
    THREAD_END = 53,
    CLASS_FILE_LOAD_HOOK = 54,
    CLASS_LOAD = 55,
    CLASS_PREPARE = 56,
    VM_START = 57,
    EXCEPTION = 58,
    EXCEPTION_CATCH = 59,
    SINGLE_STEP = 60,
    FRAME_POP = 61,
    BREAKPOINT = 62,
    FIELD_ACCESS = 63,
    FIELD_MODIFICATION = 64,
    METHOD_ENTRY = 65,
    METHOD_EXIT = 66,
    NATIVE_METHOD_BIND = 67,
    COMPILED_METHOD_LOAD = 68,
    COMPILED_METHOD_UNLOAD = 69,
    DYNAMIC_CODE_GENERATED = 70,
    DATA_DUMP_REQUEST = 71,
    MONITOR_WAIT = 73,
    MONITOR_WAITED = 74,
    MONITOR_CONTENDED_ENTER = 75,
    MONITOR_CONTENDED_ENTERED = 76,
    RESOURCE_EXHAUSTED = 80,
    GARBAGE_COLLECTION_START = 81,
    GARBAGE_COLLECTION_FINISH = 82,
    OBJECT_FREE = 83,
    VM_OBJECT_ALLOC = 84,
    SAMPLED_OBJECT_ALLOC = 86,
    VIRTUAL_THREAD_START = 87,
    VIRTUAL_THREAD_END = 88,
    MAX_EVENT_TYPE_VAL = 88,
}