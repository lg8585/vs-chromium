﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace VsChromiumCore.Win32 {
  // Win32 UNICODE_STRING structure.
  [StructLayout(LayoutKind.Sequential)]
  public struct UnicodeString {
    // The length in bytes of the string pointed to by buffer, not including the null-terminator.
    private ushort length;
    // The total allocated size in memory pointed to by buffer.
    private ushort maximumLength;
    // A pointer to the buffer containing the string data.
    private IntPtr buffer;

    public ushort Length { get { return length; } }
    public ushort MaximumLength { get { return maximumLength; } }
    public IntPtr Buffer { get { return buffer; } }
  }
}
