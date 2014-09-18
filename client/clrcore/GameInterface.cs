﻿using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace CitizenFX.Core
{
    internal static class GameInterface
    {
        [SecurityCritical]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern IntPtr OpenFile(string fileName);

        [SecurityCritical]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern int ReadFile(IntPtr handle, byte[] buffer, int offset, int length);

        [SecurityCritical]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern void CloseFile(IntPtr handle);

        [SecurityCritical]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern int GetFileLength(IntPtr handle);

        [SecurityCritical]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern bool GetEnvironmentInfo(out string resourceName, out string resourcePath, out string resourceAssembly, out uint instanceId);

        [SecurityCritical]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern void PrintLog(string text);

        [SecurityCritical]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern byte[] InvokeNativeReference(string resource, uint instance, uint reference, byte[] argsSerialized);

        [SecurityCritical]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern void DeleteNativeReference(string resource, uint instance, uint reference);
    }
}