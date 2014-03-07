﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace VsChromiumCore.Win32.Shell {
  public static class NativeMethods {
    [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
    public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes,
      ref SHFileInfo psfi, uint cbFileInfo, uint uFlags);
  }
}
