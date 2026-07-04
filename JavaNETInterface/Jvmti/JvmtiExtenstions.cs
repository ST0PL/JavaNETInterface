using JavaNETInterface.Jni;

namespace JavaNETInterface.Jvmti;

public static unsafe class JvmtiExtensions
{
    extension(ref JvmtiEnv env)
    {
        public JvmtiError SetEventNotificationMode(JvmtiEventMode mode, JvmtiEvent eventType, JObject* eventThread)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetEventNotificationMode(p, mode, eventType, eventThread);
        }

        public JvmtiError GetAllModules(int* countPtr, JObject*** modulesPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetAllModules(p, countPtr, modulesPtr);
        }

        public JvmtiError GetAllThreads(int* countPtr, JObject*** threadsPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetAllThreads(p, countPtr, threadsPtr);
        }

        public JvmtiError SuspendThread(JObject* thread)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SuspendThread(p, thread);
        }

        public JvmtiError ResumeThread(JObject* thread)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->ResumeThread(p, thread);
        }

        public JvmtiError InterruptThread(JObject* thread)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->InterruptThread(p, thread);
        }

        public JvmtiError GetThreadInfo(JObject* thread, JvmtiThreadInfo* infoPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetThreadInfo(p, thread, infoPtr);
        }

        public JvmtiError GetCurrentThread(JObject** threadPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetCurrentThread(p, threadPtr);
        }

        public JvmtiError GetThreadState(JObject* thread, int* statePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetThreadState(p, thread, statePtr);
        }

        public JvmtiError GetFrameCount(JObject* thread, int* countPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetFrameCount(p, thread, countPtr);
        }

        public JvmtiError GetFrameLocation(JObject* thread, int depth, JMethodID** methodPtr, long* locationPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetFrameLocation(p, thread, depth, methodPtr, locationPtr);
        }

        public JvmtiError CreateRawMonitor(byte* name, JRawMonitorID** monitorPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->CreateRawMonitor(p, name, monitorPtr);
        }

        public JvmtiError DestroyRawMonitor(JRawMonitorID* monitor)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->DestroyRawMonitor(p, monitor);
        }

        public JvmtiError RawMonitorEnter(JRawMonitorID* monitor)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->RawMonitorEnter(p, monitor);
        }

        public JvmtiError RawMonitorExit(JRawMonitorID* monitor)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->RawMonitorExit(p, monitor);
        }

        public JvmtiError RawMonitorWait(JRawMonitorID* monitor, long millis)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->RawMonitorWait(p, monitor, millis);
        }

        public JvmtiError RawMonitorNotify(JRawMonitorID* monitor)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->RawMonitorNotify(p, monitor);
        }

        public JvmtiError RawMonitorNotifyAll(JRawMonitorID* monitor)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->RawMonitorNotifyAll(p, monitor);
        }

        public JvmtiError SetBreakpoint(JMethodID* method, long location)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetBreakpoint(p, method, location);
        }

        public JvmtiError ClearBreakpoint(JMethodID* method, long location)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->ClearBreakpoint(p, method, location);
        }

        public JvmtiError SetFieldAccessWatch(JClass* klass, JFieldID* field)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetFieldAccessWatch(p, klass, field);
        }

        public JvmtiError ClearFieldAccessWatch(JClass* klass, JFieldID* field)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->ClearFieldAccessWatch(p, klass, field);
        }

        public JvmtiError SetFieldModificationWatch(JClass* klass, JFieldID* field)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetFieldModificationWatch(p, klass, field);
        }

        public JvmtiError ClearFieldModificationWatch(JClass* klass, JFieldID* field)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->ClearFieldModificationWatch(p, klass, field);
        }

        public JvmtiError Allocate(long size, byte** memPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->Allocate(p, size, memPtr);
        }

        public JvmtiError Deallocate(byte* mem)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->Deallocate(p, mem);
        }

        public JvmtiError GetClassSignature(JClass* klass, byte** signaturePtr, byte** genericPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetClassSignature(p, klass, signaturePtr, genericPtr);
        }

        public JvmtiError GetClassStatus(JClass* klass, int* statusPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetClassStatus(p, klass, statusPtr);
        }

        public JvmtiError GetLoadedClasses(int* countPtr, JClass*** classesPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetLoadedClasses(p, countPtr, classesPtr);
        }

        public JvmtiError GetClassLoaderClasses(JObject* loader, int* countPtr, JClass*** classesPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetClassLoaderClasses(p, loader, countPtr, classesPtr);
        }

        public JvmtiError GetClassMethods(JClass* klass, int* countPtr, JMethodID*** methodsPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetClassMethods(p, klass, countPtr, methodsPtr);
        }

        public JvmtiError GetClassFields(JClass* klass, int* countPtr, JFieldID*** fieldsPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetClassFields(p, klass, countPtr, fieldsPtr);
        }

        public JvmtiError GetMethodName(JMethodID* method, byte** namePtr, byte** signaturePtr, byte** genericPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetMethodName(p, method, namePtr, signaturePtr, genericPtr);
        }

        public JvmtiError GetFieldName(JClass* klass, JFieldID* field, byte** namePtr, byte** signaturePtr, byte** genericPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetFieldName(p, klass, field, namePtr, signaturePtr, genericPtr);
        }

        public JvmtiError GetMethodDeclaringClass(JMethodID* method, JClass** declaringClassPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetMethodDeclaringClass(p, method, declaringClassPtr);
        }

        public JvmtiError GetMethodModifiers(JMethodID* method, int* modifiersPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetMethodModifiers(p, method, modifiersPtr);
        }

        public JvmtiError GetMaxLocals(JMethodID* method, int* maxPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetMaxLocals(p, method, maxPtr);
        }

        public JvmtiError GetArgumentsSize(JMethodID* method, int* sizePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetArgumentsSize(p, method, sizePtr);
        }

        public JvmtiError GetLineNumberTable(JMethodID* method, int* countPtr, JvmtiLineNumberEntry** tablePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetLineNumberTable(p, method, countPtr, tablePtr);
        }

        public JvmtiError GetMethodLocation(JMethodID* method, long* startPtr, long* endPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetMethodLocation(p, method, startPtr, endPtr);
        }

        public JvmtiError GetLocalVariableTable(JMethodID* method, int* countPtr, JvmtiLocalVariableEntry** tablePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetLocalVariableTable(p, method, countPtr, tablePtr);
        }

        public JvmtiError GetBytecodes(JMethodID* method, int* countPtr, byte** bytecodesPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetBytecodes(p, method, countPtr, bytecodesPtr);
        }

        public JvmtiError IsMethodNative(JMethodID* method, byte* isNativePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IsMethodNative(p, method, isNativePtr);
        }

        public JvmtiError IsMethodSynthetic(JMethodID* method, byte* isSyntheticPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IsMethodSynthetic(p, method, isSyntheticPtr);
        }

        public JvmtiError IsMethodObsolete(JMethodID* method, byte* isObsoletePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IsMethodObsolete(p, method, isObsoletePtr);
        }

        public JvmtiError SetNativeMethodPrefix(byte* prefix)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetNativeMethodPrefix(p, prefix);
        }

        public JvmtiError SetNativeMethodPrefixes(int count, byte** prefixes)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetNativeMethodPrefixes(p, count, prefixes);
        }

        public JvmtiError RedefineClasses(int classCount, JvmtiClassDefinition* definitions)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->RedefineClasses(p, classCount, definitions);
        }

        public JvmtiError RetransformClasses(int classCount, JClass** classes)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->RetransformClasses(p, classCount, classes);
        }

        public JvmtiError GetVersionNumber(int* versionPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetVersionNumber(p, versionPtr);
        }

        public JvmtiError GetCapabilities(JvmtiCapabilities* capsPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetCapabilities(p, capsPtr);
        }

        public JvmtiError GetPotentialCapabilities(JvmtiCapabilities* capsPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetPotentialCapabilities(p, capsPtr);
        }

        public JvmtiError AddCapabilities(JvmtiCapabilities* capsPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->AddCapabilities(p, capsPtr);
        }

        public JvmtiError RelinquishCapabilities(JvmtiCapabilities* capsPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->RelinquishCapabilities(p, capsPtr);
        }

        public JvmtiError SetEventCallbacks(JvmtiEventCallbacks* callbacks, int size)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetEventCallbacks(p, callbacks, size);
        }

        public JvmtiError GenerateEvents(JvmtiEvent eventType)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GenerateEvents(p, eventType);
        }

        public JvmtiError GetTag(JObject* obj, long* tagPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetTag(p, obj, tagPtr);
        }

        public JvmtiError SetTag(JObject* obj, long tag)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetTag(p, obj, tag);
        }

        public JvmtiError ForceGarbageCollection()
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->ForceGarbageCollection(p);
        }

        public JvmtiError ForceEarlyReturnObject(JObject* thread, JObject* value)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->ForceEarlyReturnObject(p, thread, value);
        }

        public JvmtiError ForceEarlyReturnInt(JObject* thread, int value)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->ForceEarlyReturnInt(p, thread, value);
        }

        public JvmtiError ForceEarlyReturnLong(JObject* thread, long value)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->ForceEarlyReturnLong(p, thread, value);
        }

        public JvmtiError ForceEarlyReturnFloat(JObject* thread, float value)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->ForceEarlyReturnFloat(p, thread, value);
        }

        public JvmtiError ForceEarlyReturnDouble(JObject* thread, double value)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->ForceEarlyReturnDouble(p, thread, value);
        }

        public JvmtiError ForceEarlyReturnVoid(JObject* thread)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->ForceEarlyReturnVoid(p, thread);
        }

        public JvmtiError PopFrame(JObject* thread)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->PopFrame(p, thread);
        }

        public JvmtiError GetTime(long* nanosPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetTime(p, nanosPtr);
        }

        public JvmtiError GetTimerInfo(JvmtiTimerInfo* infoPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetTimerInfo(p, infoPtr);
        }

        public JvmtiError GetCurrentThreadCpuTime(long* nanosPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetCurrentThreadCpuTime(p, nanosPtr);
        }

        public JvmtiError GetThreadCpuTime(JObject* thread, long* nanosPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetThreadCpuTime(p, thread, nanosPtr);
        }

        public JvmtiError GetPhase(JvmtiPhase* phasePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetPhase(p, phasePtr);
        }

        public JvmtiError GetAvailableProcessors(int* countPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetAvailableProcessors(p, countPtr);
        }

        public JvmtiError GetSystemProperties(int* countPtr, byte*** propertyPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetSystemProperties(p, countPtr, propertyPtr);
        }

        public JvmtiError GetSystemProperty(byte* property, byte** valuePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetSystemProperty(p, property, valuePtr);
        }

        public JvmtiError SetSystemProperty(byte* property, byte* value)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetSystemProperty(p, property, value);
        }

        public JvmtiError AddToBootstrapClassLoaderSearch(byte* segment)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->AddToBootstrapClassLoaderSearch(p, segment);
        }

        public JvmtiError AddToSystemClassLoaderSearch(byte* segment)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->AddToSystemClassLoaderSearch(p, segment);
        }

        public JvmtiError SetVerboseFlag(JvmtiVerboseFlag flag, byte value)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetVerboseFlag(p, flag, value);
        }

        public JvmtiError GetErrorName(JvmtiError error, byte** namePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetErrorName(p, error, namePtr);
        }

        public JvmtiError DisposeEnvironment()
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->DisposeEnvironment(p);
        }

        public JvmtiError GetEnvironmentLocalStorage(void** dataPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetEnvironmentLocalStorage(p, dataPtr);
        }

        public JvmtiError SetEnvironmentLocalStorage(void* data)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetEnvironmentLocalStorage(p, data);
        }

        public JvmtiError SetJNIFunctionTable(JniNativeInterface* table)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetJNIFunctionTable(p, table);
        }

        public JvmtiError GetJNIFunctionTable(JniNativeInterface** table)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetJNIFunctionTable(p, table);
        }

        public JvmtiError GetObjectSize(JObject* obj, long* sizePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetObjectSize(p, obj, sizePtr);
        }

        public JvmtiError GetObjectHashCode(JObject* obj, int* hashPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetObjectHashCode(p, obj, hashPtr);
        }

        public JvmtiError GetObjectMonitorUsage(JObject* obj, JvmtiMonitorUsage* infoPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetObjectMonitorUsage(p, obj, infoPtr);
        }

        public JvmtiError IsModifiableClass(JClass* klass, byte* isModifiablePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IsModifiableClass(p, klass, isModifiablePtr);
        }

        public JvmtiError IsInterface(JClass* klass, byte* isInterfacePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IsInterface(p, klass, isInterfacePtr);
        }

        public JvmtiError IsArrayClass(JClass* klass, byte* isArrayPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IsArrayClass(p, klass, isArrayPtr);
        }

        public JvmtiError GetClassLoader(JClass* klass, JObject** loaderPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetClassLoader(p, klass, loaderPtr);
        }

        public JvmtiError GetSourceFileName(JClass* klass, byte** namePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetSourceFileName(p, klass, namePtr);
        }

        public JvmtiError GetClassModifiers(JClass* klass, int* modifiersPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetClassModifiers(p, klass, modifiersPtr);
        }

        public JvmtiError GetImplementedInterfaces(JClass* klass, int* countPtr, JClass*** interfacesPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetImplementedInterfaces(p, klass, countPtr, interfacesPtr);
        }

        public JvmtiError GetClassVersionNumbers(JClass* klass, int* minorPtr, int* majorPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetClassVersionNumbers(p, klass, minorPtr, majorPtr);
        }

        public JvmtiError GetConstantPool(JClass* klass, int* countPtr, int* byteCountPtr, byte** bytesPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetConstantPool(p, klass, countPtr, byteCountPtr, bytesPtr);
        }

        public JvmtiError GetSourceDebugExtension(JClass* klass, byte** extPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetSourceDebugExtension(p, klass, extPtr);
        }

        public JvmtiError GetFieldDeclaringClass(JClass* klass, JFieldID* field, JClass** declaringPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetFieldDeclaringClass(p, klass, field, declaringPtr);
        }

        public JvmtiError GetFieldModifiers(JClass* klass, JFieldID* field, int* modifiersPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetFieldModifiers(p, klass, field, modifiersPtr);
        }

        public JvmtiError IsFieldSynthetic(JClass* klass, JFieldID* field, byte* isSyntheticPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IsFieldSynthetic(p, klass, field, isSyntheticPtr);
        }

        public JvmtiError AddModuleReads(JObject* module, JObject* toModule)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->AddModuleReads(p, module, toModule);
        }

        public JvmtiError AddModuleExports(JObject* module, byte* pkgName, JObject* toModule)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->AddModuleExports(p, module, pkgName, toModule);
        }

        public JvmtiError AddModuleOpens(JObject* module, byte* pkgName, JObject* toModule)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->AddModuleOpens(p, module, pkgName, toModule);
        }

        public JvmtiError AddModuleUses(JObject* module, JClass* service)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->AddModuleUses(p, module, service);
        }

        public JvmtiError AddModuleProvides(JObject* module, JClass* service, JClass* implClass)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->AddModuleProvides(p, module, service, implClass);
        }

        public JvmtiError IsModifiableModule(JObject* module, byte* isModifiablePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IsModifiableModule(p, module, isModifiablePtr);
        }

        public JvmtiError GetNamedModule(JObject* classLoader, byte* packageName, JObject** modulePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetNamedModule(p, classLoader, packageName, modulePtr);
        }

        public JvmtiError GetAllStackTraces(int maxFrameCount, JvmtiStackInfo** stackInfoPtr, int* threadCountPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetAllStackTraces(p, maxFrameCount, stackInfoPtr, threadCountPtr);
        }

        public JvmtiError GetThreadListStackTraces(int threadCount, JObject** threadList, int maxFrameCount, JvmtiStackInfo** stackInfoPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetThreadListStackTraces(p, threadCount, threadList, maxFrameCount, stackInfoPtr);
        }

        public JvmtiError GetStackTrace(JObject* thread, int startDepth, int maxFrameCount, JvmtiFrameInfo* frameBuffer, int* countPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetStackTrace(p, thread, startDepth, maxFrameCount, frameBuffer, countPtr);
        }

        public JvmtiError SetHeapSamplingInterval(int interval)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetHeapSamplingInterval(p, interval);
        }

        public JvmtiError GetLocalInstance(JObject* thread, int depth, JObject** valuePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetLocalInstance(p, thread, depth, valuePtr);
        }

        public JvmtiError GetOwnedMonitorStackDepthInfo(JObject* thread, int* countPtr, JvmtiMonitorStackDepthInfo** infoPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetOwnedMonitorStackDepthInfo(p, thread, countPtr, infoPtr);
        }

        public JvmtiError SuspendAllVirtualThreads(int exceptCount, JObject** exceptList)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SuspendAllVirtualThreads(p, exceptCount, exceptList);
        }

        public JvmtiError ResumeAllVirtualThreads(int exceptCount, JObject** exceptList)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->ResumeAllVirtualThreads(p, exceptCount, exceptList);
        }

        public JvmtiError GetJLocationFormat(JvmtiJlocationFormat* formatPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetJLocationFormat(p, formatPtr);
        }

        public JvmtiError GetCurrentThreadCpuTimerInfo(JvmtiTimerInfo* infoPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetCurrentThreadCpuTimerInfo(p, infoPtr);
        }

        public JvmtiError GetThreadCpuTimerInfo(JvmtiTimerInfo* infoPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetThreadCpuTimerInfo(p, infoPtr);
        }

        public JvmtiError GetExtensionFunctions(int* countPtr, JvmtiExtensionFunctionInfo** extensions)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetExtensionFunctions(p, countPtr, extensions);
        }

        public JvmtiError GetExtensionEvents(int* countPtr, JvmtiExtensionEventInfo** extensions)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetExtensionEvents(p, countPtr, extensions);
        }

        public JvmtiError SetExtensionEventCallback(int index, void* callback)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetExtensionEventCallback(p, index, callback);
        }

        public JvmtiError FollowReferences(int heapFilter, JClass* klass, JObject* initialObject, JvmtiHeapCallbacks* callbacks, void* userData)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->FollowReferences(p, heapFilter, klass, initialObject, callbacks, userData);
        }

        public JvmtiError IterateThroughHeap(int heapFilter, JClass* klass, JvmtiHeapCallbacks* callbacks, void* userData)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IterateThroughHeap(p, heapFilter, klass, callbacks, userData);
        }

        public JvmtiError GetObjectsWithTags(int tagCount, long* tags, int* countPtr, JObject*** objectResultPtr, long** tagResultPtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetObjectsWithTags(p, tagCount, tags, countPtr, objectResultPtr, tagResultPtr);
        }

        public JvmtiError IterateOverObjectsReachableFromObject(JObject* obj, void* callback, void* userData)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IterateOverObjectsReachableFromObject(p, obj, callback, userData);
        }

        public JvmtiError IterateOverReachableObjects(void* heapRootCb, void* stackRefCb, void* objectRefCb, void* userData)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IterateOverReachableObjects(p, heapRootCb, stackRefCb, objectRefCb, userData);
        }

        public JvmtiError IterateOverHeap(JvmtiHeapObjectFilter filter, void* heapObjectCb, void* userData)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IterateOverHeap(p, filter, heapObjectCb, userData);
        }

        public JvmtiError IterateOverInstancesOfClass(JClass* klass, JvmtiHeapObjectFilter filter, void* heapObjectCb, void* userData)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->IterateOverInstancesOfClass(p, klass, filter, heapObjectCb, userData);
        }

        public JvmtiError GetLocalObject(JObject* thread, int depth, int slot, JObject** valuePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetLocalObject(p, thread, depth, slot, valuePtr);
        }

        public JvmtiError GetLocalInt(JObject* thread, int depth, int slot, int* valuePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetLocalInt(p, thread, depth, slot, valuePtr);
        }

        public JvmtiError GetLocalLong(JObject* thread, int depth, int slot, long* valuePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetLocalLong(p, thread, depth, slot, valuePtr);
        }

        public JvmtiError GetLocalFloat(JObject* thread, int depth, int slot, float* valuePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetLocalFloat(p, thread, depth, slot, valuePtr);
        }

        public JvmtiError GetLocalDouble(JObject* thread, int depth, int slot, double* valuePtr)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->GetLocalDouble(p, thread, depth, slot, valuePtr);
        }

        public JvmtiError SetLocalObject(JObject* thread, int depth, int slot, JObject* value)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetLocalObject(p, thread, depth, slot, value);
        }

        public JvmtiError SetLocalInt(JObject* thread, int depth, int slot, int value)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetLocalInt(p, thread, depth, slot, value);
        }

        public JvmtiError SetLocalLong(JObject* thread, int depth, int slot, long value)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetLocalLong(p, thread, depth, slot, value);
        }

        public JvmtiError SetLocalFloat(JObject* thread, int depth, int slot, float value)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetLocalFloat(p, thread, depth, slot, value);
        }

        public JvmtiError SetLocalDouble(JObject* thread, int depth, int slot, double value)
        {
            fixed (JvmtiEnv* p = &env) return env.Functions->SetLocalDouble(p, thread, depth, slot, value);
        }
    }

    extension(ref JavaVM vm)
    {
        public int GetJvmtiEnv(JvmtiEnv** env, int version = JvmtiConstants.JVMTI_VERSION)
        {
            fixed (JavaVM* vmPtr = &vm)
            {
                return vm.Functions->GetEnv(vmPtr, (void**)env, version);
            }
        }
    }
}